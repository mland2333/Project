using System;
//using System.Reflection;
using System.Collections;
delegate void Td();
/*class Program
{
    static void Main(string[] args)
    {
        //Td a = new Td(TestMethod);
        Td a = TestMethod1;
        a += TestMethod2;
        a();
    }
    public static void TestMethod1()
    {
        Console.WriteLine("TestMethod1 invoke");
    }
    public static void TestMethod2()
    {
        Console.WriteLine("TestMethod2 invoke");
    }
}*//*
class Program
{
    public static void Main()
    {
        Download Md = new Download();
        Md.MyDownload();
    }
}
class Download
{
    public void MyDownload()
    {
        Console.WriteLine("Download begin");
        for(int i = 0; i <= 100; i++) {
            Thread.Sleep(50);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write("下载进度 {0}%", i);
        }
        Console.WriteLine("\nHello World");
    }
}*/
/*class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(typeof(Td));
        Type t = typeof(Person);
        //object obj = Activator.CreateInstance(t, "小王");
        object obj = Activator.CreateInstance(t, 
            BindingFlags.NonPublic | BindingFlags.Instance, 
            null, new object[] { "小徐", 20 }, null);

        FieldInfo a = t.GetField("a", BindingFlags.NonPublic | BindingFlags.Static);
        a.SetValue(null, 21);
        Console.WriteLine(a.GetValue(null));

        FieldInfo b = t.GetField("_age", BindingFlags.NonPublic|BindingFlags.Instance);
        b.SetValue(obj, 22);
        Console.WriteLine(b.GetValue(obj));

        MethodInfo method0 = t.GetMethod("showA", BindingFlags.NonPublic | BindingFlags.Static);
        method0.Invoke(null, null);
        //Console.WriteLine(obj.ToString);
        MethodInfo method1 = t.GetMethod("Show", 
            BindingFlags.Public | BindingFlags.Instance, 
            null, new Type[] {typeof(double), typeof(double)}, null);
        Console.WriteLine(method1.Invoke(obj, new object[] { 1.1, 2.2}));
    }
}
class Person
{
    private static int a;
    private string _id;
    private int _age;
    public string Id { get { return _id; } }
    public int Age { get { return _age; } }
    private Person()
    {
        Console.WriteLine("Person 无参构造");
        _id = "小明";
        _age = 18;
    }
    public Person(string id)
    {
        Console.WriteLine("Person 单参数构造");
        _id = id;
        _age = 18;
    }
    private Person(string id, int age)
    {
        Console.WriteLine("Person 双参数构造");
        _id = id;
        _age = age;
    }
    
    private static void showA()
    {
        Console.WriteLine("showA");
    }

    public int Show(int a, int b)
    {
        Console.WriteLine(a);
        return b;
    }
    public double Show(double a, double b)
    {
        Console.WriteLine(a);
        return b;
    }
}*/

class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        Console.WriteLine(list);
    }
    public static void list_operation(ArrayList list)
    {
        list.Add(1);
        list.Add(2);
        list.AddRange(new int[] {3,4,5});
        list.Add(new int[] { 1, 2, 3 });

        list.Remove(1);
    }
}