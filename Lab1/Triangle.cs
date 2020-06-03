using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Triangle
    {

        private Cord A, B, C;
        private float BC, AC, AB;

        public Triangle(Cord A, Cord B, Cord C)
        {
            Set(A, B, C);
        }
        private void Set(Cord A, Cord B, Cord C)
        {
            this.A = A.GetCord();
            this.B = B.GetCord();
            this.C = C.GetCord();
            this.BC = B.Distance(C);
            this.AC = A.Distance(C);
            this.AB = A.Distance(B);
        }
        public bool EqualTr(Triangle tr)
        {
            if (AB != tr.AB && AB != tr.AC && AB != tr.BC)
                return false;
            if (BC != tr.AB && BC != tr.AC && BC != tr.BC)
                return false;
            if (AC != tr.AB && AC != tr.AC && AC != tr.BC) 
                return false;
            return true;
        }
        public float Perimeter()
        {
            return AB + BC + AC;
        }
        public float[] Hights()
        {
            float S = Square();
            return new float[3]
            {
                2*S/AB,
                2*S/BC,
                2*S/AC
            };
        }
        public string [] Characters()
        {
            if (AB==BC && AB == AC)
            {
                return new string[2]
                {
                    "рівносторонний",
                    "гострокутний"
                }; 
            }
            string[] res = new string[2] {"Різносторонний",""};
            if (AB==BC || BC==AC || AC == AB)
            {
                res[0] = "Рівнобедрений";
            }
            float[] ac = A.VectorTo(C);
            float[] ab = A.VectorTo(B);
            float[] bc = B.VectorTo(C);
            float cos_a = (ac[0] * ab[0] + ac[1] * ab[1]) / (AC * AB);
            float cos_b = (ab[0] * bc[0] + ab[1] * bc[1]) / (AB * BC);
            float cos_c = (bc[0] * ac[0] + bc[1] * ac[1]) / (BC * AC);
            if (cos_a == 0 || cos_b == 0 || cos_c == 0)
            {
                res[1] = "Прямокутний";
            }
            else if (cos_a > 0 && cos_b > 0 && cos_c > 0)
            {
                res[1] = "Гострокутний";
            }
            else 
                res[1] = "Тупокутний";
            return res;
        }
        /// <summary>
        /// Повертає трикутник навколо точки pointName: (A,B,C, O - центр описаного кола) на кут angle в градусах
        /// </summary>
        /// <returns></returns>
        public void Rotation(char pointName, int angle)
        {
            Console.WriteLine($"Rotation by a {angle} degrees relative to a point \'" + pointName+"\'.");
            Cord centerOfRotation;
            switch (pointName)
            {
                case 'A':
                case 'a':
                    centerOfRotation = A.GetCord();
                    break;
                case 'B':
                case 'b':
                    centerOfRotation = B.GetCord();
                    break;
                case 'C':
                case 'c':
                    centerOfRotation = C.GetCord();
                    break;
                case 'O':
                case 'o':
                    float znam = 2 * (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y));
                    float x = (A.Y * DSSC(B,C)+ B.Y * DSSC(C,A)+ C.Y * DSSC(A,B)) / (-2 * znam);
                    float y = (A.X * DSSC(B, C) + B.X * DSSC(C, A) + C.X * DSSC(A, B)) / znam;
                    centerOfRotation = new Cord(x, y);
                    break;
                default: return;
            }
            float cos_angle = (float)Math.Cos(angle * Math.PI / 180);
            float sin_angle = (float)Math.Sin(angle * Math.PI / 180);
            float Ax = centerOfRotation.X + (A.X - centerOfRotation.X) * cos_angle - (A.Y - centerOfRotation.Y) * sin_angle;
            float Ay= centerOfRotation.Y + (A.Y - centerOfRotation.Y) * cos_angle + (A.X - centerOfRotation.X) * sin_angle;
            float Bx = centerOfRotation.X + (B.X - centerOfRotation.X) * cos_angle - (B.Y - centerOfRotation.Y) * sin_angle;
            float By = centerOfRotation.Y + (B.Y - centerOfRotation.Y) * cos_angle + (B.X - centerOfRotation.X) * sin_angle;
            float Cx = centerOfRotation.X + (C.X - centerOfRotation.X) * cos_angle - (C.Y - centerOfRotation.Y) * sin_angle;
            float Cy = centerOfRotation.Y + (C.Y - centerOfRotation.Y) * cos_angle + (C.X - centerOfRotation.X) * sin_angle;
            Set(new Cord(Ax, Ay), new Cord(Bx, By), new Cord(Cx, Cy));
        }
        /// <summary>
        /// difference of the sum of squares of coordinates: повертає різницю між сумю кватратів координат точки Т1 та Т2
        /// </summary>
        /// <returns></returns>
        private float DSSC(Cord T1, Cord T2)
        {
            return T1.X * T1.X + T1.Y * T1.Y - T2.X * T2.X - T2.Y * T2.Y;
        }
        public float R()
        {
            return AB * BC * AC / (4 * Square());
        }
        public float r()
        {
            return Square() / (Perimeter() / 2);
        }
        public float [] Bisectors()
        {
            float p = Perimeter() / 2;
            return new float[3]
            {
               (float) (2*Math.Sqrt(AB*BC*p*(p-AC))/(AB+BC)),
               (float) (2*Math.Sqrt(AC*BC*p*(p-AB))/(AC+BC)),
               (float) (2*Math.Sqrt(AB*AC*p*(p-BC))/(AB+AC))
            };
        }
        public float [] Medians()

        {
            return new float[3]
            {
                (float)Math.Sqrt(2*AB*AB+2*BC*BC-AC*AC)/2,
                (float)Math.Sqrt(2*AC*AC+2*BC*BC-AB*AB)/2,
                (float)Math.Sqrt(2*AB*AB+2*AC*AC-BC*BC)/2,
            };

        }
        public float Square()
        {
            float p = Perimeter() / 2;
            return (float)Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));

        }
        public void Display(string name = "Name of Triangle")
        {
            Console.WriteLine("\n"+name+":");
            string[] t = Characters();
            Console.WriteLine($"Type of triangle: {t[0]}, {t[1]}");
            Console.Write("A: ");
            A.Display();
            Console.Write("B: ");
            B.Display();
            Console.Write("C: ");
            C.Display();
            Console.WriteLine($"AB = {AB}\nBC = {BC}\nAC = {AC}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Square: {Square()}");
            float[] h = Hights();
            Console.WriteLine($"Hights: {h[0]}; {h[1]}; {h[2]}");
            float[] m = Medians();
            Console.WriteLine($"Medians: {m[0]}; {m[1]}; {m[2]}");
            float[] b = Bisectors();
            Console.WriteLine($"Bisectors: {b[0]}; {b[1]}; {b[2]}");
            Console.WriteLine($"r = {r()}");
            Console.WriteLine($"R = {R()}\n");

        }
        
    }
}
