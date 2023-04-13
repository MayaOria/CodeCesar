using System;

namespace Code_César
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme de encryptage selon le Code César");
            Console.WriteLine("Quel(le) mot/phrase souhaitez-vous encrypter ?");

            string mot = Console.ReadLine();
            string mot_crypte = "", mot_crypte2 = "";
            

            foreach (char l in mot)
            {
                int l_code = l + 2;
                mot_crypte += (char)l_code;
            }

            Console.WriteLine("Votre message codé : " + mot_crypte);

            //avec methode toCharArray

            char[] liste_lettres = mot.ToCharArray();
            for (int i = 0; i <= liste_lettres.Length - 1; i++)
            {
                int lettre_crypte = liste_lettres[i] + 2;
                mot_crypte2 += (char)lettre_crypte;
            }

            Console.WriteLine("Votre message codé avec la méthode ToCharArray: " + mot_crypte2);


        }
    }
}
