bool startAgain;
do
{
    Console.WriteLine("Please select a number from 1-100.");
    int number;
    number = Convert.ToInt32(Console.ReadLine());
    {
        if (number % 2 == 1 && number < 60)
        {
            Console.WriteLine("Odd and less than 60");
        }
        else if (number % 2 == 1 && number > 60)
        {
            Console.WriteLine("Odd and greater than 60");
        }

        if (number % 2 != 1 && number < 24)
        {
            Console.WriteLine("Even and less than 25");
        }
        else if (number % 2 != 1 && number <= 60)
        {

            Console.WriteLine("Even and betwen 26 and 60 inclusive.");
        }
        else if (number % 2 != 1 && number > 60)

            Console.WriteLine("Even and greater than 60");

    }

    Console.WriteLine("Would you like to enter another number (yes/no)? If not yes it will be taken as a no");
    string input = Console.ReadLine();
    startAgain = input.ToLower() == "yes";
} while (startAgain == true);
Console.WriteLine ("Thank you for using our service");
