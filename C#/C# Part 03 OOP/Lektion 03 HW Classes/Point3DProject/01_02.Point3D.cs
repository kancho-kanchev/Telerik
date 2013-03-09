using System;

//01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
//in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.

//02.Add a private static read-only field to hold the start of
//the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

public struct Point3D
{
	public int pointX { get; set; }

	public int pointY { get; set; }

	public int pointZ { get; set; }

	static public readonly Point3D zero = new Point3D(0, 0, 0);

	public Point3D(int pointX, int pointY, int pointZ)
		: this()
	{
		this.pointX = pointX;
		this.pointY = pointY;
		this.pointZ = pointZ;
	}

	public override string ToString()
	{
		string str = String.Format("Point X: {0}; Point Y: {1}; Point Z: {2};", this.pointX.ToString(), this.pointY.ToString(), this.pointZ.ToString());
		return str;
	}
}