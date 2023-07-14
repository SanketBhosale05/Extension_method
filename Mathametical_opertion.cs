using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
  public class Calculation  
    {

    }
    public static class ExtensionClass
    { 
        public static  int Sqaure (this Calculation c,int x)
        {
            return x*x;


        }

    }
    public static class ExtensionClass1
    {
        public static int multiply ( this Calculation c,int x,int y)
        {
            return x*y ;

        }
    }
    public static class ExtensionClass2
    {
        public static int Divide( this Calculation calculation,int x,int y)
        {
            return x/y ;
        }
    }
}
