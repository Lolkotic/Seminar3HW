/*

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine,out result);
        if(result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
Console.WriteLine("Введите координаты");
int CoordinateXa = getCoordinateFromUser("Xa: ");
int CoordinateYa = getCoordinateFromUser("Ya: ");
int CoordinateZa = getCoordinateFromUser("Za: ");
int CoordinateXb = getCoordinateFromUser("Xb: ");
int CoordinateYb = getCoordinateFromUser("Yb: ");
int CoordinateZb = getCoordinateFromUser("Zb: ");

double Scalyar = 0;
Scalyar = (Math.Sqrt (Math.Pow(CoordinateXa - CoordinateXb, 2) + Math.Pow(CoordinateYa - CoordinateYb, 2) + Math.Pow(CoordinateZa - CoordinateZb,2)));

Console.WriteLine(Scalyar);