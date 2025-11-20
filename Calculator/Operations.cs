using System;

namespace Calculator.Core
{
    //  Базов абстрактен клас за всички операции в калкулатора.
    //  Осигурява общи свойства и методи, които всяка операция трябва да реализира.
    public abstract class OperationBase : IOperation
    {
        //  Уникален символ на операцията (например "+", "-", "sqrt", "log").
        public abstract string Symbol { get; }

        //  Показва дали операцията е унарна (true) или бинарна (false).
        public abstract bool IsUnary { get; }

        //  Изпълнява операцията.
        //  За бинарни операции: left и right се използват.
        //  За унарни: left се игнорира, а се използва само right.
        public abstract double Execute(double left, double right);

        //  Проверява дали стойността е >= 0.
        //  Използва се от операции, които изискват неотрицателни входни данни.
        protected void EnsureNonNegative(double value, string message)
        {
            if (value < 0)
                throw new Exception(message);
        }

        //  Проверява дали стойността е > 0.
        //  Използва се от операции като log, които не позволяват стойности <= 0.
        protected void EnsureGreaterThanZero(double value, string message)
        {
            if (value <= 0)
                throw new Exception(message);
        }
    }

    //  Операция за събиране на два числа.
    public class AdditionOperation : OperationBase
    {
        public override string Symbol => "+";
        public override bool IsUnary => false;

        //  Извършва събиране: left + right.
        public override double Execute(double left, double right) => left + right;
    }

    //  Операция за изваждане.
    public class SubtractionOperation : OperationBase
    {
        public override string Symbol => "-";
        public override bool IsUnary => false;

        //  Извършва изваждане: left - right.
        public override double Execute(double left, double right) => left - right;
    }

    //  Операция за умножение.
    public class MultiplicationOperation : OperationBase
    {
        public override string Symbol => "*";
        public override bool IsUnary => false;

        //  Извършва умножение: left * right.
        public override double Execute(double left, double right) => left * right;
    }

    //  Операция за деление.
    public class DivisionOperation : OperationBase
    {
        public override string Symbol => "/";
        public override bool IsUnary => false;

        //  Деление: left / right.
        //  Забранява делене на 0.
        public override double Execute(double left, double right)
        {
            if (right == 0)
                throw new Exception("Can't divide by 0");
            return left / right;
        }
    }

    //  Операция за степенуване (left ^ right).
    public class PowerOperation : OperationBase
    {
        public override string Symbol => "pow";
        public override bool IsUnary => false;

        //  Извършва степенуване: Math.Pow(left, right).
        public override double Execute(double left, double right) => Math.Pow(left, right);
    }

    //  Операция за изчисляване на n-тото число на Фибоначи.
    public class FibonacciOperation : OperationBase
    {
        public override string Symbol => "fib";
        public override bool IsUnary => true;

        //  Изчислява Фибоначи от right.
        //  Позволява само целочислени стойности (например 0, 1, 2, 3...).
        public override double Execute(double left, double right)
        {
            if (right < 0 || right != Math.Floor(right))
                throw new Exception("Input must be a non-negative integer");

            int n = (int)right;
            if (n == 0) return 0;
            if (n == 1) return 1;

            double a = 0, b = 1;

            //  Итеративно изчисляване на Фибоначи
            for (int i = 2; i <= n; i++)
            {
                double temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }

    //  Операция за натурален логаритъм (ln).
    public class LogOperation : OperationBase
    {
        public override string Symbol => "log";
        public override bool IsUnary => true;

        //  Изчислява ln(right).
        //  right трябва да е по-голямо от 0.
        public override double Execute(double left, double right)
        {
            EnsureGreaterThanZero(right, "Input must be > 0");
            return Math.Log(right);
        }
    }

    //  Операция за корен квадратен.
    public class SqrtOperation : OperationBase
    {
        public override string Symbol => "sqrt";
        public override bool IsUnary => true;

        //  Изчислява корен квадратен: sqrt(right).
        //  right трябва да е >= 0.
        public override double Execute(double left, double right)
        {
            EnsureNonNegative(right, "Input must be non-negative");
            return Math.Sqrt(right);
        }
    }

    //  Операция за абсолютна стойност.
    public class AbsOperation : OperationBase
    {
        public override string Symbol => "abs";
        public override bool IsUnary => true;

        //  Връща абсолютната стойност на right.
        public override double Execute(double left, double right) => Math.Abs(right);
    }

    //  Операция за реципрочна стойност (1 / right).
    public class ReciprocalOperation : OperationBase
    {
        public override string Symbol => "rec";
        public override bool IsUnary => true;

        //  Връща 1 / right.
        //  Забранява делене на нула.
        public override double Execute(double left, double right)
        {
            if (right == 0)
                throw new Exception("Cannot divide by zero");

            return 1 / right;
        }
    }
}
