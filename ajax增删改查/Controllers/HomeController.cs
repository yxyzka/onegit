using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax增删改查.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Select()
        {
            GoodsManager good = new GoodsManager();
            List<Goods> lis = good.GetAll();
            var lis1 = lis.Select(x => new
            {
                x.GoodsId,
                x.GoodsName,
                x.Num,
                x.Price,
                typeName = x.Goods_Type.TypeName
            });
            return Json(lis1, JsonRequestBehavior.AllowGet);
        }
        /*根据名字查询*/
        [HttpPost]
        public ActionResult SelectId(Goods info1) {
            GoodsManager gooid = new GoodsManager();
            var lis = gooid.GetEntitysWhereAsNoTracking(x => x.GoodsName == info1.GoodsName);
            var list1 = lis.Select(x => new {
                x.GoodsId,
                x.GoodsName,
                x.Num,
                x.Price,
                x.Goods_Type.TypeName
            });
            return Json(list1, JsonRequestBehavior.AllowGet);
        }
        //根据id删除
        public ActionResult DelectId(Goods info1) {
            GoodsManager goods = new GoodsManager();
            var lis = goods.Delete(info1.GoodsId);
            return Json(lis, JsonRequestBehavior.AllowGet);
        }
        //下拉框显示
        public ActionResult selectOption() {
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}