using System.Collections.Generic;

//Console Settings:
Console.Title = "Area 51";
Console.ForegroundColor = ConsoleColor.Green;


/*The Console Object:
Console.WriteLine("Area 51 | Login ");

Console.WriteLine("Username:");
string userName = Console.ReadLine();

Console.WriteLine("Password:");
string passWord = Console.ReadLine();

Console.WriteLine(userName+" | "+passWord);*/


// Variables
double number01 ;
double number02 ;
double number03 ;

// Console.Write("Input a Number:");

//By Default the Console accepts and displays info as a string. so we have to convert what we are going to input to the data type we need.
// number01 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input a Second Number:");
// number02 = Convert.ToDouble(Console.ReadLine());

// double answer = number01 * number02;
// Console.Write("The Result is :" + answer);

//This Code Calculates the Average of three numbers:
// Console.WriteLine("This Application Gives you the average of three numbers:");

// Console.Write("Input a Number:");
// number01 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input a Number:");
// number02 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input a Number:");
// number03 = Convert.ToDouble(Console.ReadLine());

// double answer = (number01+number02+number03)/3;

// Console.Write("The average of the three numbers " + number01 +","+number02+", and "+number03 + " is " + answer);


// Conditional Statements
// int cash;

// Console.WriteLine("Buy a Movie Ticket. Price is $5.\nDeposit your Amount:");
// cash = Convert.ToInt32(Console.ReadLine());

// if(cash<5){
//     Console.WriteLine("The Deposit is not enough.");
// }
// else if(cash == 5){
//     Console.WriteLine("Here's Your Ticket!");
// }
// else{
//     Console.WriteLine("Here's your ticket, with a change of : " + (cash-5) + " dollars" );
// }


//Loops

// For Loops:
// Console.WriteLine("How many numbers should be displayed?");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 0; i<number; i++){
//     //the increment variable, the condition, and what should happen after each loop
//     double result = Math.Pow(2,i);
//     Console.WriteLine(result);
// }

//While Loops:
// while(){
    
// }

//List and Arrays:
string[] favoriteGames = {"Uncharted:Lost Legacy", "Ghost of Tsushima", "GTA V"};
// Console.WriteLine(favoriteGames[1]);

// for (int i = 0; i < favoriteGames.Length; i++)
// {
//     int ranking = i + 1;
//     Console.WriteLine(ranking +". "+favoriteGames[i]);   
// }

string[] yourFavGames = new string[5];

Console.WriteLine("Type In your Favourite Games:");

for (int i = 0; i < yourFavGames.Length; i++)
{
    yourFavGames[i] = Console.ReadLine();
}

Array.Sort(yourFavGames);

for (int i = 0; i < yourFavGames.Length; i++)
{
    Console.WriteLine(yourFavGames[i]);
}

//Lists: Arrays but we don't have to specify the length:
List<string> shoppingList = new List<string>();

shoppingList.Add("Dreams");
shoppingList.Add("Miracles");
shoppingList.Add("Ponies");

for (int i = 0; i < shoppingList.Count ; i++)
{
    Console.WriteLine(shoppingList[i]);
}

//Remove Items From List
shoppingList.Remove("Dreams");
//or
shoppingList.RemoveAt(2);