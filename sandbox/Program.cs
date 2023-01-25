namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string path1;
            string path2;

            Console.WriteLine("type de sauvegarde :");
            Console.WriteLine("1 - Sauvegarde Complète (default)");
            Console.WriteLine("2 - Sauvegarde Incrementale");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("chemin de sauvegarde initial :");
            path1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("chemin de sauvegarde final :");
            path2 = Convert.ToString(Console.ReadLine());

            Program p = new Program();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sauvegarde Complète");
                    p.Complete(path1, path2);
                    break;
                case 2:
                    Console.WriteLine("Sauvegarde Incrementale");
                    break;
                default:
                    Console.WriteLine("Sauvegarde Complète");
                    break;
            }

            
        }

        void Complete(string PathFrom, string PathTo)
        {
            Console.WriteLine("Vérification de l'existance du dossier..........");
            if (System.IO.Directory.Exists(PathFrom))
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(PathFrom, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(PathFrom, PathTo));
                }
                Console.WriteLine("Copie en cours..........");
                foreach (string newPath in Directory.GetFiles(PathFrom, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(PathFrom, PathTo), true);
                }
            }
        }
    }
}