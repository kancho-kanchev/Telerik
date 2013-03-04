using System;

//04. Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them.
//Use System.Math

internal class SurfaceOfTriangle
{
	private static double surfaceByAllSides(double sideA, double sideB, double sideC)
	{
		double result = 0;
		result = (sideA + sideB + sideC) / 2;
		result = Math.Sqrt(result * (result - sideA) * (result - sideB) * (result - sideC));
		return result;
	}

	private static double surfaceByAngle(double sideA, double sideB, double angelAB)
	{
		return (sideA * sideB * Math.Sin(Math.PI * angelAB / 180)) / 2;
	}

	private static double surfaceBySideAndAltidude(double side, double altitude)
	{
		return side * altitude / 2;
	}

	private static void Main()
	{
		double sideA = 3;
		double sideB = 4;
		double sideC = 5;
		double altitudeA = 4;
		double altitudeB = 3;
		double altitudeC = 2.4;
		double angelAB = 90;
		double angelBC = 37;
		double angelCA = 53;
		if (sideA > 0 && altitudeA > 0) Console.WriteLine("Side A = {0}, altidude A = {1}, surface = {2}", sideA, altitudeA, surfaceBySideAndAltidude(sideA, altitudeA));
		if (sideB > 0 && altitudeB > 0) Console.WriteLine("Side B = {0}, altidude B = {1}, surface = {2}", sideB, altitudeB, surfaceBySideAndAltidude(sideB, altitudeB));
		if (sideC > 0 && altitudeC > 0) Console.WriteLine("Side C = {0}, altidude C = {1}, surface = {2}", sideC, altitudeC, surfaceBySideAndAltidude(sideC, altitudeC));
		if ((sideA > 0) && (sideB > 0) && (sideC > 0)) Console.WriteLine("Side A = {0}, side B = {1}, side C = {2}, surface = {3}", sideA, sideB, sideC, surfaceByAllSides(sideA, sideB, sideC));
		if ((sideA > 0) && (sideB > 0) && (angelAB > 0)) Console.WriteLine("Side A = {0}, side B = {1}, angle AB = {2}, surface = {3}", sideA, sideB, angelAB, surfaceByAngle(sideA, sideB, angelAB));
		if ((sideB > 0) && (sideC > 0) && (angelBC > 0)) Console.WriteLine("Side B = {0}, side C = {1}, angle BC = {2}, surface = {3}", sideB, sideC, angelBC, surfaceByAngle(sideB, sideC, angelBC));
		if ((sideC > 0) && (sideA > 0) && (angelCA > 0)) Console.WriteLine("Side C = {0}, side A = {1}, angle CA = {2}, surface = {3}", sideC, sideA, angelCA, surfaceByAngle(sideC, sideA, angelCA));
	}
}