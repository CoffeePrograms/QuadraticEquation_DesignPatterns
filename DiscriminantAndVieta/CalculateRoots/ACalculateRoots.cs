namespace DiscriminantAndVieta.CalculateRoots
{
    /// <summary>
    /// Абстрактный класс для вычисления корней с помощью дискриминанта
    /// </summary>
    /// Используется абстрактный класс, а не интерфейс, 
    /// потому что наследники могут использовать конструктор и поле без изменений
    internal abstract class ACalculateRoots
    {
        private protected double[] variables;

        protected ACalculateRoots(double[] variables)
        {
            this.variables = variables;
        }

        public abstract double[] CalcRoots();
    }
}
