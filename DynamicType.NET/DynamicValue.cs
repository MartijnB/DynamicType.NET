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
    public sealed class DynamicValue {
        private readonly dynamic _value;

        public Type Type {
            get {
                if (_value == null) {
                    return null;
                }
                
                return _value.GetType();
            }
        }

        public dynamic Value {
            get { return _value; }
        }

        #region Constructors
        public DynamicValue() {
            _value = null;
        }

        //public DynamicValue(dynamic v) {
        //    _value = v;
        //}

        public DynamicValue(bool v) {
            _value = v;
        }

        public DynamicValue(byte v) {
            _value = v;
        }

        public DynamicValue(sbyte v) {
            _value = v;
        }

        public DynamicValue(char v) {
            _value = v;
        }

        public DynamicValue(decimal v) {
            _value = v;
        }

        public DynamicValue(double v) {
            _value = v;
        }

        public DynamicValue(float v) {
            _value = v;
        }

        public DynamicValue(int v) {
            _value = v;
        }

        public DynamicValue(uint v) {
            _value = v;
        }

        public DynamicValue(long v) {
            _value = v;
        }

        public DynamicValue(ulong v) {
            _value = v;
        }

        public DynamicValue(short v) {
            _value = v;
        }

        public DynamicValue(ushort v) {
            _value = v;
        }

        public DynamicValue(string v) {
            _value = v;
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj) {
            if (obj is DynamicValue) {
                try {
                    return (_value == new DynamicValue((dynamic) obj).To(_value.GetType()));
                }
                catch {
                    //exception so the compare failed
                }
            }

            return false;
        }

        public bool Equals(DynamicValue obj) {
            try {
                return (_value == obj.To(_value.GetType()));
            }
            catch {
                //exception so the compare failed
            }

            return false;
        }

        public override int GetHashCode() {
            return (_value != null ? _value.GetHashCode() : 0);
        }
        #endregion

        #region Conversion
        public T To<T>() {
            return (T) To(typeof(T));
        }

        public object To(Type t) {
            return DynamicConversion.To(t, _value);
        }

        public override string ToString() {
            return To<string>();
        }
        #endregion

        #region Implicit Cast
        //It looks we can only decently support 1 Implicit cast. Otherwise the system get confused about wich one to take.

        /*
        public static implicit operator bool(DynamicValue v) {
            return v.To<bool>();
        }

        public static implicit operator byte(DynamicValue v) {
            return v.To<byte>();
        }

        public static implicit operator sbyte(DynamicValue v) {
            return v.To<sbyte>();
        }

        public static implicit operator char(DynamicValue v) {
            return v.To<char>();
        }

        public static implicit operator decimal(DynamicValue v) {
            return v.To<decimal>();
        }

        public static implicit operator double(DynamicValue v) {
            return v.To<double>();
        }

        public static implicit operator float(DynamicValue v) {
            return v.To<float>();
        }

        public static implicit operator int(DynamicValue v) {
            return v.To<int>();
        }

        public static implicit operator uint(DynamicValue v) {
            return v.To<uint>();
        }

        public static implicit operator long(DynamicValue v) {
            return v.To<long>();
        }

        public static implicit operator ulong(DynamicValue v) {
            return v.To<ulong>();
        }

        public static implicit operator short(DynamicValue v) {
            return v.To<short>();
        }

        public static implicit operator ushort(DynamicValue v) {
            return v.To<ushort>();
        }
        */

        public static implicit operator string(DynamicValue v) {
            return v.To<string>();
        }
        #endregion

        #region Explicit Cast
        public static explicit operator bool(DynamicValue v) {
            return v.To<bool>();
        }

        public static explicit operator byte(DynamicValue v) {
            return v.To<byte>();
        }

        public static explicit operator sbyte(DynamicValue v) {
            return v.To<sbyte>();
        }

        public static explicit operator char(DynamicValue v) {
            return v.To<char>();
        }

        public static explicit operator decimal(DynamicValue v) {
            return v.To<decimal>();
        }

        public static explicit operator double(DynamicValue v) {
            return v.To<double>();
        }

        public static explicit operator float(DynamicValue v) {
            return v.To<float>();
        }

        public static explicit operator int(DynamicValue v) {
            return v.To<int>();
        }

        public static explicit operator uint(DynamicValue v) {
            return v.To<uint>();
        }

        public static explicit operator long(DynamicValue v) {
            return v.To<long>();
        }

        public static explicit operator ulong(DynamicValue v) {
            return v.To<ulong>();
        }

        public static explicit operator short(DynamicValue v) {
            return v.To<short>();
        }

        public static explicit operator ushort(DynamicValue v) {
            return v.To<ushort>();
        }

        //We do this one as a impliciet conversion.
        /*
        public static explicit operator string(DynamicValue v) {
            return v.To<string>();
        }
        */

        public static explicit operator DynamicValue(bool v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(byte v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(sbyte v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(char v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(decimal v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(double v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(float v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(int v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(uint v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(long v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(ulong v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(short v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(ushort v) {
            return new DynamicValue(v);
        }

        public static explicit operator DynamicValue(string v) {
            return new DynamicValue(v);
        }
        #endregion

        #region Unary Operators
        public static DynamicValue operator ++(DynamicValue v) {
            dynamic value = v.Value;

            if (v.Value == null) {
                return new DynamicValue(1);
            }
            else if (v.Type == typeof(bool)) {
                return new DynamicValue(true);
            }
            else if (v.Type == typeof(byte) || v.Type == typeof(sbyte) || v.Type == typeof(decimal) || v.Type == typeof(double) || v.Type == typeof(float) || v.Type == typeof(int) ||
                     v.Type == typeof(uint) || v.Type == typeof(long) || v.Type == typeof(ulong) || v.Type == typeof(short) || v.Type == typeof(ushort)) {
                return new DynamicValue(value + 1);
            }
            else if (v.Type == typeof(char)) {
                return new DynamicValue(value + 1);
            }
            else if (v.Type == typeof(string)) {
                if (((string) value).Trim() == "") {
                    return new DynamicValue(1);
                }

                throw new NotSupportedException("Operation ++ not supported!");
            }
            else {
                throw new Exception("Invalid type: " + v.Type + "!");
            }
        }

        public static DynamicValue operator --(DynamicValue v) {
            dynamic value = v.Value;

            if (v.Value == null) {
                return new DynamicValue(-1);
            }
            else if (v.Type == typeof(bool)) {
                return new DynamicValue(false);
            }
            else if (v.Type == typeof(byte) || v.Type == typeof(sbyte) || v.Type == typeof(decimal) || v.Type == typeof(double) || v.Type == typeof(float) || v.Type == typeof(int) ||
                     v.Type == typeof(uint) || v.Type == typeof(long) || v.Type == typeof(ulong) || v.Type == typeof(short) || v.Type == typeof(ushort)) {
                return new DynamicValue(value - 1);
            }
            else if (v.Type == typeof(char)) {
                return new DynamicValue(value - 1);
            }
            else if (v.Type == typeof(string)) {
                if (((string) value).Trim() == "") {
                    return new DynamicValue(-1);
                }

                throw new NotSupportedException("Operation -- not supported!");
            }
            else {
                throw new Exception("Invalid type: " + v.Type + "!");
            }
        }

        public static DynamicValue operator !(DynamicValue v) {
            dynamic value = v.Value;

            if (v.Value == null) {
                throw new ArgumentNullException();
            }
            else if (v.Type == typeof(bool)) {
                return new DynamicValue(!value);
            }
            else if (v.Type == typeof(byte) || v.Type == typeof(sbyte) || v.Type == typeof(decimal) || v.Type == typeof(double) || v.Type == typeof(float) || v.Type == typeof(int) ||
                     v.Type == typeof(uint) || v.Type == typeof(long) || v.Type == typeof(ulong) || v.Type == typeof(short) || v.Type == typeof(ushort)) {
                return new DynamicValue(!value);
            }
            else if (v.Type == typeof(char)) {
                return new DynamicValue(!value);
            }
            else if (v.Type == typeof(string)) {
                throw new NotSupportedException("Operation ! not supported!");
            }
            else {
                throw new Exception("Invalid type: " + v.Type + "!");
            }
        }

        public static DynamicValue operator ~(DynamicValue v) {
            dynamic value = v.Value;

            if (v.Value == null) {
                throw new ArgumentNullException();
            }
            else if (v.Type == typeof(bool)) {
                return new DynamicValue(~value);
            }
            else if (v.Type == typeof(byte) || v.Type == typeof(sbyte) || v.Type == typeof(decimal) || v.Type == typeof(double) || v.Type == typeof(float) || v.Type == typeof(int) ||
                     v.Type == typeof(uint) || v.Type == typeof(long) || v.Type == typeof(ulong) || v.Type == typeof(short) || v.Type == typeof(ushort)) {
                return new DynamicValue(~value);
            }
            else if (v.Type == typeof(char)) {
                return new DynamicValue(~value);
            }
            else if (v.Type == typeof(string)) {
                throw new NotSupportedException("Operation ~ not supported!");
            }
            else {
                throw new Exception("Invalid type: " + v.Type + "!");
            }
        }
        #endregion

        #region Binary Operators (Generated)
        public static DynamicValue operator +(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value + (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator +(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 + p2.To<byte>()));
        }

        public static DynamicValue operator +(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 + p2.To<sbyte>()));
        }

        public static DynamicValue operator +(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 + p2.To<char>()));
        }

        public static DynamicValue operator +(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(decimal p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<decimal>()));
        }

        public static DynamicValue operator +(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(double p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<double>()));
        }

        public static DynamicValue operator +(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(float p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<float>()));
        }

        public static DynamicValue operator +(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(int p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<int>()));
        }

        public static DynamicValue operator +(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<uint>()));
        }

        public static DynamicValue operator +(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(long p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<long>()));
        }

        public static DynamicValue operator +(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<ulong>()));
        }

        public static DynamicValue operator +(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 + p2.To<short>()));
        }

        public static DynamicValue operator +(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 + p2.To<ushort>()));
        }

        public static DynamicValue operator +(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value + (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator +(string p1, DynamicValue p2) {
            return new DynamicValue((p1 + p2.To<string>()));
        }

        public static DynamicValue operator -(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value - (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator -(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 - p2.To<byte>()));
        }

        public static DynamicValue operator -(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 - p2.To<sbyte>()));
        }

        public static DynamicValue operator -(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 - p2.To<char>()));
        }

        public static DynamicValue operator -(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(decimal p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<decimal>()));
        }

        public static DynamicValue operator -(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(double p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<double>()));
        }

        public static DynamicValue operator -(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(float p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<float>()));
        }

        public static DynamicValue operator -(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(int p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<int>()));
        }

        public static DynamicValue operator -(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<uint>()));
        }

        public static DynamicValue operator -(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(long p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<long>()));
        }

        public static DynamicValue operator -(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 - p2.To<ulong>()));
        }

        public static DynamicValue operator -(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 - p2.To<short>()));
        }

        public static DynamicValue operator -(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator -(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 - p2.To<ushort>()));
        }

        public static DynamicValue operator -(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value - (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value * (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator *(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 * p2.To<byte>()));
        }

        public static DynamicValue operator *(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 * p2.To<sbyte>()));
        }

        public static DynamicValue operator *(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 * p2.To<char>()));
        }

        public static DynamicValue operator *(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(decimal p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<decimal>()));
        }

        public static DynamicValue operator *(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(double p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<double>()));
        }

        public static DynamicValue operator *(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(float p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<float>()));
        }

        public static DynamicValue operator *(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(int p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<int>()));
        }

        public static DynamicValue operator *(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<uint>()));
        }

        public static DynamicValue operator *(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(long p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<long>()));
        }

        public static DynamicValue operator *(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 * p2.To<ulong>()));
        }

        public static DynamicValue operator *(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 * p2.To<short>()));
        }

        public static DynamicValue operator *(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator *(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 * p2.To<ushort>()));
        }

        public static DynamicValue operator *(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value * (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value / (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator /(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 / p2.To<byte>()));
        }

        public static DynamicValue operator /(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 / p2.To<sbyte>()));
        }

        public static DynamicValue operator /(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 / p2.To<char>()));
        }

        public static DynamicValue operator /(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(decimal p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<decimal>()));
        }

        public static DynamicValue operator /(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(double p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<double>()));
        }

        public static DynamicValue operator /(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(float p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<float>()));
        }

        public static DynamicValue operator /(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(int p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<int>()));
        }

        public static DynamicValue operator /(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<uint>()));
        }

        public static DynamicValue operator /(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(long p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<long>()));
        }

        public static DynamicValue operator /(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 / p2.To<ulong>()));
        }

        public static DynamicValue operator /(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 / p2.To<short>()));
        }

        public static DynamicValue operator /(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator /(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 / p2.To<ushort>()));
        }

        public static DynamicValue operator /(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value / (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value % (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator %(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 % p2.To<byte>()));
        }

        public static DynamicValue operator %(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 % p2.To<sbyte>()));
        }

        public static DynamicValue operator %(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 % p2.To<char>()));
        }

        public static DynamicValue operator %(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(decimal p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<decimal>()));
        }

        public static DynamicValue operator %(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(double p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<double>()));
        }

        public static DynamicValue operator %(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(float p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<float>()));
        }

        public static DynamicValue operator %(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(int p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<int>()));
        }

        public static DynamicValue operator %(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<uint>()));
        }

        public static DynamicValue operator %(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(long p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<long>()));
        }

        public static DynamicValue operator %(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 % p2.To<ulong>()));
        }

        public static DynamicValue operator %(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 % p2.To<short>()));
        }

        public static DynamicValue operator %(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator %(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 % p2.To<ushort>()));
        }

        public static DynamicValue operator %(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value % (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value & (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator &(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 & p2.To<byte>()));
        }

        public static DynamicValue operator &(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 & p2.To<sbyte>()));
        }

        public static DynamicValue operator &(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 & p2.To<char>()));
        }

        public static DynamicValue operator &(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(int p1, DynamicValue p2) {
            return new DynamicValue((p1 & p2.To<int>()));
        }

        public static DynamicValue operator &(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 & p2.To<uint>()));
        }

        public static DynamicValue operator &(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(long p1, DynamicValue p2) {
            return new DynamicValue((p1 & p2.To<long>()));
        }

        public static DynamicValue operator &(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 & p2.To<ulong>()));
        }

        public static DynamicValue operator &(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 & p2.To<short>()));
        }

        public static DynamicValue operator &(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator &(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 & p2.To<ushort>()));
        }

        public static DynamicValue operator &(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value & (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value | (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator |(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 | p2.To<byte>()));
        }

        public static DynamicValue operator |(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 | p2.To<sbyte>()));
        }

        public static DynamicValue operator |(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 | p2.To<char>()));
        }

        public static DynamicValue operator |(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(int p1, DynamicValue p2) {
            return new DynamicValue((p1 | p2.To<int>()));
        }

        public static DynamicValue operator |(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 | p2.To<uint>()));
        }

        public static DynamicValue operator |(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(long p1, DynamicValue p2) {
            return new DynamicValue((p1 | p2.To<long>()));
        }

        public static DynamicValue operator |(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 | p2.To<ulong>()));
        }

        public static DynamicValue operator |(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 | p2.To<short>()));
        }

        public static DynamicValue operator |(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator |(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 | p2.To<ushort>()));
        }

        public static DynamicValue operator |(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value | (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(DynamicValue p1, DynamicValue p2) {
            return new DynamicValue((p1.Value ^ (dynamic) p2.To(p1.Type)));
        }

        public static DynamicValue operator ^(DynamicValue p1, byte p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(byte p1, DynamicValue p2) {
            return new DynamicValue((byte) (p1 ^ p2.To<byte>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, sbyte p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(sbyte p1, DynamicValue p2) {
            return new DynamicValue((sbyte) (p1 ^ p2.To<sbyte>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, char p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(char p1, DynamicValue p2) {
            return new DynamicValue((char) (p1 ^ p2.To<char>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, decimal p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(DynamicValue p1, double p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(DynamicValue p1, float p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(int p1, DynamicValue p2) {
            return new DynamicValue((p1 ^ p2.To<int>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, uint p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(uint p1, DynamicValue p2) {
            return new DynamicValue((p1 ^ p2.To<uint>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, long p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(long p1, DynamicValue p2) {
            return new DynamicValue((p1 ^ p2.To<long>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, ulong p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(ulong p1, DynamicValue p2) {
            return new DynamicValue((p1 ^ p2.To<ulong>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, short p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(short p1, DynamicValue p2) {
            return new DynamicValue((short) (p1 ^ p2.To<short>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, ushort p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator ^(ushort p1, DynamicValue p2) {
            return new DynamicValue((ushort) (p1 ^ p2.To<ushort>()));
        }

        public static DynamicValue operator ^(DynamicValue p1, string p2) {
            return new DynamicValue((p1.Value ^ (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator <<(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value << (dynamic) DynamicConversion.To(p1.Type, p2)));
        }

        public static DynamicValue operator >>(DynamicValue p1, int p2) {
            return new DynamicValue((p1.Value >> (dynamic) DynamicConversion.To(p1.Type, p2)));
        }
        #endregion

        #region Compare Operators (Generated)
        public static bool operator ==(DynamicValue p1, DynamicValue p2) {
            p1 = p1 ?? new DynamicValue();
            p2 = p2 ?? new DynamicValue();

            return (p1.Value == (dynamic) p2.To(p1.Type));
        }

        public static bool operator ==(DynamicValue p1, bool p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, byte p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, sbyte p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, char p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, decimal p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, double p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, float p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, int p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, uint p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, long p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, ulong p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, short p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, ushort p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator ==(DynamicValue p1, string p2) {
            return (p1.Value == (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, DynamicValue p2) {
            return (p1.Value != (dynamic) p2.To(p1.Type));
        }

        public static bool operator !=(DynamicValue p1, bool p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, byte p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, sbyte p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, char p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, decimal p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, double p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, float p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, int p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, uint p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, long p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, ulong p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, short p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, ushort p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator !=(DynamicValue p1, string p2) {
            return (p1.Value != (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, DynamicValue p2) {
            return (p1.Value > (dynamic) p2.To(p1.Type));
        }

        public static bool operator >(DynamicValue p1, bool p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, byte p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, sbyte p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, char p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, decimal p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, double p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, float p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, int p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, uint p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, long p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, ulong p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, short p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, ushort p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >(DynamicValue p1, string p2) {
            return (p1.Value > (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, DynamicValue p2) {
            return (p1.Value < (dynamic) p2.To(p1.Type));
        }

        public static bool operator <(DynamicValue p1, bool p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, byte p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, sbyte p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, char p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, decimal p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, double p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, float p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, int p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, uint p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, long p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, ulong p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, short p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, ushort p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <(DynamicValue p1, string p2) {
            return (p1.Value < (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, DynamicValue p2) {
            return (p1.Value >= (dynamic) p2.To(p1.Type));
        }

        public static bool operator >=(DynamicValue p1, bool p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, byte p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, sbyte p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, char p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, decimal p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, double p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, float p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, int p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, uint p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, long p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, ulong p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, short p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, ushort p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator >=(DynamicValue p1, string p2) {
            return (p1.Value >= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, DynamicValue p2) {
            return (p1.Value <= (dynamic) p2.To(p1.Type));
        }

        public static bool operator <=(DynamicValue p1, bool p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, byte p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, sbyte p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, char p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, decimal p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, double p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, float p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, int p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, uint p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, long p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, ulong p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, short p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, ushort p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }

        public static bool operator <=(DynamicValue p1, string p2) {
            return (p1.Value <= (dynamic) DynamicConversion.To(p1.Type, p2));
        }
        #endregion
    }
}