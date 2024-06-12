//Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),

//Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

//Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

//    Lag et kommandbasert meny i konsollen der du kan:

//Legge til forskjellige brukere som venn (på den som er innlogget)
//Fjerne brukere som venn
//Printe ut en liste av alle man har lagt til som venn
//Velge en av vennene og printe ut profilinformasjonen deres.


//Bruker, info om personen
//Add friend og remove friend, liste med venner
//Liste med randome brukere

using System.Transactions;
using FriendFace;

Bruker MainBruker = new Bruker("Trine", 31, "Trine.Er.Kul@gmail.com", "koding");
List<Bruker> Network = new List<Bruker>()
{
    new Bruker("kåre", 42, "Blabla", "Jogge"),
    new Bruker("Bjarne", 26, "hallu", "klappe hunder"),
};


Main();

void Main()
{
    Console.WriteLine("Welcome to FriendFace " + MainBruker._name);
    Console.WriteLine();

    MainMenu();
}


void MainMenu()
{
    bool active = true;
    while (active)
    {

        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Bruker info");
        Console.WriteLine("2. Meet new people");
        Console.WriteLine("3. Friendlist");

        Console.WriteLine("\nPlease pick an option above:");
        Console.WriteLine();
        string VarInput = Console.ReadLine();
        int Input = Convert.ToInt32(VarInput);
        switch (Input)
        {
            case 1:
                MainBruker.PrintUserInfo();
                break;
            case 2:
                Networking();
                break;
            case 3:
                MainBruker.Showallfriends();
                break;
            case 0:
                Environment.Exit(404);
                break;
            default:
                Console.WriteLine("Please pick a valid option!");
                break;
        }


    }

}


void Networking()
{
    foreach (var bruker in Network)
    {
        bruker.PrintUserInfo();
    }

    bool addingfriend = true;
    while (addingfriend)
    {
        Console.WriteLine("\nto add a friend write their name, exit to return to main menu.");
        string NamesInput = Console.ReadLine();

        if (NamesInput == "exit")
        {
            addingfriend = false;
        }
        //else if (Network.Find(NamesInput =>) == NamesInput)
        else
        {
            var FoundUser = Network.FirstOrDefault(Bruker => MainBruker._name.ToLower() == NamesInput.ToLower());
            if (FoundUser != null)
            {
                /*Console.WriteLine(FoundUser.PrintUserInfo());*/
                //var FoundUser = FindUser(NamesInput);
                MainBruker.AddFriend(FoundUser);
                Console.WriteLine("Halp");
                Console.ReadKey();
                Network.Remove(FoundUser);
            }

            else
            {
                Console.WriteLine("The name does not exist within the network.");
            }
        }
    }
}


Bruker FindUser(string NamesInput)
{
    foreach (var bruker in Network)
    {
        if (bruker._name == NamesInput)
        {
            return bruker;
        }
    }

    return null;
}