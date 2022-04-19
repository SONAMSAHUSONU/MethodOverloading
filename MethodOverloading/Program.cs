/*using System;

    class Program
    {
        static void Main(string[] args)
        {
        string mess=Program.GetEmployeeDetails(01);//01 is method of argument
        Console.WriteLine(mess);
        Console.ReadLine();
        }
    public static string GetEmployeeDetails(byte employee_id)//method of parameter//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }
}*/

//Method overloading:- if class has multiple method with same name with different parameter.
// we can overload static and non static method also.
// return type can be anythink.
// using method overloading we can achive static polymorpdhism.
//rules of method overloading 
//1. Method name will be name 
//2. method parameter will be diffrenet 
//3. number of parameter will be different
//4. type of parameter willl be different
//5. order of parameter will be different

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start");
        GetEmployeeDetails(101);
        GetEmployeeDetails();
        GetEmployeeDetails(122342222222, "Hello");
        Console.WriteLine("end");
        Console.ReadLine();




    }
    public static void GetEmployeeDetails()
    {
        Console.WriteLine("GetEmployeeDetails()");
    }

    public static string GetEmployeeDetails(short employee_id)// number of parameter 
    {     
        Console.WriteLine("(int employee_id)");
        return "101";
    }

    public static string GetEmployeeDetails(byte employee_id)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }

 
    public static string GetEmployeeDetails(int employee_id)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }

    public static string GetEmployeeDetails(long employee_id)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }


    public static string GetEmployeeDetails(long employee_id,string fname)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }

    public static string GetEmployeeDetails(float employee_id, string fname)//type of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }
    public static string GetEmployeeDetails(string fname, float employee_id)//order of parameter 
    {
        Console.WriteLine("(int employee_id)");
        return "101";
    }

    public static string GetEmployeeDetails(int employee_id,int pincode)// number of parameter 
    {
        Console.WriteLine("(int employee_id,int pincode)");
        return "101";
    }

    public static string GetEmployeeDetails(int employee_id, int pincode,int stdcode)// number of parameter 
    {
        Console.WriteLine("(int employee_id, int pincode,int stdcode)");
        return "101";
    }

}
*/
//Method return cab be any predifine data type and user difine data type
/*using System;//namspace
using System.Collections;
public class Employee
{
    int i = 10, j = 20;



    //Method:-Method is the block of code that can perform some specific task.
    //there are two type of method 
    //1. static  2. non static 
    // public <reurntype> MethodName(parameter1,parameter2,parameter3 ,parameter n)
    //{

    //}
    // public static <reurntype> MethodName(parameter1,parameter2,parameter3 ,parameter n)
    //{

    //}
    public void LogOut()
    {
        Console.WriteLine("i am from logout");
    }
    public static string LogIn(string userName, string password)
    {
        return "You Loged in home";
    }

    public bool ForgotPassword(string userId, string passwrd, long mobile)
    {
        return true;
    }
    static void Main()
    {
        LogIn("Viswa", "india@123a");
        Employee.LogIn("lara", "wel");
        Employee obj = new Employee();
        obj.ForgotPassword("user", "66777", 8908909908);
    }
}*/

/*using System;//namspace
using System.Collections;
public class Employee
{
    public void M1()
    {
        Console.WriteLine("no arg method");
    }
    public int GetMyAge(string name)
    {
        Console.WriteLine(name);
        return 101;
    }
    public int Sum(int x, int y)
    {
        Console.WriteLine("i am from sum method");
        return x + y;
    }
    public static void Main()
    {
        Employee a1 = new Employee();
        a1.M1();
        a1.Sum(100, 200);
        a1.GetMyAge("Vk");
    }
}*/

//case -1: just normal call

