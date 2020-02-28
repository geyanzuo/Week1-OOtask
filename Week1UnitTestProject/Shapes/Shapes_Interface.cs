using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Interface
{
    public interface IShapeProps
    {
        double GetArea();
        double GetPerimeter();
    }

    public interface ICircleProps
    {
        double GetArea();
        double GetCircumference();
    }

    public abstract class Shape
    {
        public string _name;
        public string _colour;

        public Shape(string pname, string pcolour)
        {
            _name = pname;
            _colour = pcolour;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();


    }

    public abstract class Quadrilateral : Shape
    {
        private const int _NumberSides = 4;

        public Quadrilateral(string pname, string pcolour) : base(pname, pcolour)
        {

        }
    }

    public class Square : Quadrilateral, IShapeProps
    {
        public double _sideLength;

        public Square(string pname, string pcolour, double psideLength) : base(pname, pcolour)
        {
            _sideLength = psideLength;
        }

        public override double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(4 * _sideLength, 2);
        }
    }

    public class Rectangle : Quadrilateral, IShapeProps
    {
        public double _length;
        public double _width;

        public Rectangle(string pname, string pcolour, double plength, double pwidth) : base(pname, pcolour)
        {
            _length = plength;
            _width = pwidth;
        }

        public override double GetArea()
        {
            return Math.Round(_length * _width, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * _length + 2 * _width, 2);
        }
    }

    public class Circle : Shape, ICircleProps
    {
        public const double PI = 3.142;
        public double _radius;

        public Circle(string pname, string pcolour, double pradius) : base(pname, pcolour)
        {
            _radius = pradius;
        }

        public override double GetArea()
        {
            return Math.Round(_radius * _radius * PI, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * _radius * PI, 2);
        }

        public double GetCircumference()
        {
            return Math.Round(2 * _radius * PI, 2);
        }
    }
}
