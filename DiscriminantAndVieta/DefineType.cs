using DiscriminantAndVieta.CalculateEquation;
using DiscriminantAndVieta.TypeEquation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantAndVieta
{
    /// <summary>
    /// Определение типа квадратичного уравнения. Паттерн Синглтон (Одиночка)
    /// </summary>
    public class DefineType
    {
        private static DefineType instance;

        private DefineType()
        {

        }

        public static DefineType Instance
        {
            get
            {
                if (instance == null)
                    instance = new DefineType();
                return instance;
            }
        }

        public ACalcQe? SetType(double[] variables, bool isBiqudratic = false)
        {
            // Уравнения нет. Данные введены неверно
            if (variables[0] == 0)
            {
                return null;
            }
            // Биквадратное уравнение
            else if (isBiqudratic)
            {
                if (variables[0] == 0 || variables[1] == 0 || variables[2] == 0)
                {
                    return null;
                }
                else
                {
                    return new CalcQeByD(new TypeBqe(), variables);
                }
            }
            // Неполное квадратичное уравнение
            else if (variables[1] == 0)
            {
                if (variables[2] != 0)
                {
                    return new CalcIqe(new TypeIncompleteQeBIsZero(), variables);
                }
                else if (variables[2] == 0)
                {
                    return new CalcIqe(new TypeIncompleteQeBAndCIsZero(), variables);
                }
            }
            else if (variables[1] != 0 && variables[2] == 0)
            {
                return new CalcIqe(new TypeIncompleteQeCIsZero(), variables);
            }
            // Полное квадратное уравнение при а == 1
            else if (variables[0] == 1)
            {
                return new CalcQeByD(new TypeAIs1(), variables);
            }
            // Полное квадратное уравнение с четным коэффициентом
            else if (variables[1] % 2 == 0)
            {
                return new CalcQeByD(new TypeBIsOdd(), variables);
            }
            // Полное квадратное уравнение
            return new CalcQeByD(new TypeStandart(), variables);
        }

    }
}
