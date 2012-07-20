using System;

/**
 * This file is part of the DynamicType.NET Project.
 * 
 * Copyright (c) 2012 iCept Media. All rights reserved.
 * 
 * DynamicType.NET is dual licensed BSD / LGPL.
 * 
 * See License.txt for more information.
 */

namespace DynamicType.NET {
    public static class DynamicConversion {
        #region Conversion (Static)
        public static T To<T>(dynamic value) {
            return (T) To(typeof(T), value);
        }

        public static object To(Type t, dynamic value) {
            if (value == null || t != value.GetType()) {
                if (t == null) {
                    return null;
                }
                else if (t == typeof(bool)) {
                    return _toBool(value);
                }
                else if (t == typeof(byte)) {
                    return _toByte(value);
                }
                else if (t == typeof(sbyte)) {
                    return _toSByte(value);
                }
                else if (t == typeof(decimal)) {
                    return _toDecimal(value);
                }
                else if (t == typeof(double)) {
                    return _toDouble(value);
                }
                else if (t == typeof(float)) {
                    return _toFloat(value);
                }
                else if (t == typeof(int)) {
                    return _toInt(value);
                }
                else if (t == typeof(uint)) {
                    return _toUInt(value);
                }
                else if (t == typeof(long)) {
                    return _toLong(value);
                }
                else if (t == typeof(ulong)) {
                    return _toULong(value);
                }
                else if (t == typeof(short)) {
                    return _toShort(value);
                }
                else if (t == typeof(ushort)) {
                    return _toUShort(value);
                }
                else if (t == typeof(char)) {
                    return _toChar(value);
                }
                else if (t == typeof(string)) {
                    return _toString(value);
                }
                else {
                    throw new Exception("Invalid type: " + t + "!");
                }
            }

            return value;
        }
        #endregion

        #region Conversion (Private)
        private static bool _toBool(dynamic value) {
            if (value == null) {
                return false;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (bool) value;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return (value != 0);
            }
            else if (type == typeof(char)) {
                return (value != '\0');
            }
            else if (type == typeof(string)) {
                return (value == "1" || value == "true");
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static byte _toByte(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (byte) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToByte(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToByte(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToByte(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static sbyte _toSByte(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (sbyte) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToSByte(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToSByte(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToSByte(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (sbyte) (int) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static decimal _toDecimal(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (value) ? 1 : 0;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToDecimal(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToDecimal(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                /*
                var numberFormatInfo = NumberFormatInfo.CurrentInfo;
                numberFormatInfo.NumberDecimalSeparator = ".";
                numberFormatInfo.NumberGroupSeparator = "";

                return decimal.Parse(value, numberFormatInfo);
                */

                return decimal.Parse(value);
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static double _toDouble(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (value) ? 1 : 0;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToDouble(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToDouble(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                /*
                var numberFormatInfo = NumberFormatInfo.CurrentInfo;
                numberFormatInfo.NumberDecimalSeparator = ".";
                numberFormatInfo.NumberGroupSeparator = "";

                return double.Parse(value, numberFormatInfo);
                */

                return double.Parse(value);
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static float _toFloat(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (value) ? 1 : 0;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToDouble(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToDouble(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                // }

                /*
                var numberFormatInfo = NumberFormatInfo.CurrentInfo;
                numberFormatInfo.NumberDecimalSeparator = ".";
                numberFormatInfo.NumberGroupSeparator = "";

                return float.Parse(value, numberFormatInfo);
                */

                return float.Parse(value);
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static int _toInt(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (value) ? 1 : 0;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToInt32(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToInt32(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToInt32(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (int) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static uint _toUInt(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (uint) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToUInt32(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToUInt32(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToUInt32(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (uint) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static long _toLong(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (value) ? 1 : 0;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToInt64(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToInt64(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToInt64(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (long) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static ulong _toULong(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (ulong) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToUInt64(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToUInt64(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToUInt64(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (ulong) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static short _toShort(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (short) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToInt16(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToInt16(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToInt16(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (short) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static ushort _toUShort(dynamic value) {
            if (value == null) {
                return 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (ushort) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToUInt16(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToUInt16(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return 0;
                //}

                try {
                    return Convert.ToUInt16(value);
                }
                catch (FormatException) {
                    //try it as a decimal
                    try {
                        return (ushort) Convert.ToDecimal(value);
                    }
                    catch {
                    }

                    //this also failed, rethrow the original exception since its something else
                    throw;
                }
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static char _toChar(dynamic value) {
            if (value == null) {
                return (char) 0;
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return (char) ((value) ? 1 : 0);
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return Convert.ToChar(value);
            }
            else if (type == typeof(char)) {
                return Convert.ToChar(value);
            }
            else if (type == typeof(string)) {
                //if (((string) value).Trim() == "") {
                //    return (char) 0;
                //}

                return Convert.ToChar(value);
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }

        private static string _toString(dynamic value) {
            if (value == null) {
                return "";
            }

            var type = value.GetType();
            if (type == typeof(bool)) {
                return "" + value;
            }
            else if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) ||
                     type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(short) || type == typeof(ushort)) {
                return "" + value;
            }
            else if (type == typeof(char)) {
                return "" + value;
            }
            else if (type == typeof(string)) {
                return value;
            }
            else {
                throw new Exception("Invalid type: " + type + "!");
            }
        }
        #endregion
    }
}