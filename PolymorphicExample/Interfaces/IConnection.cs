using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicExample.Interfaces
{
    public interface IConnection
    {
        public void Open();
        public void Close();
    }
}
