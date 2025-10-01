namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            string schoolSubject = Console.ReadLine();
            FavoriteSchoolSubject(schoolSubject);
        }

        static void FavoriteSchoolSubject(string schoolSubject)
        {
            switch (schoolSubject.ToLower())
            {
                case "math":
                case "mathematics":
                    Console.WriteLine("Go Green! Pure Mathematics was my major during my time at MSU!");
                    break;
                case "science":
                    Console.WriteLine("I dabbled in chemistry.");
                    break;
                case "history":
                case "social studies":
                    Console.WriteLine("My mother's high school history teacher waked out of the classroom leaving the exam answers on his desk!");
                    break;
                case "art":
                    Console.WriteLine("I took art lessons when I was a teenager!");
                    break;
                case "physical education":
                case "pe":
                case "gym":
                    Console.WriteLine("Some regret skipping PE. I regret skipping PE enrollment.");
                    break;
                default:
                    Console.WriteLine("Interesting String");
                    break;
            }
        }
    }
}