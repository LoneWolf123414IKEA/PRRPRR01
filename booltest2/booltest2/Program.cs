using System;
namespace booltest2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> abdi = new();
            abdi.Add("Abdi");
            abdi.Add("Abdulhakim");
            List<string> pontus = new();
            pontus.Add("Pontus");
            pontus.Add("Lone");
            pontus.Add("IKEA");
            Console.WriteLine("Please enter a name or nickname:");
            string search = Console.ReadLine();
            if (abdi.Contains(search))
            {
                Console.WriteLine("first name: Cabdixakiin\nLast name: Khadar\nMiddle name(s): Caqli\nNickname(s): Abdi, Abdulhakim, Adam, Adamhakim\nGender: M\nPronouns: He/Him\nLikes: Chai Tea, Food");
            }
            if (pontus.Contains(search))
            {
                Console.WriteLine("first name: Pontus\nLast name: Kans\nMiddle name(s): Erik, Samuel\nNickname(s): Lone, IKEA, SCP 3008, Freja\nGender: N/A\nPronouns: Any/All\nLikes: black Tea, audio tech");
            }
        }
    }
}