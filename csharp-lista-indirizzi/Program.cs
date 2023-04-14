namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TRY CATCH TEST

            //bool error = false;

            ////Riprovo ogni volta che error è false
            //while (!error)
            //{

            //    try
            //    {
            //        Console.WriteLine("Nome: ");
            //        string nome = Console.ReadLine();
            //        Console.WriteLine("Cognome: ");
            //        string cognome = Console.ReadLine();

            //        Persona persona = new Persona(nome, cognome);
            //        error = true;
            //    }
            //    catch (ArgumentNullException)
            //    {
            //        Console.WriteLine("Il nome non può essere Nullo!");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Errore Generale");
            //    }

            //}


            //EXERCISE

            List<Address> addresses = new List<Address>();


            StreamReader testo = File.OpenText("C:\\Users\\vince\\Desktop\\TestFile\\addresses.csv");

            while (!testo.EndOfStream)
            {
                string? line = testo.ReadLine();

                try
                {
                    string[] camp = line.Split(',');
                    Console.WriteLine($"Name: {camp[0]}");
                    Console.WriteLine($"Last: {camp[1]}");
                    Console.WriteLine($"Street: {camp[2]}");
                    Console.WriteLine($"City: {camp[3]}");
                    Console.WriteLine($"Province: {camp[4]}");
                    Console.WriteLine($"ZIP: {camp[5]}");

                    addresses.Add(new Address(camp[0], camp[1], camp[2], camp[3], camp[4], camp[5]));
                    Console.WriteLine("\n------------------\n");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Argomenti nulli!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Qualcosa è andato storto!");
                }
            }
            
            testo.Close();


        }
    }
}