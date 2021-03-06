﻿using Unity.Jobs;
using Unity.Burst;
using UnityEngine;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
public struct TestJob : IJob
{
    public float value;
    public NativeArray<float> result;
    
    public void Execute()
    {
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = value;
        }
    }
}

[BurstCompile]
public struct ParallelTestJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<int> ParallelData;
    
    [NativeDisableParallelForRestriction]
    public NativeList<int> ParallelBuffer;

    public void Execute(int index)
    {
        if(ParallelData[index] % 512 == 0)
        {
            ParallelBuffer.Add(index);
        }
    }
}

//[BurstCompile]
public struct ParallelHashmapJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<int> HashmapKey;
    
    [ReadOnly]
    public NativeHashMap<int, float> HashmapData;

    public void Execute(int index)
    {
        int Key = HashmapKey[index];
        Debug.Log(HashmapData[Key]);
    }
}

public unsafe struct MyClass
{
    public float Float;
}



public class JobTest : MonoBehaviour
{
    NativeArray<float> Result;

    void OnEnable()
    {
        Result = new NativeArray<float>(1024, Allocator.Persistent);
        //NativeHashmapTest();
        UnsafeTest();
    }

    void Update()
    {
        //RunNet();
        //RunNetNative();
        //RunJob();
        //RunParallelJob();
        //NativeListTest();
    }

    void RunNet()
    {
        float[] result = new float[1024];
        
        for(int i = 0; i < 32; i++)
        {
            for(int j = 0; j < result.Length; j++)
            {
                result[j] = 5;
            }
        }
    }

    void RunNetNative()
    {
        for(int i = 0; i < 32; i++)
        {
            for(int j = 0; j < Result.Length; j++)
            {
                Result[j] = 5;
            }
        }
    }
    
    void RunJob()
    {
        NativeArray<float> result = new NativeArray<float>(1024, Allocator.TempJob);
    
        TestJob jobData = new TestJob();
        jobData.value = 5;
        jobData.result = result;
        
        for(int i = 0; i < 32; i++)
        {
            JobHandle handle = jobData.Schedule();
            handle.Complete();
        }

        result.Dispose();
    }

    void RunParallelJob()
    {
        NativeArray<int> ParallelData = new NativeArray<int>(8192, Allocator.TempJob);
        for(int i = 0; i < 8192; i++) {
            ParallelData[i] = i;
        }

        NativeList<int> ParallelBuffer = new NativeList<int>(8192, Allocator.TempJob);

        ParallelTestJob ParallelJob = new ParallelTestJob();
        ParallelJob.ParallelData = ParallelData;
        ParallelJob.ParallelBuffer = ParallelBuffer;

        ParallelJob.Schedule(ParallelData.Length, 1).Complete();

        ParallelData.Dispose();
        ParallelBuffer.Dispose();
    }

    void NativeListTest()
    {
        /*NativeList<int> result = new NativeList<int>(5, Allocator.TempJob);
        result.Add(0);
        result.Add(1);
        result.Add(2);
        result.Add(3);
        result.Add(4);
        result.Add(5);
        result.Add(6);
        result.Add(7);

        result.RemoveAt(0);
        result.RemoveAt(2 - 1);
        result.RemoveAt(4 - 2);

        int data = result[4 - 3];

        result.Add(8);
        result.Add(9);*/

        NativeList<int> result = new NativeList<int>(5, Allocator.Temp);
        result.Resize(2, NativeArrayOptions.ClearMemory);

        result[0] = 0;
        result[1] = 1;

        result.Resize(3, NativeArrayOptions.ClearMemory);
        result[2] = 2;

        result.Dispose();
    }

    void NativeHashmapTest()
    {
        NativeHashMap<int, float> HashmapData = new NativeHashMap<int, float>(5, Allocator.TempJob);
        HashmapData.Add(0, 0.1f);
        HashmapData.Add(1, 0.2f);
        HashmapData.Add(2, 0.3f);
        HashmapData.Add(3, 0.4f);
        HashmapData.Add(4, 0.5f);
        HashmapData.Add(5, 0.6f);

        NativeArray<int> HashmapKey = HashmapData.GetKeyArray(Allocator.TempJob);

        /*for(int i = 0; i < HashmapKey.Length; i++)
        {
            int Key = HashmapKey[i];
            print(Hashmap[Key]);
        }*/

        ParallelHashmapJob ParallelJob = new ParallelHashmapJob();
        ParallelJob.HashmapKey = HashmapKey;
        ParallelJob.HashmapData = HashmapData;

        ParallelJob.Schedule(HashmapKey.Length, 1).Complete();

        HashmapData.Dispose();
        HashmapKey.Dispose();
    }

    unsafe void UnsafeTest()
    {
        MyClass* MyData = (MyClass*)UnsafeUtility.Malloc(sizeof(MyClass), 4, Allocator.Temp);
        MyData->Float = 150;

        print(MyData->Float);
        UnsafeUtility.Free(MyData, Allocator.Temp);
    }

    void OnDisable()
    {
        Result.Dispose();
    }
}
