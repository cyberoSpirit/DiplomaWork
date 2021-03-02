using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathNet.Numerics.LinearAlgebra.Double;
using System.Collections;

namespace ThreeStepsRecursiveNewtonMethod
{
    class Documentator
    {
        struct Record
        {
            public String alpha;
            public String beta;
            public String uk;
            public String vk;
            public String xNext;
            public String fxNext;
        }

        ArrayList List;
        int numberOfCalcFunction;
        int numberOfCalcPrimeFunc;
        int numberOfCalcDoubPrimeFunc;

        public void incCalcFunc(int n)
        {
            numberOfCalcFunction += n;
        }

        public void incCalcPrimeFunc(int n)
        {
            numberOfCalcPrimeFunc += n;
        }

        public void incCalcDoublePrimeFunc(int n)
        {
            numberOfCalcDoubPrimeFunc += n;
        }

        public int GetCalcFunc()
        {
            return numberOfCalcFunction;
        }

        public int GetCalcPrimeFunc()
        {
            return numberOfCalcPrimeFunc;
        }

        public int GetCalcDoublePrimeFunc()
        {
            return numberOfCalcDoubPrimeFunc;
        } 

        public Documentator()
        {
            numberOfCalcFunction = 0;
            numberOfCalcPrimeFunc = 0;
            numberOfCalcDoubPrimeFunc = 0;
            List = new ArrayList();
        }

        public void Add(double alpha1, double beta1, DenseVector uk1, DenseVector vk1, DenseVector xNext1, double FxNext1, int n)
        {
            Record rec;
            rec.alpha = Convert.ToString(alpha1);
            rec.beta = Convert.ToString(beta1);
            rec.uk = ConvertToString(uk1, n);
            rec.vk = ConvertToString(vk1, n);
            rec.xNext = ConvertToString(xNext1, n);
            rec.fxNext = Convert.ToString(FxNext1);

            List.Add(rec);
        }

        public String[] GetNextArray()
        {
            Record rec = (Record)List[0];
            String[] arr = new String[6];
            arr[0] = rec.alpha;
            arr[1] = rec.beta;
            arr[2] = rec.uk;
            arr[3] = rec.vk;
            arr[4] = rec.xNext;
            arr[5] = rec.fxNext;
            List.RemoveAt(0);
            return arr;
        }

        public int GetSize()
        {
            return List.Count;
        }

        public String ConvertToString(DenseVector x, int n)
        {
            if (x != null)
            {
                String s = "(";
                for (int i = 0; i < n - 1; ++i)
                {
                    s += Convert.ToString(x[i]) + ",\r\n";
                }
                s += Convert.ToString(x[n - 1]) + ")";
                return s;
            }
            else
            {
                return "";
            }
        }

    }
}
