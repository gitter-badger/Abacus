﻿// ┌────────────────────────────────────────────────────────────────────────┐ \\
// │ Abacus - Fast, efficient, cross precision, maths library               │ \\
// ├────────────────────────────────────────────────────────────────────────┤ \\
// │ Brought to you by:                                                     │ \\
// │          _________                    .__               __             │ \\
// │         /   _____/__ __  ____    ____ |__|____    _____/  |_           │ \\
// │         \_____  \|  |  \/    \  / ___\|  \__  \  /    \   __\          │ \\
// │         /        \  |  /   |  \/ /_/  >  |/ __ \|   |  \  |            │ \\
// │        /_______  /____/|___|  /\___  /|__(____  /___|  /__|            │ \\
// │                \/           \//_____/         \/     \/                │ \\
// │                                                                        │ \\
// ├────────────────────────────────────────────────────────────────────────┤ \\
// │ Copyright © 2013 A.J.Pook (http://sungiant.github.com)                 │ \\
// ├────────────────────────────────────────────────────────────────────────┤ \\
// │ Permission is hereby granted, free of charge, to any person obtaining  │ \\
// │ a copy of this software and associated documentation files (the        │ \\
// │ "Software"), to deal in the Software without restriction, including    │ \\
// │ without limitation the rights to use, copy, modify, merge, publish,    │ \\
// │ distribute, sublicense, and/or sellcopies of the Software, and to      │ \\
// │ permit persons to whom the Software is furnished to do so, subject to  │ \\
// │ the following conditions:                                              │ \\
// │                                                                        │ \\
// │ The above copyright notice and this permission notice shall be         │ \\
// │ included in all copies or substantial portions of the Software.        │ \\
// │                                                                        │ \\
// │ THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,        │ \\
// │ EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF     │ \\
// │ MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. │ \\
// │ IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY   │ \\
// │ CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,   │ \\
// │ TORT OR OTHERWISE, ARISING FROM,OUT OF OR IN CONNECTION WITH THE       │ \\
// │ SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                 │ \\
// └────────────────────────────────────────────────────────────────────────┘ \\


using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Sungiant.Abacus.Tests
{

	/// <summary>
	/// todo
	/// </summary>
	[TestFixture]
    public class RealMaths
	{
	}


}

