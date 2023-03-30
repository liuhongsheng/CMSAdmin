﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Cache.Factory;
using CMS.Entity.SystemManage;
using CMS.Service.SystemManage;

namespace CMS.Business.Cache
{
    public class DataDictCache : BaseBusinessCache<DataDictEntity>
    {
        private DataDictService dataDictService = new DataDictService();

        public override string CacheKey => this.GetType().Name;

        public override async Task<List<DataDictEntity>> GetList()
        {
            var cacheList = CacheFactory.Cache.GetCache<List<DataDictEntity>>(CacheKey);
            if (cacheList == null)
            {
                var list = await dataDictService.GetList(null);
                CacheFactory.Cache.SetCache(CacheKey, list);
                return list;
            }
            else
            {
                return cacheList;
            }
        }
    }
}
