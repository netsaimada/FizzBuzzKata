using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata1
{
    interface IRule
    {
        bool check(int n);

        String result(int n);
    }
}
