using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{ 
    class Cord
    {
        private float x, y;

        public float X { get { return x; } }
        public float Y { get { return y; } }
        
        public Cord()
        {
            Set(0, 0);
        }
        public Cord(float x, float y)
        {
            Set(x, y);
        }

        private void Set(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float Distance(Cord T)
        {
            return (float)Math.Sqrt(Math.Pow(T.x - this.x, 2) + Math.Pow(T.y - this.y, 2));
        }
        public float[] VectorTo(Cord T)
        {
            return new float[2] 
            { 
                x-T.x,
                y-T.y
            };
        }
        public Cord GetCord()
        {
            return new Cord(this.x, this.y);
        }
        public void Display()
        {
            Console.WriteLine("(" + x + "; " + y+")");
        }

    }
}
