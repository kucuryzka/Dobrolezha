namespace lab3;

class Program
{
    static int task1(){
         int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++){
            int num = int.Parse(Console.ReadLine());
            int summ = 0;

            while (num / 10 != 0)
            {
                summ += num % 10;
                num /= 10;
            }
            summ += num % 10;

            if (summ % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }


    static int task2(){
         int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++){
            int num = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            while (num / 10 != 0){
                if (num % 10 % 2 == 0)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
                num /= 10;
            }

            if (num % 10 % 2 == 0){
                odd++;
            }
            else{
                even++;
            }

            if (odd > even){
                count++;
            }

        }

        return count;

    }


    static void Main(string[] args)
    {
        System.Console.WriteLine(task2());

    }
}
