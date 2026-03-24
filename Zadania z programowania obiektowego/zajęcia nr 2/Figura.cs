using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Figura
    {
        private double[] parametry;

        public Figura(params double[] parametry)
        {
            this.parametry = parametry;
        }

        public Figura(Figura f)
        {
            this.parametry = (double[])f.parametry.Clone();
        }

        public double ObliczObwod()
        {
            switch (parametry.Length)
            {
                case 1:
                    return (2 * Math.PI * parametry[0]);
                case 2:
                    return (2 * (parametry[0] + parametry[1]));
                case 3:
                    return (parametry[0] + parametry[1] + parametry[2]);
                default:
                    throw new InvalidOperationException("zły typ figury");
            }
        }

        public double parametr1
        {
            set { parametry[0] = value; }
        }
    }
}
