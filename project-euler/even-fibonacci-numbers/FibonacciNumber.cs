namespace even_fibonacci_numbers
{
    public class FibonacciNumber
    {
        private readonly int m_PreviousValue;
        private readonly int m_CurrentValue;

        public FibonacciNumber(int previousValue, int currentValue)
        {
            m_PreviousValue = previousValue;
            m_CurrentValue = currentValue;
        }

        public FibonacciNumber Next()
        {
            return new FibonacciNumber(m_CurrentValue, m_PreviousValue + m_CurrentValue);
        }

        public int Value => m_CurrentValue;
    }
}