int kon1x, kon1y, ferz1x, ferz1y, kon2x, kon2y;
Console.WriteLine("Введите координаты коня от 1 до 8");
kon1x= int.Parse(Console.ReadLine());
kon1y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты ферьзя от 1 до 8");
ferz1x= int.Parse(Console.ReadLine());
ferz1y= int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты хода коня");
kon2x= int.Parse(Console.ReadLine());
kon2y= int.Parse(Console.ReadLine()); // Ввод
if (kon1x > 8 & kon1y > 8)
{
    Console.WriteLine("Конь не может пойти на это поле");
}// проверка

if ((kon1x + 1 == kon2x && kon1y + 2 == kon2y) ||
    (kon1x - 1 == kon2x && kon1y + 2 == kon2y) ||
    (kon1x + 1 == kon2x && kon1y - 2 == kon2y) ||
    (kon1x - 1 == kon2x && kon1y - 2 == kon2y) ||
    (kon1x + 2 == kon2x && kon1y + 1 == kon2y) ||
    (kon1x - 2 == kon2x && kon1y + 1 == kon2y) ||
    (kon1x + 2 == kon2x && kon1y - 1 == kon2y) ||
    (kon1x - 2 == kon2x && kon1y - 1 == kon2y)) //перебирает варианты ходов коня 
{
    
    if ((ferz1y - kon2x == ferz1x - kon2y) || (ferz1y - kon2x == kon2y - ferz1x) || (ferz1y == kon2y || ferz1x == kon2x))  //проверяет под ударом ли конь 
    {
        Console.WriteLine("Конь может пойти на это поле, но подставляется под ферзя");
    }
    else
    {
        Console.WriteLine("Конь может пойти на это поле, и не подставляется под ферзя");
    }
   
}// итоги
