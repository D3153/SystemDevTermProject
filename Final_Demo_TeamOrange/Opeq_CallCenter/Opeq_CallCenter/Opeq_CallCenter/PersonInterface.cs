using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opeq_CallCenter
{

    interface PersonInterface
    {
        int Id
        {
            get; set;
        }
        String Name
        {
            get; set;
        }

    }


    internal class Person : PersonInterface
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }        
    }
}
