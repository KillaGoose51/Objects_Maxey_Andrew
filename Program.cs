// See https://aka.ms/new-console-template for more information
using Objects_Maxey_Andrew;
// makes a new object called computer with 3 different values
Computer myComputer = new Computer("Apple", "All-in-One", true);
IBootUp myBootUp = myComputer; // Makes myBootUp = myComputer which makes 
Console.WriteLine(myComputer.Equals(myBootUp));//this true
// makes a new object called othercomputer with 3 different values
Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
Console.WriteLine(myComputer.Equals(myOtherComputer));
//makes the string = a object computer that then gets turned into a string
string myString = myComputer.ToString();
string myOtherString = myString;
// makes myString have a value of "Hi"
myString = "Hi!";
//prints out the strings
Console.WriteLine(myString);
Console.WriteLine(myOtherString);

// makes the stringfs into computer objects that are turned into strings
Console.WriteLine(myString == myComputer.ToString());
Console.WriteLine(myString == myOtherComputer.ToString());
// prints the type of the computer and boot up
Console.WriteLine(myComputer.GetType());
Console.WriteLine(myBootUp.GetType());
//calls for the computer to power off
myOtherComputer.PowerOnOff();
// prints it all again to show that it was turned off
Console.WriteLine(myString == myOtherComputer.ToString());
Console.WriteLine(myString);
Console.WriteLine(myOtherComputer.ToString());
//prints whatever string has the letter "i" in it
Console.WriteLine(myString.Contains('i'));
// prints out myString in capitals
Console.WriteLine(myString.ToUpper());