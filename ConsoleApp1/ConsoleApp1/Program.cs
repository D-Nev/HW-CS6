namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        //1
        static void SizeCube(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string(symbol, size));
            }
        }


        //2
        long number;
        public bool Palindrom()
        {
            var a = number.ToString();
            var b = new string(number.ToString().Reverse().ToArray());
            return a == b;
        }

        //3
        static int[] Filter(int[] orgnl, int[] filter)
        {
            return orgnl.Where(x => !filter.Contains(x)).ToArray();
        }

        //4
        class Website
        {
            string name;
            string url;
            string descrips;
            string ip;

            public void Input(string name, string url, string descripts, string ip)
            {
                this.name = name;
                this.url = url;
                this.descrips = descripts;
                this.ip = ip;
            }

            public void Displ()
            {
                Console.WriteLine($"Вебсайт: {name}, Ссылка: {url}, Описание: {descrips}, Айпи: {ip}");
            }
        }


        //5
        class Journal
        {
             string title;
             int year;
             string descrip;
             string phone;
             string email;

            public void Input(string title, int year, string descrip, string phone, string email)
            {
                this.title = title;
                this.year = year;
                this.descrip = descrip;
                this.phone = phone;
                this.email = email;
            }

            public void Displ()
            {
                Console.WriteLine($"Журнал: {title}, Год: {year}, Описание: {descrip}, Телефон: {phone}, Емейл: {email}");
            }
        }


        //6
        class Shop
        {
            string name;
            string address;
            string profile;
            string phone;
            string email;

            public void Input(string name, string address, string profile, string phone, string email)
            {
                this.name = name;
                this.address = address;
                this.profile = profile;
                this.phone = phone;
                this.email = email;
            }

            public void Displ()
            {
                Console.WriteLine($"Магазин: {name}, Адресс: {address}, Профиль: {profile}, Телефон: {phone}, Емейл: {email}");
            }
        }

        static void Line()
        {
            Console.WriteLine("\n--------------------------------------------");
        }
    }
}
