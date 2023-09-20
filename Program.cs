namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new();
            try
            {
                person.Age = 10;
                person.FName = "Kalle";
                person.LName = "Larsson";
                person.Height = (float)1.70;
                person.Weight = (float)93.2;

                /*
                * Fråga: Kommer du direkt åt variablerna?
                * Svar Nej! Jag använder variablernas properties för åtkomst.
                */

            }
            catch (AccessViolationException exception) 
            { 
                Console.WriteLine(exception.Message);
            }


        }
    }
}