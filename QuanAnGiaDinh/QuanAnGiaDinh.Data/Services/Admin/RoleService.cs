using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Admin
{
    public class RoleService:ServiceBase
    {
        public RoleService()
        {
            this.NOT_DELETED_CONDITION = "RoleName!=\"Không tồn tại\"";
            this.DELETE_STATEMENT = "RoleName=N\"Không tồn tại\"";
        }
    }
}
