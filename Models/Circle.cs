﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace lab2.Figures
{
    public class Circle : Ellipse
    {
        public int radius { get { return mainAxis; } set { mainAxis = value; additionalAxis = value; } }

        public Circle(int x1, int y1, int r):base(x1,y1,r,r)
        {
        }
        public Circle(Point point1, Point point2) :
        this(
            (int)(point1.X - (point1.X - point2.X) / 2),
            (int)(point1.Y - (point1.Y - point2.Y) / 2),
            (int)Math.Min(Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y))
        )
        { 
        }
        public override string FigureName() { return "Окружность"; }
        public override void ShowFigure()
        {
            Console.WriteLine($"{FigureName()}\n" +
                $"Центр в точке ({x},{y}) \n" +
                $"Радиус = {radius} \n\n");
        }
    }
}
