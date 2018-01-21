using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyDisk
{
    [ServiceContract]
    public interface IMyDisk
    {
        [OperationContract]
        string FreeSpace(string s);

        [OperationContract]
        string TotalSpace(string s);
    }
}
