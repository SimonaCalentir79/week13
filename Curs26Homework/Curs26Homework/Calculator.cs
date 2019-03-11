using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs26Homework
{
    public class Calculator : ICalculator<int>, ICalculator<decimal>, ICalculator<double>, ICalculator<long>,ICalculator<ulong>
    {
        public int Deduct(int a, int b) => a - b;

        public decimal Deduct(decimal a, decimal b) => a - b;

        public double Deduct(double a, double b) => a - b;

        public long Deduct(long a, long b) => a - b;

        public ulong Deduct(ulong a, ulong b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public decimal Multiply(decimal a, decimal b) => a * b;

        public double Multiply(double a, double b) => a * b;

        public long Multiply(long a, long b) => a * b;

        public ulong Multiply(ulong a, ulong b) => a * b;

        public int Sum(int a, int b) => a + b;

        public decimal Sum(decimal a, decimal b) => a + b;

        public double Sum(double a, double b) => a + b;

        public long Sum(long a, long b) => a + b;

        public ulong Sum(ulong a, ulong b) => a + b;

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public long Divide(long a, long b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

        public ulong Divide(ulong a, ulong b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }

}
