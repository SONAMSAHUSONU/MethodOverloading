/*using System;

    class Method1
    {
    static void Main()
    {
        Console.WriteLine("Start");
       int total= Method1.GetSum(10,20,40);
        Console.WriteLine(total);
        Method1 obj = new Method1();
        string Fullname=obj.GetSum("Sonam", "Sahu");
        Console.WriteLine(Fullname);
        obj.GetSum();
        Console.ReadLine();
    }
    public void GetSum()
    {
        Console.WriteLine("the number of parameter is 0");
    }
    public static int GetSum(int X, int Y, int Z)
    {
        Console.WriteLine("I am sum Method");
        return X + Y + Z;
    }
    public String GetSum(string Fname, String Lname)
    {
        return Fname + " " + Lname;
    }
    }*/
    
//method overloading example
/*using System;

class Method1
{
    static void Main()
    {
        Console.WriteLine("Start");
        Whatsapp();
        Console.WriteLine(100);
        Method1 obj = new Method1();
        string Name=obj.Whatsapp("Sonam");
        Console.WriteLine(Name);
         obj.Whatsapp(101,102);
        string UserDetails=obj.Whatsapp(7411961671,333322211,"ICICI003");
        Console.WriteLine(UserDetails);
        Console.ReadLine();
    }
    public static int Whatsapp()
    {
        Console.WriteLine("This is Whatsapp Method");
        return 100;
    }
    public string Whatsapp(string UserName)
    {

        return UserName;
    }
    
    public int  Whatsapp( int UserIdX, int UserIdY)
    {
        Console.WriteLine("UserIdX: " + UserIdX);
        Console.WriteLine("UserIdY: " + UserIdY);
        return 1000;
    }
    public string  Whatsapp(long UserMobileNum, int UserAccountNum, string UserIfcCord)
    {
        Console.WriteLine("User account details");
        String AccountDetails = UserMobileNum + " " + UserAccountNum + " " + UserIfcCord;
        return AccountDetails;
    }

}*/
