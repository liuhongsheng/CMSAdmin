using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CMS.Util.Model;

namespace CMS.Business.AutoJob
{
    public interface IJobTask
    {
        Task<TData> Start();
    }
}
