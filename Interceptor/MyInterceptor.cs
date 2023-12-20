using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor
{
    public class MyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {

            try
            {
                // aSYNC İŞLEMLER TERCİH EDİLMELİ
                //Performans gerektiren işlemler yapılmamalı
                // Bu metot, her bir metot için tetiklenecektir. 

                invocation.Proceed();

            }
            catch (Exception ex)
            {



            }
            
        }
    }
}
