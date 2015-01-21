using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL
{
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文，单例
        /// </summary>
        /// <returns></returns>
        public static FirstDbContext GetCurrentContext()
        {
            FirstDbContext _nContext = CallContext.GetData("FirstContext") as FirstDbContext;
            if (_nContext == null)
            {
                _nContext = new FirstDbContext();
                CallContext.SetData("FirstContext", _nContext);
            }
            return _nContext;
        }
    }
}
