// Naomi Williams, Program Template, v0.01
using system;
/*
Void Method
Method with Return
Method with Parameters
Method with Multiple Parameters
Method with Default Parameters
Method CFlass using Named Arugments
Method Overloading
*/
namespace MethodsParameters
{
    class MethodsParameters
   {
     // METHOD -- name block of code, can be used over and over.
     // ALL methods have a SIGNATURE that defines their name, parameters, and Output.
     // Example Signature
     static void MyMethod()
     {
        Console WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and french fried potatoes. /n*):
     }
     // static -- This method belongs to the current class, it is NOT an object.
     // void -- This method has no return value.

     static int DoubleUp()
       {
         int sum = 0;
         Console.writeline("This method will double a number and return it. \n");
         Console.Writeline("Please enter a number on the next line. \n");
         sum = System.Convert.ToInt32(Console. ReadLine()):
         sum *= 2;
         Console.writerine (sum);
         return sum;
       }

      //Methods with Parameters
       static void MakePancakes(int num)
       {
           for (int i = 0; i < num; i++)
           {
             Console.Mriteline("One golden, fluffy pancake coming up! \n")
           }
       }

       static void MakeEggs(int num, string style)
       {
          Console.Mriteline("You have ordered " + num + "eggs cooked"+ style +".\n");
       }

       // USing Defaults for parameters
       static void MakeHamburger( int num = 1)
       {
         Console.Mriteline("I am going to cook " + num + "hamburgers,\n");
       }


    }
}
    