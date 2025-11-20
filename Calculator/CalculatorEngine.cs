using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculator.Core
{
    public class CalculatorEngine
    {
        // Речник с всички регистрирани операции (символ -> операция)
        private readonly Dictionary<string, IOperation> _operations =
            new Dictionary<string, IOperation>();

        // Символ на чакащата операция (ако има)
        private string _pendingOperationSymbol = "";

        // Текуща въведена стойност
        public string CurrentInput { get; private set; } = "";
        // Резултат от последната операция
        public double Result { get; private set; } = 0;
        // Флаг дали има чакаща операция
        public bool OperationPending { get; private set; } = false;

        // Конструктор - регистрира всички поддържани операции
        public CalculatorEngine()
        {
            RegisterOperation(new AdditionOperation());
            RegisterOperation(new SubtractionOperation());
            RegisterOperation(new MultiplicationOperation());
            RegisterOperation(new DivisionOperation());
            RegisterOperation(new PowerOperation());
            RegisterOperation(new FibonacciOperation());
            RegisterOperation(new LogOperation());
            RegisterOperation(new SqrtOperation());
            RegisterOperation(new AbsOperation());
            RegisterOperation(new ReciprocalOperation());
        }

        // Регистрира нова операция
        public void RegisterOperation(IOperation operation)
        {
            _operations[operation.Symbol] = operation;
        }

        // Нулира всички стойности и състояния
        public void Clear()
        {
            CurrentInput = "";
            Result = 0;
            _pendingOperationSymbol = "";
            OperationPending = false;
        }

        // Добавя текст към текущия вход
        public void AppendInput(string text)
        {
            CurrentInput += text;
        }

        // Изтрива последния символ от текущия вход
        public void Backspace()
        {
            if (!string.IsNullOrEmpty(CurrentInput))
                CurrentInput = CurrentInput.Substring(0, CurrentInput.Length - 1);
        }

        // Променя знака на текущия вход
        public void ToggleSign()
        {
            if (string.IsNullOrEmpty(CurrentInput))
                return;

            if (CurrentInput.StartsWith("-"))
                CurrentInput = CurrentInput.Substring(1);
            else
                CurrentInput = "-" + CurrentInput;
        }

        // Добавя десетична точка към текущия вход
        public void InsertDecimal()
        {
            if (!CurrentInput.Contains("."))
            {
                if (string.IsNullOrEmpty(CurrentInput))
                    CurrentInput = "0";
                CurrentInput += ".";
            }
        }

        // Задава стойността на π като текущ вход
        public void SetPi()
        {
            CurrentInput = Math.PI.ToString(CultureInfo.InvariantCulture);
        }

        // Парсира текущия вход като double
        private double ParseCurrentInput()
        {
            if (string.IsNullOrEmpty(CurrentInput))
                throw new CalculatorException("Въведете число отново");

            if (!double.TryParse(CurrentInput, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
                throw new CalculatorException("Невалиден вход");

            return value;
        }

        // Задава операцията, която ще се изпълни
        public void SetOperation(string symbol)
        {
            if (!_operations.TryGetValue(symbol, out var op))
                throw new CalculatorException("Няма такава операция");

            // Ако е унарна операция - изчислява веднага
            if (op.IsUnary)
            {
                double value = ParseCurrentInput();
                Result = op.Execute(0, value);
                CurrentInput = Result.ToString(CultureInfo.InvariantCulture);
                OperationPending = false;
                _pendingOperationSymbol = "";
                return;
            }

            // Бинарна операция
            double currentValue = ParseCurrentInput();

            if (OperationPending)
            {
                // Ако има чакаща операция - първо я изчисли
                Evaluate();
            }
            else
            {
                Result = currentValue;
            }

            CurrentInput = "";
            _pendingOperationSymbol = symbol;
            OperationPending = true;
        }

        // Изчислява чакащата операция (ако има)
        public void Evaluate()
        {
            if (!OperationPending)
                return;

            if (!_operations.TryGetValue(_pendingOperationSymbol, out var op))
                throw new CalculatorException("Няма такава операция");

            double right = ParseCurrentInput();

            if (op.IsUnary)
            {
                Result = op.Execute(0, right);
            }
            else
            {
                Result = op.Execute(Result, right);
            }

            CurrentInput = "";
            _pendingOperationSymbol = "";
            OperationPending = false;
        }

        // Връща текста, който трябва да се покаже на дисплея
        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(CurrentInput))
                return CurrentInput;

            return Result.ToString(CultureInfo.InvariantCulture);
        }
    }
}