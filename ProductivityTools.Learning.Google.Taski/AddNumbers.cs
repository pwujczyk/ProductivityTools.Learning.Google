using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.Taski
{
    class AddNumbers
    {

        private class Number
        {
            public int x;
            public Number N;

            public Number():this(0){}

            public Number(int x)
            {
                this.x = x;
            }

            public static Number operator +(Number a, Number b)
            {
                var result = new Number();
                Number elementA = a;
                Number elemebtB = b;
                var walkingresult = result;
            
                while(true)
                {
                    int overload = 0;
                    if (elementA==null && elemebtB==null)
                    {
                        return result;
                    }

                    if (elementA!=null)
                    {
                        walkingresult.x += elementA.x;
                        elementA = elementA.N;
                    }

                    if (elemebtB != null)
                    {
                        walkingresult.x += elemebtB.x;
                        elemebtB = elemebtB.N;
                    }
                    if(walkingresult.x >= 10)
                    {
                        overload = 1;
                        walkingresult.x = walkingresult.x - 10;
                    }
                    walkingresult.N = new Number(overload);
                    walkingresult = walkingresult.N;



                }
            }
        }

        public void Work()
        {
            var A = new Number(7);
            A.N = new Number(1);
            A.N.N = new Number(6);

            var b = new Number(5);
            b.N = new Number(9);
            b.N.N = new Number(2);

            var x = A + b;
        }
    }
}
