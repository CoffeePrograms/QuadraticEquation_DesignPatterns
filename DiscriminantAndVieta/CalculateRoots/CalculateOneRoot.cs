namespace DiscriminantAndVieta.CalculateRoots
{
    /// <summary>
    /// Вычисление одного корня
    /// </summary>
    internal class CalculateOneRoot : ACalculateRoots
    {
        public CalculateOneRoot(double[] variables) : base(variables)
        {
            this.variables = variables;
        }

        public override double[] CalcRoots()
        {
            return new double[] { -1 * variables[1] / (2 * variables[0]) };
        }
    }
}
