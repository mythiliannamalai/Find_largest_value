namespace Find_largest_num
{
    class Program
    {
        public void Calculation()
        {
             int num1,num2,num3;
            Console.WriteLine("enter the number 1 value : ");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 2 value : ");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 3 value : ");
            num3 = int.Parse(Console.ReadLine());
            var Max_value=Math.Max(num1 ,num2 );
            Max_value = Math.Max(Max_value,num3 );
            Console.WriteLine("the largest value is : " + Max_value);
            
        }
    }
    class Result
    {
        public static void Main(string[]args)
        {
            Program program = new Program();
            program.Calculation();
        }
    }
}
