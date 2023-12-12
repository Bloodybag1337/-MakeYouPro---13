/*
Задание 3:
Компания, занимающаяся продажей часов, ввела систему планов продаж для своих сотрудников.
Необходимо понимать, какое число сотрудников не справляются с планом.
Напишите метод, получающий на вход список суммы продаж каждого сотрудника
и отдельное число - план по продажам.
Метод должен возвращать одно значение - число сотрудников, не выполнивших план.
*/

List<int> employeeSales = new List<int>();
{
    employeeSales.Add(400000);
    employeeSales.Add(550000);
    employeeSales.Add(700000);
    employeeSales.Add(350000);
    employeeSales.Add(800000);
}

int losers = 0;
int plan = 500000;

foreach(int i in employeeSales)
{
    if (i < plan)
    {
        losers++;
    }
}

Console.WriteLine(losers);
Console.ReadKey();