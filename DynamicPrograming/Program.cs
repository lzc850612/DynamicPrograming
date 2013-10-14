using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Start()
        {
            dynamic a = new ExpandoObject();
            a.a = string.Empty;

            
        }
    }

    public class ExpandoObject : IDynamicMetaObjectProvider
    {
        public DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
        {
            throw new NotImplementedException();
        }
    }
}