namespace Sungiant.Abacus.Packed.Tests
{
	/// <summary>
	/// todo
	/// </summary>
	public static class Settings
    {
        public const Int32 NumTests = 50000;
    }

    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public static class Alpha_8Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestAllPossibleValues()
        {   
            Byte packed = Byte.MinValue;
            while ( packed < Byte.MaxValue )
            {
                ++packed;

                var packedObj = new Alpha_8();

                packedObj.PackedValue = packed;

                Single unpacked;

                packedObj.UnpackTo(out unpacked);

                var newPackedObj = new Alpha_8(unpacked);

                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }

    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Bgr_5_6_5Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestAllPossibleValues()
        {
            UInt16 packed = UInt16.MinValue;
            while ( packed < UInt16.MaxValue )
            {
                ++packed;
                
                var packedObj = new Bgr_5_6_5();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector3 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Bgr_5_6_5(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Bgra16Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestAllPossibleValues()
        {
            UInt16 packed = UInt16.MinValue;
            while ( packed < UInt16.MaxValue )
            {
                ++packed;
                
                var packedObj = new Bgra16();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Bgra16(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Bgra_5_5_5_1Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestAllPossibleValues()
        {
            UInt16 packed = UInt16.MinValue;
            while ( packed < UInt16.MaxValue )
            {
                ++packed;
                
                var packedObj = new Bgra_5_5_5_1();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);

                var newPackedObj = new Bgra_5_5_5_1(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Byte4Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];

            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);

                var packedObj = new Byte4();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Byte4(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class NormalisedByte2Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestAllPossibleValues()
        {
            UInt16 packed = UInt16.MinValue;
            while ( packed < UInt16.MaxValue )
            {
                ++packed;

                var packedObj = new NormalisedByte2();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector2 unpacked;
                
                packedObj.UnpackTo(out unpacked);

                Console.WriteLine("p: " + packed + ", v: " + unpacked);
                
                var newPackedObj = new NormalisedByte2(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed).Within(5));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class NormalisedByte4Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new NormalisedByte4();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new NormalisedByte4(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class NormalisedShort2Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new NormalisedShort2();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector2 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new NormalisedShort2(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class NormalisedShort4Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new NormalisedShort4();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new NormalisedShort4(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Rg32Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new Rg32();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector2 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Rg32(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Rgba32Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new Rgba32();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Rgba32(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Rgba64Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[8];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt64(buff, 0);
                UInt64 packed = BitConverter.ToUInt64(buff, 0);
                
                var packedObj = new Rgba64();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Rgba64(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Rgba_10_10_10_2Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new Rgba_10_10_10_2();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Rgba_10_10_10_2(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Short2Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[4];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt32(buff, 0);
                UInt32 packed = BitConverter.ToUInt32(buff, 0);
                var packedObj = new Short2();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector2 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Short2(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
    /// <summary>
    /// todo
    /// </summary>
    [TestFixture]
    public class Short4Tests
    {
        /// <summary>
        /// todo
        /// </summary>
        [Test]
        public static void TestRandomValues()
        {
            var rand = new System.Random();
            var buff = new Byte[8];
            
            for(Int32 i = 0; i < Settings.NumTests; ++i)
            {
                rand.NextBytes(buff);
                BitConverter.ToUInt64(buff, 0);

                UInt64 packed = BitConverter.ToUInt64(buff, 0);
                
                var packedObj = new Short4();
                
                packedObj.PackedValue = packed;
                
                SinglePrecision.Vector4 unpacked;
                
                packedObj.UnpackTo(out unpacked);
                
                var newPackedObj = new Short4(ref unpacked);
                
                Assert.That(newPackedObj.PackedValue, Is.EqualTo(packed));
            }
        }
    }
}

namespace Sungiant.Abacus.Int32Precision.Tests
{
	[TestFixture]
	public class Point2Tests
	{

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

	}
		[TestFixture]
	public class Point3Tests
	{

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

	}
	}

namespace Sungiant.Abacus.Int64Precision.Tests
{
	[TestFixture]
	public class Point2Tests
	{

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

	}
		[TestFixture]
	public class Point3Tests
	{

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

	}
	}


namespace Sungiant.Abacus.SinglePrecision.Tests
{
	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Matrix44Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Matrix44Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Single value.
		/// </summary>
		static Single GetNextRandomSingle ()
		{
			Single randomValue = rand.NextSingle();

			Single zero = 0;
			Single multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Matrix44.
		/// </summary>
		static Matrix44 GetNextRandomMatrix44 ()
		{
			Single a = GetNextRandomSingle();
			Single b = GetNextRandomSingle();
			Single c = GetNextRandomSingle();
			Single d = GetNextRandomSingle();
			Single e = GetNextRandomSingle();
			Single f = GetNextRandomSingle();
			Single g = GetNextRandomSingle();
			Single h = GetNextRandomSingle();
			Single i = GetNextRandomSingle();
			Single j = GetNextRandomSingle();
			Single k = GetNextRandomSingle();
			Single l = GetNextRandomSingle();
			Single m = GetNextRandomSingle();
			Single n = GetNextRandomSingle();
			Single o = GetNextRandomSingle();
			Single p = GetNextRandomSingle();

			return new Matrix44(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Matrix44s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Matrix44 a, Matrix44 b)
		{
			Single tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.M11, Is.EqualTo(b.M11).Within(tolerance));
			Assert.That(a.M12, Is.EqualTo(b.M12).Within(tolerance));
			Assert.That(a.M13, Is.EqualTo(b.M13).Within(tolerance));
			Assert.That(a.M14, Is.EqualTo(b.M14).Within(tolerance));
			Assert.That(a.M21, Is.EqualTo(b.M21).Within(tolerance));
			Assert.That(a.M22, Is.EqualTo(b.M22).Within(tolerance));
			Assert.That(a.M23, Is.EqualTo(b.M23).Within(tolerance));
			Assert.That(a.M24, Is.EqualTo(b.M24).Within(tolerance));
			Assert.That(a.M31, Is.EqualTo(b.M31).Within(tolerance));
			Assert.That(a.M32, Is.EqualTo(b.M32).Within(tolerance));
			Assert.That(a.M33, Is.EqualTo(b.M33).Within(tolerance));
			Assert.That(a.M34, Is.EqualTo(b.M34).Within(tolerance));
			Assert.That(a.M41, Is.EqualTo(b.M41).Within(tolerance));
			Assert.That(a.M42, Is.EqualTo(b.M42).Within(tolerance));
			Assert.That(a.M43, Is.EqualTo(b.M43).Within(tolerance));
			Assert.That(a.M44, Is.EqualTo(b.M44).Within(tolerance));
		}
		

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}
		
		[Test]
		public void TestTranspose_MemberFn ()
		{
			Matrix44 startMatrix = new Matrix44(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Matrix44 testMatrix = startMatrix;

			Matrix44 testMatrixExpectedTranspose = new Matrix44(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15);

			testMatrix.Transpose();

			Assert.That(testMatrix, Is.EqualTo(testMatrixExpectedTranspose));
		}

		[Test]
		public void TestTranspose_StaticFn ()
		{
			Matrix44 startMatrix = new Matrix44(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Matrix44 testMatrix = startMatrix;

			Matrix44 testMatrixExpectedTranspose = new Matrix44(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15);

			// RUN THE STATIC VERSION OF THE FUNCTION
			Matrix44 resultMatrix = Matrix44.Identity;

			Matrix44.Transpose(ref testMatrix, out resultMatrix);

			Assert.That(resultMatrix, Is.EqualTo(testMatrixExpectedTranspose));

		}

		[Test]
		public void Decompose ()
		{
            Matrix44 scale;
            Matrix44.CreateScale(4, 2, 3, out scale);

            Matrix44 rotation;
            Single pi; RealMaths.Pi(out pi);
            Matrix44.CreateRotationY(pi, out rotation);

            Matrix44 translation;
            Matrix44.CreateTranslation(100, 5, 3, out translation);

            Matrix44 m = rotation * scale;
            //m = translation * m;
			m.Translation = new Vector3(100, 5, 3);

            Vector3 outScale;
            Quaternion outRotation;
            Vector3 outTranslation;

            m.Decompose(out outScale, out outRotation, out outTranslation);

			Matrix44 mat;
            Matrix44.CreateFromQuaternion(ref outRotation, out mat);

			Assert.That(outScale, Is.EqualTo(new Vector3(4, 2, 3)));
			Assert.That(mat, Is.EqualTo(rotation));
			Assert.That(outTranslation, Is.EqualTo(new Vector3(100, 5, 3)));

		}

		// Test Constant: Identity //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Matrix44 initilised using the Identity 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Identity ()
		{
			Matrix44 result = Matrix44.Identity;
			Matrix44 expected = new Matrix44 (
				1, 0, 0, 0, 
				0, 1, 0, 0, 
				0, 0, 1, 0, 
				0, 0, 0, 1);

			AssertEqualWithinReason(result, expected);
		}	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class QuaternionTests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static QuaternionTests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Single value.
		/// </summary>
		static Single GetNextRandomSingle ()
		{
			Single randomValue = rand.NextSingle();

			Single zero = 0;
			Single multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Quaternion.
		/// </summary>
		static Quaternion GetNextRandomQuaternion ()
		{
			Single a = GetNextRandomSingle();
			Single b = GetNextRandomSingle();
			Single c = GetNextRandomSingle();
			Single d = GetNextRandomSingle();

			return new Quaternion(a, b, c, d);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Quaternions are equal.
		/// </summary>
		static void AssertEqualWithinReason (Quaternion a, Quaternion b)
		{
			Single tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
			Assert.That(a.W, Is.EqualTo(b.W).Within(tolerance));
		}
		

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		// Test Constant: Identity //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Quaternion initilised using the Identity 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Identity ()
		{
			Quaternion result = Quaternion.Identity;
			Quaternion expected = new Quaternion (
				0, 0, 0, 1);

			AssertEqualWithinReason(result, expected);
		}	}
		/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector2Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector2Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Single value.
		/// </summary>
		static Single GetNextRandomSingle ()
		{
			Single randomValue = rand.NextSingle();

			Single zero = 0;
			Single multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector2.
		/// </summary>
		static Vector2 GetNextRandomVector2 ()
		{
			Single a = GetNextRandomSingle();
			Single b = GetNextRandomSingle();

			return new Vector2(a, b);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector2s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector2 a, Vector2 b)
		{
			Single tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector2);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X and Y member variables of a number of randomly generated Vector2
		/// objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 vec = GetNextRandomVector2();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Single[] data = new Single[2];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 2);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector2 a = new Vector2();
				Assert.That(a, Is.EqualTo(Vector2.Zero));
			}
			{
				// Test Vector2( Single, Single )
				Single u = -189;
				Single v = 429;
				Vector2 c = new Vector2(u, v);
				Assert.That(c.X, Is.EqualTo(u));
				Assert.That(c.Y, Is.EqualTo(v));
			}
			{
				// Test no constructor
				Vector2 e;
				e.X = 0;
				e.Y = 0;
				Assert.That(e, Is.EqualTo(Vector2.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector2 a = new Vector2(42, -17);

			String result = a.ToString();

			String expected = "{X:42 Y:-17}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector2>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector2();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector2 a = new Vector2(3, -4);

			Single expected = 5;

			Single result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector2 a = new Vector2(3, -4);

			Single expected = 25;

			Single result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector2 a = new Vector2( 1,  0);
			Vector2 b = new Vector2(-1,  0);
			Vector2 c = new Vector2( 0,  1);
			Vector2 d = new Vector2( 0, -1);
			Vector2 e = new Vector2( 1,  1);
			Vector2 f = new Vector2( 0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));

			Assert.That(e.IsUnit(), Is.EqualTo(false));
			Assert.That(f.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b; Vector2.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Single piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Single theta = piOver2 / 90 * i;

				Single x = RealMaths.Sin(theta);
				Single y = RealMaths.Cos(theta);				

				Assert.That(
					new Vector2( x,  y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2( x, -y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2(-x,  y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2(-x, -y).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector2 result = Vector2.Zero;
			Vector2 expected = new Vector2(0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector2 result = Vector2.One;
			Vector2 expected = new Vector2(1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector2 result = Vector2.UnitX;
			Vector2 expected = new Vector2(1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector2 result = Vector2.UnitY;
			Vector2 expected = new Vector2(0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector2 a = new Vector2(0, 4);
				Vector2 b = new Vector2(3, 0);

				Single expected = 5;
				Single result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = new Vector2(0, -4);
				Vector2 b = new Vector2(3, 0);

				Single expected = 5;
				Single result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = new Vector2(0, -4);
				Vector2 b = new Vector2(-3, 0);

				Single expected = 5;
				Single result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = Vector2.Zero;

				Single expected = 0;
				Single result;

				Vector2.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();

				Single expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector2 a = new Vector2(0, 4);
				Vector2 b = new Vector2(3, 0);

				Single expected = 25;
				Single result;

				Vector2.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = Vector2.Zero;

				Single expected = 0;
				Single result;

				Vector2.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Vector2 c = b - a;

				Single expected = (c.X * c.X) + (c.Y * c.Y);
				Single result;

				Vector2.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Single expected = (a.X * b.X) + (a.Y * b.Y);
				Single result; Vector2.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(-1, 0);

			Single expected = -1;
			Single result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(1, 0);

			Single expected = 1;
			Single result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(0, 1);

			Single expected = 0;
			Single result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector2 a = Vector2.Zero;

				Vector2 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector2.Normalise(ref a, out b)
				);
			}

			{
				Vector2 a = new Vector2(
					Single.MaxValue, 
					Single.MaxValue);

				Vector2 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector2.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b; Vector2.Normalise(ref a, out b);
				
				Single expected = 1;
				Single result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Single l = a.Length();

				Vector2 b; Vector2.Normalise(ref a, out b);
				
				Vector2 expected = a;
				Vector2 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: Reflect //-----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Reflect method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_i ()
		{
			{
				Vector2 incident = new Vector2(20, -5);

				Vector2 normal = new Vector2(1, -1);
				Vector2.Normalise(ref normal, out normal);

				Vector2 expected = new Vector2(-5, 20);
				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector2 incident = new Vector2(20, -5);

				Vector2 normal = new Vector2(2, -1);
				Vector2.Normalise(ref normal, out normal);

				Vector2 expected = new Vector2(-16, 13);
				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector2 incident = Vector2.Zero;

				Vector2 normal = new Vector2(1, 0);

				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, Vector2.Zero);
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Reflect method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_ii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b = GetNextRandomVector2();

				Vector2.Normalise(ref b, out b);

				Vector2 result;
				Vector2.Reflect(ref a, ref b, out result);
				
				Single dot;
				Vector2.Dot(ref a, ref b, out dot);

				Vector2 expected = a - (2 * dot * b);

				AssertEqualWithinReason(result, expected);
			}
		}

		/// <summary>
		/// Assert that an argument exception is thrown if the value passed in
		/// to the normal parameter is not normalised.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_iii ()
		{
			Vector2 incident = GetNextRandomVector2();
			Vector2 normal = new Vector2(12, -241);

			Vector2 result; 

			Assert.Throws(
				typeof(ArgumentOutOfRangeException), 
				() => 
				Vector2.Reflect(ref incident, ref normal, out result)
			);
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector2 a, Vector2 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector2 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector2(44, -54);
			var b = new Vector2(44, -54);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector2 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector2(44, 54);
			var b = new Vector2(44, -54);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector2 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();

				Vector2 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector2 result_1b; Vector2.Add(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector2(3, -6);
			var b = new Vector2(-6, 12);

			var expected = new Vector2(-3, 6);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector2(-2313, 88);

			var expected = a;

			this.TestAddition(a, Vector2.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector2.Zero, Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var expected = new Vector2(a.X + b.X, a.Y + b.Y);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector2 result_1b; Vector2.Subtract(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector2(12, -4);
			var b = new Vector2(15, 11);
			var expected = new Vector2(-3, -15);
			this.TestSubtraction(a, b, expected);

			var c = new Vector2(-423, 342);
			this.TestSubtraction(c, Vector2.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector2.Zero, Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var expected = new Vector2(a.X - b.X, a.Y - b.Y);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector2 a, Vector2 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector2 result_1b; Vector2.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Single r = 3432;
			Single s = -6218;
			Single t = -3432;
			Single u = 6218;

			var a = new Vector2(r, s);
			var b = new Vector2(u, t);
			var c = new Vector2(t, u);
			var d = new Vector2(s, r);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Single t = -3432;
			Single u = 6218;
			Single r = 3432;
			Single s = -6218;

			var c = new Vector2(t, u);
			var d = new Vector2(s, r);

			this.TestNegation(c, Vector2.Zero - c);
			this.TestNegation(d, Vector2.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				this.TestNegation(a, Vector2.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector2 result_1b; Vector2.Multiply(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Single r = 18;
			Single s = -54;

			Single x = 3;
			Single y = 6;
			Single z = -9;

			var a = new Vector2(x, y);
			var b = new Vector2(y, z);
			var c = new Vector2(r, s);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var c = new Vector2(a.X * b.X, a.Y * b.Y);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector2 result_1b; Vector2.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Single r = 10;
			Single s = -40;

			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector2(x, y);
			var b = new Vector2(y, z);
			var c = new Vector2(r, s);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Single t = ((Single) 1 ) / ((Single) 10);
			Single u = ((Single) (-1) ) / ((Single) 40 );
			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector2(y, z);
			var b = new Vector2(x, y);
			var c = new Vector2(t, u);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var c = new Vector2(a.X / b.X, a.Y / b.Y);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				Single amount1 = 0;
				Vector2 result1;

				Vector2.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector2 result2;

				Vector2.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector2( -30, -30 );
			var b = new Vector2( +30, +30 );

			Single one = 1;

			Single i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Single j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Single k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector2 r0 = a;
			Vector2 r1 = new Vector2( -i, -i );
			Vector2 r2 = new Vector2( -j, -j );
			Vector2 r3 = new Vector2( -k, -k );
			Vector2 r4 = Vector2.Zero;
			Vector2 r5 = new Vector2(  k,  k );
			Vector2 r6 = new Vector2(  j,  j );
			Vector2 r7 = new Vector2(  i,  i );
			Vector2 r8 = b;

			var knownResults = new List<Tuple<Single, Vector2>>
			{
				new Tuple<Single, Vector2>( a0, r0 ),
				new Tuple<Single, Vector2>( a1, r1 ),
				new Tuple<Single, Vector2>( a2, r2 ),
				new Tuple<Single, Vector2>( a3, r3 ),
				new Tuple<Single, Vector2>( a4, r4 ),
				new Tuple<Single, Vector2>( a5, r5 ),
				new Tuple<Single, Vector2>( a6, r6 ),
				new Tuple<Single, Vector2>( a7, r7 ),
				new Tuple<Single, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();
				var c = GetNextRandomVector2();
				var d = GetNextRandomVector2();

				Single amount1 = 0;
				Vector2 result1;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Single amount2 = 1;
				Vector2 result2;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector2( -90, +30 );
			var b = new Vector2( -30, -30 );
			var c = new Vector2( +30, +30 );
			var d = new Vector2( +90, -30 );

			Single one = 1;

			Single u = 15;
			Single v = (Single) 165  / (Single)  8; // 20.5
			Single w = (Single) 45   / (Single)  2; // 20.625
			Single x = (Single) 1755 / (Single) 64; // 27.421875
			Single y = (Single) 15   / (Single)  2; // 14.5
			Single z = (Single) 705  / (Single) 64; // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2( -w, -x );
			Vector2 r2 = new Vector2( -u, -v );
			Vector2 r3 = new Vector2( -y, -z );
			Vector2 r4 = Vector2.Zero;
			Vector2 r5 = new Vector2(  y,  z );
			Vector2 r6 = new Vector2(  u,  v );
			Vector2 r7 = new Vector2(  w,  x );
			Vector2 r8 = c;

			var knownResults = new List<Tuple<Single, Vector2>>
			{
				new Tuple<Single, Vector2>( a0, r0 ),
				new Tuple<Single, Vector2>( a1, r1 ),
				new Tuple<Single, Vector2>( a2, r2 ),
				new Tuple<Single, Vector2>( a3, r3 ),
				new Tuple<Single, Vector2>( a4, r4 ),
				new Tuple<Single, Vector2>( a5, r5 ),
				new Tuple<Single, Vector2>( a6, r6 ),
				new Tuple<Single, Vector2>( a7, r7 ),
				new Tuple<Single, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();
			var c = GetNextRandomVector2();
			var d = GetNextRandomVector2();
			
			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector2( -90, -90 );
			var b = new Vector2( -30, -30 );
			var c = new Vector2( +30, +30 );
			var d = new Vector2( +90, +90 );

			Single one = 1;

			Single a0 = 0;
			Single a1 = (one * 1) / 4;
			Single a2 = (one * 2) / 4;
			Single a3 = (one * 3) / 4;
			Single a4 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2( -15, -15 );
			Vector2 r2 = Vector2.Zero;
			Vector2 r3 = new Vector2( 15, 15 );
			Vector2 r4 = c;

			var knownResults = new List<Tuple<Single, Vector2>>
			{
				new Tuple<Single, Vector2>( a0, r0 ),
				new Tuple<Single, Vector2>( a1, r1 ),
				new Tuple<Single, Vector2>( a2, r2 ),
				new Tuple<Single, Vector2>( a3, r3 ),
				new Tuple<Single, Vector2>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector2();
				var b  = GetNextRandomVector2();

				var c = GetNextRandomVector2();
				var d = GetNextRandomVector2();

				Vector2 an; Vector2.Normalise(ref c, out an);
				Vector2 bn; Vector2.Normalise(ref d, out bn);

				Single amount1 = 0;
				Vector2 result1;

				Vector2.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector2 result2;

				Vector2.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();
			var c = GetNextRandomVector2();
			var d = GetNextRandomVector2();

			Vector2 an; Vector2.Normalise(ref c, out an);
			Vector2 bn; Vector2.Normalise(ref d, out bn);

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector2( -100, +50 );
			var b = new Vector2( +100, -50 );

			var c = new Vector2( -10, +5 );
			var d = new Vector2( +10, -5 );

			Vector2 an; Vector2.Normalise(ref c, out an);
			Vector2 bn; Vector2.Normalise(ref d, out bn);

			Single one = 1;
			
			// 100.1953125
			Single e = (Single) 51300 / (Single) 512;

			// 50.09765625
			Single f = (Single) 12825 / (Single) 256;

			// 91.25
			Single g = (Single) 365 / (Single) 4;

			// 45.625
			Single h = (Single) 365 / (Single) 8;

			// 75.7421875
			Single i = (Single) 9695 / (Single) 128;

			// 37.87109375
			Single j = (Single) 9695 / (Single) 256;

			// 56.25
			Single k = (Single) 225 / (Single) 4;

			// 28.125
			Single l = (Single) 225 / (Single) 8;

			// 35.3515625
			Single m = (Single) 4525 / (Single) 128;

			// 17.67578125
			Single n = (Single) 4525 / (Single) 256;

			// 15.625
			Single o = (Single) 125 / (Single) 8;

			// 7.8125
			Single p = (Single) 125 / (Single) 16;

			// 0.3515625
			Single q = (Single) 45 / (Single) 128;

			// 0.17578125
			Single r = (Single) 45 / (Single) 256;

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2(  e, -f );
			Vector2 r2 = new Vector2(  g, -h );
			Vector2 r3 = new Vector2(  i, -j );
			Vector2 r4 = new Vector2(  k, -l );
			Vector2 r5 = new Vector2(  m, -n );
			Vector2 r6 = new Vector2(  o, -p );
			Vector2 r7 = new Vector2( -q,  r );
			Vector2 r8 = c;

			var knownResults = new List<Tuple<Single, Vector2>>
			{
				new Tuple<Single, Vector2>( a0, r0 ),
				new Tuple<Single, Vector2>( a1, r1 ),
				new Tuple<Single, Vector2>( a2, r2 ),
				new Tuple<Single, Vector2>( a3, r3 ),
				new Tuple<Single, Vector2>( a4, r4 ),
				new Tuple<Single, Vector2>( a5, r5 ),
				new Tuple<Single, Vector2>( a6, r6 ),
				new Tuple<Single, Vector2>( a7, r7 ),
				new Tuple<Single, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector2 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = a * 2;

				Vector2 result;
				Vector2.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(a.X < b.X ? a.X : b.X ));
				Assert.That(result.Y, Is.EqualTo(a.Y < b.Y ? a.Y : b.Y ));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector2 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Vector2 result;
				Vector2.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(a.X > b.X ? a.X : b.X ));
				Assert.That(result.Y, Is.EqualTo(a.Y > b.Y ? a.Y : b.Y ));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector2 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector2 min = new Vector2(-30, 1);
			Vector2 max = new Vector2(32, 130);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 result;
				Vector2.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector2 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector2 min = new Vector2(-30, 1);
			Vector2 max = new Vector2(32, 130);

			Vector2 a = new Vector2(-100, 1113);

			Vector2 expected = new Vector2(-30, 130);

			Vector2 result;
			Vector2.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector2 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Single delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector2 a = GetNextRandomVector2();
					Vector2 b = GetNextRandomVector2();

					Vector2 result;
					Vector2.Lerp (ref a, ref b, delta, out result);

					Vector2 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector2 a = GetNextRandomVector2();
			Vector2 b = GetNextRandomVector2();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector2 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector3Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector3Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Single value.
		/// </summary>
		static Single GetNextRandomSingle ()
		{
			Single randomValue = rand.NextSingle();

			Single zero = 0;
			Single multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector3.
		/// </summary>
		static Vector3 GetNextRandomVector3 ()
		{
			Single a = GetNextRandomSingle();
			Single b = GetNextRandomSingle();
			Single c = GetNextRandomSingle();

			return new Vector3(a, b, c);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector3s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector3 a, Vector3 b)
		{
			Single tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector3);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X, Y and Z member variables of a number of randomly generated 
		/// Vector3 objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 vec = GetNextRandomVector3();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Single[] data = new Single[3];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 3);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
		        Assert.That(data[2], Is.EqualTo(vec.Z));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector3 a = new Vector3();
				Assert.That(a, Is.EqualTo(Vector3.Zero));
			}
			{
				// Test Vector3( Single, Single, Single )
				Single a = -189;
				Single b = 429;
				Single c = 4298;
				Vector3 d = new Vector3(a, b, c);
				Assert.That(d.X, Is.EqualTo(a));
				Assert.That(d.Y, Is.EqualTo(b));
				Assert.That(d.Z, Is.EqualTo(c));
			}
			{
				// Test Vector3( Vector2, Single )
				Vector2 a = new Vector2(-189, 429);
				Single b = 4298;
				Vector3 c = new Vector3(a, b);
				Assert.That(c.X, Is.EqualTo(a.X));
				Assert.That(c.Y, Is.EqualTo(a.Y));
				Assert.That(c.Z, Is.EqualTo(b));
			}
			{
				// Test no constructor
				Vector3 a;
				a.X = 0;
				a.Y = 0;
				a.Z = 0;
				Assert.That(a, Is.EqualTo(Vector3.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector3 a = new Vector3(42, -17, 13);

			String result = a.ToString();

			String expected = "{X:42 Y:-17 Z:13}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector3>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector3();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector3 a = new Vector3(3, -4, 12);

			Single expected = 13;

			Single result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector3 a = new Vector3(3, -4, 12);

			Single expected = 169;

			Single result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector3 a = new Vector3( 1,  0,  0);
			Vector3 b = new Vector3(-1,  0,  0);
			Vector3 c = new Vector3( 0,  1,  0);
			Vector3 d = new Vector3( 0, -1,  0);
			Vector3 e = new Vector3( 0,  0,  1);
			Vector3 f = new Vector3( 0,  0, -1);
			Vector3 g = new Vector3( 1,  1,  1);
			Vector3 h = new Vector3( 0,  0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));
			Assert.That(e.IsUnit(), Is.EqualTo(true));
			Assert.That(f.IsUnit(), Is.EqualTo(true));

			Assert.That(g.IsUnit(), Is.EqualTo(false));
			Assert.That(h.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b; Vector3.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Single piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Single theta = piOver2 / 90 * i;

				Single x = RealMaths.Sin(theta);
				Single y = RealMaths.Cos(theta);
				Single z = 0;				

				Assert.That(
					new Vector3( x,  y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3( x, -y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3(-x,  y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3(-x, -y,  z).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector3 result = Vector3.Zero;
			Vector3 expected = new Vector3(0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector3 result = Vector3.One;
			Vector3 expected = new Vector3(1, 1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector3 result = Vector3.UnitX;
			Vector3 expected = new Vector3(1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector3 result = Vector3.UnitY;
			Vector3 expected = new Vector3(0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitZ //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitZ
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitZ ()
		{
			Vector3 result = Vector3.UnitZ;
			Vector3 expected = new Vector3(0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Up //-----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Up
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Up ()
		{
			Vector3 result = Vector3.Up;
			Vector3 expected = new Vector3(0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Down //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Down
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Down ()
		{
			Vector3 result = Vector3.Down;
			Vector3 expected = new Vector3(0, -1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Right //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Right
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Right ()
		{
			Vector3 result = Vector3.Right;
			Vector3 expected = new Vector3(1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Left //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Left
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Left ()
		{
			Vector3 result = Vector3.Left;
			Vector3 expected = new Vector3(-1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Forward //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Forward
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Forward ()
		{
			Vector3 result = Vector3.Forward;
			Vector3 expected = new Vector3(0, 0, -1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Backward //-----------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Backward
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Backward ()
		{
			Vector3 result = Vector3.Backward;
			Vector3 expected = new Vector3(0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector3 a = new Vector3(0, 4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Single expected = 13;
				Single result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = new Vector3(0, -4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Single expected = 13;
				Single result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = new Vector3(0, -4, -12);
				Vector3 b = new Vector3(-3, 0, 0);

				Single expected = 13;
				Single result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = Vector3.Zero;

				Single expected = 0;
				Single result;

				Vector3.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();

				Single expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector3 a = new Vector3(0, 4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Single expected = 161;
				Single result;

				Vector3.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = Vector3.Zero;

				Single expected = 0;
				Single result;

				Vector3.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Vector3 c = b - a;

				Single expected = (c.X * c.X) + (c.Y * c.Y) + (c.Z * c.Z);
				Single result;

				Vector3.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Single expected = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
				Single result; Vector3.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector3 a = new Vector3(0, 0, 1);
			Vector3 b = new Vector3(0, 0, -1);

			Single expected = -1;
			Single result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector3 a = new Vector3(0, 0, 1);
			Vector3 b = new Vector3(0, 0, 1);

			Single expected = 1;
			Single result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector3 a = new Vector3(0, 1, 0);
			Vector3 b = new Vector3(0, 0, 1);

			Single expected = 0;
			Single result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector3 a = Vector3.Zero;

				Vector3 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector3.Normalise(ref a, out b)
				);
			}

			{
				Vector3 a = new Vector3(
					Single.MaxValue, 
					Single.MaxValue, 
					Single.MaxValue);

				Vector3 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector3.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b; Vector3.Normalise(ref a, out b);
				
				Single expected = 1;
				Single result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Single l = a.Length();

				Vector3 b; Vector3.Normalise(ref a, out b);
				
				Vector3 expected = a;
				Vector3 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: Cross //-------------------------------------------//
		[Test]
		public void TestStaticFn_Cross_i ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		// Test Static Fn: Reflect //-----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Reflect method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_i ()
		{
			{
				Vector3 incident = new Vector3(20, -5, 10);

				Vector3 normal = new Vector3(1, -1, 2);
				Vector3.Normalise(ref normal, out normal);

				Vector3 expected = new Vector3(-5, 20, 2);
				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector3 incident = new Vector3(20, -5, 10);

				Vector3 normal = new Vector3(2, -1, 2);
				Vector3.Normalise(ref normal, out normal);

				Vector3 expected = new Vector3(-16, 13, 2);
				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector3 incident = Vector3.Zero;

				Vector3 normal = new Vector3(0, 0, 1);

				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, Vector3.Zero);
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Reflect method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_ii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b = GetNextRandomVector3();

				Vector3.Normalise(ref b, out b);

				Vector3 result;
				Vector3.Reflect(ref a, ref b, out result);
				
				Single dot;
				Vector3.Dot(ref a, ref b, out dot);

				Vector3 expected = a - (2 * dot * b);

				AssertEqualWithinReason(result, expected);
			}
		}

		/// <summary>
		/// Assert that an argument exception is thrown if the value passed in
		/// to the normal parameter is not normalised.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_iii ()
		{
			Vector3 incident = GetNextRandomVector3();
			Vector3 normal = new Vector3(12, -241, 123);

			Vector3 result; 

			Assert.Throws(
				typeof(ArgumentOutOfRangeException), 
				() => 
				Vector3.Reflect(ref incident, ref normal, out result)
			);
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector3 a, Vector3 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector3 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector3(44, -54, -22);
			var b = new Vector3(44, -54, -22);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector3 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector3(44, 54, 2);
			var b = new Vector3(44, -54, 2);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector3 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();

				Vector3 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector3 result_1b; Vector3.Add(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector3(3, -6, 44);
			var b = new Vector3(-6, 12, 18);

			var expected = new Vector3(-3, 6, 62);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector3(-2313, 88, 199);

			var expected = a;

			this.TestAddition(a, Vector3.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector3.Zero, Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var expected = new Vector3(
					a.X + b.X, a.Y + b.Y, a.Z + b.Z);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector3 result_1b; Vector3.Subtract(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector3(12, -4, 14);
			var b = new Vector3(15, 11, 7);
			var expected = new Vector3(-3, -15, 7);
			this.TestSubtraction(a, b, expected);

			var c = new Vector3(-423, 342, 7);
			this.TestSubtraction(c, Vector3.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector3.Zero, Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var expected = new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector3 a, Vector3 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector3 result_1b; Vector3.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Single r = 3432;
			Single s = -6218;
			Single t = -3432;
			Single u = 6218;

			var a = new Vector3(r, s, t);
			var b = new Vector3(u, t, s);
			var c = new Vector3(t, u, r);
			var d = new Vector3(s, r, u);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Single t = -3432;
			Single u = 6218;
			Single r = 3432;
			Single s = -6218;

			var c = new Vector3(t, u, r);
			var d = new Vector3(s, r, u);

			this.TestNegation(c, Vector3.Zero - c);
			this.TestNegation(d, Vector3.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				this.TestNegation(a, Vector3.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector3 result_1b; Vector3.Multiply(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Single r = -27;
			Single s = 36;
			Single t = 9;

			Single x = 3;
			Single y = 6;
			Single z = -9;

			var a = new Vector3(x, y, x);
			var b = new Vector3(z, y, x);
			var c = new Vector3(r, s, t);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var c = new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector3 result_1b; Vector3.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Single r = 10;
			Single s = -40;
			Single t = 1;

			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector3(x, y, x);
			var b = new Vector3(y, z, x);
			var c = new Vector3(r, s, t);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Single t = ((Single) 1 ) / ((Single) 10);
			Single u = ((Single) (-1) ) / ((Single) 40 );
			Single v = -20;
			Single w = 100;
			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector3(y, z, w);
			var b = new Vector3(x, y, z);
			var c = new Vector3(t, u, v);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var c = new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				Single amount1 = 0;
				Vector3 result1;

				Vector3.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector3 result2;

				Vector3.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector3( -30, -30, -30 );
			var b = new Vector3( +30, +30, +30 );

			Single one = 1;

			Single i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Single j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Single k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector3 r0 = a;
			Vector3 r1 = new Vector3( -i, -i, -i );
			Vector3 r2 = new Vector3( -j, -j, -j );
			Vector3 r3 = new Vector3( -k, -k, -k );
			Vector3 r4 = Vector3.Zero;
			Vector3 r5 = new Vector3(  k,  k,  k );
			Vector3 r6 = new Vector3(  j,  j,  j );
			Vector3 r7 = new Vector3(  i,  i,  i );
			Vector3 r8 = b;

			var knownResults = new List<Tuple<Single, Vector3>>
			{
				new Tuple<Single, Vector3>( a0, r0 ),
				new Tuple<Single, Vector3>( a1, r1 ),
				new Tuple<Single, Vector3>( a2, r2 ),
				new Tuple<Single, Vector3>( a3, r3 ),
				new Tuple<Single, Vector3>( a4, r4 ),
				new Tuple<Single, Vector3>( a5, r5 ),
				new Tuple<Single, Vector3>( a6, r6 ),
				new Tuple<Single, Vector3>( a7, r7 ),
				new Tuple<Single, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();
				var c = GetNextRandomVector3();
				var d = GetNextRandomVector3();

				Single amount1 = 0;
				Vector3 result1;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Single amount2 = 1;
				Vector3 result2;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector3( -90, +30, +90 );
			var b = new Vector3( -30, -30, +30 );
			var c = new Vector3( +30, +30, -30 );
			var d = new Vector3( +90, -30, -90 );

			Single one = 1;

			Single u = 15;
			Single v = (Single) 165  / (Single)  8; // 20.5
			Single w = (Single) 45   / (Single)  2; // 20.625
			Single x = (Single) 1755 / (Single) 64; // 27.421875
			Single y = (Single) 15   / (Single)  2; // 14.5
			Single z = (Single) 705  / (Single) 64; // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3( -w, -x,  w );
			Vector3 r2 = new Vector3( -u, -v,  u );
			Vector3 r3 = new Vector3( -y, -z,  y );
			Vector3 r4 = Vector3.Zero;
			Vector3 r5 = new Vector3(  y,  z, -y );
			Vector3 r6 = new Vector3(  u,  v, -u );
			Vector3 r7 = new Vector3(  w,  x, -w );
			Vector3 r8 = c;

			var knownResults = new List<Tuple<Single, Vector3>>
			{
				new Tuple<Single, Vector3>( a0, r0 ),
				new Tuple<Single, Vector3>( a1, r1 ),
				new Tuple<Single, Vector3>( a2, r2 ),
				new Tuple<Single, Vector3>( a3, r3 ),
				new Tuple<Single, Vector3>( a4, r4 ),
				new Tuple<Single, Vector3>( a5, r5 ),
				new Tuple<Single, Vector3>( a6, r6 ),
				new Tuple<Single, Vector3>( a7, r7 ),
				new Tuple<Single, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();
			var c = GetNextRandomVector3();
			var d = GetNextRandomVector3();
			
			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector3( -90, -90, +90 );
			var b = new Vector3( -30, -30, +30 );
			var c = new Vector3( +30, +30, -30 );
			var d = new Vector3( +90, +90, -90 );

			Single one = 1;

			Single a0 = 0;
			Single a1 = (one * 1) / 4;
			Single a2 = (one * 2) / 4;
			Single a3 = (one * 3) / 4;
			Single a4 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3( -15, -15,  15 );
			Vector3 r2 = Vector3.Zero;
			Vector3 r3 = new Vector3(  15,  15, -15 );
			Vector3 r4 = c;

			var knownResults = new List<Tuple<Single, Vector3>>
			{
				new Tuple<Single, Vector3>( a0, r0 ),
				new Tuple<Single, Vector3>( a1, r1 ),
				new Tuple<Single, Vector3>( a2, r2 ),
				new Tuple<Single, Vector3>( a3, r3 ),
				new Tuple<Single, Vector3>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector3();
				var b  = GetNextRandomVector3();

				var c = GetNextRandomVector3();
				var d = GetNextRandomVector3();

				Vector3 an; Vector3.Normalise(ref c, out an);
				Vector3 bn; Vector3.Normalise(ref d, out bn);

				Single amount1 = 0;
				Vector3 result1;

				Vector3.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector3 result2;

				Vector3.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();
			var c = GetNextRandomVector3();
			var d = GetNextRandomVector3();

			Vector3 an; Vector3.Normalise(ref c, out an);
			Vector3 bn; Vector3.Normalise(ref d, out bn);

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector3( -100, +50, +100 );
			var b = new Vector3( +100, -50, -100 );

			var c = new Vector3( -10, +5, +10 );
			var d = new Vector3( +10, -5, -10 );

			Vector3 an; Vector3.Normalise(ref c, out an);
			Vector3 bn; Vector3.Normalise(ref d, out bn);

			Single one = 1;
			
			// 100.1953125
			Single e = (Single) 51300 / (Single) 512;

			// 50.09765625
			Single f = (Single) 12825 / (Single) 256;

			// 91.25
			Single g = (Single) 365 / (Single) 4;

			// 45.625
			Single h = (Single) 365 / (Single) 8;

			// 75.7421875
			Single i = (Single) 9695 / (Single) 128;

			// 37.87109375
			Single j = (Single) 9695 / (Single) 256;

			// 56.25
			Single k = (Single) 225 / (Single) 4;

			// 28.125
			Single l = (Single) 225 / (Single) 8;

			// 35.3515625
			Single m = (Single) 4525 / (Single) 128;

			// 17.67578125
			Single n = (Single) 4525 / (Single) 256;

			// 15.625
			Single o = (Single) 125 / (Single) 8;

			// 7.8125
			Single p = (Single) 125 / (Single) 16;

			// 0.3515625
			Single q = (Single) 45 / (Single) 128;

			// 0.17578125
			Single r = (Single) 45 / (Single) 256;

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3(  e, -f, -e );
			Vector3 r2 = new Vector3(  g, -h, -g );
			Vector3 r3 = new Vector3(  i, -j, -i );
			Vector3 r4 = new Vector3(  k, -l, -k );
			Vector3 r5 = new Vector3(  m, -n, -m );
			Vector3 r6 = new Vector3(  o, -p, -o );
			Vector3 r7 = new Vector3( -q,  r,  q );
			Vector3 r8 = c;

			var knownResults = new List<Tuple<Single, Vector3>>
			{
				new Tuple<Single, Vector3>( a0, r0 ),
				new Tuple<Single, Vector3>( a1, r1 ),
				new Tuple<Single, Vector3>( a2, r2 ),
				new Tuple<Single, Vector3>( a3, r3 ),
				new Tuple<Single, Vector3>( a4, r4 ),
				new Tuple<Single, Vector3>( a5, r5 ),
				new Tuple<Single, Vector3>( a6, r6 ),
				new Tuple<Single, Vector3>( a7, r7 ),
				new Tuple<Single, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector3 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = a * 2;

				Vector3 result;
				Vector3.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));

				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector3 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Vector3 result;
				Vector3.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector3 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector3 min = new Vector3(-30, 1, 18);
			Vector3 max = new Vector3(32, 130, 47);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 result;
				Vector3.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector3 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector3 min = new Vector3(-30, 1, 18);
			Vector3 max = new Vector3(32, 130, 47);

			Vector3 a = new Vector3(-100, 1113, 50);

			Vector3 expected = new Vector3(-30, 130, 47);

			Vector3 result;
			Vector3.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.Z, Is.LessThanOrEqualTo(max.Z));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			Assert.That(result.Z, Is.GreaterThanOrEqualTo(min.Z));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector3 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Single delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector3 a = GetNextRandomVector3();
					Vector3 b = GetNextRandomVector3();

					Vector3 result;
					Vector3.Lerp (ref a, ref b, delta, out result);

					Vector3 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector3 a = GetNextRandomVector3();
			Vector3 b = GetNextRandomVector3();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector3 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector4Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector4Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Single value.
		/// </summary>
		static Single GetNextRandomSingle ()
		{
			Single randomValue = rand.NextSingle();

			Single zero = 0;
			Single multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector4.
		/// </summary>
		static Vector4 GetNextRandomVector4 ()
		{
			Single a = GetNextRandomSingle();
			Single b = GetNextRandomSingle();
			Single c = GetNextRandomSingle();
			Single d = GetNextRandomSingle();

			return new Vector4(a, b, c, d);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector4s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector4 a, Vector4 b)
		{
			Single tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
			Assert.That(a.W, Is.EqualTo(b.W).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector4);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X, Y, Z and W member variables of a number of randomly generated 
		/// Vector4 objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 vec = GetNextRandomVector4();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Single[] data = new Single[4];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 4);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
		        Assert.That(data[2], Is.EqualTo(vec.Z));
		        Assert.That(data[3], Is.EqualTo(vec.W));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector4 a = new Vector4();
				Assert.That(a, Is.EqualTo(Vector4.Zero));
			}
			{
				// Test Vector4( Single, Single, Single )
				Single a = -189;
				Single b = 429;
				Single c = 4298;
				Single d = 341;
				Vector4 e = new Vector4(a, b, c, d);
				Assert.That(e.X, Is.EqualTo(a));
				Assert.That(e.Y, Is.EqualTo(b));
				Assert.That(e.Z, Is.EqualTo(c));
				Assert.That(e.W, Is.EqualTo(d));
			}
			{
				// Test Vector4( Vector2, Single, Single )
				Vector2 a = new Vector2(-189, 429);
				Single b = 4298;
				Single c = 341;
				Vector4 d = new Vector4(a, b, c);
				Assert.That(d.X, Is.EqualTo(a.X));
				Assert.That(d.Y, Is.EqualTo(a.Y));
				Assert.That(d.Z, Is.EqualTo(b));
				Assert.That(d.W, Is.EqualTo(c));
			}
			{
				// Test Vector4( Vector3, Single )
				Vector3 a = new Vector3(-189, 429, 4298);
				Single b = 341;
				Vector4 c = new Vector4(a, b);
				Assert.That(c.X, Is.EqualTo(a.X));
				Assert.That(c.Y, Is.EqualTo(a.Y));
				Assert.That(c.Z, Is.EqualTo(a.Z));
				Assert.That(c.W, Is.EqualTo(b));
			}
			{
				// Test no constructor
				Vector4 a;
				a.X = 0;
				a.Y = 0;
				a.Z = 0;
				a.W = 0;
				Assert.That(a, Is.EqualTo(Vector4.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector4 a = new Vector4(42, -17, 13, 44);

			String result = a.ToString();

			String expected = "{X:42 Y:-17 Z:13 W:44}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector4>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector4();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector4 a = new Vector4(3, -4, 12, 84);

			Single expected = 85;

			Single result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector4 a = new Vector4(3, -4, 12, 84);

			Single expected = 7225;

			Single result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector4 a = new Vector4( 1,  0,  0,  0);
			Vector4 b = new Vector4(-1,  0,  0,  0);
			Vector4 c = new Vector4( 0,  1,  0,  0);
			Vector4 d = new Vector4( 0, -1,  0,  0);
			Vector4 e = new Vector4( 0,  0,  1,  0);
			Vector4 f = new Vector4( 0,  0, -1,  0);
			Vector4 g = new Vector4( 0,  0,  0,  1);
			Vector4 h = new Vector4( 0,  0,  0, -1);
			Vector4 i = new Vector4( 1,  1,  1,  1);
			Vector4 j = new Vector4( 0,  0,  0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));
			Assert.That(e.IsUnit(), Is.EqualTo(true));
			Assert.That(f.IsUnit(), Is.EqualTo(true));
			Assert.That(g.IsUnit(), Is.EqualTo(true));
			Assert.That(h.IsUnit(), Is.EqualTo(true));

			Assert.That(i.IsUnit(), Is.EqualTo(false));
			Assert.That(j.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 b; Vector4.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Single piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Single theta = piOver2 / 90 * i;

				Single x = RealMaths.Sin(theta);
				Single y = RealMaths.Cos(theta);				
				Single z = 0;
				Single w = 0;

				Assert.That(
					new Vector4( x,  y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4( x, -y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4(-x,  y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4(-x, -y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector4 result = Vector4.Zero;
			Vector4 expected = new Vector4(0, 0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector4 result = Vector4.One;
			Vector4 expected = new Vector4(1, 1, 1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector4 result = Vector4.UnitX;
			Vector4 expected = new Vector4(1, 0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector4 result = Vector4.UnitY;
			Vector4 expected = new Vector4(0, 1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitZ //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitZ 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitZ ()
		{
			Vector4 result = Vector4.UnitZ;
			Vector4 expected = new Vector4(0, 0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitW //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitW
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitW ()
		{
			Vector4 result = Vector4.UnitW;
			Vector4 expected = new Vector4(0, 0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector4 a = new Vector4(0, 4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Single expected = 85;
				Single result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = new Vector4(0, -4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Single expected = 85;
				Single result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = new Vector4(0, -4, -12, 0);
				Vector4 b = new Vector4(-3, 0, 0, -84);

				Single expected = 85;
				Single result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = Vector4.Zero;

				Single expected = 0;
				Single result;

				Vector4.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();

				Single expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z) + (a.W * a.W));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector4 a = new Vector4(0, 4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Single expected = 7225;
				Single result;

				Vector4.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = Vector4.Zero;

				Single expected = 0;
				Single result;

				Vector4.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Vector4 c = b - a;

				Single expected = (c.X * c.X) + (c.Y * c.Y) + (c.Z * c.Z) + (c.W * c.W);
				Single result;

				Vector4.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Single expected = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z) + (a.W * b.W);
				Single result; Vector4.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector4 a = new Vector4(0, 0, 0, 1);
			Vector4 b = new Vector4(0, 0, 0, -1);

			Single expected = -1;
			Single result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector4 a = new Vector4(0, 0, 0, 1);
			Vector4 b = new Vector4(0, 0, 0, 1);

			Single expected = 1;
			Single result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector4 a = new Vector4(0, 0, 1, 0);
			Vector4 b = new Vector4(0, 0, 0, 1);

			Single expected = 0;
			Single result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector4 a = Vector4.Zero;

				Vector4 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector4.Normalise(ref a, out b)
				);
			}

			{
				Vector4 a = new Vector4(
					Single.MaxValue, 
					Single.MaxValue, 
					Single.MaxValue, 
					Single.MaxValue);

				Vector4 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector4.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 b; Vector4.Normalise(ref a, out b);
				
				Single expected = 1;
				Single result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Single epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Single l = a.Length();

				Vector4 b; Vector4.Normalise(ref a, out b);
				
				Vector4 expected = a;
				Vector4 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector4 a, Vector4 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector4 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector4(44, -54, -22, 11);
			var b = new Vector4(44, -54, -22, 11);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector4 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector4(44, 54, 2, 11);
			var b = new Vector4(44, -54, 2, -1);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector4 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();

				Vector4 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector4 result_1b; Vector4.Add(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector4(3, -6, 44, 11);
			var b = new Vector4(-6, 12, 18, -3);

			var expected = new Vector4(-3, 6, 62, 8);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector4(-2313, 88, 199, 42);

			var expected = a;

			this.TestAddition(a, Vector4.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector4.Zero, Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var expected = new Vector4(
					a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector4 result_1b; Vector4.Subtract(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector4(12, -4, 14, 18);
			var b = new Vector4(15, 11, 7, 27);
			var expected = new Vector4(-3, -15, 7, -9);
			this.TestSubtraction(a, b, expected);

			var c = new Vector4(-423, 342, 7, -800);
			this.TestSubtraction(c, Vector4.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector4.Zero, Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var expected = new Vector4(
					a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector4 a, Vector4 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector4 result_1b; Vector4.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Single r = 3432;
			Single s = -6218;
			Single t = -3432;
			Single u = 6218;

			var a = new Vector4(r, s, t, u);
			var b = new Vector4(u, t, s, r);
			var c = new Vector4(t, u, r, s);
			var d = new Vector4(s, r, u, t);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Single t = -3432;
			Single u = 6218;
			Single r = 3432;
			Single s = -6218;

			var c = new Vector4(t, u, r, s);
			var d = new Vector4(s, r, u, t);

			this.TestNegation(c, Vector4.Zero - c);
			this.TestNegation(d, Vector4.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				this.TestNegation(a, Vector4.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector4 result_1b; Vector4.Multiply(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Single r = -27;
			Single s = 36;
			Single t = 9;
			Single u = -54;

			Single x = 3;
			Single y = 6;
			Single z = -9;

			var a = new Vector4(x, y, x, y);
			var b = new Vector4(z, y, x, z);
			var c = new Vector4(r, s, t, u);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var c = new Vector4(
					a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector4 result_1b; Vector4.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Single r = 10;
			Single s = -40;
			Single t = 1;
			Single u = -400;

			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector4(x, y, x, x);
			var b = new Vector4(y, z, x, z);
			var c = new Vector4(r, s, t, u);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Single s = 4;
			Single t = ((Single) 1 ) / ((Single) 10);
			Single u = ((Single) (-1) ) / ((Single) 40 );
			Single v = -20;
			Single w = 100;
			Single x = 2000;
			Single y = 200;
			Single z = -5;

			var a = new Vector4(y, z, w, v);
			var b = new Vector4(x, y, z, z);
			var c = new Vector4(t, u, v, s);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var c = new Vector4(
					a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				Single amount1 = 0;
				Vector4 result1;

				Vector4.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector4 result2;

				Vector4.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector4( -30, -30, -30, -30 );
			var b = new Vector4( +30, +30, +30, +30 );

			Single one = 1;

			Single i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Single j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Single k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector4 r0 = a;
			Vector4 r1 = new Vector4( -i, -i, -i, -i );
			Vector4 r2 = new Vector4( -j, -j, -j, -j );
			Vector4 r3 = new Vector4( -k, -k, -k, -k );
			Vector4 r4 = Vector4.Zero;
			Vector4 r5 = new Vector4(  k,  k,  k,  k );
			Vector4 r6 = new Vector4(  j,  j,  j,  j );
			Vector4 r7 = new Vector4(  i,  i,  i,  i );
			Vector4 r8 = b;

			var knownResults = new List<Tuple<Single, Vector4>>
			{
				new Tuple<Single, Vector4>( a0, r0 ),
				new Tuple<Single, Vector4>( a1, r1 ),
				new Tuple<Single, Vector4>( a2, r2 ),
				new Tuple<Single, Vector4>( a3, r3 ),
				new Tuple<Single, Vector4>( a4, r4 ),
				new Tuple<Single, Vector4>( a5, r5 ),
				new Tuple<Single, Vector4>( a6, r6 ),
				new Tuple<Single, Vector4>( a7, r7 ),
				new Tuple<Single, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();
				var c = GetNextRandomVector4();
				var d = GetNextRandomVector4();

				Single amount1 = 0;
				Vector4 result1;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Single amount2 = 1;
				Vector4 result2;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector4( -90, +30, +90, -30 );
			var b = new Vector4( -30, -30, +30, +30 );
			var c = new Vector4( +30, +30, -30, -30 );
			var d = new Vector4( +90, -30, -90, -30 );

			Single one = 1;

			Single u = 15;
			Single v = (Single) 165  / (Single)  8; // 20.5
			Single w = (Single) 45   / (Single)  2; // 20.625
			Single x = (Single) 1755 / (Single) 64; // 27.421875
			Single y = (Single) 15   / (Single)  2; // 14.5
			Single z = (Single) 705  / (Single) 64; // 11.015625

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4( -w, -x,  w,  x );
			Vector4 r2 = new Vector4( -u, -v,  u,  v );
			Vector4 r3 = new Vector4( -y, -z,  y,  z );
			Vector4 r4 = Vector4.Zero;
			Vector4 r5 = new Vector4(  y,  z, -y, -z );
			Vector4 r6 = new Vector4(  u,  v, -u, -v );
			Vector4 r7 = new Vector4(  w,  x, -w, -x );
			Vector4 r8 = c;

			var knownResults = new List<Tuple<Single, Vector4>>
			{
				new Tuple<Single, Vector4>( a0, r0 ),
				new Tuple<Single, Vector4>( a1, r1 ),
				new Tuple<Single, Vector4>( a2, r2 ),
				new Tuple<Single, Vector4>( a3, r3 ),
				new Tuple<Single, Vector4>( a4, r4 ),
				new Tuple<Single, Vector4>( a5, r5 ),
				new Tuple<Single, Vector4>( a6, r6 ),
				new Tuple<Single, Vector4>( a7, r7 ),
				new Tuple<Single, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();
			var c = GetNextRandomVector4();
			var d = GetNextRandomVector4();
			
			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector4( -90, +30, +90, -30 );
			var b = new Vector4( -30, -30, +30, +30 );
			var c = new Vector4( +30, +30, -30, -30 );
			var d = new Vector4( +90, -30, -90, -30 );

			Single one = 1;

			Single a0 = 0;
			Single a1 = (one * 1) / 4;
			Single a2 = (one * 2) / 4;
			Single a3 = (one * 3) / 4;
			Single a4 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4( -15, -15,  15,  15 );
			Vector4 r2 = Vector4.Zero;
			Vector4 r3 = new Vector4(  15,  15, -15, -15 );
			Vector4 r4 = c;

			var knownResults = new List<Tuple<Single, Vector4>>
			{
				new Tuple<Single, Vector4>( a0, r0 ),
				new Tuple<Single, Vector4>( a1, r1 ),
				new Tuple<Single, Vector4>( a2, r2 ),
				new Tuple<Single, Vector4>( a3, r3 ),
				new Tuple<Single, Vector4>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector4();
				var b  = GetNextRandomVector4();

				var c = GetNextRandomVector4();
				var d = GetNextRandomVector4();

				Vector4 an; Vector4.Normalise(ref c, out an);
				Vector4 bn; Vector4.Normalise(ref d, out bn);

				Single amount1 = 0;
				Vector4 result1;

				Vector4.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Single amount2 = 1;
				Vector4 result2;

				Vector4.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();
			var c = GetNextRandomVector4();
			var d = GetNextRandomVector4();

			Vector4 an; Vector4.Normalise(ref c, out an);
			Vector4 bn; Vector4.Normalise(ref d, out bn);

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector4( -100, +50, +100, -50 );
			var b = new Vector4( +100, -50, -100, +50 );

			var c = new Vector4( -10, +5, +10, -5 );
			var d = new Vector4( +10, -5, -10, +5 );

			Vector4 an; Vector4.Normalise(ref c, out an);
			Vector4 bn; Vector4.Normalise(ref d, out bn);

			Single one = 1;
			
			// 100.1953125
			Single e = (Single) 51300 / (Single) 512;

			// 50.09765625
			Single f = (Single) 12825 / (Single) 256;

			// 91.25
			Single g = (Single) 365 / (Single) 4;

			// 45.625
			Single h = (Single) 365 / (Single) 8;

			// 75.7421875
			Single i = (Single) 9695 / (Single) 128;

			// 37.87109375
			Single j = (Single) 9695 / (Single) 256;

			// 56.25
			Single k = (Single) 225 / (Single) 4;

			// 28.125
			Single l = (Single) 225 / (Single) 8;

			// 35.3515625
			Single m = (Single) 4525 / (Single) 128;

			// 17.67578125
			Single n = (Single) 4525 / (Single) 256;

			// 15.625
			Single o = (Single) 125 / (Single) 8;

			// 7.8125
			Single p = (Single) 125 / (Single) 16;

			// 0.3515625
			Single q = (Single) 45 / (Single) 128;

			// 0.17578125
			Single r = (Single) 45 / (Single) 256;

			Single a0 = 0;
			Single a1 = (one * 1) / 8;
			Single a2 = (one * 2) / 8;
			Single a3 = (one * 3) / 8;
			Single a4 = (one * 4) / 8;
			Single a5 = (one * 5) / 8;
			Single a6 = (one * 6) / 8;
			Single a7 = (one * 7) / 8;
			Single a8 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4(  e, -f, -e,  f );
			Vector4 r2 = new Vector4(  g, -h, -g,  h );
			Vector4 r3 = new Vector4(  i, -j, -i,  j );
			Vector4 r4 = new Vector4(  k, -l, -k,  l );
			Vector4 r5 = new Vector4(  m, -n, -m,  n );
			Vector4 r6 = new Vector4(  o, -p, -o,  p );
			Vector4 r7 = new Vector4( -q,  r,  q, -r );
			Vector4 r8 = c;

			var knownResults = new List<Tuple<Single, Vector4>>
			{
				new Tuple<Single, Vector4>( a0, r0 ),
				new Tuple<Single, Vector4>( a1, r1 ),
				new Tuple<Single, Vector4>( a2, r2 ),
				new Tuple<Single, Vector4>( a3, r3 ),
				new Tuple<Single, Vector4>( a4, r4 ),
				new Tuple<Single, Vector4>( a5, r5 ),
				new Tuple<Single, Vector4>( a6, r6 ),
				new Tuple<Single, Vector4>( a7, r7 ),
				new Tuple<Single, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector4 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = a * 2;

				Vector4 result;
				Vector4.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector4 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Vector4 result;
				Vector4.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector4 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector4 min = new Vector4(-30, 1, 18, -22);
			Vector4 max = new Vector4(32, 130, 47, -2);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 result;
				Vector4.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector4 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector4 min = new Vector4(-30, 1, 18, -22);
			Vector4 max = new Vector4(32, 130, 47, -2);

			Vector4 a = new Vector4(-100, 1113, 50, 14);

			Vector4 expected = new Vector4(-30, 130, 47, -2);

			Vector4 result;
			Vector4.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.Z, Is.LessThanOrEqualTo(max.Z));
			Assert.That(result.W, Is.LessThanOrEqualTo(max.W));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			Assert.That(result.Z, Is.GreaterThanOrEqualTo(min.Z));
			Assert.That(result.W, Is.GreaterThanOrEqualTo(min.W));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector4 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Single delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector4 a = GetNextRandomVector4();
					Vector4 b = GetNextRandomVector4();

					Vector4 result;
					Vector4.Lerp (ref a, ref b, delta, out result);

					Vector4 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector4 a = GetNextRandomVector4();
			Vector4 b = GetNextRandomVector4();

			Single half; RealMaths.Half(out half);

			var tests = new Single[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector4 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}}

namespace Sungiant.Abacus.DoublePrecision.Tests
{
	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Matrix44Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Matrix44Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Double value.
		/// </summary>
		static Double GetNextRandomDouble ()
		{
			Double randomValue = rand.NextDouble();

			Double zero = 0;
			Double multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Matrix44.
		/// </summary>
		static Matrix44 GetNextRandomMatrix44 ()
		{
			Double a = GetNextRandomDouble();
			Double b = GetNextRandomDouble();
			Double c = GetNextRandomDouble();
			Double d = GetNextRandomDouble();
			Double e = GetNextRandomDouble();
			Double f = GetNextRandomDouble();
			Double g = GetNextRandomDouble();
			Double h = GetNextRandomDouble();
			Double i = GetNextRandomDouble();
			Double j = GetNextRandomDouble();
			Double k = GetNextRandomDouble();
			Double l = GetNextRandomDouble();
			Double m = GetNextRandomDouble();
			Double n = GetNextRandomDouble();
			Double o = GetNextRandomDouble();
			Double p = GetNextRandomDouble();

			return new Matrix44(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Matrix44s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Matrix44 a, Matrix44 b)
		{
			Double tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.M11, Is.EqualTo(b.M11).Within(tolerance));
			Assert.That(a.M12, Is.EqualTo(b.M12).Within(tolerance));
			Assert.That(a.M13, Is.EqualTo(b.M13).Within(tolerance));
			Assert.That(a.M14, Is.EqualTo(b.M14).Within(tolerance));
			Assert.That(a.M21, Is.EqualTo(b.M21).Within(tolerance));
			Assert.That(a.M22, Is.EqualTo(b.M22).Within(tolerance));
			Assert.That(a.M23, Is.EqualTo(b.M23).Within(tolerance));
			Assert.That(a.M24, Is.EqualTo(b.M24).Within(tolerance));
			Assert.That(a.M31, Is.EqualTo(b.M31).Within(tolerance));
			Assert.That(a.M32, Is.EqualTo(b.M32).Within(tolerance));
			Assert.That(a.M33, Is.EqualTo(b.M33).Within(tolerance));
			Assert.That(a.M34, Is.EqualTo(b.M34).Within(tolerance));
			Assert.That(a.M41, Is.EqualTo(b.M41).Within(tolerance));
			Assert.That(a.M42, Is.EqualTo(b.M42).Within(tolerance));
			Assert.That(a.M43, Is.EqualTo(b.M43).Within(tolerance));
			Assert.That(a.M44, Is.EqualTo(b.M44).Within(tolerance));
		}
		

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}
		
		[Test]
		public void TestTranspose_MemberFn ()
		{
			Matrix44 startMatrix = new Matrix44(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Matrix44 testMatrix = startMatrix;

			Matrix44 testMatrixExpectedTranspose = new Matrix44(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15);

			testMatrix.Transpose();

			Assert.That(testMatrix, Is.EqualTo(testMatrixExpectedTranspose));
		}

		[Test]
		public void TestTranspose_StaticFn ()
		{
			Matrix44 startMatrix = new Matrix44(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Matrix44 testMatrix = startMatrix;

			Matrix44 testMatrixExpectedTranspose = new Matrix44(0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15);

			// RUN THE STATIC VERSION OF THE FUNCTION
			Matrix44 resultMatrix = Matrix44.Identity;

			Matrix44.Transpose(ref testMatrix, out resultMatrix);

			Assert.That(resultMatrix, Is.EqualTo(testMatrixExpectedTranspose));

		}

		[Test]
		public void Decompose ()
		{
            Matrix44 scale;
            Matrix44.CreateScale(4, 2, 3, out scale);

            Matrix44 rotation;
            Double pi; RealMaths.Pi(out pi);
            Matrix44.CreateRotationY(pi, out rotation);

            Matrix44 translation;
            Matrix44.CreateTranslation(100, 5, 3, out translation);

            Matrix44 m = rotation * scale;
            //m = translation * m;
			m.Translation = new Vector3(100, 5, 3);

            Vector3 outScale;
            Quaternion outRotation;
            Vector3 outTranslation;

            m.Decompose(out outScale, out outRotation, out outTranslation);

			Matrix44 mat;
            Matrix44.CreateFromQuaternion(ref outRotation, out mat);

			Assert.That(outScale, Is.EqualTo(new Vector3(4, 2, 3)));
			Assert.That(mat, Is.EqualTo(rotation));
			Assert.That(outTranslation, Is.EqualTo(new Vector3(100, 5, 3)));

		}

		// Test Constant: Identity //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Matrix44 initilised using the Identity 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Identity ()
		{
			Matrix44 result = Matrix44.Identity;
			Matrix44 expected = new Matrix44 (
				1, 0, 0, 0, 
				0, 1, 0, 0, 
				0, 0, 1, 0, 
				0, 0, 0, 1);

			AssertEqualWithinReason(result, expected);
		}	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class QuaternionTests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static QuaternionTests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Double value.
		/// </summary>
		static Double GetNextRandomDouble ()
		{
			Double randomValue = rand.NextDouble();

			Double zero = 0;
			Double multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Quaternion.
		/// </summary>
		static Quaternion GetNextRandomQuaternion ()
		{
			Double a = GetNextRandomDouble();
			Double b = GetNextRandomDouble();
			Double c = GetNextRandomDouble();
			Double d = GetNextRandomDouble();

			return new Quaternion(a, b, c, d);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Quaternions are equal.
		/// </summary>
		static void AssertEqualWithinReason (Quaternion a, Quaternion b)
		{
			Double tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
			Assert.That(a.W, Is.EqualTo(b.W).Within(tolerance));
		}
		

		[Test]
		public void Test_Constructors ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void Test_Equality ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_ToString ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		[Test]
		public void TestMemberFn_GetHashCode ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		// Test Constant: Identity //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Quaternion initilised using the Identity 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Identity ()
		{
			Quaternion result = Quaternion.Identity;
			Quaternion expected = new Quaternion (
				0, 0, 0, 1);

			AssertEqualWithinReason(result, expected);
		}	}
		/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector2Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector2Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Double value.
		/// </summary>
		static Double GetNextRandomDouble ()
		{
			Double randomValue = rand.NextDouble();

			Double zero = 0;
			Double multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector2.
		/// </summary>
		static Vector2 GetNextRandomVector2 ()
		{
			Double a = GetNextRandomDouble();
			Double b = GetNextRandomDouble();

			return new Vector2(a, b);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector2s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector2 a, Vector2 b)
		{
			Double tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector2);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X and Y member variables of a number of randomly generated Vector2
		/// objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 vec = GetNextRandomVector2();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Double[] data = new Double[2];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 2);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector2 a = new Vector2();
				Assert.That(a, Is.EqualTo(Vector2.Zero));
			}
			{
				// Test Vector2( Double, Double )
				Double u = -189;
				Double v = 429;
				Vector2 c = new Vector2(u, v);
				Assert.That(c.X, Is.EqualTo(u));
				Assert.That(c.Y, Is.EqualTo(v));
			}
			{
				// Test no constructor
				Vector2 e;
				e.X = 0;
				e.Y = 0;
				Assert.That(e, Is.EqualTo(Vector2.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector2 a = new Vector2(42, -17);

			String result = a.ToString();

			String expected = "{X:42 Y:-17}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector2>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector2();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector2 a = new Vector2(3, -4);

			Double expected = 5;

			Double result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector2 a = new Vector2(3, -4);

			Double expected = 25;

			Double result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector2 a = new Vector2( 1,  0);
			Vector2 b = new Vector2(-1,  0);
			Vector2 c = new Vector2( 0,  1);
			Vector2 d = new Vector2( 0, -1);
			Vector2 e = new Vector2( 1,  1);
			Vector2 f = new Vector2( 0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));

			Assert.That(e.IsUnit(), Is.EqualTo(false));
			Assert.That(f.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b; Vector2.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Double piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Double theta = piOver2 / 90 * i;

				Double x = RealMaths.Sin(theta);
				Double y = RealMaths.Cos(theta);				

				Assert.That(
					new Vector2( x,  y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2( x, -y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2(-x,  y).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector2(-x, -y).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector2 result = Vector2.Zero;
			Vector2 expected = new Vector2(0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector2 result = Vector2.One;
			Vector2 expected = new Vector2(1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector2 result = Vector2.UnitX;
			Vector2 expected = new Vector2(1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector2 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector2 result = Vector2.UnitY;
			Vector2 expected = new Vector2(0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector2 a = new Vector2(0, 4);
				Vector2 b = new Vector2(3, 0);

				Double expected = 5;
				Double result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = new Vector2(0, -4);
				Vector2 b = new Vector2(3, 0);

				Double expected = 5;
				Double result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = new Vector2(0, -4);
				Vector2 b = new Vector2(-3, 0);

				Double expected = 5;
				Double result;

				Vector2.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = Vector2.Zero;

				Double expected = 0;
				Double result;

				Vector2.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();

				Double expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector2 a = new Vector2(0, 4);
				Vector2 b = new Vector2(3, 0);

				Double expected = 25;
				Double result;

				Vector2.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector2 a = Vector2.Zero;

				Double expected = 0;
				Double result;

				Vector2.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Vector2 c = b - a;

				Double expected = (c.X * c.X) + (c.Y * c.Y);
				Double result;

				Vector2.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Double expected = (a.X * b.X) + (a.Y * b.Y);
				Double result; Vector2.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(-1, 0);

			Double expected = -1;
			Double result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(1, 0);

			Double expected = 1;
			Double result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector2 a = new Vector2(1, 0);
			Vector2 b = new Vector2(0, 1);

			Double expected = 0;
			Double result; Vector2.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector2 a = Vector2.Zero;

				Vector2 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector2.Normalise(ref a, out b)
				);
			}

			{
				Vector2 a = new Vector2(
					Double.MaxValue, 
					Double.MaxValue);

				Vector2 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector2.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b; Vector2.Normalise(ref a, out b);
				
				Double expected = 1;
				Double result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Double l = a.Length();

				Vector2 b; Vector2.Normalise(ref a, out b);
				
				Vector2 expected = a;
				Vector2 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: Reflect //-----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Reflect method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_i ()
		{
			{
				Vector2 incident = new Vector2(20, -5);

				Vector2 normal = new Vector2(1, -1);
				Vector2.Normalise(ref normal, out normal);

				Vector2 expected = new Vector2(-5, 20);
				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector2 incident = new Vector2(20, -5);

				Vector2 normal = new Vector2(2, -1);
				Vector2.Normalise(ref normal, out normal);

				Vector2 expected = new Vector2(-16, 13);
				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector2 incident = Vector2.Zero;

				Vector2 normal = new Vector2(1, 0);

				Vector2 result;
				Vector2.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, Vector2.Zero);
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Reflect method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_ii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 b = GetNextRandomVector2();

				Vector2.Normalise(ref b, out b);

				Vector2 result;
				Vector2.Reflect(ref a, ref b, out result);
				
				Double dot;
				Vector2.Dot(ref a, ref b, out dot);

				Vector2 expected = a - (2 * dot * b);

				AssertEqualWithinReason(result, expected);
			}
		}

		/// <summary>
		/// Assert that an argument exception is thrown if the value passed in
		/// to the normal parameter is not normalised.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_iii ()
		{
			Vector2 incident = GetNextRandomVector2();
			Vector2 normal = new Vector2(12, -241);

			Vector2 result; 

			Assert.Throws(
				typeof(ArgumentOutOfRangeException), 
				() => 
				Vector2.Reflect(ref incident, ref normal, out result)
			);
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector2 a, Vector2 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector2 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector2(44, -54);
			var b = new Vector2(44, -54);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector2 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector2(44, 54);
			var b = new Vector2(44, -54);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector2 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();

				Vector2 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector2 result_1b; Vector2.Add(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector2(3, -6);
			var b = new Vector2(-6, 12);

			var expected = new Vector2(-3, 6);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector2(-2313, 88);

			var expected = a;

			this.TestAddition(a, Vector2.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector2.Zero, Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var expected = new Vector2(a.X + b.X, a.Y + b.Y);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector2 result_1b; Vector2.Subtract(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector2(12, -4);
			var b = new Vector2(15, 11);
			var expected = new Vector2(-3, -15);
			this.TestSubtraction(a, b, expected);

			var c = new Vector2(-423, 342);
			this.TestSubtraction(c, Vector2.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector2.Zero, Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var expected = new Vector2(a.X - b.X, a.Y - b.Y);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector2 a, Vector2 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector2 result_1b; Vector2.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Double r = 3432;
			Double s = -6218;
			Double t = -3432;
			Double u = 6218;

			var a = new Vector2(r, s);
			var b = new Vector2(u, t);
			var c = new Vector2(t, u);
			var d = new Vector2(s, r);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Double t = -3432;
			Double u = 6218;
			Double r = 3432;
			Double s = -6218;

			var c = new Vector2(t, u);
			var d = new Vector2(s, r);

			this.TestNegation(c, Vector2.Zero - c);
			this.TestNegation(d, Vector2.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector2.Zero, Vector2.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				this.TestNegation(a, Vector2.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector2 result_1b; Vector2.Multiply(ref a, ref b, out result_1b);
			Vector2 result_2b; Vector2.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Double r = 18;
			Double s = -54;

			Double x = 3;
			Double y = 6;
			Double z = -9;

			var a = new Vector2(x, y);
			var b = new Vector2(y, z);
			var c = new Vector2(r, s);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var c = new Vector2(a.X * b.X, a.Y * b.Y);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector2 a, Vector2 b, Vector2 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector2 result_1b; Vector2.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Double r = 10;
			Double s = -40;

			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector2(x, y);
			var b = new Vector2(y, z);
			var c = new Vector2(r, s);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Double t = ((Double) 1 ) / ((Double) 10);
			Double u = ((Double) (-1) ) / ((Double) 40 );
			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector2(y, z);
			var b = new Vector2(x, y);
			var c = new Vector2(t, u);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				var c = new Vector2(a.X / b.X, a.Y / b.Y);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();

				Double amount1 = 0;
				Vector2 result1;

				Vector2.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector2 result2;

				Vector2.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector2( -30, -30 );
			var b = new Vector2( +30, +30 );

			Double one = 1;

			Double i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Double j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Double k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector2 r0 = a;
			Vector2 r1 = new Vector2( -i, -i );
			Vector2 r2 = new Vector2( -j, -j );
			Vector2 r3 = new Vector2( -k, -k );
			Vector2 r4 = Vector2.Zero;
			Vector2 r5 = new Vector2(  k,  k );
			Vector2 r6 = new Vector2(  j,  j );
			Vector2 r7 = new Vector2(  i,  i );
			Vector2 r8 = b;

			var knownResults = new List<Tuple<Double, Vector2>>
			{
				new Tuple<Double, Vector2>( a0, r0 ),
				new Tuple<Double, Vector2>( a1, r1 ),
				new Tuple<Double, Vector2>( a2, r2 ),
				new Tuple<Double, Vector2>( a3, r3 ),
				new Tuple<Double, Vector2>( a4, r4 ),
				new Tuple<Double, Vector2>( a5, r5 ),
				new Tuple<Double, Vector2>( a6, r6 ),
				new Tuple<Double, Vector2>( a7, r7 ),
				new Tuple<Double, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector2();
				var b = GetNextRandomVector2();
				var c = GetNextRandomVector2();
				var d = GetNextRandomVector2();

				Double amount1 = 0;
				Vector2 result1;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Double amount2 = 1;
				Vector2 result2;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector2( -90, +30 );
			var b = new Vector2( -30, -30 );
			var c = new Vector2( +30, +30 );
			var d = new Vector2( +90, -30 );

			Double one = 1;

			Double u = 15;
			Double v = (Double) 165  / (Double)  8; // 20.5
			Double w = (Double) 45   / (Double)  2; // 20.625
			Double x = (Double) 1755 / (Double) 64; // 27.421875
			Double y = (Double) 15   / (Double)  2; // 14.5
			Double z = (Double) 705  / (Double) 64; // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2( -w, -x );
			Vector2 r2 = new Vector2( -u, -v );
			Vector2 r3 = new Vector2( -y, -z );
			Vector2 r4 = Vector2.Zero;
			Vector2 r5 = new Vector2(  y,  z );
			Vector2 r6 = new Vector2(  u,  v );
			Vector2 r7 = new Vector2(  w,  x );
			Vector2 r8 = c;

			var knownResults = new List<Tuple<Double, Vector2>>
			{
				new Tuple<Double, Vector2>( a0, r0 ),
				new Tuple<Double, Vector2>( a1, r1 ),
				new Tuple<Double, Vector2>( a2, r2 ),
				new Tuple<Double, Vector2>( a3, r3 ),
				new Tuple<Double, Vector2>( a4, r4 ),
				new Tuple<Double, Vector2>( a5, r5 ),
				new Tuple<Double, Vector2>( a6, r6 ),
				new Tuple<Double, Vector2>( a7, r7 ),
				new Tuple<Double, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();
			var c = GetNextRandomVector2();
			var d = GetNextRandomVector2();
			
			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector2( -90, -90 );
			var b = new Vector2( -30, -30 );
			var c = new Vector2( +30, +30 );
			var d = new Vector2( +90, +90 );

			Double one = 1;

			Double a0 = 0;
			Double a1 = (one * 1) / 4;
			Double a2 = (one * 2) / 4;
			Double a3 = (one * 3) / 4;
			Double a4 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2( -15, -15 );
			Vector2 r2 = Vector2.Zero;
			Vector2 r3 = new Vector2( 15, 15 );
			Vector2 r4 = c;

			var knownResults = new List<Tuple<Double, Vector2>>
			{
				new Tuple<Double, Vector2>( a0, r0 ),
				new Tuple<Double, Vector2>( a1, r1 ),
				new Tuple<Double, Vector2>( a2, r2 ),
				new Tuple<Double, Vector2>( a3, r3 ),
				new Tuple<Double, Vector2>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector2();
				var b  = GetNextRandomVector2();

				var c = GetNextRandomVector2();
				var d = GetNextRandomVector2();

				Vector2 an; Vector2.Normalise(ref c, out an);
				Vector2 bn; Vector2.Normalise(ref d, out bn);

				Double amount1 = 0;
				Vector2 result1;

				Vector2.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector2 result2;

				Vector2.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector2();
			var b = GetNextRandomVector2();
			var c = GetNextRandomVector2();
			var d = GetNextRandomVector2();

			Vector2 an; Vector2.Normalise(ref c, out an);
			Vector2 bn; Vector2.Normalise(ref d, out bn);

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector2 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector2( -100, +50 );
			var b = new Vector2( +100, -50 );

			var c = new Vector2( -10, +5 );
			var d = new Vector2( +10, -5 );

			Vector2 an; Vector2.Normalise(ref c, out an);
			Vector2 bn; Vector2.Normalise(ref d, out bn);

			Double one = 1;
			
			// 100.1953125
			Double e = (Double) 51300 / (Double) 512;

			// 50.09765625
			Double f = (Double) 12825 / (Double) 256;

			// 91.25
			Double g = (Double) 365 / (Double) 4;

			// 45.625
			Double h = (Double) 365 / (Double) 8;

			// 75.7421875
			Double i = (Double) 9695 / (Double) 128;

			// 37.87109375
			Double j = (Double) 9695 / (Double) 256;

			// 56.25
			Double k = (Double) 225 / (Double) 4;

			// 28.125
			Double l = (Double) 225 / (Double) 8;

			// 35.3515625
			Double m = (Double) 4525 / (Double) 128;

			// 17.67578125
			Double n = (Double) 4525 / (Double) 256;

			// 15.625
			Double o = (Double) 125 / (Double) 8;

			// 7.8125
			Double p = (Double) 125 / (Double) 16;

			// 0.3515625
			Double q = (Double) 45 / (Double) 128;

			// 0.17578125
			Double r = (Double) 45 / (Double) 256;

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector2 r0 = b;
			Vector2 r1 = new Vector2(  e, -f );
			Vector2 r2 = new Vector2(  g, -h );
			Vector2 r3 = new Vector2(  i, -j );
			Vector2 r4 = new Vector2(  k, -l );
			Vector2 r5 = new Vector2(  m, -n );
			Vector2 r6 = new Vector2(  o, -p );
			Vector2 r7 = new Vector2( -q,  r );
			Vector2 r8 = c;

			var knownResults = new List<Tuple<Double, Vector2>>
			{
				new Tuple<Double, Vector2>( a0, r0 ),
				new Tuple<Double, Vector2>( a1, r1 ),
				new Tuple<Double, Vector2>( a2, r2 ),
				new Tuple<Double, Vector2>( a3, r3 ),
				new Tuple<Double, Vector2>( a4, r4 ),
				new Tuple<Double, Vector2>( a5, r5 ),
				new Tuple<Double, Vector2>( a6, r6 ),
				new Tuple<Double, Vector2>( a7, r7 ),
				new Tuple<Double, Vector2>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector2 result;

				Vector2.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector2 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = a * 2;

				Vector2 result;
				Vector2.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(a.X < b.X ? a.X : b.X ));
				Assert.That(result.Y, Is.EqualTo(a.Y < b.Y ? a.Y : b.Y ));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector2 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();
				Vector2 b = GetNextRandomVector2();

				Vector2 result;
				Vector2.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(a.X > b.X ? a.X : b.X ));
				Assert.That(result.Y, Is.EqualTo(a.Y > b.Y ? a.Y : b.Y ));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector2 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector2 min = new Vector2(-30, 1);
			Vector2 max = new Vector2(32, 130);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector2 a = GetNextRandomVector2();

				Vector2 result;
				Vector2.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector2 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector2 min = new Vector2(-30, 1);
			Vector2 max = new Vector2(32, 130);

			Vector2 a = new Vector2(-100, 1113);

			Vector2 expected = new Vector2(-30, 130);

			Vector2 result;
			Vector2.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector2 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Double delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector2 a = GetNextRandomVector2();
					Vector2 b = GetNextRandomVector2();

					Vector2 result;
					Vector2.Lerp (ref a, ref b, delta, out result);

					Vector2 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector2 a = GetNextRandomVector2();
			Vector2 b = GetNextRandomVector2();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector2 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector2.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector3Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector3Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Double value.
		/// </summary>
		static Double GetNextRandomDouble ()
		{
			Double randomValue = rand.NextDouble();

			Double zero = 0;
			Double multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector3.
		/// </summary>
		static Vector3 GetNextRandomVector3 ()
		{
			Double a = GetNextRandomDouble();
			Double b = GetNextRandomDouble();
			Double c = GetNextRandomDouble();

			return new Vector3(a, b, c);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector3s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector3 a, Vector3 b)
		{
			Double tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector3);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X, Y and Z member variables of a number of randomly generated 
		/// Vector3 objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 vec = GetNextRandomVector3();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Double[] data = new Double[3];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 3);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
		        Assert.That(data[2], Is.EqualTo(vec.Z));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector3 a = new Vector3();
				Assert.That(a, Is.EqualTo(Vector3.Zero));
			}
			{
				// Test Vector3( Double, Double, Double )
				Double a = -189;
				Double b = 429;
				Double c = 4298;
				Vector3 d = new Vector3(a, b, c);
				Assert.That(d.X, Is.EqualTo(a));
				Assert.That(d.Y, Is.EqualTo(b));
				Assert.That(d.Z, Is.EqualTo(c));
			}
			{
				// Test Vector3( Vector2, Double )
				Vector2 a = new Vector2(-189, 429);
				Double b = 4298;
				Vector3 c = new Vector3(a, b);
				Assert.That(c.X, Is.EqualTo(a.X));
				Assert.That(c.Y, Is.EqualTo(a.Y));
				Assert.That(c.Z, Is.EqualTo(b));
			}
			{
				// Test no constructor
				Vector3 a;
				a.X = 0;
				a.Y = 0;
				a.Z = 0;
				Assert.That(a, Is.EqualTo(Vector3.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector3 a = new Vector3(42, -17, 13);

			String result = a.ToString();

			String expected = "{X:42 Y:-17 Z:13}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector3>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector3();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector3 a = new Vector3(3, -4, 12);

			Double expected = 13;

			Double result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector3 a = new Vector3(3, -4, 12);

			Double expected = 169;

			Double result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector3 a = new Vector3( 1,  0,  0);
			Vector3 b = new Vector3(-1,  0,  0);
			Vector3 c = new Vector3( 0,  1,  0);
			Vector3 d = new Vector3( 0, -1,  0);
			Vector3 e = new Vector3( 0,  0,  1);
			Vector3 f = new Vector3( 0,  0, -1);
			Vector3 g = new Vector3( 1,  1,  1);
			Vector3 h = new Vector3( 0,  0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));
			Assert.That(e.IsUnit(), Is.EqualTo(true));
			Assert.That(f.IsUnit(), Is.EqualTo(true));

			Assert.That(g.IsUnit(), Is.EqualTo(false));
			Assert.That(h.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b; Vector3.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Double piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Double theta = piOver2 / 90 * i;

				Double x = RealMaths.Sin(theta);
				Double y = RealMaths.Cos(theta);
				Double z = 0;				

				Assert.That(
					new Vector3( x,  y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3( x, -y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3(-x,  y,  z).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector3(-x, -y,  z).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector3 result = Vector3.Zero;
			Vector3 expected = new Vector3(0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector3 result = Vector3.One;
			Vector3 expected = new Vector3(1, 1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector3 result = Vector3.UnitX;
			Vector3 expected = new Vector3(1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector3 result = Vector3.UnitY;
			Vector3 expected = new Vector3(0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitZ //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the UnitZ
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitZ ()
		{
			Vector3 result = Vector3.UnitZ;
			Vector3 expected = new Vector3(0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Up //-----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Up
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Up ()
		{
			Vector3 result = Vector3.Up;
			Vector3 expected = new Vector3(0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Down //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Down
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Down ()
		{
			Vector3 result = Vector3.Down;
			Vector3 expected = new Vector3(0, -1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Right //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Right
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Right ()
		{
			Vector3 result = Vector3.Right;
			Vector3 expected = new Vector3(1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Left //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Left
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Left ()
		{
			Vector3 result = Vector3.Left;
			Vector3 expected = new Vector3(-1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Forward //------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Forward
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Forward ()
		{
			Vector3 result = Vector3.Forward;
			Vector3 expected = new Vector3(0, 0, -1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: Backward //-----------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector3 initilised using the Backward
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Backward ()
		{
			Vector3 result = Vector3.Backward;
			Vector3 expected = new Vector3(0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector3 a = new Vector3(0, 4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Double expected = 13;
				Double result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = new Vector3(0, -4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Double expected = 13;
				Double result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = new Vector3(0, -4, -12);
				Vector3 b = new Vector3(-3, 0, 0);

				Double expected = 13;
				Double result;

				Vector3.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = Vector3.Zero;

				Double expected = 0;
				Double result;

				Vector3.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();

				Double expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector3 a = new Vector3(0, 4, 12);
				Vector3 b = new Vector3(3, 0, 0);

				Double expected = 161;
				Double result;

				Vector3.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector3 a = Vector3.Zero;

				Double expected = 0;
				Double result;

				Vector3.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Vector3 c = b - a;

				Double expected = (c.X * c.X) + (c.Y * c.Y) + (c.Z * c.Z);
				Double result;

				Vector3.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Double expected = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
				Double result; Vector3.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector3 a = new Vector3(0, 0, 1);
			Vector3 b = new Vector3(0, 0, -1);

			Double expected = -1;
			Double result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector3 a = new Vector3(0, 0, 1);
			Vector3 b = new Vector3(0, 0, 1);

			Double expected = 1;
			Double result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector3 a = new Vector3(0, 1, 0);
			Vector3 b = new Vector3(0, 0, 1);

			Double expected = 0;
			Double result; Vector3.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector3 a = Vector3.Zero;

				Vector3 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector3.Normalise(ref a, out b)
				);
			}

			{
				Vector3 a = new Vector3(
					Double.MaxValue, 
					Double.MaxValue, 
					Double.MaxValue);

				Vector3 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector3.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b; Vector3.Normalise(ref a, out b);
				
				Double expected = 1;
				Double result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Double l = a.Length();

				Vector3 b; Vector3.Normalise(ref a, out b);
				
				Vector3 expected = a;
				Vector3 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: Cross //-------------------------------------------//
		[Test]
		public void TestStaticFn_Cross_i ()
		{
			Assert.That(true, Is.EqualTo(false));
		}

		// Test Static Fn: Reflect //-----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Reflect method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_i ()
		{
			{
				Vector3 incident = new Vector3(20, -5, 10);

				Vector3 normal = new Vector3(1, -1, 2);
				Vector3.Normalise(ref normal, out normal);

				Vector3 expected = new Vector3(-5, 20, 2);
				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector3 incident = new Vector3(20, -5, 10);

				Vector3 normal = new Vector3(2, -1, 2);
				Vector3.Normalise(ref normal, out normal);

				Vector3 expected = new Vector3(-16, 13, 2);
				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, expected);
			}

			{
				Vector3 incident = Vector3.Zero;

				Vector3 normal = new Vector3(0, 0, 1);

				Vector3 result;
				Vector3.Reflect(ref incident, ref normal, out result);

				AssertEqualWithinReason(result, Vector3.Zero);
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Reflect method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_ii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 b = GetNextRandomVector3();

				Vector3.Normalise(ref b, out b);

				Vector3 result;
				Vector3.Reflect(ref a, ref b, out result);
				
				Double dot;
				Vector3.Dot(ref a, ref b, out dot);

				Vector3 expected = a - (2 * dot * b);

				AssertEqualWithinReason(result, expected);
			}
		}

		/// <summary>
		/// Assert that an argument exception is thrown if the value passed in
		/// to the normal parameter is not normalised.
		/// </summary>
		[Test]
		public void TestStaticFn_Reflect_iii ()
		{
			Vector3 incident = GetNextRandomVector3();
			Vector3 normal = new Vector3(12, -241, 123);

			Vector3 result; 

			Assert.Throws(
				typeof(ArgumentOutOfRangeException), 
				() => 
				Vector3.Reflect(ref incident, ref normal, out result)
			);
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector3 a, Vector3 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector3 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector3(44, -54, -22);
			var b = new Vector3(44, -54, -22);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector3 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector3(44, 54, 2);
			var b = new Vector3(44, -54, 2);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector3 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();

				Vector3 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector3 result_1b; Vector3.Add(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector3(3, -6, 44);
			var b = new Vector3(-6, 12, 18);

			var expected = new Vector3(-3, 6, 62);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector3(-2313, 88, 199);

			var expected = a;

			this.TestAddition(a, Vector3.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector3.Zero, Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var expected = new Vector3(
					a.X + b.X, a.Y + b.Y, a.Z + b.Z);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector3 result_1b; Vector3.Subtract(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector3(12, -4, 14);
			var b = new Vector3(15, 11, 7);
			var expected = new Vector3(-3, -15, 7);
			this.TestSubtraction(a, b, expected);

			var c = new Vector3(-423, 342, 7);
			this.TestSubtraction(c, Vector3.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector3.Zero, Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var expected = new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector3 a, Vector3 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector3 result_1b; Vector3.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Double r = 3432;
			Double s = -6218;
			Double t = -3432;
			Double u = 6218;

			var a = new Vector3(r, s, t);
			var b = new Vector3(u, t, s);
			var c = new Vector3(t, u, r);
			var d = new Vector3(s, r, u);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Double t = -3432;
			Double u = 6218;
			Double r = 3432;
			Double s = -6218;

			var c = new Vector3(t, u, r);
			var d = new Vector3(s, r, u);

			this.TestNegation(c, Vector3.Zero - c);
			this.TestNegation(d, Vector3.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector3.Zero, Vector3.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				this.TestNegation(a, Vector3.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector3 result_1b; Vector3.Multiply(ref a, ref b, out result_1b);
			Vector3 result_2b; Vector3.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Double r = -27;
			Double s = 36;
			Double t = 9;

			Double x = 3;
			Double y = 6;
			Double z = -9;

			var a = new Vector3(x, y, x);
			var b = new Vector3(z, y, x);
			var c = new Vector3(r, s, t);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var c = new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector3 a, Vector3 b, Vector3 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector3 result_1b; Vector3.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Double r = 10;
			Double s = -40;
			Double t = 1;

			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector3(x, y, x);
			var b = new Vector3(y, z, x);
			var c = new Vector3(r, s, t);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Double t = ((Double) 1 ) / ((Double) 10);
			Double u = ((Double) (-1) ) / ((Double) 40 );
			Double v = -20;
			Double w = 100;
			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector3(y, z, w);
			var b = new Vector3(x, y, z);
			var c = new Vector3(t, u, v);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				var c = new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();

				Double amount1 = 0;
				Vector3 result1;

				Vector3.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector3 result2;

				Vector3.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector3( -30, -30, -30 );
			var b = new Vector3( +30, +30, +30 );

			Double one = 1;

			Double i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Double j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Double k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector3 r0 = a;
			Vector3 r1 = new Vector3( -i, -i, -i );
			Vector3 r2 = new Vector3( -j, -j, -j );
			Vector3 r3 = new Vector3( -k, -k, -k );
			Vector3 r4 = Vector3.Zero;
			Vector3 r5 = new Vector3(  k,  k,  k );
			Vector3 r6 = new Vector3(  j,  j,  j );
			Vector3 r7 = new Vector3(  i,  i,  i );
			Vector3 r8 = b;

			var knownResults = new List<Tuple<Double, Vector3>>
			{
				new Tuple<Double, Vector3>( a0, r0 ),
				new Tuple<Double, Vector3>( a1, r1 ),
				new Tuple<Double, Vector3>( a2, r2 ),
				new Tuple<Double, Vector3>( a3, r3 ),
				new Tuple<Double, Vector3>( a4, r4 ),
				new Tuple<Double, Vector3>( a5, r5 ),
				new Tuple<Double, Vector3>( a6, r6 ),
				new Tuple<Double, Vector3>( a7, r7 ),
				new Tuple<Double, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector3();
				var b = GetNextRandomVector3();
				var c = GetNextRandomVector3();
				var d = GetNextRandomVector3();

				Double amount1 = 0;
				Vector3 result1;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Double amount2 = 1;
				Vector3 result2;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector3( -90, +30, +90 );
			var b = new Vector3( -30, -30, +30 );
			var c = new Vector3( +30, +30, -30 );
			var d = new Vector3( +90, -30, -90 );

			Double one = 1;

			Double u = 15;
			Double v = (Double) 165  / (Double)  8; // 20.5
			Double w = (Double) 45   / (Double)  2; // 20.625
			Double x = (Double) 1755 / (Double) 64; // 27.421875
			Double y = (Double) 15   / (Double)  2; // 14.5
			Double z = (Double) 705  / (Double) 64; // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3( -w, -x,  w );
			Vector3 r2 = new Vector3( -u, -v,  u );
			Vector3 r3 = new Vector3( -y, -z,  y );
			Vector3 r4 = Vector3.Zero;
			Vector3 r5 = new Vector3(  y,  z, -y );
			Vector3 r6 = new Vector3(  u,  v, -u );
			Vector3 r7 = new Vector3(  w,  x, -w );
			Vector3 r8 = c;

			var knownResults = new List<Tuple<Double, Vector3>>
			{
				new Tuple<Double, Vector3>( a0, r0 ),
				new Tuple<Double, Vector3>( a1, r1 ),
				new Tuple<Double, Vector3>( a2, r2 ),
				new Tuple<Double, Vector3>( a3, r3 ),
				new Tuple<Double, Vector3>( a4, r4 ),
				new Tuple<Double, Vector3>( a5, r5 ),
				new Tuple<Double, Vector3>( a6, r6 ),
				new Tuple<Double, Vector3>( a7, r7 ),
				new Tuple<Double, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();
			var c = GetNextRandomVector3();
			var d = GetNextRandomVector3();
			
			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector3( -90, -90, +90 );
			var b = new Vector3( -30, -30, +30 );
			var c = new Vector3( +30, +30, -30 );
			var d = new Vector3( +90, +90, -90 );

			Double one = 1;

			Double a0 = 0;
			Double a1 = (one * 1) / 4;
			Double a2 = (one * 2) / 4;
			Double a3 = (one * 3) / 4;
			Double a4 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3( -15, -15,  15 );
			Vector3 r2 = Vector3.Zero;
			Vector3 r3 = new Vector3(  15,  15, -15 );
			Vector3 r4 = c;

			var knownResults = new List<Tuple<Double, Vector3>>
			{
				new Tuple<Double, Vector3>( a0, r0 ),
				new Tuple<Double, Vector3>( a1, r1 ),
				new Tuple<Double, Vector3>( a2, r2 ),
				new Tuple<Double, Vector3>( a3, r3 ),
				new Tuple<Double, Vector3>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector3();
				var b  = GetNextRandomVector3();

				var c = GetNextRandomVector3();
				var d = GetNextRandomVector3();

				Vector3 an; Vector3.Normalise(ref c, out an);
				Vector3 bn; Vector3.Normalise(ref d, out bn);

				Double amount1 = 0;
				Vector3 result1;

				Vector3.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector3 result2;

				Vector3.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector3();
			var b = GetNextRandomVector3();
			var c = GetNextRandomVector3();
			var d = GetNextRandomVector3();

			Vector3 an; Vector3.Normalise(ref c, out an);
			Vector3 bn; Vector3.Normalise(ref d, out bn);

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector3 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector3( -100, +50, +100 );
			var b = new Vector3( +100, -50, -100 );

			var c = new Vector3( -10, +5, +10 );
			var d = new Vector3( +10, -5, -10 );

			Vector3 an; Vector3.Normalise(ref c, out an);
			Vector3 bn; Vector3.Normalise(ref d, out bn);

			Double one = 1;
			
			// 100.1953125
			Double e = (Double) 51300 / (Double) 512;

			// 50.09765625
			Double f = (Double) 12825 / (Double) 256;

			// 91.25
			Double g = (Double) 365 / (Double) 4;

			// 45.625
			Double h = (Double) 365 / (Double) 8;

			// 75.7421875
			Double i = (Double) 9695 / (Double) 128;

			// 37.87109375
			Double j = (Double) 9695 / (Double) 256;

			// 56.25
			Double k = (Double) 225 / (Double) 4;

			// 28.125
			Double l = (Double) 225 / (Double) 8;

			// 35.3515625
			Double m = (Double) 4525 / (Double) 128;

			// 17.67578125
			Double n = (Double) 4525 / (Double) 256;

			// 15.625
			Double o = (Double) 125 / (Double) 8;

			// 7.8125
			Double p = (Double) 125 / (Double) 16;

			// 0.3515625
			Double q = (Double) 45 / (Double) 128;

			// 0.17578125
			Double r = (Double) 45 / (Double) 256;

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector3 r0 = b;
			Vector3 r1 = new Vector3(  e, -f, -e );
			Vector3 r2 = new Vector3(  g, -h, -g );
			Vector3 r3 = new Vector3(  i, -j, -i );
			Vector3 r4 = new Vector3(  k, -l, -k );
			Vector3 r5 = new Vector3(  m, -n, -m );
			Vector3 r6 = new Vector3(  o, -p, -o );
			Vector3 r7 = new Vector3( -q,  r,  q );
			Vector3 r8 = c;

			var knownResults = new List<Tuple<Double, Vector3>>
			{
				new Tuple<Double, Vector3>( a0, r0 ),
				new Tuple<Double, Vector3>( a1, r1 ),
				new Tuple<Double, Vector3>( a2, r2 ),
				new Tuple<Double, Vector3>( a3, r3 ),
				new Tuple<Double, Vector3>( a4, r4 ),
				new Tuple<Double, Vector3>( a5, r5 ),
				new Tuple<Double, Vector3>( a6, r6 ),
				new Tuple<Double, Vector3>( a7, r7 ),
				new Tuple<Double, Vector3>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector3 result;

				Vector3.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector3 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = a * 2;

				Vector3 result;
				Vector3.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));

				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector3 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();
				Vector3 b = GetNextRandomVector3();

				Vector3 result;
				Vector3.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector3 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector3 min = new Vector3(-30, 1, 18);
			Vector3 max = new Vector3(32, 130, 47);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector3 a = GetNextRandomVector3();

				Vector3 result;
				Vector3.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector3 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector3 min = new Vector3(-30, 1, 18);
			Vector3 max = new Vector3(32, 130, 47);

			Vector3 a = new Vector3(-100, 1113, 50);

			Vector3 expected = new Vector3(-30, 130, 47);

			Vector3 result;
			Vector3.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.Z, Is.LessThanOrEqualTo(max.Z));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			Assert.That(result.Z, Is.GreaterThanOrEqualTo(min.Z));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector3 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Double delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector3 a = GetNextRandomVector3();
					Vector3 b = GetNextRandomVector3();

					Vector3 result;
					Vector3.Lerp (ref a, ref b, delta, out result);

					Vector3 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector3 a = GetNextRandomVector3();
			Vector3 b = GetNextRandomVector3();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector3 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector3.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class Vector4Tests
	{
		/// <summary>
		/// The random number generator used for testing.
		/// </summary>
		static readonly System.Random rand;

		/// <summary>
		/// Static constructor used to ensure that the random number generator
		/// always gets initilised with the same seed, making the tests
		/// behave in a deterministic manner.
		/// </summary>
		static Vector4Tests ()
		{
			rand = new System.Random(0);
		}

		/// <summary>
		/// Helper function for getting the next random Double value.
		/// </summary>
		static Double GetNextRandomDouble ()
		{
			Double randomValue = rand.NextDouble();

			Double zero = 0;
			Double multiplier = 1000;

			randomValue *= multiplier;

			Boolean randomBoolean = (rand.Next(0, 1) == 0) ? true : false;

			if( randomBoolean )
				randomValue = zero - randomValue;

			return randomValue;
		}

		/// <summary>
		/// Helper function for getting the next random Vector4.
		/// </summary>
		static Vector4 GetNextRandomVector4 ()
		{
			Double a = GetNextRandomDouble();
			Double b = GetNextRandomDouble();
			Double c = GetNextRandomDouble();
			Double d = GetNextRandomDouble();

			return new Vector4(a, b, c, d);
		}

		/// <summary>
		/// Helper to encapsulate asserting that two Vector4s are equal.
		/// </summary>
		static void AssertEqualWithinReason (Vector4 a, Vector4 b)
		{
			Double tolerance; RealMaths.TestTolerance(out tolerance);

			Assert.That(a.X, Is.EqualTo(b.X).Within(tolerance));
			Assert.That(a.Y, Is.EqualTo(b.Y).Within(tolerance));
			Assert.That(a.Z, Is.EqualTo(b.Z).Within(tolerance));
			Assert.That(a.W, Is.EqualTo(b.W).Within(tolerance));
		}
		

		// Test: StructLayout //----------------------------------------------//

		/// <summary>
		/// This test makes sure that the struct layout has been defined
		/// correctly.
		/// </summary>
		[Test]
		public void Test_StructLayout_i ()
		{
			Type t = typeof(Vector4);

			Assert.That(
				t.StructLayoutAttribute.Value, 
				Is.EqualTo(LayoutKind.Sequential));
		}

		/// <summary>
		/// This test makes sure that when examining the memory addresses of the 
		/// X, Y, Z and W member variables of a number of randomly generated 
		/// Vector4 objects the results are as expected. 
		/// </summary>
		[Test]
		public unsafe void Test_StructLayout_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 vec = GetNextRandomVector4();

				GCHandle h_vec = GCHandle.Alloc(vec, GCHandleType.Pinned);

		        IntPtr vecAddress = h_vec.AddrOfPinnedObject();

		        Double[] data = new Double[4];

		        // nb: when Fixed32 and Half are moved back into the main
		        //     dev branch there will be need for an extension method for
		        //     Marshal that will perform the copy for those types. 
		        Marshal.Copy(vecAddress, data, 0, 4);
		        Assert.That(data[0], Is.EqualTo(vec.X));
		        Assert.That(data[1], Is.EqualTo(vec.Y));
		        Assert.That(data[2], Is.EqualTo(vec.Z));
		        Assert.That(data[3], Is.EqualTo(vec.W));
				
		        h_vec.Free();
			}
		}

		// Test: Constructors //----------------------------------------------//

		/// <summary>
		/// This test goes though each public constuctor and ensures that the 
		/// data members of the structure have been properly set.
		/// </summary>
		[Test]
		public void Test_Constructors_i ()
		{
			{
				// Test default values
				Vector4 a = new Vector4();
				Assert.That(a, Is.EqualTo(Vector4.Zero));
			}
			{
				// Test Vector4( Double, Double, Double )
				Double a = -189;
				Double b = 429;
				Double c = 4298;
				Double d = 341;
				Vector4 e = new Vector4(a, b, c, d);
				Assert.That(e.X, Is.EqualTo(a));
				Assert.That(e.Y, Is.EqualTo(b));
				Assert.That(e.Z, Is.EqualTo(c));
				Assert.That(e.W, Is.EqualTo(d));
			}
			{
				// Test Vector4( Vector2, Double, Double )
				Vector2 a = new Vector2(-189, 429);
				Double b = 4298;
				Double c = 341;
				Vector4 d = new Vector4(a, b, c);
				Assert.That(d.X, Is.EqualTo(a.X));
				Assert.That(d.Y, Is.EqualTo(a.Y));
				Assert.That(d.Z, Is.EqualTo(b));
				Assert.That(d.W, Is.EqualTo(c));
			}
			{
				// Test Vector4( Vector3, Double )
				Vector3 a = new Vector3(-189, 429, 4298);
				Double b = 341;
				Vector4 c = new Vector4(a, b);
				Assert.That(c.X, Is.EqualTo(a.X));
				Assert.That(c.Y, Is.EqualTo(a.Y));
				Assert.That(c.Z, Is.EqualTo(a.Z));
				Assert.That(c.W, Is.EqualTo(b));
			}
			{
				// Test no constructor
				Vector4 a;
				a.X = 0;
				a.Y = 0;
				a.Z = 0;
				a.W = 0;
				Assert.That(a, Is.EqualTo(Vector4.Zero));
			}
		}

		// Test Member Fn: ToString //----------------------------------------//

		/// <summary>
		/// For a given example, this test ensures that the ToString function
		/// yields the expected string.
		/// </summary>
		[Test]
		public void TestMemberFn_ToString_i ()
		{
			Vector4 a = new Vector4(42, -17, 13, 44);

			String result = a.ToString();

			String expected = "{X:42 Y:-17 Z:13 W:44}";

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: GetHashCode //-------------------------------------//

		/// <summary>
		/// Makes sure that the hashing function is good by testing 10,000
		/// random scenarios and ensuring that there are no more than 10
		/// collisions.
		/// </summary>
		[Test]
		public void TestMemberFn_GetHashCode_i ()
		{
			var hs1 = new System.Collections.Generic.HashSet<Vector4>();
			var hs2 = new System.Collections.Generic.HashSet<Int32>();

			for(Int32 i = 0; i < 10000; ++i)
			{
				var a = GetNextRandomVector4();

				hs1.Add(a);
				hs2.Add(a.GetHashCode());
			}

			Assert.That(hs1.Count, Is.EqualTo(hs2.Count).Within(10));
		}

		// Test Member Fn: Length //------------------------------------------//

		/// <summary>
		/// Tests that for a known example the Length member function yields
		/// the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_Length_i ()
		{
			Vector4 a = new Vector4(3, -4, 12, 84);

			Double expected = 85;

			Double result = a.Length();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: LengthSquared //-----------------------------------//

		/// <summary>
		/// Tests that for a known example the LengthSquared member function 
		/// yields the correct result.
		/// </summary>
		[Test]
		public void TestMemberFn_LengthSquared_i ()
		{
			Vector4 a = new Vector4(3, -4, 12, 84);

			Double expected = 7225;

			Double result = a.LengthSquared();

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Member Fn: IsUnit //------------------------------------------//

		/// <summary>
		/// Tests that for the simple vectors the IsUnit member function
		/// returns the correct result of TRUE.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_i ()
		{
			Vector4 a = new Vector4( 1,  0,  0,  0);
			Vector4 b = new Vector4(-1,  0,  0,  0);
			Vector4 c = new Vector4( 0,  1,  0,  0);
			Vector4 d = new Vector4( 0, -1,  0,  0);
			Vector4 e = new Vector4( 0,  0,  1,  0);
			Vector4 f = new Vector4( 0,  0, -1,  0);
			Vector4 g = new Vector4( 0,  0,  0,  1);
			Vector4 h = new Vector4( 0,  0,  0, -1);
			Vector4 i = new Vector4( 1,  1,  1,  1);
			Vector4 j = new Vector4( 0,  0,  0,  0);

			Assert.That(a.IsUnit(), Is.EqualTo(true));
			Assert.That(b.IsUnit(), Is.EqualTo(true));
			Assert.That(c.IsUnit(), Is.EqualTo(true));
			Assert.That(d.IsUnit(), Is.EqualTo(true));
			Assert.That(e.IsUnit(), Is.EqualTo(true));
			Assert.That(f.IsUnit(), Is.EqualTo(true));
			Assert.That(g.IsUnit(), Is.EqualTo(true));
			Assert.That(h.IsUnit(), Is.EqualTo(true));

			Assert.That(i.IsUnit(), Is.EqualTo(false));
			Assert.That(j.IsUnit(), Is.EqualTo(false));
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of TRUE for a number of scenarios where the test 
		/// vector is both random and normalised.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_ii ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 b; Vector4.Normalise(ref a, out b);

				Assert.That(b.IsUnit(), Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test ensures that the IsUnit member function correctly
		/// returns TRUE for a collection of vectors, all known to be of unit 
		/// length.
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iii ()
		{
			Double piOver2; RealMaths.PiOver2(out piOver2);

			for( Int32 i = 0; i <= 90; ++ i)
			{
				Double theta = piOver2 / 90 * i;

				Double x = RealMaths.Sin(theta);
				Double y = RealMaths.Cos(theta);				
				Double z = 0;
				Double w = 0;

				Assert.That(
					new Vector4( x,  y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4( x, -y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4(-x,  y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
				
				Assert.That(
					new Vector4(-x, -y,  z,  w).IsUnit(), 
					Is.EqualTo(true));
			}
		}

		/// <summary>
		/// This test makes sure that the IsUnit member function returns the 
		/// correct result of FALSE for a number of scenarios where the test 
		/// vector is randomly generated and not normalised.  It's highly
		/// unlikely that the random generator will create a unit vector!
		/// </summary>
		[Test]
		public void TestMemberFn_IsUnit_iv ()
		{
			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Assert.That(a.IsUnit(), Is.EqualTo(false));
			}
		}
			
		// Test Constant: Zero //---------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the Zero constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_Zero ()
		{
			Vector4 result = Vector4.Zero;
			Vector4 expected = new Vector4(0, 0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: One //----------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the One constant
		/// has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_One ()
		{
			Vector4 result = Vector4.One;
			Vector4 expected = new Vector4(1, 1, 1, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitX //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitX 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitX ()
		{
			Vector4 result = Vector4.UnitX;
			Vector4 expected = new Vector4(1, 0, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitY //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitY
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitY ()
		{
			Vector4 result = Vector4.UnitY;
			Vector4 expected = new Vector4(0, 1, 0, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitZ //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitZ 
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitZ ()
		{
			Vector4 result = Vector4.UnitZ;
			Vector4 expected = new Vector4(0, 0, 1, 0);
			AssertEqualWithinReason(result, expected);
		}

		// Test Constant: UnitW //--------------------------------------------//

		/// <summary>
		/// Tests to make sure that a Vector4 initilised using the UnitW
		/// constant has it's member variables correctly set.
		/// </summary>
		[Test]
		public void TestConstant_UnitW ()
		{
			Vector4 result = Vector4.UnitW;
			Vector4 expected = new Vector4(0, 0, 0, 1);
			AssertEqualWithinReason(result, expected);
		}

		// Test Static Fn: Distance //----------------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the Distance method
		/// yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_i ()
		{
			{
				Vector4 a = new Vector4(0, 4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Double expected = 85;
				Double result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = new Vector4(0, -4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Double expected = 85;
				Double result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = new Vector4(0, -4, -12, 0);
				Vector4 b = new Vector4(-3, 0, 0, -84);

				Double expected = 85;
				Double result;

				Vector4.Distance(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = Vector4.Zero;

				Double expected = 0;
				Double result;

				Vector4.Distance(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Distance method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Distance_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();

				Double expected = 
					RealMaths.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z) + (a.W * a.W));

				Assert.That(a.Length(), Is.EqualTo(expected));
			}
		}

		// Test Static Fn: DistanceSquared //---------------------------------//

		/// <summary>
		/// Assert that, for a number of known examples, the DistanceSquared 
		/// method yeilds the correct results.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_i ()
		{
			{
				Vector4 a = new Vector4(0, 4, 12, 0);
				Vector4 b = new Vector4(3, 0, 0, 84);

				Double expected = 7225;
				Double result;

				Vector4.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}

			{
				Vector4 a = Vector4.Zero;

				Double expected = 0;
				Double result;

				Vector4.DistanceSquared(ref a, ref a, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}


		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// DistanceSquared method yeilds the same results as those obtained 
		/// from performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_DistanceSquared_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Vector4 c = b - a;

				Double expected = (c.X * c.X) + (c.Y * c.Y) + (c.Z * c.Z) + (c.W * c.W);
				Double result;

				Vector4.DistanceSquared(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		// Test Static Fn: Dot //---------------------------------------------//

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Dot method yeilds the same results as those obtained from
		/// performing a manual calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Double expected = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z) + (a.W * b.W);
				Double result; Vector4.Dot(ref a, ref b, out result);

				Assert.That(result, Is.EqualTo(expected));
			}
		}

		/// <summary>
		/// Assert that two unit vectors pointing in opposing directions yeild a
		/// dot product of negative one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_ii ()
		{
			Vector4 a = new Vector4(0, 0, 0, 1);
			Vector4 b = new Vector4(0, 0, 0, -1);

			Double expected = -1;
			Double result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two unit vectors pointing in the same direction yeild a
		/// dot product of one.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iii ()
		{
			Vector4 a = new Vector4(0, 0, 0, 1);
			Vector4 b = new Vector4(0, 0, 0, 1);

			Double expected = 1;
			Double result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that two perpendicular unit vectors yeild a dot product of 
		/// zero.
		/// </summary>
		[Test]
		public void TestStaticFn_Dot_iv ()
		{
			Vector4 a = new Vector4(0, 0, 1, 0);
			Vector4 b = new Vector4(0, 0, 0, 1);

			Double expected = 0;
			Double result; Vector4.Dot(ref a, ref b, out result);

			Assert.That(result, Is.EqualTo(expected));
		}

		// Test Static Fn: Normalise //---------------------------------------//

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_i()
		{
			{
				Vector4 a = Vector4.Zero;

				Vector4 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector4.Normalise(ref a, out b)
				);
			}

			{
				Vector4 a = new Vector4(
					Double.MaxValue, 
					Double.MaxValue, 
					Double.MaxValue, 
					Double.MaxValue);

				Vector4 b;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
					Vector4.Normalise(ref a, out b)
				);
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a unit vector (with length equal to one);
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_ii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 b; Vector4.Normalise(ref a, out b);
				
				Double expected = 1;
				Double result = b.Length();

				Assert.That(result, Is.EqualTo(expected).Within(epsilon));
			}
		}

		/// <summary>
		/// Assert that, for a number of randomly generated examples, the 
		/// Normalise method yeilds a vector, which when multipled by the 
		/// length of the original vector results in the same vector as the
		/// original vector;
		/// </summary>
		[Test]
		public void TestStaticFn_Normalise_iii ()
		{
			Double epsilon; RealMaths.Epsilon(out epsilon);

			for( Int32 i = 0; i < 100; ++ i)
			{
				Vector4 a = GetNextRandomVector4();

				Double l = a.Length();

				Vector4 b; Vector4.Normalise(ref a, out b);
				
				Vector4 expected = a;
				Vector4 result = b * l;

				AssertEqualWithinReason(result, expected);
			}
		}

		// Test Static Fn: TransformMatrix44 //-------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformMatix44_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformNormal //---------------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformNormal_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Static Fn: TransformQuaternion //-----------------------------//

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestStaticFn_TransformQuaternion_i ()
		{
			Assert.That (true, Is.EqualTo (false));
		}

		// Test Operator: Equality //-----------------------------------------//

		/// <summary>
		/// Helper method for testing equality.
		/// </summary>
		void TestEquality (Vector4 a, Vector4 b, Boolean expected )
		{
			// This test asserts the following:
			//   (a == b) == expected
			//   (b == a) == expected
			//   (a != b) == !expected
			//   (b != a) == !expected

			Boolean result_1a = (a == b);
			Boolean result_1b = (a.Equals(b));
			Boolean result_1c = (a.Equals((Object)b));
			
			Boolean result_2a = (b == a);
			Boolean result_2b = (b.Equals(a));
			Boolean result_2c = (b.Equals((Object)a));

			Boolean result_3a = (a != b);
			Boolean result_4a = (b != a);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_1c, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
			Assert.That(result_2c, Is.EqualTo(expected));
			Assert.That(result_3a, Is.EqualTo(!expected));
			Assert.That(result_4a, Is.EqualTo(!expected));
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of TRUE when two equal  
		/// Vector4 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_i ()
		{
			var a = new Vector4(44, -54, -22, 11);
			var b = new Vector4(44, -54, -22, 11);

			Boolean expected = true;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Makes sure that, for a known example, all the equality opperators
		/// and functions yield the expected result of FALSE when two unequal  
		/// Vector4 objects are compared.
		/// </summary>
		[Test]
		public void TestOperator_Equality_ii ()
		{
			var a = new Vector4(44, 54, 2, 11);
			var b = new Vector4(44, -54, 2, -1);

			Boolean expected = false;

			this.TestEquality(a, b, expected);
		}

		/// <summary>
		/// Tests to make sure that all the equality opperators and functions 
		/// yield the expected result of TRUE when used on a number of randomly 
		/// generated pairs of equal Vector4 objects.
		/// </summary>
		[Test]
		public void TestOperator_Equality_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();

				Vector4 b = a;

				this.TestEquality(a, b, true);
			}
		}


		// Test Operator: Addition //-----------------------------------------//

		/// <summary>
		/// Helper method for testing addition.
		/// </summary>
		void TestAddition (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a + b == expected
			//   b + a == expected

			var result_1a = a + b;
			var result_2a = b + a;

			Vector4 result_1b; Vector4.Add(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Add(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the addition opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_i ()
		{
			var a = new Vector4(3, -6, 44, 11);
			var b = new Vector4(-6, 12, 18, -3);

			var expected = new Vector4(-3, 6, 62, 8);

			this.TestAddition(a, b, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving the zero vector, all the 
		/// addition opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Addition_ii ()
		{
			var a = new Vector4(-2313, 88, 199, 42);

			var expected = a;

			this.TestAddition(a, Vector4.Zero, expected);
		}

		/// <summary>
		/// Assert that, for a known example involving two zero vectors, all the 
		/// addition opperators and functions yield the correct result of zero.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iii ()
		{
			this.TestAddition(Vector4.Zero, Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// addition opperators and functions yield the same results as a
		/// manual addition calculation.
		/// </summary>
		[Test]
		public void TestOperator_Addition_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var expected = new Vector4(
					a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);

				this.TestAddition(a, b, expected);
			}
		}

		// Test Operator: Subtraction //--------------------------------------//
		
		/// <summary>
		/// Helper method for testing subtraction.
		/// </summary>
		void TestSubtraction (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a - b == expected
			//   b - a == -expected

			var result_1a = a - b;
			var result_2a = b - a;

			Vector4 result_1b; Vector4.Subtract(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Subtract(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(-expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(-expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the subtraction opperators
		/// and functions yield the correct result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_i ()
		{
			var a = new Vector4(12, -4, 14, 18);
			var b = new Vector4(15, 11, 7, 27);
			var expected = new Vector4(-3, -15, 7, -9);
			this.TestSubtraction(a, b, expected);

			var c = new Vector4(-423, 342, 7, -800);
			this.TestSubtraction(c, Vector4.Zero, c);
		}

		/// <summary>
		/// Assert that when subtracting the zero vector fromt the zero vector, 
		/// all the subtraction opperators and functions yield the correct 
		/// result.
		/// <summary>
		[Test]
		public void TestOperator_Subtraction_ii ()
		{
			this.TestSubtraction(Vector4.Zero, Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// subtraction opperators and functions yield the same results as a
		/// manual subtraction calculation.
		/// </summary>
		[Test]
		public void TestOperator_Subtraction_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var expected = new Vector4(
					a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);

				this.TestSubtraction(a, b, expected);
			}
		}

		// Test Operator: Negation //-----------------------------------------//
		
		/// <summary>
		/// Helper method for testing negation.
		/// </summary>
		void TestNegation (Vector4 a, Vector4 expected )
		{
			// This test asserts the following:
			//   -a == expected

			var result_1a = -a;

			Vector4 result_1b; Vector4.Negate(ref a, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for known examples, all the negation opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_i ()
		{
			Double r = 3432;
			Double s = -6218;
			Double t = -3432;
			Double u = 6218;

			var a = new Vector4(r, s, t, u);
			var b = new Vector4(u, t, s, r);
			var c = new Vector4(t, u, r, s);
			var d = new Vector4(s, r, u, t);

			this.TestNegation(a, c);
			this.TestNegation(b, d);
		}

		/// <summary>
		/// Assert that, for known examples involving the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_ii ()
		{
			Double t = -3432;
			Double u = 6218;
			Double r = 3432;
			Double s = -6218;

			var c = new Vector4(t, u, r, s);
			var d = new Vector4(s, r, u, t);

			this.TestNegation(c, Vector4.Zero - c);
			this.TestNegation(d, Vector4.Zero - d);
		}

		/// <summary>
		/// Assert that when negating the zero vector, all the 
		/// negation opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iii ()
		{
			this.TestNegation(Vector4.Zero, Vector4.Zero);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// negation opperators and functions yield the same results as a
		/// manual negation calculation.
		/// </summary>
		[Test]
		public void TestOperator_Negation_iv ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				this.TestNegation(a, Vector4.Zero - a);
			}
		}

		// Test Operator: Multiplication //-----------------------------------//

		/// <summary>
		/// Helper method for testing multiplication.
		/// </summary>
		void TestMultiplication (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a * b == expected
			//   b * a == expected

			var result_1a = a * b;
			var result_2a = b * a;

			Vector4 result_1b; Vector4.Multiply(ref a, ref b, out result_1b);
			Vector4 result_2b; Vector4.Multiply(ref b, ref a, out result_2b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_2a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
			Assert.That(result_2b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example, all the multiplication opperators
		/// and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_i ()
		{
			Double r = -27;
			Double s = 36;
			Double t = 9;
			Double u = -54;

			Double x = 3;
			Double y = 6;
			Double z = -9;

			var a = new Vector4(x, y, x, y);
			var b = new Vector4(z, y, x, z);
			var c = new Vector4(r, s, t, u);

			this.TestMultiplication(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// multiplication opperators and functions yield the same results as a
		/// manual multiplication calculation.
		/// </summary>
		[Test]
		public void TestOperator_Multiplication_ii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var c = new Vector4(
					a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);

				this.TestMultiplication(a, b, c);
			}
		}


		// Test Operator: Division //-----------------------------------------//

		/// <summary>
		/// Helper method for testing division.
		/// </summary>
		void TestDivision (Vector4 a, Vector4 b, Vector4 expected )
		{
			// This test asserts the following:
			//   a / b == expected

			var result_1a = a / b;

			Vector4 result_1b; Vector4.Divide(ref a, ref b, out result_1b);
			
			Assert.That(result_1a, Is.EqualTo(expected));
			Assert.That(result_1b, Is.EqualTo(expected));
		}

		/// <summary>
		/// Assert that, for a known example using whole numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_i ()
		{
			Double r = 10;
			Double s = -40;
			Double t = 1;
			Double u = -400;

			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector4(x, y, x, x);
			var b = new Vector4(y, z, x, z);
			var c = new Vector4(r, s, t, u);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a known example using fractional numbers, all the 
		/// division opperators and functions yield the correct result.
		/// </summary>
		[Test]
		public void TestOperator_Division_ii ()
		{
			Double s = 4;
			Double t = ((Double) 1 ) / ((Double) 10);
			Double u = ((Double) (-1) ) / ((Double) 40 );
			Double v = -20;
			Double w = 100;
			Double x = 2000;
			Double y = 200;
			Double z = -5;

			var a = new Vector4(y, z, w, v);
			var b = new Vector4(x, y, z, z);
			var c = new Vector4(t, u, v, s);

			this.TestDivision(a, b, c);
		}

		/// <summary>
		/// Assert that, for a number of randomly generated scenarios, all the 
		/// division opperators and functions yield the same results as a
		/// manual addition division.
		/// </summary>
		[Test]
		public void TestOperator_Division_iii ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				var c = new Vector4(
					a.X / b.X, a.Y / b.Y, a.Z / b.Z, a.W / b.W);

				this.TestDivision(a, b, c);
			}
		}

		// Test Static Fn: SmoothStep //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();

				Double amount1 = 0;
				Vector4 result1;

				Vector4.SmoothStep (
					ref a, ref b, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector4 result2;

				Vector4.SmoothStep (
					ref a, ref b, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_ii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.SmoothStep (
							ref a, ref b, amount, out result)
					);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_SmoothStep_iii ()
		{
			var a = new Vector4( -30, -30, -30, -30 );
			var b = new Vector4( +30, +30, +30, +30 );

			Double one = 1;

			Double i;
			RealMaths.FromFraction(1755, 64, out i); // 27.421875
			
			Double j;
			RealMaths.FromFraction( 165,  8, out j); // 20.625
			
			Double k;
			RealMaths.FromFraction( 705, 64, out k); // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector4 r0 = a;
			Vector4 r1 = new Vector4( -i, -i, -i, -i );
			Vector4 r2 = new Vector4( -j, -j, -j, -j );
			Vector4 r3 = new Vector4( -k, -k, -k, -k );
			Vector4 r4 = Vector4.Zero;
			Vector4 r5 = new Vector4(  k,  k,  k,  k );
			Vector4 r6 = new Vector4(  j,  j,  j,  j );
			Vector4 r7 = new Vector4(  i,  i,  i,  i );
			Vector4 r8 = b;

			var knownResults = new List<Tuple<Double, Vector4>>
			{
				new Tuple<Double, Vector4>( a0, r0 ),
				new Tuple<Double, Vector4>( a1, r1 ),
				new Tuple<Double, Vector4>( a2, r2 ),
				new Tuple<Double, Vector4>( a3, r3 ),
				new Tuple<Double, Vector4>( a4, r4 ),
				new Tuple<Double, Vector4>( a5, r5 ),
				new Tuple<Double, Vector4>( a6, r6 ),
				new Tuple<Double, Vector4>( a7, r7 ),
				new Tuple<Double, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.SmoothStep (
					ref a, ref b, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: CatmullRom //--------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a = GetNextRandomVector4();
				var b = GetNextRandomVector4();
				var c = GetNextRandomVector4();
				var d = GetNextRandomVector4();

				Double amount1 = 0;
				Vector4 result1;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, amount1, out result1);

				AssertEqualWithinReason(result1, b);

				Double amount2 = 1;
				Vector4 result2;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, amount2, out result2);

				AssertEqualWithinReason(result2, c);
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_ii ()
		{
			var a = new Vector4( -90, +30, +90, -30 );
			var b = new Vector4( -30, -30, +30, +30 );
			var c = new Vector4( +30, +30, -30, -30 );
			var d = new Vector4( +90, -30, -90, -30 );

			Double one = 1;

			Double u = 15;
			Double v = (Double) 165  / (Double)  8; // 20.5
			Double w = (Double) 45   / (Double)  2; // 20.625
			Double x = (Double) 1755 / (Double) 64; // 27.421875
			Double y = (Double) 15   / (Double)  2; // 14.5
			Double z = (Double) 705  / (Double) 64; // 11.015625

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4( -w, -x,  w,  x );
			Vector4 r2 = new Vector4( -u, -v,  u,  v );
			Vector4 r3 = new Vector4( -y, -z,  y,  z );
			Vector4 r4 = Vector4.Zero;
			Vector4 r5 = new Vector4(  y,  z, -y, -z );
			Vector4 r6 = new Vector4(  u,  v, -u, -v );
			Vector4 r7 = new Vector4(  w,  x, -w, -x );
			Vector4 r8 = c;

			var knownResults = new List<Tuple<Double, Vector4>>
			{
				new Tuple<Double, Vector4>( a0, r0 ),
				new Tuple<Double, Vector4>( a1, r1 ),
				new Tuple<Double, Vector4>( a2, r2 ),
				new Tuple<Double, Vector4>( a3, r3 ),
				new Tuple<Double, Vector4>( a4, r4 ),
				new Tuple<Double, Vector4>( a5, r5 ),
				new Tuple<Double, Vector4>( a6, r6 ),
				new Tuple<Double, Vector4>( a7, r7 ),
				new Tuple<Double, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		/// <summary>
		/// Assert that, for known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();
			var c = GetNextRandomVector4();
			var d = GetNextRandomVector4();
			
			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.CatmullRom (
							ref a, ref b, ref c, ref d, amount, out result)
				);
			}
		}

		/// <summary>
		/// This tests compares results against an example where all the control
		/// points are in a straight line.  In this case the resulting spline
		/// should be a straight line.
		/// </summary>
		[Test]
		public void TestStaticFn_CatmullRom_iv ()
		{
			var a = new Vector4( -90, +30, +90, -30 );
			var b = new Vector4( -30, -30, +30, +30 );
			var c = new Vector4( +30, +30, -30, -30 );
			var d = new Vector4( +90, -30, -90, -30 );

			Double one = 1;

			Double a0 = 0;
			Double a1 = (one * 1) / 4;
			Double a2 = (one * 2) / 4;
			Double a3 = (one * 3) / 4;
			Double a4 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4( -15, -15,  15,  15 );
			Vector4 r2 = Vector4.Zero;
			Vector4 r3 = new Vector4(  15,  15, -15, -15 );
			Vector4 r4 = c;

			var knownResults = new List<Tuple<Double, Vector4>>
			{
				new Tuple<Double, Vector4>( a0, r0 ),
				new Tuple<Double, Vector4>( a1, r1 ),
				new Tuple<Double, Vector4>( a2, r2 ),
				new Tuple<Double, Vector4>( a3, r3 ),
				new Tuple<Double, Vector4>( a4, r4 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

		// Test Static Fn: Hermite //-----------------------------------------//

		/// <summary>
		/// This test runs a number of random scenarios and makes sure that when
		/// the weighting parameter is at it's limits the spline passes directly 
		/// through the correct control points.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_i ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				var a  = GetNextRandomVector4();
				var b  = GetNextRandomVector4();

				var c = GetNextRandomVector4();
				var d = GetNextRandomVector4();

				Vector4 an; Vector4.Normalise(ref c, out an);
				Vector4 bn; Vector4.Normalise(ref d, out bn);

				Double amount1 = 0;
				Vector4 result1;

				Vector4.Hermite (
					ref a, ref an, ref b, ref bn, amount1, out result1);

				AssertEqualWithinReason(result1, a);

				Double amount2 = 1;
				Vector4 result2;

				Vector4.Hermite (
					ref a, ref an, ref b, ref bn, amount2, out result2);

				AssertEqualWithinReason(result2, b);
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_ii ()
		{
			var a = GetNextRandomVector4();
			var b = GetNextRandomVector4();
			var c = GetNextRandomVector4();
			var d = GetNextRandomVector4();

			Vector4 an; Vector4.Normalise(ref c, out an);
			Vector4 bn; Vector4.Normalise(ref d, out bn);

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var amount in tests )
			{
				Vector4 result;

				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.Hermite (
							ref a, ref an, ref b, ref bn, amount, out result)
					);
				
			}
		}

		/// <summary>
		/// This tests compares results against a known example.
		/// </summary>
		[Test]
		public void TestStaticFn_Hermite_iii ()
		{
			var a = new Vector4( -100, +50, +100, -50 );
			var b = new Vector4( +100, -50, -100, +50 );

			var c = new Vector4( -10, +5, +10, -5 );
			var d = new Vector4( +10, -5, -10, +5 );

			Vector4 an; Vector4.Normalise(ref c, out an);
			Vector4 bn; Vector4.Normalise(ref d, out bn);

			Double one = 1;
			
			// 100.1953125
			Double e = (Double) 51300 / (Double) 512;

			// 50.09765625
			Double f = (Double) 12825 / (Double) 256;

			// 91.25
			Double g = (Double) 365 / (Double) 4;

			// 45.625
			Double h = (Double) 365 / (Double) 8;

			// 75.7421875
			Double i = (Double) 9695 / (Double) 128;

			// 37.87109375
			Double j = (Double) 9695 / (Double) 256;

			// 56.25
			Double k = (Double) 225 / (Double) 4;

			// 28.125
			Double l = (Double) 225 / (Double) 8;

			// 35.3515625
			Double m = (Double) 4525 / (Double) 128;

			// 17.67578125
			Double n = (Double) 4525 / (Double) 256;

			// 15.625
			Double o = (Double) 125 / (Double) 8;

			// 7.8125
			Double p = (Double) 125 / (Double) 16;

			// 0.3515625
			Double q = (Double) 45 / (Double) 128;

			// 0.17578125
			Double r = (Double) 45 / (Double) 256;

			Double a0 = 0;
			Double a1 = (one * 1) / 8;
			Double a2 = (one * 2) / 8;
			Double a3 = (one * 3) / 8;
			Double a4 = (one * 4) / 8;
			Double a5 = (one * 5) / 8;
			Double a6 = (one * 6) / 8;
			Double a7 = (one * 7) / 8;
			Double a8 = 1;

			Vector4 r0 = b;
			Vector4 r1 = new Vector4(  e, -f, -e,  f );
			Vector4 r2 = new Vector4(  g, -h, -g,  h );
			Vector4 r3 = new Vector4(  i, -j, -i,  j );
			Vector4 r4 = new Vector4(  k, -l, -k,  l );
			Vector4 r5 = new Vector4(  m, -n, -m,  n );
			Vector4 r6 = new Vector4(  o, -p, -o,  p );
			Vector4 r7 = new Vector4( -q,  r,  q, -r );
			Vector4 r8 = c;

			var knownResults = new List<Tuple<Double, Vector4>>
			{
				new Tuple<Double, Vector4>( a0, r0 ),
				new Tuple<Double, Vector4>( a1, r1 ),
				new Tuple<Double, Vector4>( a2, r2 ),
				new Tuple<Double, Vector4>( a3, r3 ),
				new Tuple<Double, Vector4>( a4, r4 ),
				new Tuple<Double, Vector4>( a5, r5 ),
				new Tuple<Double, Vector4>( a6, r6 ),
				new Tuple<Double, Vector4>( a7, r7 ),
				new Tuple<Double, Vector4>( a8, r8 ),
			};

			foreach(var knownResult in knownResults )
			{
				Vector4 result;

				Vector4.CatmullRom (
					ref a, ref b, ref c, ref d, knownResult.Item1, out result);

				AssertEqualWithinReason(result, knownResult.Item2);
			}
		}

				/// <summary>
		/// Assert that, running the Min function on a number of randomly
		/// generated pairs of Vector4 objects, yields the same results as those
		/// obtained from performing a manual Min calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Min ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = a * 2;

				Vector4 result;
				Vector4.Min (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Max function on a number of randomly
		/// generated pairs of Vector4 objects, yields the same results as those
		/// obtained from performing a manual Max calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Max ()
		{
			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();
				Vector4 b = GetNextRandomVector4();

				Vector4 result;
				Vector4.Max (ref a, ref b, out result);

				Assert.That(result.X, Is.EqualTo(1));
				Assert.That(result.Y, Is.EqualTo(1));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on a number of randomly
		/// generated Vector4 objects for a given min-max range, yields
		/// results that fall within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_i ()
		{
			Vector4 min = new Vector4(-30, 1, 18, -22);
			Vector4 max = new Vector4(32, 130, 47, -2);

			for(Int32 i = 0; i < 100; ++i)
			{
				Vector4 a = GetNextRandomVector4();

				Vector4 result;
				Vector4.Clamp (ref a, ref min, ref max, out result);

				Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
				Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
				Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
				Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			}
		}

		/// <summary>
		/// Assert that, running the Clamp function on an a Vector4 object known
		/// to fall outside of a given min-max range, yields a result that fall 
		/// within that range.
		/// </summary>
		[Test]
		public void TestStaticFn_Clamp_ii ()
		{
			Vector4 min = new Vector4(-30, 1, 18, -22);
			Vector4 max = new Vector4(32, 130, 47, -2);

			Vector4 a = new Vector4(-100, 1113, 50, 14);

			Vector4 expected = new Vector4(-30, 130, 47, -2);

			Vector4 result;
			Vector4.Clamp (ref a, ref min, ref max, out result);

			Assert.That(result.X, Is.LessThanOrEqualTo(max.X));
			Assert.That(result.Y, Is.LessThanOrEqualTo(max.Y));
			Assert.That(result.Z, Is.LessThanOrEqualTo(max.Z));
			Assert.That(result.W, Is.LessThanOrEqualTo(max.W));
			Assert.That(result.X, Is.GreaterThanOrEqualTo(min.X));
			Assert.That(result.Y, Is.GreaterThanOrEqualTo(min.Y));
			Assert.That(result.Z, Is.GreaterThanOrEqualTo(min.Z));
			Assert.That(result.W, Is.GreaterThanOrEqualTo(min.W));

			AssertEqualWithinReason(result, expected);

		}

		/// <summary>
		/// Assert that, running the Lerp function on a number of randomly
		/// generated pairs of Vector4 objects for a range of weighting amounts, 
		/// yields the same results as those obtained from performing a manual 
		/// Lerp calculation.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_i ()
		{
			for(Int32 j = 0; j < 100; ++j)
			{
				Double delta = j;

				delta = delta / 100;

				for(Int32 i = 0; i < 100; ++i)
				{
					Vector4 a = GetNextRandomVector4();
					Vector4 b = GetNextRandomVector4();

					Vector4 result;
					Vector4.Lerp (ref a, ref b, delta, out result);

					Vector4 expected = a + ( ( b - a ) * delta );

					AssertEqualWithinReason(result, expected);
				}
			}
		}

		/// <summary>
		/// Assert that, for a known examples where the weighting parameter is
		/// is outside the allowed range, the correct exception is thrown.
		/// </summary>
		[Test]
		public void TestStaticFn_Lerp_ii ()
		{
			Vector4 a = GetNextRandomVector4();
			Vector4 b = GetNextRandomVector4();

			Double half; RealMaths.Half(out half);

			var tests = new Double[] { 2, half + 1, -half, -1 };

			foreach( var weighting in tests )
			{
				Vector4 result; 
				Assert.Throws(
					typeof(ArgumentOutOfRangeException), 
					() => 
						Vector4.Lerp (
							ref a, ref b, weighting, out result)
					);
			}
		}


	}}

