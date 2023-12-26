using System;

namespace Lab11
{
    struct LinearEquation
    {
        double k;
        double b;
        

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;            
        }

        public string Root()
        {
            if (k == 0)
            {
                if (b == 0)
                    return "Бесконечное количество решений";
                else
                    return "Решений нет";
            }

            double root = -b / k;
            return $"Решение уравнения: x = {root}";
        }
    }
}
