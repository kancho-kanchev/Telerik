using System;

//03.Write a static class with a static method to calculate
//the distance between two points in the 3D space

public static class DistanceTwo3DPoints
{
	public static double CalcDistance(Point3D pointFirst, Point3D pointSecond)
	{
		double distance = 0.0D;
		distance = Math.Sqrt(Math.Pow(pointFirst.pointX - pointSecond.pointX, 2) + Math.Pow(pointFirst.pointY - pointSecond.pointY, 2) + Math.Pow(pointFirst.pointZ - pointSecond.pointZ, 2));

		return distance;
	}
}