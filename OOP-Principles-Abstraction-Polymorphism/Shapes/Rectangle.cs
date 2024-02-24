using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int _width;
        private int _height;

        public int Width
        {
            get { return _width; }
            private set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            private set { _height = value; }
        }

        public Rectangle(int width, int heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }


        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}