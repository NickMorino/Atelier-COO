// See https://aka.ms/new-console-template for more information

using atelier7Delegue;
Login login = new Login();
Abonne abonne = new Abonne();
string choix = "";

while (choix != "4")
{
    Console.WriteLine("Bienvenue, veuillez choisir une des options suivantes :");
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Inscritption");
    Console.WriteLine("3- Changer encryption");
    Console.WriteLine("4 - Quitter");
    Console.WriteLine("Choix : ");
    choix = Console.ReadLine();
       
    if (choix == "3")
      {
        login.changerEncrytpion(new TypePourDelegue(abonne.encryptionBetter));
      }
}

