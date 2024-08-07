namespace Domain
{
    public class Calculator
    {
        public int Division(int a, int b)
        {
            if (b != 0)
                return a / b;

            return 0;
        }
    }
}
