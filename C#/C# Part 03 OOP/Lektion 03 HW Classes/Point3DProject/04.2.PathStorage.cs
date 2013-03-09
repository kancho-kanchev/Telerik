using System.Collections.Generic;
using System.IO;

//04.Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load
//paths from a text file. Use a file format of your choice.

internal static class PathStorage
{
	public static void SavePath(Path path)
	{
		using (StreamWriter writer = new StreamWriter(@"../../Paths.txt"))
		{
			foreach (var point in path.Paths)
			{
				writer.WriteLine(point);
			}
		}
	}

	public static List<Path> LoadPath()
	{
		Path loadPath = new Path();
		List<Path> pathsLoaded = new List<Path>();
		using (StreamReader reader = new StreamReader(@"../../Paths.txt"))
		{
			Point3D point = new Point3D();
			string line = reader.ReadLine();
			while (line != null)
			{
				line = line.Replace("Point X: ", "");
				line = line.Replace("Point Y: ", "");
				line = line.Replace("Point Z: ", "");
				string[] points = line.Split(';');
				point.pointX = int.Parse(points[0]);
				point.pointY = int.Parse(points[1]);
				point.pointZ = int.Parse(points[2]);
				loadPath.AddPoint(point);
				pathsLoaded.Add(loadPath);
				line = reader.ReadLine();
				loadPath = new Path();
			}
		}
		return pathsLoaded;
	}
}