string folderPath = @"C:\Users\User\source\repos\Week8EpicGame\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = { "Superman", "Batman", "Luke Skywalker", "Captain America" };
//string[] villains = { "Joker", "Darth Vader", "Lex Luthor", "Voldemort", "Frankenstein" };

string[] weapons = { "magic wand", "wooden sword", "hammer", "stone axe", "burger" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random(); 
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
