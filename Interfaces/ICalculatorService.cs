namespace CalculatorAPI.Interfaces
{
    public interface ICalculatorService<T> where T : struct
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }
}
