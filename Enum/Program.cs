namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var User = new User();
            User.Nom = "Tutu";
            User.Prenom = "Toto";
            User.Ecolors = Ecolors.Jaune;
            var User2 = new User();
            User2.Nom = "Tata";
            User2.Prenom = "Titi";
            User2.Ecolors = Ecolors.Jaune;
            var User3 = new User();
            User3.Nom = "Pololo";
            User3.Prenom = "Palala";
            User3.Ecolors = Ecolors.Rouge;
            List<User> list = new List<User>();
            list.Add(User);
            list.Add(User2);
            list.Add(User3);
            foreach (User o in list)
            {
                Console.WriteLine("Nom : "+ o.Nom);
                Console.WriteLine("Prenom : " + o.Prenom);
                Console.WriteLine("Couleur : " + o.Ecolors);
                Console.WriteLine();
            }
            static int CountOccurenceOfValue(List<User> list, Ecolors valueToFind)
            {
                return ((from temp in list where temp.Ecolors.Equals(valueToFind) select temp).Count());
            }
            Console.WriteLine("Jaune "+ CountOccurenceOfValue(list,Ecolors.Jaune)+ " utilisateurs");
            Console.WriteLine("Rouge " + CountOccurenceOfValue(list, Ecolors.Rouge) + " utilisateurs");
            // Console.WriteLine(list.ToArray());

        }
    }
}
