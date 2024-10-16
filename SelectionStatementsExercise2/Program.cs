namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();


            switch (favSubject)
            {
                case "Math" or "math":
                    Console.WriteLine("Good choice, I have allways liked Math because its all about solving problems!");
                    break;

                case "Sciance" or "sciance":
                    Console.WriteLine("Good choice, I love sciance because it explanse the whole world!");
                    break;


                case "Reading" or "reading":
                    Console.WriteLine("Good choice, Reading has never been my strongest.");
                    break;

                case "PE" or "Pe" or "pe":
                    Console.WriteLine("Good choice, PE has allways been one of my favorits!");
                    break;

                case "Writing" or "writing":
                    Console.WriteLine("Good choice, Writing was allways hard because Im horible at spelling!");
                    break;

                default:
                    Console.WriteLine("Good choice, thats one is allways interesting!");
                    break;
                    


            }



        }

    }
}