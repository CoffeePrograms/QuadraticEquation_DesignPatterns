namespace DiscriminantAndVieta.CalculateEquation
{
    /// <summary>
    /// Абстрактный класс для вычисления коней квадратного уравнения (Quadratic Equation)
    /// </summary>
    /// Используется абстрактный класс, а не интерфейс, 
    /// потому что наследники могут использовать конструктор и свойства без изменений
    public abstract class ACalcQe
    {
        private protected ACalcQe(double[] variables)
        {
            IsSuccessfullyChecked = null;
            Variables = variables;
        }

        public virtual double[] Variables { get; private protected set; }
        public virtual double[] Roots { get; private protected set; }
        public virtual bool? IsSuccessfullyChecked { get; private protected set; }
        public abstract void Calc();
    }
}
