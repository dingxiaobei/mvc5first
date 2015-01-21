using FirstProject.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL
{
    /// <summary>
    /// 简单工厂 
    /// 以后在BLL中调用的时候就不用每次都写InterfaceUserRepository _iUserRsy = new  UserRepository()了，直接写成InterfaceUserRepository _iUserRsy = RepositoryFactory.UserRepository这个东西的好处就是，以后在DAL项目中实现InterfaceUserRepository接口的类需要修改时我们可以直接创建个新类，然后RepositoryFactory类中让UserRepository属性返回新类就行了。
    /// </summary>
    public static class RepositoryFactory
    {
        public static InterfaceUserRepository 
            UserRepository { get { return new UserRepository(); } }
    }
}
