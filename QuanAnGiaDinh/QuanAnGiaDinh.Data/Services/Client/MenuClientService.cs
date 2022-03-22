using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.Data.Services.Client
{
    public class MenuClientService:ServiceBase
    {
        public MenuClientService() : base()
        {
            this.NOT_DELETED_CONDITION = "ThucDon!=\"\"";
            this.DELETE_STATEMENT = "ThucDon=N\"\"";
        }
    }
}
