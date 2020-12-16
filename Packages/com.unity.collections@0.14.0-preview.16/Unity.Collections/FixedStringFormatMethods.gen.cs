
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     TextTransform Samples/Packages/com.unity.collections/Unity.Collections/FixedStringFormatMethods.tt
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
    /// <summary>
    /// <undoc />
    /// </summary>
    public unsafe static partial class FixedStringMethods
    {
        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0>(ref this T dest, in U format, in T0 arg0)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1>(ref this T dest, in U format, in T0 arg0, in T1 arg1)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <typeparam name="T5"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        /// <param name="arg5"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4, T5>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
            where T5 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            case 5: dest.Append(in arg5); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <typeparam name="T5"><undoc /></typeparam>
        /// <typeparam name="T6"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        /// <param name="arg5"><undoc /></param>
        /// <param name="arg6"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
            where T5 : struct, INativeList<byte>, IUTF8Bytes
            where T6 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            case 5: dest.Append(in arg5); i+=2; break;
                            case 6: dest.Append(in arg6); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <typeparam name="T5"><undoc /></typeparam>
        /// <typeparam name="T6"><undoc /></typeparam>
        /// <typeparam name="T7"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        /// <param name="arg5"><undoc /></param>
        /// <param name="arg6"><undoc /></param>
        /// <param name="arg7"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
            where T5 : struct, INativeList<byte>, IUTF8Bytes
            where T6 : struct, INativeList<byte>, IUTF8Bytes
            where T7 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            case 5: dest.Append(in arg5); i+=2; break;
                            case 6: dest.Append(in arg6); i+=2; break;
                            case 7: dest.Append(in arg7); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <typeparam name="T5"><undoc /></typeparam>
        /// <typeparam name="T6"><undoc /></typeparam>
        /// <typeparam name="T7"><undoc /></typeparam>
        /// <typeparam name="T8"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        /// <param name="arg5"><undoc /></param>
        /// <param name="arg6"><undoc /></param>
        /// <param name="arg7"><undoc /></param>
        /// <param name="arg8"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
            where T5 : struct, INativeList<byte>, IUTF8Bytes
            where T6 : struct, INativeList<byte>, IUTF8Bytes
            where T7 : struct, INativeList<byte>, IUTF8Bytes
            where T8 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            case 5: dest.Append(in arg5); i+=2; break;
                            case 6: dest.Append(in arg6); i+=2; break;
                            case 7: dest.Append(in arg7); i+=2; break;
                            case 8: dest.Append(in arg8); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }

        /// <summary>
        /// Convenience function to append a formatted string into the given FixedString.
        /// Similar to StringBuilder.AppendFormat, with significant limitations:
        ///   - only supports FixedStringN arguments (convert arguments to FixedString first)
        ///   - only supports numeric format placeholders of the form "{0}" .. "{N}"
        ///   - no format modifiers (e.g. "{0:x}") are supported
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="T0"><undoc /></typeparam>
        /// <typeparam name="T1"><undoc /></typeparam>
        /// <typeparam name="T2"><undoc /></typeparam>
        /// <typeparam name="T3"><undoc /></typeparam>
        /// <typeparam name="T4"><undoc /></typeparam>
        /// <typeparam name="T5"><undoc /></typeparam>
        /// <typeparam name="T6"><undoc /></typeparam>
        /// <typeparam name="T7"><undoc /></typeparam>
        /// <typeparam name="T8"><undoc /></typeparam>
        /// <typeparam name="T9"><undoc /></typeparam>
        /// <param name="dest"></param>
        /// <param name="format"></param>
        /// <param name="arg0"><undoc /></param>
        /// <param name="arg1"><undoc /></param>
        /// <param name="arg2"><undoc /></param>
        /// <param name="arg3"><undoc /></param>
        /// <param name="arg4"><undoc /></param>
        /// <param name="arg5"><undoc /></param>
        /// <param name="arg6"><undoc /></param>
        /// <param name="arg7"><undoc /></param>
        /// <param name="arg8"><undoc /></param>
        /// <param name="arg9"><undoc /></param>
        public static unsafe void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref this T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9)
            where T : struct, INativeList<byte>, IUTF8Bytes
            where U : struct, INativeList<byte>, IUTF8Bytes
            where T0 : struct, INativeList<byte>, IUTF8Bytes
            where T1 : struct, INativeList<byte>, IUTF8Bytes
            where T2 : struct, INativeList<byte>, IUTF8Bytes
            where T3 : struct, INativeList<byte>, IUTF8Bytes
            where T4 : struct, INativeList<byte>, IUTF8Bytes
            where T5 : struct, INativeList<byte>, IUTF8Bytes
            where T6 : struct, INativeList<byte>, IUTF8Bytes
            where T7 : struct, INativeList<byte>, IUTF8Bytes
            where T8 : struct, INativeList<byte>, IUTF8Bytes
            where T9 : struct, INativeList<byte>, IUTF8Bytes
        {
            ref var formatRef = ref UnsafeUtilityExtensions.AsRef(in format);
            int formatLength = formatRef.Length;
            byte* formatBytes = formatRef.GetUnsafePtr();
            for (var i = 0; i < formatLength; ++i)
            {
                if (formatBytes[i] == (byte)'{')
                {
                    if (formatLength - i >= 3 && formatBytes[i + 1] != (byte)'{')
                    {
                        var index = formatBytes[i + 1] - (byte)'0';
                        switch (index)
                        {
                            case 0: dest.Append(in arg0); i+=2; break;
                            case 1: dest.Append(in arg1); i+=2; break;
                            case 2: dest.Append(in arg2); i+=2; break;
                            case 3: dest.Append(in arg3); i+=2; break;
                            case 4: dest.Append(in arg4); i+=2; break;
                            case 5: dest.Append(in arg5); i+=2; break;
                            case 6: dest.Append(in arg6); i+=2; break;
                            case 7: dest.Append(in arg7); i+=2; break;
                            case 8: dest.Append(in arg8); i+=2; break;
                            case 9: dest.Append(in arg9); i+=2; break;
                            default:
                                dest.AppendRawByte(formatBytes[i]);
                                break;
                        }
                    }
                }
                else
                    dest.AppendRawByte(formatBytes[i]);
            }
        }


    }
}