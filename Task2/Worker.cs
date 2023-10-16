using System;


namespace Task2
{
    internal class Worker
    {
        private byte _exp;
        public string Name;
        public string Surname;

        public string WorkerCode 
        {
            get => this.Name.Trim()[0].ToString().ToUpper() + this.Surname.Trim()[0].ToString().ToUpper();
        }

        //?
        public byte Experience 
        { 
            get => this._exp;
            set 
            {
                if (value < 0x0)
                {
                    this._exp = 0x0;
                }
                else this._exp = value;
            } 
        }

        public Worker(string name, string surname, byte exp) {
            this.Name = name.Trim();
            this.Surname = surname.Trim();
            this.Experience = exp;
        }
    }
}
