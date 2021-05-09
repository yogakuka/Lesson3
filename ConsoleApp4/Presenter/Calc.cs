using ConsoleApp4.View;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Infrastryctyre;

namespace ConsoleApp4.Presenter
{
    class Calc
    {
        Model model;
        ConsoleView view;

        public Calc(ConsoleView view)
        {
            this.view = view;
            model = new Model();
        }


        public void Sum()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(Model.Sum(z1, z2).Print());

        }
        public void Sub()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(z1.Sub(z2).Print());

        }
        public void Mult()
        {
            Complex z1 = view.GetData();
            Complex z2 = view.GetData();

            view.Print(z1.Mult(z2).Print());

        }


    }
}
