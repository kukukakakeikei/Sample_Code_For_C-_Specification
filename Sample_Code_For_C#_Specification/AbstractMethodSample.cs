using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AbstractMethodSampleCode
{
    internal class AbstractMethodSample
    {
    }
    public abstract class Expression
    {
        public abstract double Evaluate(Hashtable vars);
    }
    public class Constant : Expression
    {
        double value;
        public Constant(double value)
        {
            this.value = value;
        }

        public override double Evaluate(Hashtable vars)
        {
            return value;
        }
    }
    public class variableReference : Expression
    {
        string name;
        public variableReference(string name)
        {
            this.name = name;
        }
        public override double Evaluate(Hashtable vars)
        {
            object value = vars[name];
            if (value == null)
            {
                throw new Exception("Unknow variable:" + name);
            }
            return Convert.ToDouble(value);
        }
    }
    public class operation : Expression
    {

        Expression left;
        char op;
        Expression right;

        public operation(Expression left, char op, Expression right)
        {
            this.left = left;
            this.op = op;
            this.right = right;
        }
        public override double Evaluate(Hashtable vars)
        {
            double x = left.Evaluate(vars);
            double y = right.Evaluate(vars);
            switch (op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;
            }
            throw new Exception("Unknow operator");
        }
    }
}
