// See https://aka.ms/new-console-template for more information
using LearninTime;

Console.WriteLine("Start");

Gamer steve = new Gamer { Name = "Steve", Gender = "Man", FavouriteGame = "Goat Simulator" };
Fashionista jamie = new Fashionista { Name = "Jamie", Gender = "Indeterminate", FavouriteDress = "Sundress", FavouriteTrousers = "Chinos" };

List<Person> people = new () { steve, jamie };

foreach(Person person in people)
{
    Console.WriteLine($"This person's name is {person.Name}. Their gender is {person.Gender}");

    if (person is Gamer)
    {
        Gamer gamerPerson = (Gamer)person;

        Console.WriteLine($"This person is a gamer and their favourite game is {gamerPerson.FavouriteGame}");
    }
}