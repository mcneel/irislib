﻿namespace THREE.Math
{
    /// <summary>
    /// Class representing a 3D vector.
    /// Analogous to: https://threejs.org/docs/index.html#api/math/Vector3
    /// JS Source: https://github.com/mrdoob/three.js/blob/master/src/math/Vector3.js
    /// </summary>
    public class Vector3
    {

        float[] XYZ;

        /// <summary>
        /// The x value of the vector.
        /// </summary>
        public float X { get { return XYZ[0]; } set { XYZ[0] = value; } }

        /// <summary>
        /// The y value of the vector.
        /// </summary>
        public float Y { get { return XYZ[1]; } set { XYZ[1] = value; } }

        /// <summary>
        /// The z value of the vector.
        /// </summary>
        public float Z { get { return XYZ[2]; } set { XYZ[2] = value; } }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Vector3()
        {
            XYZ = new float[3];
            X = 0;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Extended constructor that takes three components of this vector.
        /// </summary>
        /// <param name="x">The x component of this vector.</param>
        /// <param name="y">The y component of this vector.</param>
        /// <param name="z">The z component of this vector.</param>
        public Vector3(float x, float y, float z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// An array representation of this vector.
        /// </summary>
        /// <returns>An array where x is index 0, y is index 1, and z is index 2.</returns>
        public float[] ToArray() { return XYZ; }

        public void SubVectors(Vector3 a, Vector3 b)
        {
            X = a.X - b.X;
            Y = a.Y - b.Y;
            Z = a.Z - b.Z;
        }

        public float LengthSq()
        {
            return X * X + Y * Y + Z * Z;
        }

        public void MultiplyScalar(float scalar)
        {
            X *= scalar;
            Y *= scalar;
            Y *= scalar;
        }

        public void DivideScalar(float scalar)
        {
            MultiplyScalar(1 / scalar);
        }

        public float Length()
        {
            return (float)System.Math.Sqrt(X*X + Y*Y + Z*Z);
        }

        public void Normalize()
        {
            DivideScalar(Length());
        }

        public void CrossVectors(Vector3 a, Vector3 b)
        {
            var ax = a.X;
            var ay = a.Y;
            var az = a.Z;

            var bx = b.X;
            var by = b.Y;
            var bz = b.Z;

            X = ay * bz - az * by;
            Y = az * bx - ax * bz;
            Z = ax * by - ay * bx;
        }
    }
}
