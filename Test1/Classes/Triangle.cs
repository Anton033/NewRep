using System;
namespace Test1.Classes
{
	public class Triangle
	{
		public double firstSide;
		public double secondSide;
		public double thrirdSide;

		//Площадь разностороннего по формуле Герона
		public virtual double GetSq()
		{
			Console.WriteLine("\nGet square Heron formula");
			double semiPr = (firstSide + secondSide + thrirdSide) / 2;
			return Math.Sqrt(semiPr * (semiPr - firstSide) * (semiPr - secondSide) * (semiPr - thrirdSide));
		}
		public Triangle(double firstSide, double secondSide, double thrirdSide)
		{
			this.firstSide = firstSide;
			this.secondSide = secondSide;
			this.thrirdSide = thrirdSide;
		}
	}

	//Площадь равностореннего
	public class equilateralTriangle : Triangle
	{
		public equilateralTriangle(double firstSide, double secondSide, double thrirdSide) : base(firstSide, secondSide, thrirdSide)
		{
		}

		public override double GetSq()
		{
			Console.WriteLine("\nGet square of equilateral Triangle");
			return Math.Pow(firstSide, 2) * Math.Sqrt(3) / 4;
		}
	}

	//Площадь прямого
	public class StraightTriangle : Triangle
	{
		public StraightTriangle(double firstSide, double secondSide, double thrirdSide) : base(firstSide, secondSide, thrirdSide)
		{
		}

		public override double GetSq()
		{
			Console.WriteLine("\nGet square of Straight triangle");
			if (firstSide > secondSide)
			{
				if (firstSide > thrirdSide)
				{
					return GetSquareForStrightTriangle(secondSide, thrirdSide);
				}
				else
				{
					return GetSquareForStrightTriangle(firstSide, secondSide);
				}
			}
			else
			{
				if (secondSide > thrirdSide)
				{
					return GetSquareForStrightTriangle(firstSide, thrirdSide);
				}
				else
				{
					return GetSquareForStrightTriangle(firstSide, secondSide);
				}
			}
		}

		private double GetSquareForStrightTriangle(double firstSide, double secondSide)
		{
			return 0.5 * firstSide * secondSide;
		}
	}

	//Создать отдельный класс который будет отвечать за логину создания треугольников.В нем вернуть нужный обьект треугольника проверив его стороны
	public static class TriangleBuilder
	{

		public static Triangle CreateTriangle(double firstSide, double secondSide, double thrirdSide)
		{
			if (thrirdSide == secondSide || firstSide == thrirdSide || firstSide == secondSide)
			{
				return new equilateralTriangle(firstSide, secondSide, thrirdSide);
			}
			else
			{
				return new equilateralTriangle(firstSide, secondSide, thrirdSide);
			}
		}
	}

	//добавить класс квадрат и прямоугольник и логику подсчета площади для него
	//добавить класс для реализации иерархии фигур
	public abstract class Shape
	{
		public abstract double GetSquare();
	}

	public class Square : Shape
	{
		public double sideA;

		public Square(double sideA)
		{
			this.sideA = sideA;
		}
		public override double GetSquare()
		{
			Console.WriteLine("\nGet the square of Square from formula");
			return Math.Pow(sideA, 2);
		}
	}
	public class Rectangle : Square
	{
		public double sideB;

		public Rectangle(double sideA, double sideB) : base (sideA)
		{
			this.sideB = sideB;
		}
			
		public override double GetSquare()
		{
			Console.WriteLine("\nGet the square of Rectangle from formula");
			return sideB * sideA;
		}
	}

}

