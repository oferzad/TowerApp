using System;

namespace TowerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube c1 = new Cube(10, 5);
            Cube c2 = new Cube(12, 7);
            Cube c3 = new Cube(3, 3);
            Cube c4 = new Cube(5, 5);
            Cube c5 = new Cube(6, 5);

            Tower t1 = new Tower();
            t1.AddCube(c1);
            t1.AddCube(c2);

            Console.WriteLine(t1);

            t1.AddCube(c3);
            Console.WriteLine(t1);
        }
    }
}
