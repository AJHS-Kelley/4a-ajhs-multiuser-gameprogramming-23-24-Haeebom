// Naomi Williams, Example Game Methods, v0.1
using System;
// Time to learn language
// Do you want to get paid from learning this language
// ask the player what they want to do.
// collect users response in a variable
// string.StartsWith("x") will check to see if a string starts with that letter, returns true if it does. 

<<<<<<< HEAD
namespace language 
=======
/*
No for loop. 
No while loop. 
Missing parameters for methods. 
*/ 


namespace languagepicker
>>>>>>> fd2eef215dc181bcd2f85ed00a9ad0004e601052
{
    class person
    {
      static string difficulty = "Empty";
      static string language()
       {
         Console.WriteLine("Would you like to learn a language?\n");
         string answer = Console.ReadLine().ToLower();
         if (answer == "yes") 
         {
            Console.WriteLine(" Would you like to learn Spanish, Russian, Japanese, or Chinese\n");
            answer = Console.ReadLine().ToLower();
            if (answer == "spanish")
            { 
              Console.WriteLine(" You've selected Spanish!\n");
              difficulty = "Easy"; 
            } else if (answer == "japanese") {
           Console.WriteLine("You've selected Japanese \n"); 
            difficulty = "Medium";
          }else if (answer == "russian")
         {
          Console.WriteLine("You've selected Russian\n");
         
         }else if (answer == "chinese")
         {
         Console.WriteLine("You've selected Chinese\n");
         }

         } else if (answer == "no") // answer.ToLower().StartsWith("n"); 
         {
          Console.WriteLine("No language for you !!\n");
         }
         return answer;
       } 

       static void spanish()
       {
         Console.WriteLine("You can learn from duolingo!https://www.duolingo.com/\n");
      
       }
       static void japanese()
       {
        Console.WriteLine("You can learn from japanese pod 101! https://www.japanesepod101.com/free-lifetime-account?src=gc_learn_search_brandedsearch_japanese-brand_usa_c__392829551250_&gad_source=1&gclid=EAIaIQobChMIuO\n");        
       }
       static void russian()
       {
        Console.WriteLine("You can learn from Russian for free!https://www.russianforfree.com/lessons-russian-language-01.php\n");        
               }
       static void chinese()
       {
        Console.WriteLine("You can learn from Mandarin blueprint!https://www.mandarinblueprint.com/blog/best-way-to-learn-mandarin/\n");        
        
       }
         static void Main(string[] args)  
        {
        
         
         int time = 0;
         bool pay = false;
         string option = language();      
         if(option == "spanish")
         {
          spanish();
         } else if (option == "japanese")
         {
          japanese();
         }else if (option == "russian")
         {
          russian();
         }else if (option == "chinese")
         {
          chinese();
         }
        

       }  

    }
}

// code review by: Ashley