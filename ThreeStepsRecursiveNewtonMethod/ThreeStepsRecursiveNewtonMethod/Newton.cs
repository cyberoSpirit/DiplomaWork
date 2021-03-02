using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathNet.Numerics.LinearAlgebra.Double;

namespace ThreeStepsRecursiveNewtonMethod
{
    class Newton
    {
        int n;
        int functionNumber;
        DenseVector uk;
        DenseVector vk;
        DenseVector x;
        double gamma;
        double eps;
        int depth;
        Documentator doc;
        Function f;

        struct interval
        {
            public double a;
            public double b;
        }

        //конструктор
        public Newton(DenseVector x1, int n1, double eps1, double gamma1, int depth1, int fNumber)
        {
            n = (n1 < 0) ? 0 : n1;

            x = new DenseVector(n);
            for (int i = 0; i < n; ++i)
            {
                x[i] = x1[i];
            }

            eps = (eps1 > 0) ? eps1 : 0.0001;
            
            gamma = (gamma1 > 0) ? gamma1 : 0.5;

            depth = depth1;

            functionNumber = (fNumber >= 0) ? fNumber : 0;
        }

        //функція для мінімізації
        double func(double t)
        {
            doc.incCalcFunc(1);
            double ret = f.function(uk + t * (vk - uk), n);
            return ret;
        }

        //локалізація проміжку
        //interval DCK(double h0)
        //{
        //    double x0 = 0;
        //    h0 = 0.01;

        //    double xp, xn, h;
        //    xp = x0;
        //    h = h0;
        //    if (func(xp - h) < func(xp + h)) h *= -1;
        //    xn = xp + h;
        //    while (func(xp) > func(xn))
        //    {
        //        xp = xn;
        //        h = 2 * h;
        //        xn = xp + h;
        //    }
        //    double[] x = new double[4];
        //    double[] fx = new double[4];
        //    x[2] = xn;
        //    x[1] = xp;
        //    x[0] = xp - h / 4;
        //    x[3] = x[2] - h / 2;

        //    for (int i = 0; i < 4; i++)
        //        fx[i] = func(x[i]);
        //    int max = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (fx[i] > fx[max]) max = i;
        //    }
        //    int a = 0, b = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (i == max) { }
        //        else
        //        {
        //            if (a == max && b == max) { a = i; b = i; }
        //            if (x[i] < x[a]) a = i;
        //            if (x[i] > x[b]) b = i;
        //        }
        //    }

        //    interval intr;

        //    intr.a = x[a];
        //    intr.b = x[b];
        //    doc.GetCalcFunc();
        //    return intr;
        //}

