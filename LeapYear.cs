namespace Unit_Testing
{
    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            return (year %4 == 0 && year %100 != 0) || (year % 400 == 0);   
        }

        public static void CheckLeap()
        {
            Console.Write("Enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is a not a Leap year.");
            }
        }
    }
}
