namespace PrimoProgetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Esercizio 1: Stampa di una stringa a piacere
            Console.WriteLine("Questa è una stringa di prova.");

            // Esercizio 2: Stampa la somma di due numeri
            int numero1 = 5;
            int numero2 = 4;
            int somma = numero1 + numero2;
            Console.WriteLine("Somma: " + somma);

            // Esercizio 3: Elenco che stampa lista della spesa
            string articolo1 = "Pane";
            string articolo2 = "Latte";
            string articolo3 = "Biscotti";
            string articolo4 = "Pasta";
            string articolo5 = "Uova";

            Console.WriteLine("Lista della Spesa:");
            Console.WriteLine(articolo1);
            Console.WriteLine(articolo2);
            Console.WriteLine(articolo3);
            Console.WriteLine(articolo4);
            Console.WriteLine(articolo5);

            // Esercizio 4: Lista della spesa con articoli separati da una virgola
            string listaCompatta = articolo1 + ", " + articolo2 + ", " + articolo3 + ", " + articolo4 + ", " + articolo5;
            Console.WriteLine("Lista compatta della Spesa: " + listaCompatta);

            // Esercizio 5: Visualizzare il nome all'interno di un rettangolo
            string nome = "Salvatore";
            int lunghezzaRettangolo = nome.Length + 4;

            Console.WriteLine("+" + new string('-', lunghezzaRettangolo - 2) + "+");
            Console.WriteLine("| " + nome + " |");
            Console.WriteLine("+" + new string('-', lunghezzaRettangolo - 2) + "+");

            // Esercizio 6: Creare delle classi in C# che contengano almeno tre attributi
            Animale cane = new Animale
            {
                Nome = "Rambo",
                Specie = "Cane",
                Eta = 5
            };
            cane.Descrizione();

            Automobile auto = new Automobile
            {
                Marca = "Fiat",
                Modello = "Panda",
                Anno = 2020
            };
            auto.Descrizione();

            Appartamento appartamento = new Appartamento
            {
                Indirizzo = "Via Roma 10",
                NumeroStanze = 3,
                Superficie = 85.5
            };
            appartamento.Descrizione();
        }

        public class Animale
        {
            public string Nome { get; set; }
            public string Specie { get; set; }
            public int Eta { get; set; }

            public void Descrizione()
            {
                Console.WriteLine("Animale: Nome: " + Nome + ", Specie: " + Specie + ", Età: " + Eta + " anni.");
            }
        }

        public class Automobile
        {
            public string Marca { get; set; }
            public string Modello { get; set; }
            public int Anno { get; set; }

            public void Descrizione()
            {
                Console.WriteLine("Automobile: Marca: " + Marca + ", Modello: " + Modello + ", Anno: " + Anno + ".");
            }
        }

        public class Appartamento
        {
            public string Indirizzo { get; set; }
            public int NumeroStanze { get; set; }
            public double Superficie { get; set; }

            public void Descrizione()
            {
                Console.WriteLine("Appartamento: Indirizzo: " + Indirizzo + ", Stanze: " + NumeroStanze + ", Superficie: " + Superficie + " mq.");
            }
        }
    }
}
