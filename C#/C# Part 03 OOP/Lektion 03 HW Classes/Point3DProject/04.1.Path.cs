using System.Collections.Generic;

//04.Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load
//paths from a text file. Use a file format of your choice.

public class Path
{
	public readonly List<Point3D> sequenceOfPoints = new List<Point3D>();

	public List<Point3D> Paths
	{
		get
		{
			return this.sequenceOfPoints;
		}
	}

	public void AddPoint(Point3D point)
	{
		sequenceOfPoints.Add(point);
	}

	public void ClearPath()
	{
		sequenceOfPoints.Clear();
	}
}