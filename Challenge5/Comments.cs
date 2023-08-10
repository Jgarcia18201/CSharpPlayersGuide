// See https://aka.ms/new-console-template for more information
Console.WriteLine("What kind of thing are we talking about?"); //This line asks what kind of thing it is
string a = Console.ReadLine(); //User input
Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); //This line asks user to pick an adjective
string b = Console.ReadLine(); //User input
/* The below lines add Doom and 3000 to the final statement
*/
string c = "Doom";
string d = "3000";
//This final line outputs the string starting with "The", then string b, then string a, then "of", then string c, then string d and !
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

/*Aside from comments, what else could you do to make this code more understandable? Write cleaner code. For instance, include 
Doom and 3000 in a single variable. 
*/