/*using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main() 
    {
        Console.WriteLine("Start");
        Employee obj = new Employee();

       obj.A1("Sonam");
        obj.A2("Banglore", "KA");
        Console.ReadLine();
    }

    public void A1(string name) //non static method //called
    {
        Console.WriteLine("Hi");
    }

    public string A2(string city, string state)
    {
        Console.WriteLine("i am from A2");
        return  "city:" + city + "sate:" + state;
    }
}*/
/*
//Case-2. catching return string value
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("i am from main");
        Employee obj = new Employee();
        obj.A1("Nayan");
        string result = obj.A2("Banglore", "KA");
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public void A1(string name)
    {
        Console.WriteLine("hi " + name);
    }

    public string A2(string city, string state)
    {
        Console.WriteLine("i am from A2");
        return "City:" + " " + city + " " + "State:" + " " + state;
    }
}*/

//Case-3 catching return int value
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("i am from main");
        Employee obj = new Employee();

        obj.A1("Nayan");
        Console.WriteLine("Nayan");

        string result = obj.A2("Banglore", "KA");
        Console.WriteLine(result);
        int sum = obj.A3(100, 200);
        Console.WriteLine(sum);
        Console.ReadLine();
    }

    public void A1(string name)//non static
    {
        Console.WriteLine("hi " + name);
    }

    public string A2(string city, string state)
    {
        Console.WriteLine("i am from A2");
        return "City:" + " " + city + " " + "State:" + " " + state;
    }
    public int A3(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}
/*
Case-4 static method call

using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        M1(100, 2000);
        Employee.Div(100, 200);
        Console.ReadLine();
    }

    public static void M1(int x, int y)
    {
        Console.WriteLine("x=" + x);
        Console.WriteLine("y=" + y);
    }
    public static int Sum(int x, int y)
    {
        Console.WriteLine(" i am from sum");
        return x + y;
    }
    public static int Mul(int x, int y)
    {
        Console.WriteLine(" i am from mul");
        return x * y;
    }
    public static int Div(int x, int y)
    {
        Console.WriteLine("i am from dev");
        return x / y;
    }

}*/
/*
Case-5 catching return int value

using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        M1(100, 2000);
        int xyz = Employee.Div(100, 2);
        Console.WriteLine(xyz);
        Console.ReadLine();
    }

    public static void M1(int x, int y)
    {
        Console.WriteLine("x=" + x);
        Console.WriteLine("y=" + y);
    }
    public static int Sum(int x, int y)
    {
        Console.WriteLine(" i am from sum");
        return x + y;
    }
    public static int Mul(int x, int y)
    {
        Console.WriteLine(" i am from mul");
        return x * y;
    }
    public static int Div(int x, int y)
    {
        Console.WriteLine("i am from dev");
        return x / y;
    }


}*/
/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main-begin");
        Employee obj = new Employee();//obj is the object refence variable
        obj.T1();
        Console.WriteLine("T1 exuation completed");
    }

    public void T1()
    {
        Console.WriteLine("t1 begin");
        T2(100, 200);
        Console.WriteLine("T2 execution completd");
        int i = T2(1000, 20);
        Console.WriteLine(i);
    }

    public static int T2(int x, int y)
    {
        Console.WriteLine("i am from T2");
        Employee obj = new Employee();
        string name = obj.FullName("jach", "Kim");
        Console.WriteLine(name);
        return 100;
    }

    public string FullName(string fn, string ln)
    {
        Console.WriteLine("i am from FullName");
        return fn + ln;


    }

}
*/
/*using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        Employee obj = new Employee();
        obj.A();
        Console.WriteLine("main end");
        Console.ReadLine();
    }

    public void A()
    {
        Console.WriteLine("A() begin");
        Employee obj = new Employee();
        obj.B(20, 10);
        Console.WriteLine("i am from A");
        Console.WriteLine("A() end");
    }

    public int B(int x, int y)
    {
        Console.WriteLine("B() begin");
        Console.WriteLine("i am from B");
        Console.WriteLine("B() end");
        return 100;
    }*/


