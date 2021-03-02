using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathNet.Numerics.LinearAlgebra.Double;

namespace ThreeStepsRecursiveNewtonMethod
{
    class Function
    {
        int numberOfFunction;

        public Function(int number)
        {
            numberOfFunction = (number >= 0) ? number : 0;
        }

        public double functionBeil(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                f += Math.Pow(1.5 - x[2 * i] * (1 - Math.Pow(x[2 * i + 1], 3)), 2) + Math.Pow(2.25 - x[2 * i] * (1 - Math.Pow(x[2 * i + 1], 2)), 2) + Math.Pow(2.625 - x[2 * i] * (1 - Math.Pow(x[2 * i + 1], 3)), 2);
            }
            return f;
        }
        public double functionRosenbrok(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                f += 100 * (Math.Pow((x[2 * i + 1] - Math.Pow(x[2 * i], 2)), 2)) + Math.Pow((1 - x[2 * i]), 2);
            }
            return f;
        }
        public double functionShtraf1(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n-1; ++i)
            {
                f += Math.Pow(x[i] - 1, 2) + Math.Pow((x[i] * x[i] - 0.25), 2);
            }
            return f += Math.Pow((x[n - 1] * x[n - 1] - 0.25), 2);
        }
        public double functionShtraf2(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n; ++i)
            {
                f += 0.00001 * Math.Pow(x[i] - 1, 2) + Math.Pow((x[i] * x[i] - 0.25), 2);
            }
            return f;
        }
        public double functionVaitXolst(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                f += 100 * Math.Pow(x[2 * i + 1] - Math.Pow(x[2 * i], 3), 2) + Math.Pow(1 - x[2 * i], 2);
            }
            return f;
        }
        public double functionPayel(int n, DenseVector x)
        {
            double f = 0;
            for (int i = 0; i < n / 4; ++i)
            {
                f += Math.Pow((x[4 * i] + 10 * x[4 * i + 1]), 2) + 5 * Math.Pow((x[4 * i + 2] - x[4 * i + 3]), 2) + Math.Pow((x[4 * i + 1] - 2 * x[4 * i + 2]), 4) + 10 * Math.Pow((x[4 * i] - x[4 * i + 3]), 4);
            }
            return f;
        }
        public double function(DenseVector x, int n)
        {
            switch (numberOfFunction)
            {
                case 0:
                    return functionBeil(n, x);
                case 1:
                    return functionRosenbrok(n, x);
                case 2:
                    return functionShtraf1(n, x);
                case 3:
                    return functionShtraf2(n, x);
                case 4:
                    return functionVaitXolst(n, x);
                case 5:
                    return functionPayel(n, x);
                default:
                    return functionBeil(n, x);
            }
        }

        public DenseVector primeBeil(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);

            for (int i = 0; i < n / 2; ++i)
            {
                grad[2*i] = 2 * (-6.375 + 3 * x[2 * i] - 4 * x[2 * i] * Math.Pow(x[2 * i + 1], 3) + 4.125 * Math.Pow(x[2 * i + 1], 3) + 2 * x[2 * i] * Math.Pow(x[2 * i + 1], 6) - 2 * x[2 * i] * Math.Pow(x[2 * i + 1], 2) + 2.25 * Math.Pow(x[2 * i + 1], 2) + x[2 * i] * Math.Pow(x[2 * i + 1], 4));
                grad[2 * i + 1] = 2 * (12.375 * x[2 * i] * Math.Pow(x[2 * i + 1], 2) - 6 * Math.Pow(x[2 * i], 2) * Math.Pow(x[2 * i + 1], 2) + 6 * Math.Pow(x[2 * i], 2) * Math.Pow(x[2 * i + 1], 5) + 4.5 * x[2 * i] * x[2 * i + 1] - 2 * Math.Pow(x[2 * i], 2) * x[2 * i + 1] + 2 * Math.Pow(x[2 * i], 2) * Math.Pow(x[2 * i + 1], 3));
            }
            return grad;
        }
        public DenseVector primeRosenbrok(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);
            for (int i = 0; i < n / 2; ++i)
            {
                grad[2 * i] = -400 * (x[2 * i] * x[2 * i + 1] - Math.Pow(x[2 * i], 3)) - 2 * (1 - x[2 * i]);
                grad[2 * i + 1] = 200 * (x[2 * i + 1] - Math.Pow(x[2 * i], 2));
            }
            return grad;
        }
        public DenseVector primeShtraf1(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);
            double sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += x[i] * x[i];
            }
            for (int i = 0; i < n; ++i)
            {
                grad[i] = x[i] - 2 + 4 * x[i] * sum;
            }
            return grad;
        }
        public DenseVector primeShtraf2(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);
            double sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += x[i] * x[i];
            }
            for (int i = 0; i < n; ++i)
            {
                grad[i] = 0.00002 * (x[i] - 1) + 4 * x[i] * sum - x[i];
            }
            return grad;
        }
        public DenseVector primeVaitXolst(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);

            for (int i = 0; i < n / 2; ++i)
            {
                grad[2 * i] = 600 * (Math.Pow(x[2 * i], 3) - x[2 * i + 1]) * Math.Pow(x[2 * i], 2) - 2 + 2 * x[2 * i];
                grad[2 * i + 1] = 200 * (x[2 * i + 1] - Math.Pow(x[2 * i], 3));
            }
            return grad;
        }
        public DenseVector primePayel(int n, DenseVector x)
        {
            DenseVector grad = new DenseVector(n);
            for (int i = 0; i < n / 4; ++i)
            {
                grad[4 * i] = 2 * (x[4 * i] + 10 * x[4 * i + 1]) + 40 * Math.Pow(x[4 * i] - x[4 * i + 3], 3);
                grad[4 * i + 1] = 20 * (x[4 * i] + 10 * x[4 * i + 1]) + 4 * Math.Pow(x[4 * i + 1] - 2 * x[4 * i + 2], 3);
                grad[4 * i + 2] = 10 * (x[4 * i + 2] - x[4 * i + 3]) - 8 * Math.Pow(x[4 * i + 1] - 2 * x[4 * i + 2], 3);
                grad[4 * i + 3] = -10 * (x[4 * i + 2] - x[4 * i + 3]) - 40 * Math.Pow(x[4 * i] - x[4 * i + 3], 3);
            }
            return grad;
        }
        public DenseVector prime(DenseVector x, int n)
        {
            switch (numberOfFunction)
            {
                case 0:
                    return primeBeil(n, x);
                case 1:
                    return primeRosenbrok(n, x);
                case 2:
                    return primeShtraf1(n, x);
                case 3:
                    return primeShtraf2(n, x);
                case 4:
                    return primeVaitXolst(n, x);
                case 5:
                    return primePayel(n, x);
                default:
                    return primeBeil(n, x);

            }
        }

        public DenseMatrix doublePrimeBeil(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }

            for (int i = 0; i < n / 2; ++i)
            {
                gess[2 * i, 2 * i] = 2 * (3 - 4 * Math.Pow(x[2 * i + 1], 3) + 2 * Math.Pow(x[2 * i + 1], 6) - 2 * Math.Pow(x[2 * i + 1], 2) + Math.Pow(x[2 * i + 1], 4));
                gess[2 * i, 2 * i + 1] = 2 * (-12 * x[2 * i] * Math.Pow(x[2 * i + 1], 2) + 12.375 * Math.Pow(x[2 * i + 1], 2) + 12 * x[2 * i] * Math.Pow(x[2 * i + 1], 5) - 4 * x[2 * i] * x[2 * i + 1] + 4.5 * x[2 * i + 1] + 4 * x[2 * i] * Math.Pow(x[2 * i + 1], 3));
                gess[2 * i + 1, 2 * i] = 2 * (-12 * x[2 * i] * Math.Pow(x[2 * i + 1], 2) + 12.375 * Math.Pow(x[2 * i + 1], 2) + 12 * x[2 * i] * Math.Pow(x[2 * i + 1], 5) - 4 * x[2 * i] * x[2 * i + 1] + 4.5 * x[2 * i + 1] + 4 * x[2 * i] * Math.Pow(x[2 * i + 1], 3));
                gess[2 * i + 1, 2 * i + 1] = 2 * (24.75 * x[2 * i] * x[2 * i + 1] - 12 * Math.Pow(x[2 * i], 2) * x[2 * i + 1] + 30 * Math.Pow(x[2 * i], 2) * Math.Pow(x[2 * i + 1], 4) + 4.5 * x[2 * i] - 2 * Math.Pow(x[2 * i], 2) + 6 * Math.Pow(x[2 * i], 2) * Math.Pow(x[2 * i + 1], 2));
            }
            return gess;
        }
        public DenseMatrix doublePrimeRosenbrok(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }

            for (int i = 0; i < n / 2; ++i)
            {
                gess[2 * i, 2 * i] = 400 * (3 * Math.Pow(x[2 * i], 2) - x[2 * i + 1]) + 2;
                gess[2 * i, 2 * i + 1] = -400 * x[2 * i];
                gess[2 * i + 1, 2 * i] = gess[2 * i, 2 * i + 1];
                gess[2 * i + 1, 2 * i + 1] = 200;
            }
            return gess;
        }
        public DenseMatrix doublePrimeShtraf1(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }
            double sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += x[i] * x[i];
            }
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                    {
                        gess[i, j] = 1 + 4 * (sum + 2 * x[i] * x[i]);
                    }
                    else
                    {
                        gess[i, j] = 8 * x[i] * x[j];
                    }
                }

            return gess;
        }
        public DenseMatrix doublePrimeShtraf2(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }
            double sum = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += x[i] * x[i];
            }
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                    {
                        gess[i, j] = 0.00002 + 4 * (sum + 2 * x[i] * x[i] - 0.25);
                    }
                    else
                    {
                        gess[i, j] = 8 * x[i] * x[j];
                    }
                }

            return gess;
        }
        public DenseMatrix doublePrimeVaitXolst(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }

            for (int i = 0; i < n / 2; ++i)
            {
                gess[2 * i, 2 * i] = 600 * (5 * Math.Pow(x[2 * i], 4) - 2 * x[2 * i] * x[2 * i + 1]) + 2;
                gess[2 * i, 2 * i + 1] = -600 * x[2 * i] * x[2 * i];
                gess[2 * i + 1, 2 * i] = gess[2 * i, 2 * i + 1];
                gess[2 * i + 1, 2 * i + 1] = 200;
            }
            return gess;
        }
        public DenseMatrix doublePrimePayel(int n, DenseVector x)
        {
            DenseMatrix gess = new DenseMatrix(n, n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    gess[i, j] = 0;
                }

            for (int i = 0; i < n / 4; ++i)
            {
                gess[4 * i, 4 * i] = 2 + 120 * Math.Pow(x[4 * i] - x[4 * i + 3], 2);
                gess[4 * i, 4 * i + 1] = 20;
                gess[4 * i, 4 * i + 3] = -120 * Math.Pow(x[4 * i] - x[4 * i + 3], 2);
                gess[4 * i + 1, 4 * i] = 20;
                gess[4 * i + 1, 4 * i + 1] = 200 + 12 * Math.Pow(x[4 * i + 1] - 2 * x[4 * i + 2], 2);
                gess[4 * i + 1, 4 * i + 2] = -24 * Math.Pow(x[4 * i + 1] - 2 * x[4 * i + 2], 2);
                gess[4 * i + 2, 4 * i + 1] = gess[4 * i + 1, 4 * i + 2];
                gess[4 * i + 2, 4 * i + 2] = 10 + 48 * Math.Pow(x[4 * i] - x[4 * i + 3], 2);
                gess[4 * i + 2, 4 * i + 3] = -10;
                gess[4 * i + 3, 4 * i] = gess[4 * i, 4 * i + 3];
                gess[4 * i + 3, 4 * i + 2] = -10;
                gess[4 * i + 3, 4 * i + 3] = 10 + 120 * Math.Pow(x[4 * i] - x[4 * i + 3], 2);
            }
            return gess;
        }
        public DenseMatrix doublePrime(DenseVector x, int n)
        {
            switch (numberOfFunction)
            {
                case 0:
                    return doublePrimeBeil(n, x);
                case 1:
                    return doublePrimeRosenbrok(n, x);
                case 2:
                    return doublePrimeShtraf1(n, x);
                case 3:
                    return doublePrimeShtraf2(n, x);
                case 4:
                    return doublePrimeVaitXolst(n, x);
                case 5:
                    return doublePrimePayel(n, x);
                default:
                    return doublePrimeBeil(n, x);

            }
        }

    }
}
