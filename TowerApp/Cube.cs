using System;
using System.Collections.Generic;
using System.Text;

namespace TowerApp
{
    class Cube
    {
        private double height, width;
        public Cube(double h, double w)
        {
            this.height = h;
            this.width = w;
        }

        public Cube(Cube c)
        {
            this.height = c.height;
            this.width = c.width;
        }
        public void SetHeight(double h)
        {
            this.height = h;
        }

        public void SetWidth(double w)
        {
            this.width = w;
        }

        public double GetWidth()
        {
            return this.width;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public double Area()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            return $"Cube ({this.height},{this.width})";
        }
    }
}
