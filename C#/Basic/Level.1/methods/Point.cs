using System;

namespace methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point NewLocation)
        {
            if (NewLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(NewLocation.X, NewLocation.Y);
        }

        public void Display()
        {
            System.Console.WriteLine(this.X);
            System.Console.WriteLine(Y);
        }

    }
}
