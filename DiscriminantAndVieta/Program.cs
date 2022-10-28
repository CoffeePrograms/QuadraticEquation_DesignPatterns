using DiscriminantAndVieta;
using DiscriminantAndVieta.CalculateEquation;


/* Решение квадратичных уравнений нескольких типов: полных, неполных, биквадратных.
 * Реализованы вычисления без дискриминанта, с дискриминантом, проверка корней с помощью Виета.
 * Источник, из которого взята теория: https://izamorfix.ru/matematika/algebra/kvadratnye_uravn.html
 */

void Print(double[] Roots)
{
    if (Roots != null)
        foreach (var item in Roots)
        {
            Console.WriteLine("x = " + item);
        }
    else
        Console.WriteLine("Нет корней");

    Console.WriteLine();
}

ACalcQe? equation;
//double[] variables = new double[3];
var variables = new double[3] { 3, -4, 2 };
equation = DefineType.Instance.SetType(variables);
if (equation == null)
{
    Console.WriteLine("Программа не может решить это уравнение. Возможно, данные введены неверно");
    Console.WriteLine("Нажмите любую клавишу для завершения программы");
    return;
}
equation.Calc();
Print(equation.Roots);