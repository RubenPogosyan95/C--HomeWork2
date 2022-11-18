Console.WriteLine("Select Number = ");
int num = Convert.ToInt32(Console.ReadLine());

int index = 0;
int discount = 1;

//Узнаем Размер Числа
int size = num.ToString().Length;

//Проверка на Отрицательное число
if (num < 0)
{
    if (size >= 4)
    {
        //Узнаем На что делить число чтобы получить ТрехЗначное
        while (index < size - 4)
        {
         discount = discount * 10;
         index++;
        }
    Console.WriteLine((num / discount) % 10);
    }  
    else
        Console.WriteLine("Number is't third-digit");
}       
else
    //Число Положительное
    if (size >= 3)
    {
    
        //Узнаем На что делить число чтобы получить ТрехЗначное
        while (index < size - 3)
        {
            discount = discount * 10;
            index++;
        }
    Console.WriteLine((num / discount) % 10);
    }
    else
        Console.WriteLine("Number is't third-digit");