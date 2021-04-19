using System;
using System.Collections.Generic;
using System.Text;

namespace TowerApp
{
    class Tower
    {
        private int numCubes;
        private Cube[] cubes;
        private const int MAX_CUBES = 1000;

        public Tower()
        {
            this.numCubes = 0;
            this.cubes = new Cube[MAX_CUBES];
        }

        public double GetHeight()
        {
            double h = 0;
            for (int i = 0; i < this.numCubes; i++)
            {
                Cube c = this.cubes[i];
                h = h + c.GetHeight();
            }
            return h;
        }

        public bool AddCube(Cube c)
        {
            if (this.numCubes < MAX_CUBES)
            {
                this.cubes[this.numCubes] = new Cube(c);
                this.numCubes++;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string str = $"Tower ({this.numCubes},{this.GetHeight()})\n";
            for (int i = 0; i < this.numCubes; i++)
            {
                str += $"{this.cubes[i]}\n";
            }
            return str;
        }
    }
}
