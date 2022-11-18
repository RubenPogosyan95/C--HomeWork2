Console.WriteLine("Write the day of Week - ");
var Number = Convert.ToInt32(Console.ReadLine());


if (Number >= 0 && Number <= 7)
{
    switch (Number)
    {
        case 1:
            Console.WriteLine("Not WeekEnd");
            break;
        case 2:
            Console.WriteLine("Not WeekEnd");
            break;
        case 3:
            Console.WriteLine("Not WeekEnd");
            break;
        case 4:
            Console.WriteLine("Not WeekEnd");
            break;
        case 5:
            Console.WriteLine("Not WeekEnd");
            break;
        case 6:
            Console.WriteLine("WeekEnd");
            break;
        case 7:
            Console.WriteLine("WeekEnd");
            break;
    }
}
else
    Console.WriteLine("Wrong Number");