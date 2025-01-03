namespace Methode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //A
            //Console.WriteLine("pleas phonenumber:");
            //string phoneNumber = Console.ReadLine();
            //bool IsValid = IsValidMobileNumber(phoneNumber);
            //Console.WriteLine(IsValid);


            //B
            //Console.WriteLine("Number1 ?");
            //string numberSTR1 = Console.ReadLine();
            //Console.WriteLine("Number2 ?");
            //string numberSTR2 = Console.ReadLine();
            //int number1 = int.Parse(numberSTR1);
            //int number2 = int.Parse(numberSTR2);
            //Console.WriteLine($"Answer: {Zarb(a:number1, b:number2)}");

            //C
            //ShowWellcomMassage();

            //D
            //string welcomeMassage = GetWellcomMassage();

            //E
            //ShowWarWellcomeMassage("Mahdi");

            //F
            //int res = Add(x:15, y:25);

        }
        //A
        static bool IsValidMobileNumber(string mobileNumber)
        {
            if (mobileNumber.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //B
        static int Zarb(int a, int b)
        {
            int result = a * b;
            return result;
        }


        //نه ورودی دارد و نه خروجی
        //C
        static void ShowWellcomMassage()
        {
            Console.WriteLine("Wellcome....");
        }

        //ورودی ندارد اما خروجی دارد
        //D
        static string GetWellcomMassage()
        {
            return "Welcome...";
        }

        //ورودی دارد اما خروجی ندارد
        //E
        static void ShowWarWellcomeMassage(string name)
        {
            Console.WriteLine($"Wellcome {name}....");
        }

        //هم ورودی دارد و هم خروجی دارد
        //F
        static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}

