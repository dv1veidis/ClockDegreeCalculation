class ClockArrowDegreeCalculator
{
    public static void Calculation(int hours, int minutes)
    {
        int minuteHand = 360/60 * minutes;
        double hourHand = 360 / 12 * hours + minutes * 0.5;
        double result = Math.Abs(minuteHand - hourHand);
        if (result > 180)
        {
            Console.WriteLine(360-result);
        }
        else
        {
            Console.WriteLine(result);
        }
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            while (hours < 0 || hours > 24)
            {
                Console.WriteLine("Hours must be between 0 and 24:");
                hours = Convert.ToInt32(Console.ReadLine());
            }
            if (hours > 12)
            {
                hours -= 12;
            }
            Console.WriteLine("Enter the minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            while (minutes < 0 || minutes > 60)
            {
                Console.WriteLine("Minutes must be between 0 and 60:");
                minutes = Convert.ToInt32(Console.ReadLine());
            }
            Calculation(hours, minutes);
        }
        catch(Exception error)
        {
            Console.WriteLine(error.Message.ToString());
        }
        return;
    }
}

