using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier7Delegue
{
    public delegate string TypePourDelegue(string password);

    internal class Login
    {
        List<User> listUser;
        public TypePourDelegue encryptionModif;

        public Login ()
        {
            listUser = new List<User> ();
            encryptionModif = new TypePourDelegue(encryptionDefault);
        }
        public bool identificatiom()
        {
            Console.WriteLine("Entrez un nom d'utilisateur : ");
            string username = Console.ReadLine();
            Console.WriteLine("Entrez un mot de passe : ");
            string password = Console.ReadLine();

            foreach (var user in listUser)
            {
                if (user.Username == username && user.Password == encryptionModif(password))
                {
                    return true;
                }
            }
            return false;
        }

        public void inscription()
        {
            Console.WriteLine("Entrez un nom d'utilisateur : ");
            string username = Console.ReadLine();
            Console.WriteLine("Entrez un mot de passe : ");
            string password = Console.ReadLine();

            if (username != null && password != null)
            {
                listUser.Add(new User(username, encryptionModif(password)));
            }
        }

        public string encryptionDefault(string password)
        {
            return password + "*!*!";
        }
        public void afficherList() {
            foreach (var user in listUser)
            {
                Console.WriteLine(user.Username + user.Password);
            }
        }
        
        public void changerEncrytpion (TypePourDelegue encryption)
        {
            encryptionModif = encryption;
        }
    }    
}
