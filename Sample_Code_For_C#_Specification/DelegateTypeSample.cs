using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTypeSampleCode
{
    public delegate double Function(double x);
    public class Multiplier
    {
        double factor;
        public Multiplier(double factor)
        {
            this.factor = factor;
        }
        public double Multiply(double x)
        { 
            return factor * x;
        }
    }
    public class DelegateTest
    {
        public static double Square(double x)
        { 
            return x * x;
        }
        public static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++) { result[i] = f(a[i]);}
            return result;
        }
        //static void Main()
        //{
        //    double[] a = { 0.1, 0.5, 1.0 };
        //    double[] squares = Apply(a, Square);
        //    double[] sines = Apply(a, Math.Sin);
        //    Multiplier m = new Multiplier(2.0);
        //    double[] doubles = Apply(a,m.Multiply);

        //}
    }
}
