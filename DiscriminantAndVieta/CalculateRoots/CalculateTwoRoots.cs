namespace DiscriminantAndVieta.CalculateRoots
{
    /// <summary>
    /// Вычисление двух корней
    /// </summary>
    internal class CalculateTwoRoots : ACalculateRoots
    {
        private readonly double d;

        public CalculateTwoRoots(double[] variables, double d) : base(variables)
        {
            this.d = d;
        }

        private double CalcRoot(bool isSecondRoot)
        {
            return ((-1 * variables[1]) + ((isSecondRoot ? -1 : 1) * Math.Sqrt(d))) / (2 * variables[0]);
        }

        public override double[] CalcRoots()
        {
            return new double[] { CalcRoot(false), CalcRoot(true) };
        }
    }
}
