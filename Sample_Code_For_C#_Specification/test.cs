using System;
using Acme.Collections;

class Test
{
    static void Main()
    { 
        Stack s = new Stack();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());

        BoxingAndUnboxing();
        LocalVariable();

    }
    /// <summary>
    /// 装箱与拆箱
    /// </summary>
    public static void BoxingAndUnboxing()
    {
        int i = 123;
        object o = i; //boxing
        int j = (int)o; //unboxing
    }
    /// <summary>
    /// 局部变量声明
    /// </summary>
    public static void LocalVariable()
    {
        int a;
        int b = 2, c = 3;
        a = 1;
        Console.WriteLine(a + b + c);
    }
    /// <summary>
    /// 局部常量声明
    /// </summary>
    public static void ConstantVariable()
    {
        const float pi = 3.1415926f;
        const int r = 25;
        Console.WriteLine(pi * r * r );
    }
    /// <summary>
    /// 表达式语句
    /// </summary>
    public static void Expression()
    {
        int i;
        i = 123;
        Console.WriteLine(i);
        i++;
        Console.WriteLine(i);
    }
    /// <summary>
    /// 选择语句If
    /// </summary>
    /// <param name="args"></param>
    public static void SelectionIf(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments");
        }
        else
        {
            Console.WriteLine("One or more arguments");
        }
    }
    /// <summary>
    /// 条件语句Switch
    /// </summary>
    /// <param name="args"></param>
    public static void SelectionSwitch(string[] args)
    { 
        int n = args.Length;
        switch (n)
        {
            case 0: 
                Console.WriteLine("No arguments");
                break;
            case 1: 
                Console.WriteLine("One argument");
                break;
            default:
                Console.WriteLine("{0} argument", n);
                break;
        }
    }
    /// <summary>
    /// 条件语句While
    /// </summary>
    /// <param name="args"></param>
    public static void SelectionWhile(string[] args)
    {
        int i = 0;
        while (i < args.Length)
        {
            Console.WriteLine(args[i]);
            i++;
        }
    }
    /// <summary>
    /// 条件语句Do
    /// </summary>
    public static void SelectionDo()
    {
        string s;
        do { 
            s = Console.ReadLine();
            if (s != null) Console.WriteLine(s);
        }while (s != null);
    }
    /// <summary>
    /// 条件语句For
    /// </summary>
    /// <param name="args"></param>
    public static void SelectionFor(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"{args[i]}");
        }
    }
    /// <summary>
    /// 条件语句Foreach
    /// </summary>
    /// <param name="args"></param>
    public static void SelectionForeach(string[] args)
    {
        foreach (string s in args) {
            Console.WriteLine(s);
        }
    }
}
