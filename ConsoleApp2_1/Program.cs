
namespace ConsoleApp2_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int x = 1;


            MyList<String> list = new MyList<String>();

            while (x != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ввелите код выполнения функции, иначе введите НОЛЬ(!!!!) для выхода из программы:");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: AddElement(list); break;

                    case 2: RemoveAtElement(list); break;

                    case 3: RemoveElement(list); break;

                    case 4: ClearList(list); break;

                    case 5: SortElement(list); break;
                }

            }
        }

        private static void AddElement(MyList<string> list)
        {
            Console.WriteLine("Введите сколько элементов будет вставленно в массив:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string userInput;
                Console.WriteLine($"Ввод элемента под номером {i} : ");
                userInput = Console.ReadLine();
                list.Add(userInput);
            }

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        static void RemoveAtElement(MyList<string> list)
        {
            Console.WriteLine($"Введите(!!) индекс элемента, который нужно удалить: ");
            int n = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(n);

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }

        }

        static void RemoveElement(MyList<string> list)
        {
            Console.WriteLine($"Введите(!!) элемент, который нужно удалить: ");
            string n = Convert.ToString(Console.ReadLine());
            list.Remove(n);

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }

        }

        static void ClearList(MyList<string> list)
        {
            list.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        static void SortElement(MyList<string> list)
        {
            list.SortElement();

            for (int i = 0; i < list.Count; i++)
            {
                list.Print(i);
            }
        }

        /*
         
        static void AddRange(List<string> starList)
        {
            Random random = new Random();
            string[] randomTarget = new string[8] { "Venitate", "Vega", "Mircam", "Talina", "Vita", "Isida", "Hedus", " Maara" };

            Console.WriteLine("Введите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] targetArray = new string[n];
            for (int i = 0; i < targetArray.Length; i++)
            {
                targetArray[i] = (randomTarget[random.Next(randomTarget.Length)]);
                Console.WriteLine($" A [ {i} ] = {targetArray[i]} ");
            }

            starList.AddRange(targetArray);

        }

        */
    }
}