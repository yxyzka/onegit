using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Goods_TypeManager:NetBLL<Goods_Type>
    {
        public Goods_TypeManager() : base(new Goods_TypeService()) { 
        }
    }
}
