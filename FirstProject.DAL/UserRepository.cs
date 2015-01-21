using FirstProject.IDAL;
using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL
{
    /// <summary>
    /// 用户仓库
    /// </summary>
    public class UserRepository:BaseRepository<User>,InterfaceUserRepository
    {
    }
}
