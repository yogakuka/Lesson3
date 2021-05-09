
namespace ConsoleApp4.Infrastryctyre
{
    public struct Complex
    {
        public double re;
        public double im;  

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        
        public string Print()
        {
            return $"{re} + {im}i";
        }
        public Complex Sub( Complex c1)
        {
            return (new Complex(this.re - c1.re, this.im - c1.im));
        }
        public Complex Mult(Complex c1)
        {
            return (new Complex(this.re * c1.re - this.im* c1.im, this.re * c1.im + this.im*c1.re));
        }
    }
}
