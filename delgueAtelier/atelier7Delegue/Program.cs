// See https://aka.ms/new-console-template for more information

using atelier7Delegue;
Login login = new Login();
string choix = "";

while (choix != "3")
{
    Console.WriteLine("Bienvenue, veuillez choisir une des options suivantes :");
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Inscritption");
    Console.WriteLine("3 - Quitter");
    Console.WriteLine("Choix : ");
    choix = Console.ReadLine();
       
    if (choix == "2")
      {
        Console.Clear();
        login.inscription();
        Console.WriteLine("Compte créé avec succès");
        login.afficherList();
        }
}

