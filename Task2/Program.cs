namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Department Name:");
            string name = Console.ReadLine();

            Department dp = new Department(name);


            string menu = "";
            do
            {
                if (menu == "")
                {
                    Console.WriteLine("\n\n\n0)exit\n1)create worker\n2)search worker by name\n3)search by experience\n4)show all workers\n\n\n");
                    menu = Console.ReadLine().Trim();

                }

                switch (menu)
                {
                    case "0":
                        menu = "0";
                        break;
  
                    case "1":
                        menu = "1";
                        Console.WriteLine("name:");
                        string wname = Console.ReadLine();

                        Console.WriteLine("surname:");
                        string wsur = Console.ReadLine();

                        Console.WriteLine("experience:");
                        string exp = Console.ReadLine();

                        if (!Byte.TryParse(exp, out byte wexp))
                        {
                            Console.WriteLine("invalid data retrying...");
                            continue;
                        }

                        dp.AddWorker(new Worker(wname, wsur, wexp));


                        Console.WriteLine($"\n\n\nworker successfully added {wname} - {wsur} - {wexp}\n\n\n");


                        menu = "";

                        break;    

                    case "2":
                        Console.WriteLine("worker name:");
                        Worker wk = dp.SearchWorker(Console.ReadLine());

                        Console.WriteLine(wk?.Name != null ? $"\n\n\n{wk.Name} - {wk.Surname} - {wk.Experience}" : "\n\n\n----there is no such worker----\n\n\n");
                       
                        menu = "";
                        break;

                    case "3":
                        menu = "3";
                        
                        Console.WriteLine("enter experience min level");
                        string _ = Console.ReadLine();

                        Console.WriteLine("enter experience max level");
                        string __ = Console.ReadLine();

                        bool checkMin = Byte.TryParse(_, out byte min);
                        bool checkMax = Byte.TryParse(__, out byte max);

                        if (!checkMin || !checkMax) {
                            Console.WriteLine("\n\n\n----invalid experience values----\n\n\n");
                            continue;
                        };

                        wk = dp.SearchWorker(min, max);

                        Console.WriteLine(wk?.Name != null ? $"\n\n\n{wk.Name} - {wk.Surname} - {wk.Experience}" : "\n\n\n----there is no such worker----\n\n\n");

                        menu = "";
                        break;

                    case "4":
                        dp.ShowAllWorkers();
                        menu = "";
                        break;

                    default:
                        Console.WriteLine("\n\n\n-----invalid command------\n\n\n");
                        menu = "";
                        break;

                }



            }
            while (menu != "0");
        }
    }
}