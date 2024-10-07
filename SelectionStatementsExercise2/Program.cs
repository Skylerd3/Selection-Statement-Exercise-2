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
                case "math":
                    Console.WriteLine("I have allways liked Math because its all about solving problems!");
                    break;

                case "sciance":
                    Console.WriteLine("I love sciance because it explanse the whole world!");
                    break;


                case "reading":
                    Console.WriteLine("Reading has never been my strongest but I love to learn from it!");
                    break;

                case "PE":
                    Console.WriteLine("PE has allways been one of my favorits!");
                    break;

                case "writing":
                    Console.WriteLine("Writing was allways hard because Im horible at spelling!");
                    break;

                default:
                    Console.WriteLine("Good choice, thats one is allways interesting!");
                    break;
                    


            }



        }

    }
}