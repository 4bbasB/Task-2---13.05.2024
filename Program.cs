namespace Task_2___13._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapan alqoritm.

            //2.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.Məs: 23452, output: 5 , Məs: 456, output: 3

            #region Task 1
            Console.Write("Ededi daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool flag = false;
            while (i <= number / 2)
            {
                if (number % i == 0)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag == false)
                Console.WriteLine("Eded sadedir");
            else
                Console.WriteLine("Eded Murekkebdir");
            #endregion

            #region Task 2
            //Console.Write("Ededi daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int digit = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    digit++;
            //    if (number < 10)
            //        break;
            //    number = number / 10;
            //}
            //Console.WriteLine($"Eded {digit} mertebelidir");
            #endregion


        }
    }
}