        //знаходження аргументу, який мінімізує функцію
        double argmin()
        {
            //interval intr = DCK(n);

            //double a = intr.a;
            //double b = intr.b;

            ////  МЕТОД ЗОЛОТОГО ПОДІЛУ

            //////константи для золотого поділу
            //////double k1 = (Math.Sqrt(5) - 1) / 2.0;
            //////double k2 = 1 - k1;

            ////double x1, x2;
            ////x1 = a + 0.382 * (b - a);
            ////x2 = a + b - x1;

            ////while (Math.Abs(a - b) > 0.1)
            ////{
            ////    if (func(x1) <= func(x2))
            ////    {
            ////        b = x2;
            ////        x2 = x1;
            ////        x1 = a + b - x1;
            ////    }
            ////    else
            ////    {
            ////        a = x1;
            ////        x1 = x2;
            ////        x2 = a + b - x2; ;
            ////    }
            ////    //x1 = a + k2 * (b - a);
            ////    //x2 = a + k1 * (b - a);
            ////}

            //double y = a + 0.382 * (b - a);
            //    double z = a + b - y;
            //    double a1 = a, b1 = b;
            //    while (Math.Abs(a1 - b1) > 0.01)
            //    {
            //        if (func(y) <= func(z))
            //        {
            //            b1 = z;
            //            z = y;
            //            y = a1 + b1 - y;
            //        }
            //        else
            //        {
            //            a1 = y;
            //            y = z;
            //            z = a1 + b1 - z;
            //        }
            //    }
            ////    rez = (a1 + b1) / 2.0;
            ////}
            ////catch { }
            ////return rez;
            //    doc.GetCalcFunc();
            //return (a1 + b1) / 2.0;

            double rez = 0;
            double x0, h0;
            try
            {
                //метод ДСК
                x0 = 0;
                h0 = 0.1;

                double xp, xn, h;
                xp = x0;
                h = h0;
                if (func(xp - h) < func(xp + h)) h *= -1;
                xn = xp + h;
                while (func(xp) > func(xn))
                {
                    xp = xn;
                    h = 2 * h;
                    xn = xp + h;
                }
                double[] x1 = new double[4];
                double[] fx = new double[4];
                x1[2] = xn;
                x1[1] = xp;
                x1[0] = xp - h / 4;
                x1[3] = x1[2] - h / 2;

                for (int i = 0; i < 4; i++)
                    fx[i] = func(x1[i]);
                int max = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (fx[i] > fx[max]) max = i;
                }
                int a = 0, b = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (i == max) { }
                    else
                    {
                        if (a == max && b == max) { a = i; b = i; }
                        if (x1[i] < x1[a]) a = i;
                        if (x1[i] > x1[b]) b = i;
                    }
                }
                //кінець методу ДСК
                //метод золотого поділу 
                double y = x1[a] + 0.382 * (x1[b] - x1[a]);
                double z = x1[a] + x1[b] - y;
                double a1 = x1[a], b1 = x1[b];
                while (Math.Abs(a1 - b1) > 0.01)
                {
                    if (func(y) <= func(z))
                    {
                        b1 = z;
                        z = y;
                        y = a1 + b1 - y;
                    }
                    else
                    {
                        a1 = y;
                        y = z;
                        z = a1 + b1 - z;
                    }
                }
                rez = (a1 + b1) / 2.0;
            }
            catch { }
            return rez;
        }

        //класичний метод Ньютона
        public DenseVector NewtonMethod()
        {
            doc = new Documentator();
            DenseVector xNext = new DenseVector(n);
            xNext = x;
            int k = 0;
            f = new Function(functionNumber);

            doc.Add(0, 0, null, null, x, f.function(xNext, n), n);

            do
            {
                x = xNext;
                xNext = x - ((DenseMatrix)f.doublePrime(x, n).Inverse()) * f.prime(x, n);
                doc.incCalcDoublePrimeFunc(1);
                doc.incCalcPrimeFunc(1);
                doc.Add(0, 0, null, null, x, f.function(xNext, n), n);
                ++k;

            } while ((xNext - x).Norm(2) > eps);
            //(xNext-x).Norm(2)>eps
            //(f.prime(xNext, n)).Norm(1) > eps
            return xNext;
        }

        //трикроковий рекурсивний метод Ньютона
        public DenseVector ThreeStepsRecursiveNewtonMethod()
        {
            doc = new Documentator();
            uk = new DenseVector(n);
            vk = new DenseVector(n);
            DenseVector xNext = new DenseVector(n);
            xNext = x;
            DenseVector prim = new DenseVector(n);
            DenseMatrix xk_zilda = new DenseMatrix(n, n);
            double alpha = 1;
            double beta = 1;
            double func1;
            int k = 0;

            f = new Function(functionNumber);

            doc.Add(alpha, beta, uk, vk, x, f.function(xNext, n), n);

            do
            {
                x = xNext;

                if (k % depth == 0)
                {
                    xk_zilda = (DenseMatrix)f.doublePrime(x, n).Inverse();
                    doc.incCalcDoublePrimeFunc(1);
                }

                doc.incCalcPrimeFunc(1);
                prim = f.prime(x, n);

                uk = x - alpha * xk_zilda * prim;
                
                doc.incCalcFunc(2);
                func1 = f.function(x, n);
                while (f.function(uk, n) > func1)
                {
                   doc.incCalcFunc(1);
                    alpha *= gamma;
                    uk = x - alpha * xk_zilda * prim;
                }

                vk = x - beta * prim;

                doc.incCalcFunc(1);
                while (f.function(vk, n) > func1)
                {
                    beta *= gamma;
                    vk = x - beta * prim;
                    doc.incCalcFunc(1);
                }

                xNext = uk + argmin() * (vk - uk);

                doc.Add(alpha, beta, uk, vk, x, f.function(xNext, n), n);
                ++k;

            } while ((xNext - x).Norm(2) > eps);
            //(xNext-x).Norm(2)>eps
            //(f.prime(xNext, n)).Norm(1) > eps
            return xNext;
        }

        public Documentator GetDoc()
        {
            return doc;
        }
    }
}
