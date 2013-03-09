using System;
using System.Collections.Generic;

internal class Point3DProject
{
	private static void Main()
	{
		Point3D point = new Point3D(2, 4, 6);
		Point3D pointTwo = new Point3D(8, 5, 3);
		Console.WriteLine("First point:");
		Console.WriteLine(point.ToString());
		Console.WriteLine();
		Console.WriteLine("Second point:");
		Console.WriteLine(pointTwo.ToString());
		Console.WriteLine();
		Console.WriteLine("Distance:");
		Console.WriteLine(DistanceTwo3DPoints.CalcDistance(point, pointTwo));
		Console.WriteLine();
		Console.WriteLine("Center of coordinate system:");
		Console.WriteLine(Point3D.zero.ToString());
		Console.WriteLine();
		Console.WriteLine("Writing in file \"Paths.txt\" first point, second point, first point again!");
		Path firstPath = new Path();
		firstPath.AddPoint(pointTwo);
		firstPath.AddPoint(point);
		firstPath.AddPoint(pointTwo);
		PathStorage.SavePath(firstPath);
		Console.WriteLine("File is saved");
		Console.WriteLine();
		Console.WriteLine("Loading points from file \"Paths.txt\"");
		List<Path> pathList = PathStorage.LoadPath();
		foreach (var path in pathList)
		{
			foreach (var pointers in path.Paths)
			{
				Console.WriteLine(pointers);
			}
		}
	}
}