using ConsoleApp4.Infrastryctyre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    class Model
    {
        public static Complex Sum(Complex q, Complex w) => new Complex(q.re + w.re, q.im + w.im);
    }
}
