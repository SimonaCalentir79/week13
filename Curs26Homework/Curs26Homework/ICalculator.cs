using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs26Homework
{
    public interface ICalculator<T>
    {
        T Sum(T a, T b);

        T Deduct(T a, T b);

        T Multiply(T a, T b);

        T Divide(T a, T b);
    }
}
