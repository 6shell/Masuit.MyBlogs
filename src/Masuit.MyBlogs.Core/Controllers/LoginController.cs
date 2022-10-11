﻿using Masuit.MyBlogs.Core.Infrastructure.Services.Interface;
using Masuit.MyBlogs.Core.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Masuit.MyBlogs.Core.Controllers;

[Route("login")]
public class LoginController : AdminController
{
    public ILoginRecordService LoginRecordService { get; set; }

    [Route("delete/{id:int}/{ids}")]
    public async Task<ActionResult> Delete(int id, string ids)
    {
        if (!string.IsNullOrWhiteSpace(ids))
        {
            bool b = await LoginRecordService.DeleteEntitySavedAsync(r => r.UserInfoId == id && ids.Contains(r.Id.ToString())) > 0;
            return ResultData(null, b, b ? "删除成功！" : "删除失败");
        }

        return ResultData(null, false, "数据不合法");
    }

    [Route("getrecent/{id:int}")]
    public ActionResult GetRecentRecord(int id)
    {
        var time = DateTime.Now.AddMonths(-1);
        var list = LoginRecordService.GetQueryFromCache<DateTime, LoginRecordViewModel>(r => r.UserInfoId == id && r.LoginTime >= time, r => r.LoginTime, false);
        return ResultData(list);
    }
}