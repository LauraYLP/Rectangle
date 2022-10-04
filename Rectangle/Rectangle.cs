using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        private int length =1;
        private int width =1;

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public Rectangle() { }

        public int Length {
            get { return this.length; }
            set { length = value; }
        
        }
        public int Width {
            get { return this.width; } 
            set { width = value; }
        
        }

        public int GetCurrentLength()
        {
            return this.Length;
        }

        public int SetNewLength(int length)
        {
            return this.Length = length;
        }

        public int GetCurrentWidth()
        {
            return this.width;
        }

        public int SetNewWidth(int width)
        {
            return this.Width = width;
        }
        public int GetPerimeter()
        {
            return (Width + Length)*2;
        }
        public int GetArea()
        {
            return (Length * Width);
        }
    }
}
