using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public class Handler
    {

        public Handler()
        {

        }

        public Object CreateObject(List<Object> objectList)
        {
            var obj = new Object();
            objectList.Add(obj);

            return obj;
        }

        public void DeleteObject(Object obj, List<Object> objectList)
        {
            objectList.Remove(obj);
        }

    }

}
