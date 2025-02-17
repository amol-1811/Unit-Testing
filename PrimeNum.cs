namespace Unit_Testing
{
    public class PrimeNum
    {
        public static bool IsPrime(int n)
        {
            if(n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n) ; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        
        public static void CheckPrime()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isprime = IsPrime(num); 

            if(isprime)
            {
                Console.WriteLine($"{num} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not prime number");
            }
        }
    }
}
