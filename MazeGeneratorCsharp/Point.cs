using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public struct Point
    {
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int x, y;

        public static bool operator ==(Point a, Point b) => 
            a.x == b.x && a.y == b.y;

        public static bool operator !=(Point a, Point b) =>
            !(a == b);

        public override bool Equals(object obj)
        {
            return this == (Point)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }/*

        public MazeGenerator.Direction To(Point other)
        {
            MazeGenerator.Direction dir = MazeGenerator.Direction.None;

            if (other.x > x)
                dir |= MazeGenerator.Direction.Right;
            else if (x < other.x)
                dir |= MazeGenerator.Direction.Left;

            if (other.y > y)
                dir |= MazeGenerator.Direction.Down;
            else if (y < other.y)
                dir |= MazeGenerator.Direction.Up;

            return dir;
        }*/
    }
}
