namespace Training;

public class FreqTemp
{
    static void Main(string[] args)
    {
        int x = 0; // Cela servira à la fin du programme : au moment de comparer les températures et leur fréquence.
        int n = x; // ↑ Même fonction : pour garder l'index de x à la fin du programme (au même moment).
        
        
        // Déclaration et initialisation du vecteur (nott. le contenu de ses cases) par des inputs utilisateurs.
        Console.Write("Entrez le nombre de températures : ");
        int nb = int.Parse(Console.ReadLine()!);
        List<int> list = new List<int>();

        for (x = 1; x < nb + 1; x++)
        {
            int value = 99;
            while (value < -20 || value > 40)
            {
                Console.Write("Saisir une température se trouvant entre -20°C et +40°C (temp. n°" + x + ") : ");
                value = int.Parse(Console.ReadLine()!);
                if (value >= -20 & value <= 40)
                {
                    list.Add(value);
                }
            }
        }

        
        // Affichage des températures
        Console.Write("Voici la liste des températures : ");
        for (x = 0; x < nb; x++)
        {
            Console.Write(list[x] + "; "); 
        }

        
        // Voir le début du programme en ce qui concerne les déclarations et instanciations de n et de x.
        Console.WriteLine("\nVoici leur fréquence : ");
        for (x = 0; x < nb; x++)
        {
            int freq = 1;
            for (int y = x + 1; y < nb; y++)
            {
                bool a = list[n].Equals(list[y]);
                if (a)
                {
                    list.RemoveAt(y);
                    freq++;
                    y--;
                    nb--; // éviter le index out of range ??
                }  
            }
            Console.WriteLine(list[x] + " : " + freq);
            n++;
        }
        Console.ReadLine();
    }
}