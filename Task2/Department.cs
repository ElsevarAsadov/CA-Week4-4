using System;


namespace Task2
{
    internal class Department
    {
        public string Name;
        public Worker[] Workers = Array.Empty<Worker>();

        public Department(string name) {

            this.Name = name;
        }

        public void AddWorker(Worker wk)
        {

            Array.Resize(ref this.Workers, this.Workers.Length + 1);
            this.Workers[^1] = wk;

        }

        public Worker SearchWorker(string name)
        {

            foreach (Worker w in this.Workers)
            {
                if (name.ToLower().Trim() == w.Name.ToLower())
                {
                    return w;
                };

            }

            return null;
        }

        public Worker SearchWorker(byte minExp, byte maxExp)
        {

            foreach (Worker w in this.Workers)
            {
                if (w?.Experience >= minExp && w?.Experience <= maxExp)
                {

                    return w;
                }
            }
            return null;
        }

        public void ShowAllWorkers() {
            bool found = false;
            foreach (Worker w in this.Workers)
            {
                found = true;
                Console.WriteLine($"{w.Name} - {w.Surname} - {w.Experience}");
            }
            if(!found) Console.WriteLine("\n\n\n----there is no worker-----\n\n\n");

        }
    }
}
