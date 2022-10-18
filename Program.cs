//Coded by: Ulises Ortega
//Date Revised:10.17.22
//Project Name: What's Your Name?
//Description:
//1)The programe request the user to enter his/her name.
//2)Validate that the user input is not emptry and it's a string not numbers. 
//3)Ask the user to run the program again Yes or Not.

//Review By: 

string userChoice = "";
string userName = "";
do{
Console.WriteLine("Please Type Your Name, press enter after: ");
userName = Console.ReadLine();

//This is to Validate the User Input

if (string.IsNullOrEmpty(userName))
{
  Console.WriteLine("you didn't entered your name, Please type your name!");
}
else
{
  Console.WriteLine("Hello " + userName);
}


//This is to Play Again//  
do
{
    Console.WriteLine("Do you want to Run the Program Again? Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");  

