﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using CMS.Util;
using CMS.Util.Model;
using CMS.Entity;
using CMS.Model;
using CMS.Admin.Web.Controllers;
using CMS.Entity.OrganizationManage;
using CMS.Business.OrganizationManage;
using CMS.Model.Param.OrganizationManage;
using Microsoft.AspNetCore.Mvc;
using CMS.Web.Code;

namespace CMS.Admin.Web.Areas.OrganizationManage.Controllers
{
    [Area("OrganizationManage")]
    public class NewsController : BaseController
    {
        private NewsBLL newsBLL = new NewsBLL();

        #region 视图功能
        [AuthorizeFilter("organization:news:view")]
        public IActionResult NewsIndex()
        {
            return View();
        }

        public async Task<IActionResult> NewsForm()
        {
            ViewBag.OperatorInfo = await Operator.Instance.Current();
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("organization:news:search")]
        public async Task<IActionResult> GetListJson(NewsListParam param)
        {
            TData<List<NewsEntity>> obj = await newsBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("organization:news:search")]
        public async Task<IActionResult> GetPageListJson(NewsListParam param, Pagination pagination)
        {
            TData<List<NewsEntity>> obj = await newsBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("organization:news:view")]
        public async Task<IActionResult> GetFormJson(long id)
        {
            TData<NewsEntity> obj = await newsBLL.GetEntity(id);
            return Json(obj);
        }

        [HttpGet]
        public async Task<IActionResult> GetMaxSortJson()
        {
            TData<int> obj = await newsBLL.GetMaxSort();
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("organization:news:add,organization:news:edit")]
        public async Task<IActionResult> SaveFormJson(NewsEntity entity)
        {
            TData<string> obj = await newsBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("organization:news:delete")]
        public async Task<IActionResult> DeleteFormJson(string ids)
        {
            TData obj = await newsBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
