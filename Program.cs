using System;


namespace C__Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(10), new Table(15), new Table(5) };
            int desiredTable;
            bool IsOpen = true;

            while (IsOpen)
            {
                Console.WriteLine("Hi, what table you want to reserve?");
                Console.WriteLine();

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowData();
                }

                desiredTable = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much?");
                int WishedQuantityOfTables;
                WishedQuantityOfTables = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                bool isReservComplete = tables[desiredTable - 1].IsTableAvailable(WishedQuantityOfTables);

                Console.WriteLine();

                Console.WriteLine("Press 'е' if you want to quit");
                ConsoleKeyInfo key = Console.ReadKey();

                Console.WriteLine();

                if (key.KeyChar == 'e')
                {
                    Console.WriteLine("Thanks for coming");
                    IsOpen = false;
                }
                else
                {
                    Console.WriteLine("Then lets order table?");
                    IsOpen = true;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class Table
    {
        private int _freePlaces;
        private int _maxPlaces;

        public Table(int freePlaces)
        {
            _freePlaces = freePlaces;
            _maxPlaces = _freePlaces;
        }

        public void ShowData()
        {
            Console.WriteLine("Left tables: " + _freePlaces + " max quantity: " + _maxPlaces);
        }

        public bool IsTableAvailable(int quantityOfTables)
        {
            bool Sucseed = false;

            if (_freePlaces > 0 && quantityOfTables <= _freePlaces)
            {
                _freePlaces -= quantityOfTables;
                Sucseed = true;
                Console.WriteLine("Sucseed, please come in");
            }

            else if (_freePlaces <= 0 || quantityOfTables >= _freePlaces)
            {
                Sucseed = false;
                Console.WriteLine("Sorry, but its allready taken or you take too much places");
            }
            return Sucseed;
        }

    }

}





