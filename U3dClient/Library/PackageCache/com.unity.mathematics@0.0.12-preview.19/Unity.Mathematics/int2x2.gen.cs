// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int2x2 : System.IEquatable<int2x2>, IFormattable
    {
        public int2 c0;
        public int2 c1;

        /// <summary>int2x2 identity transform.</summary>
        public static readonly int2x2 identity = new int2x2(1, 0,   0, 1);

        /// <summary>int2x2 zero value.</summary>
        public static readonly int2x2 zero = new int2x2(0, 0,   0, 0);


        /// <summary>Constructs a int2x2 matrix from two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(int2 c0, int2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a int2x2 matrix from 4 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(int m00, int m01,
                      int m10, int m11)
        { 
            this.c0 = new int2(m00, m10);
            this.c1 = new int2(m01, m11);
        }

        /// <summary>Constructs a int2x2 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a int2x2 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(bool v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v);
            this.c1 = math.select(new int2(0), new int2(1), v);
        }

        /// <summary>Constructs a int2x2 matrix from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(bool2x2 v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v.c0);
            this.c1 = math.select(new int2(0), new int2(1), v.c1);
        }

        /// <summary>Constructs a int2x2 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(uint v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
        }

        /// <summary>Constructs a int2x2 matrix from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(uint2x2 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
        }

        /// <summary>Constructs a int2x2 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(float v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
        }

        /// <summary>Constructs a int2x2 matrix from a float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(float2x2 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
        }

        /// <summary>Constructs a int2x2 matrix from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(double v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
        }

        /// <summary>Constructs a int2x2 matrix from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x2(double2x2 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a int2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x2(int v) { return new int2x2(v); }

        /// <summary>Explicitly converts a single bool value to a int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(bool v) { return new int2x2(v); }

        /// <summary>Explicitly converts a bool2x2 matrix to a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(bool2x2 v) { return new int2x2(v); }

        /// <summary>Explicitly converts a single uint value to a int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(uint v) { return new int2x2(v); }

        /// <summary>Explicitly converts a uint2x2 matrix to a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(uint2x2 v) { return new int2x2(v); }

        /// <summary>Explicitly converts a single float value to a int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(float v) { return new int2x2(v); }

        /// <summary>Explicitly converts a float2x2 matrix to a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(float2x2 v) { return new int2x2(v); }

        /// <summary>Explicitly converts a single double value to a int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(double v) { return new int2x2(v); }

        /// <summary>Explicitly converts a double2x2 matrix to a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x2(double2x2 v) { return new int2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator * (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator * (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator * (int lhs, int2x2 rhs) { return new int2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator + (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator + (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator + (int lhs, int2x2 rhs) { return new int2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator - (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator - (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator - (int lhs, int2x2 rhs) { return new int2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator / (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator / (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator / (int lhs, int2x2 rhs) { return new int2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator % (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator % (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator % (int lhs, int2x2 rhs) { return new int2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator ++ (int2x2 val) { return new int2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator -- (int2x2 val) { return new int2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (int lhs, int2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (int lhs, int2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (int lhs, int2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (int lhs, int2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator - (int2x2 val) { return new int2x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator + (int2x2 val) { return new int2x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on an int2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator << (int2x2 x, int n) { return new int2x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator >> (int2x2 x, int n) { return new int2x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (int lhs, int2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (int2x2 lhs, int2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (int2x2 lhs, int rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (int lhs, int2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator ~ (int2x2 val) { return new int2x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator & (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator & (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator & (int lhs, int2x2 rhs) { return new int2x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator | (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator | (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator | (int lhs, int2x2 rhs) { return new int2x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator ^ (int2x2 lhs, int2x2 rhs) { return new int2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator ^ (int2x2 lhs, int rhs) { return new int2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 operator ^ (int lhs, int2x2 rhs) { return new int2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the int2 element at a specified index.</summary>
        unsafe public int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int2x2* array = &this) { return ((int2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int2* array = &c0) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the int2x2 is equal to a given int2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the int2x2 is equal to a given int2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int2x2)o); }


        /// <summary>Returns a hash code for the int2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the int2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int2x2 matrix constructed from two int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(int2 c0, int2 c1) { return new int2x2(c0, c1); }

        /// <summary>Returns a int2x2 matrix constructed from from 4 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(int m00, int m01,
                                    int m10, int m11)
        {
            return new int2x2(m00, m01,
                              m10, m11);
        }

        /// <summary>Returns a int2x2 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(int v) { return new int2x2(v); }

        /// <summary>Returns a int2x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(bool v) { return new int2x2(v); }

        /// <summary>Return a int2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(bool2x2 v) { return new int2x2(v); }

        /// <summary>Returns a int2x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(uint v) { return new int2x2(v); }

        /// <summary>Return a int2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(uint2x2 v) { return new int2x2(v); }

        /// <summary>Returns a int2x2 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(float v) { return new int2x2(v); }

        /// <summary>Return a int2x2 matrix constructed from a float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(float2x2 v) { return new int2x2(v); }

        /// <summary>Returns a int2x2 matrix constructed from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(double v) { return new int2x2(v); }

        /// <summary>Return a int2x2 matrix constructed from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 int2x2(double2x2 v) { return new int2x2(v); }

        /// <summary>Return the int2x2 transpose of a int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x2 transpose(int2x2 v)
        {
            return int2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns the determinant of a int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int determinant(int2x2 m)
        {
            int a = m.c0.x;
            int b = m.c1.x;
            int c = m.c0.y;
            int d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a int2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2x2 v)
        {
            return csum(asuint(v.c0) * uint2(0xAFCDD5EFu, 0xA88D187Du) + 
                        asuint(v.c1) * uint2(0xCF6EBA1Du, 0x9D88E5A1u)) + 0xEADF0775u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a int2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(int2x2 v)
        {
            return (asuint(v.c0) * uint2(0x747A9D7Bu, 0x4111F799u) + 
                    asuint(v.c1) * uint2(0xB5F05AF1u, 0xFD80290Bu)) + 0x8B65ADB7u;
        }

    }
}
