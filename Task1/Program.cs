Console.WriteLine("Select Three Digit Number = ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 100 && Number < 1000)
{
    Console.WriteLine((Number % 100) / 10);
}
else
    Console.WriteLine("Wrong Number");