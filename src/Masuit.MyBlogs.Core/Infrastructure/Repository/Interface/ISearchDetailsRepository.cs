﻿using Masuit.MyBlogs.Core.Models.Entity;

namespace Masuit.MyBlogs.Core.Infrastructure.Repository.Interface
{
    public partial interface ISearchDetailsRepository : IBaseRepository<SearchDetails>
    {
        /// <summary>
        /// 搜索统计
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        List<SearchRank> GetRanks(DateTime start);
    }
}