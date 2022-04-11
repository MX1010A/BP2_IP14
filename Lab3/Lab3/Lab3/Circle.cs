using System;

namespace Lab3
{
    public class Circle
    {
        private readonly double _radius, _coordinateX, _coordinateY;
        
        //конструктор класу
        public Circle(double radius, double coordinateX, double coordinateY)
        {
            _radius = radius;
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
        }
        
        //обчислення площі круга
        public double Area() => Math.PI * _radius * _radius;

        //конвертування параметрів круга в рядок
        public string String() => $"Radius: {_radius} cm \tCoordinates of center: ({_coordinateX}, {_coordinateY})";
    }
}