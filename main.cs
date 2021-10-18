using System;

class Program {

public static void IsPalindrome(string ptest)
{
   string reversedStr = "";
    

    for(int counter = ptest.Length -1; counter >= 0; counter--)
    {
        reversedStr = reversedStr + ptest[counter].ToString();
    
    }

    if(reversedStr == ptest)
    {
        Console.WriteLine($"The word: [{ptest}] is a palindrome, with a length of: {ptest.Length} \n");
            
    }
    else
    {
        Console.WriteLine($"The word: [{ptest}] is not a palindrome \n");
    }

}


  public static void Main (string[] args) {
    

string userInput = "";
bool theLoop = true;




do
{
   Console.WriteLine("Please enter in the word to check if it is a palindrome or not ");
   userInput = Console.ReadLine();

   userInput.Trim();

   IsPalindrome(userInput.ToLower());

   Console.WriteLine("Would you like to exit or go again? Type exit to stop the program or Yes to continue");
   userInput = Console.ReadLine();

   if(userInput.ToLower() == "exit")
   {
       
        theLoop = false;
        //Or could of done this:
        //break; 
   }

}
while(theLoop);
{
    Console.WriteLine();
    Console.WriteLine("Thank you for using the system \n ");
}



  }
}