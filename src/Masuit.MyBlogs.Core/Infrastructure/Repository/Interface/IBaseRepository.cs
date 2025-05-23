﻿using Collections.Pooled;
using Dispose.Scope;
using Masuit.LuceneEFCore.SearchEngine;

namespace Masuit.MyBlogs.Core.Infrastructure.Repository.Interface;

public interface IBaseRepository<T> : IDisposable where T : LuceneIndexableBaseEntity
{
    /// <summary>
    /// 获取所有实体
    /// </summary>
    /// <returns>还未执行的SQL语句</returns>
    IQueryable<T> GetAll();

    /// <summary>
    /// 获取所有实体（不跟踪）
    /// </summary>
    /// <returns>还未执行的SQL语句</returns>
    IQueryable<T> GetAllNoTracking();

    /// <summary>
    /// 获取所有实体
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>还未执行的SQL语句</returns>
    IOrderedQueryable<T> GetAll<TS>(Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 获取所有实体（不跟踪）
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>还未执行的SQL语句</returns>
    IOrderedQueryable<T> GetAllNoTracking<TS>(Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 从二级缓存获取所有实体
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns></returns>
    PooledList<T> GetAllFromCache<TS>(Expression<Func<T, TS>> orderby, bool isAsc = true);

    /// <summary>
    /// 基本查询方法，获取一个集合
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>还未执行的SQL语句</returns>
    IQueryable<T> GetQuery(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 基本查询方法，获取一个集合
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="where">查询条件</param>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>还未执行的SQL语句</returns>
    IOrderedQueryable<T> GetQuery<TS>(Expression<Func<T, bool>> @where, Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 基本查询方法，获取一个集合，优先从二级缓存读取
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns></returns>
    PooledList<T> GetQueryFromCache(Expression<Func<T, bool>> where);

    /// <summary>
    /// 基本查询方法，获取一个集合，优先从二级缓存读取
    /// </summary>
    /// <typeparam name="TS">排序字段</typeparam>
    /// <param name="where">查询条件</param>
    /// <param name="orderby">排序方式</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns></returns>
    PooledList<T> GetQueryFromCache<TS>(Expression<Func<T, bool>> where, Expression<Func<T, TS>> orderby, bool isAsc = true);

    /// <summary>
    /// 基本查询方法，获取一个集合（不跟踪实体）
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>还未执行的SQL语句</returns>
    IQueryable<T> GetQueryNoTracking(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 基本查询方法，获取一个集合（不跟踪实体）
    /// </summary>
    /// <typeparam name="TS">排序字段</typeparam>
    /// <param name="where">查询条件</param>
    /// <param name="orderby">排序方式</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>还未执行的SQL语句</returns>
    IOrderedQueryable<T> GetQueryNoTracking<TS>(Expression<Func<T, bool>> @where, Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 获取第一条数据
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>实体</returns>
    T Get(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 从二级缓存获取第一条数据
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>实体</returns>
    Task<T> GetFromCacheAsync(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 获取第一条数据
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="where">查询条件</param>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>实体</returns>
    T Get<TS>(Expression<Func<T, bool>> @where, Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 获取第一条数据
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>实体</returns>
    Task<T> GetAsync(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 获取第一条数据
    /// </summary>
    /// <typeparam name="TS">排序</typeparam>
    /// <param name="where">查询条件</param>
    /// <param name="orderby">排序字段</param>
    /// <param name="isAsc">是否升序</param>
    /// <returns>实体</returns>
    Task<T> GetAsync<TS>(Expression<Func<T, bool>> @where, Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 获取第一条数据（不跟踪实体）
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>实体</returns>
    T GetNoTracking(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 根据ID找实体
    /// </summary>
    /// <param name="id">实体id</param>
    /// <returns>实体</returns>
    T GetById(int id);

    /// <summary>
    /// 根据ID找实体(异步)
    /// </summary>
    /// <param name="id">实体id</param>
    /// <returns>实体</returns>
    Task<T> GetByIdAsync(int id);

    /// <summary>
    /// 标准分页查询方法
    /// </summary>
    /// <typeparam name="TS"></typeparam>
    /// <param name="pageIndex">第几页</param>
    /// <param name="pageSize">每页大小</param>
    /// <param name="where">where Lambda条件表达式</param>
    /// <param name="orderby">orderby Lambda条件表达式</param>
    /// <param name="isAsc">升序降序</param>
    /// <returns></returns>
    PagedList<T> GetPages<TS>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TS>> orderby, bool isAsc);

    /// <summary>
    /// 标准分页查询方法
    /// </summary>
    /// <typeparam name="TS"></typeparam>
    /// <param name="pageIndex">第几页</param>
    /// <param name="pageSize">每页大小</param>
    /// <param name="where">where Lambda条件表达式</param>
    /// <param name="orderby">orderby Lambda条件表达式</param>
    /// <param name="isAsc">升序降序</param>
    /// <returns></returns>
    Task<PagedList<T>> GetPagesAsync<TS>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TS>> orderby, bool isAsc);

    /// <summary>
    /// 标准分页查询方法（不跟踪实体）
    /// </summary>
    /// <typeparam name="TS"></typeparam>
    /// <param name="pageIndex">第几页</param>
    /// <param name="pageSize">每页大小</param>
    /// <param name="where">where Lambda条件表达式</param>
    /// <param name="orderby">orderby Lambda条件表达式</param>
    /// <param name="isAsc">升序降序</param>
    /// <returns></returns>
    PagedList<T> GetPagesNoTracking<TS>(int pageIndex, int pageSize, Expression<Func<T, bool>> @where, Expression<Func<T, TS>> @orderby, bool isAsc = true);

    /// <summary>
    /// 根据ID删除实体
    /// </summary>
    /// <param name="id">实体id</param>
    /// <returns>删除成功</returns>
    bool DeleteById(int id);

    /// <summary>
    /// 根据ID删除实体
    /// </summary>
    /// <param name="id">实体id</param>
    /// <returns>删除成功</returns>
    Task<int> DeleteByIdAsync(int id);

    /// <summary>
    /// 删除实体
    /// </summary>
    /// <param name="t">需要删除的实体</param>
    /// <returns>删除成功</returns>
    bool DeleteEntity(T t);

    /// <summary>
    /// 根据条件删除实体
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>删除成功</returns>
    int DeleteEntity(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 添加实体
    /// </summary>
    /// <param name="t">需要添加的实体</param>
    /// <returns>添加成功</returns>
    T AddEntity(T t);

    /// <summary>
    /// 添加或更新实体
    /// </summary>
    /// <param name="key">更新键规则</param>
    /// <param name="t">需要保存的实体</param>
    /// <returns>保存成功</returns>
    T AddOrUpdate<TKey>(Expression<Func<T, TKey>> key, T t);

    /// <summary>
    /// 添加或更新实体
    /// </summary>
    /// <param name="key">更新键规则</param>
    /// <param name="entities">需要保存的实体</param>
    /// <returns>保存成功</returns>
    void AddOrUpdate<TKey>(Expression<Func<T, TKey>> key, IEnumerable<T> entities);

    /// <summary>
    /// 统一保存数据
    /// </summary>
    /// <returns>受影响的行数</returns>
    int SaveChanges();

    /// <summary>
    /// 统一保存数据（异步）
    /// </summary>
    /// <returns>受影响的行数</returns>
    Task<int> SaveChangesAsync();

    /// <summary>
    /// 判断实体是否在数据库中存在
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>是否存在</returns>
    bool Any(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 符合条件的个数
    /// </summary>
    /// <param name="where">查询条件</param>
    /// <returns>是否存在</returns>
    int Count(Expression<Func<T, bool>> @where);

    /// <summary>
    /// 删除多个实体
    /// </summary>
    /// <param name="list">实体集合</param>
    /// <returns>删除成功</returns>
    bool DeleteEntities(IEnumerable<T> list);

    void Dispose(bool disposing);

    T this[int id] => GetById(id);

    PooledList<T> this[Expression<Func<T, bool>> where] => GetQuery(where).ToPooledListScope();
}

public partial interface ICategoryRepository : IBaseRepository<Category>;

public partial interface ICommentRepository : IBaseRepository<Comment>;

public partial interface IDonateRepository : IBaseRepository<Donate>;

public partial interface IFastShareRepository : IBaseRepository<FastShare>;

public partial interface IInternalMessageRepository : IBaseRepository<InternalMessage>;

public partial interface ILeaveMessageRepository : IBaseRepository<LeaveMessage>;

public partial interface ILinksRepository : IBaseRepository<Links>;

public partial interface ILinkLoopbackRepository : IBaseRepository<LinkLoopback>;

public partial interface ILoginRecordRepository : IBaseRepository<LoginRecord>;

public partial interface IMenuRepository : IBaseRepository<Menu>;

public partial interface IMiscRepository : IBaseRepository<Misc>;

public partial interface INoticeRepository : IBaseRepository<Notice>;

public partial interface IPostRepository : IBaseRepository<Post>;

public partial interface IPostHistoryVersionRepository : IBaseRepository<PostHistoryVersion>;

public partial interface ISeminarRepository : IBaseRepository<Seminar>;

public partial interface ISystemSettingRepository : IBaseRepository<SystemSetting>;

public partial interface IUserInfoRepository : IBaseRepository<UserInfo>;

public partial interface IPostMergeRequestRepository : IBaseRepository<PostMergeRequest>;

public partial interface IAdvertisementRepository : IBaseRepository<Advertisement>;

public partial interface IAdvertisementClickRecordRepository : IBaseRepository<AdvertisementClickRecord>;

public partial interface IVariablesRepository : IBaseRepository<Variables>;

public partial interface IPostVisitRecordRepository : IBaseRepository<PostVisitRecord>;

public partial interface IPostVisitRecordStatsRepository : IBaseRepository<PostVisitRecordStats>;

public partial interface IPostTagsRepository : IBaseRepository<PostTag>;

public partial interface IEmailBlocklistRepository : IBaseRepository<EmailBlocklist>;