### Masuit.MyBlogs
<a href="https://gitee.com/masuit/Masuit.MyBlogs"><img src="https://gitee.com/static/images/logo-black.svg" height="32"></a> <a href="https://github.com/ldqk/Masuit.MyBlogs"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Font_Awesome_5_brands_github.svg/54px-Font_Awesome_5_brands_github.svg.png" height="32"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/GitHub_logo_2013.svg/128px-GitHub_logo_2013.svg.png" height="32"></a>  
个人博客站项目源码，高性能低占用的博客系统，这也许是我写过的性能最高的web项目了。**仅1MB的代码量！** 目前日均处理请求数80-300w次，同时在线活跃用户数30-200人，**数据量累计已达到数百万条**，数据库+Redis+网站主程序同时运行在一台2核4GB的机器上，浏览器页面请求秒级响应，CPU平均使用率控制在10%左右，内存控制在1GB左右占用。**数据库支持SQL Server、mysql、PostgreSQL、sqlite的无缝切换。**  
![任务管理器](https://img11.360buyimg.com/ddimg/jfs/t1/170269/23/18655/93697/6076eb8fE82d545e7/78f0815f7311cd49.png)
![任务管理器](https://user-images.githubusercontent.com/20254980/129124177-37e0f98b-57ba-454f-955d-141201f50cc6.png)
![image](https://user-images.githubusercontent.com/20254980/129124476-88a324ac-cfd2-4e9b-8fb9-e84e12d04051.png)

### 演示站点
测试站点1：[https://masuit.org](https://masuit.org)，测试站点2：[https://masuit.com](https://masuit.com)，测试站点3：[https://masuit.tk](https://masuit.tk)，测试站点4：[https://ldqk.tk](https://ldqk.tk)

[![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg)](https://github.com/996icu/996.ICU/blob/master/LICENSE) ![codeSize](https://img.shields.io/github/languages/code-size/ldqk/Masuit.MyBlogs.svg) ![language](https://img.shields.io/github/languages/top/ldqk/Masuit.MyBlogs.svg)

请注意：一旦使用本开源项目以及引用了本项目或包含本项目代码的公司因为违反劳动法（包括但不限定非法裁员、超时用工、雇佣童工等）在任何法律诉讼中败诉的，项目作者有权利追讨本项目的使用费，或者直接不允许使用任何包含本项目的源代码！

## Star趋势  
<img src="https://starchart.cc/ldqk/Masuit.MyBlogs.svg">    

### 前端请求支援
目前网站前端页面的代码比较零乱，到处都是，大家想吐槽的尽管吐槽吧，也想找个人帮忙设计下整体的前端页面，有兴趣愿意贡献代码的的小伙伴，欢迎Pull Request吧！😂😂
### 开发环境
操作系统：Windows 10 2104  
IDE：Visual Studio 2022 v17.0  
数据库：SQL Server 2017+/MySQL 8.x/PostgreSQL 14.x  
Redis：redis-server-windows 5.x  
运行时：必须是.NET 6 
### 当前运行环境
操作系统：Windows Server 2019  
数据库：MySQL 8.0  
Redis：redis-server-windows 5.x  
运行时：.NET 6  
服务器配置：2核+6GB+1000M  
承载流量：单日请求量平均600w左右，单日带宽1TB左右  
`请勿使用阿里云、百度云等活动超卖机运行本程序，否则卡出翔！！！`  
`如何判断服务器商是否有超卖：给你的服务器跑个分，如果跑分接近于网络上该处理器公布的分数，则不是超卖的机器，计算公式：总分/核心数进行比较，由于是虚拟机，如果单独比较单核跑分，没有参考意义`
### 基础设施要求
||最低配置|推荐配置|豪华配置|至尊配置|
| --------   | -----:   | :----: | :----: | :----: |
|CPU|1核|2核|2核|4核|
|内存|1GB|2GB|4GB|8GB|
|带宽|1Mbps|1Mbps|5Mbps|1000Mbps|
|数据库|MySQL 5/SQL Server 2008/pgsql 9|MySQL 8/SQL Server 2012/pgsql 14|MySQL 8/SQL Server 2016/pgsql 14|MySQL 8/SQL Server 2016/pgsql 14|
|缓存组件|Redis 3.2+|Redis 5.0+|Redis 5.0+|Redis 5.0+|
|备注|玩玩而已|几个人同时访问|几百个人同时访问，单日请求量600w以下|单日请求量600w以上|
### 主要功能
#### 服务器性能监控
可直接在线实时监控服务器的运行状态，包括CPU、网络带宽、磁盘使用率、内存占用等情况，百分位统计和图表统计，可记录最近一天的服务器健康状态，通过websocket进行数据的推送，仅支持Windows，且需要Windows安装最新的更新。
![image](https://user-images.githubusercontent.com/20254980/127088294-89c63e04-399c-45a1-ae47-5b55ea86a05d.png)

#### 文章管理
- 包含文章审核、文章合并、文章列表的增删查改、分类管理、专题管理；
- 文章审核：当用户在前台页进行投稿后，会进入审核状态，审核通过后，才会在前台页的文章列表中展示出来。
- 文章合并：当用户在前台页进行了文章的编辑后，会创建出文章的合并请求，当后台管理进行相应的合并操作后，前台用户的修改才会正式生效，可以直接合并、编辑并合并和拒绝合并，拒绝时，修改人会收到相应的邮件通知。
- 文章操作：可对文章进行修改、新增、置顶、临时删除(下架)、还原、永久删除、禁止评论等操作，编辑后的文章会生成历史版本。文章支持模板变量。
- 分类管理：对文章的分类进行增删查改和文章的移动等操作，与文章的关系：一对多。
- 专题管理：对文章的专题进行管理，与文章的关系：多对多。
- 快速分享：首页快速分享栏目的管理。
![image](https://user-images.githubusercontent.com/20254980/127089680-c8f57334-2b7e-4ca2-a2a2-01a50d58e61b.png)
![image](https://user-images.githubusercontent.com/20254980/127088470-15fabe44-c45f-4801-b2fb-8fc034a593dd.png)
![image](https://user-images.githubusercontent.com/20254980/127089714-d85a3f8b-bb8e-4a0a-b6c1-0e4aead194e2.png)
![image](https://user-images.githubusercontent.com/20254980/127089725-25a5fa87-2c70-49bd-ada9-e65a8c71797d.png)
![image](https://user-images.githubusercontent.com/20254980/127089745-70ec7ac2-b80f-4059-abae-7ba362f02b60.png)
![image](https://user-images.githubusercontent.com/20254980/127089763-57457c59-cfdf-4b7d-a31b-8123dc944c88.png)

#### 评论和留言管理
对前台用户提交的留言和评论进行审核，当前台用户提交的内容可能包含有敏感词时，会进入人工审核，审核成功才会在前台页中展示。
#### 消息通知
站内消息包含评论、留言、投稿、文章合并等通知。
#### 公告管理
对网站的公告进行增删查改管理。支持定时上下架发布。
![image](https://user-images.githubusercontent.com/20254980/127088599-9d9d6b8b-9253-4f3d-8b9a-80965c002422.png)

#### 杂项页管理
一些通用的页面管理，可自由灵活的创建静态页面。
![image](https://user-images.githubusercontent.com/20254980/127088620-3ea1e808-7ce2-4ede-9a62-765609cfda94.png)

#### 系统设置
- 包含系统的全局设置、防火墙管理、网站运行日志记录、友链管理、邮件模板的管理。
- 全局设置：网站的一些基本配置和SEO相关操作等；
- 防火墙：对网站的所有请求进行全局流量的拦截，让规则内的请求阻止掉，支持黑名单、白名单、IP地址段、国家或地区、关键词审查等规则；
- 模板变量：针对文章内容的通用内容生成，变量只能添加不能删除。
![image](https://user-images.githubusercontent.com/20254980/127088748-13d56e4a-f5e0-4c59-9135-0af935d70976.png)
![image](https://user-images.githubusercontent.com/20254980/127088776-b95f8e8d-5f07-4937-8a9f-6a975ed29e31.png)
![image](https://user-images.githubusercontent.com/20254980/127089076-2599c484-9323-4d1a-82e5-61ef833ed4e3.png)
![image](https://user-images.githubusercontent.com/20254980/127089090-5b0dedcb-6be7-46ce-82e7-b4fcb50ea032.png)
![image](https://user-images.githubusercontent.com/20254980/127089200-cca28f8a-87bb-4a8b-b581-91c0572714c9.png)

#### 广告管理
主动式的广告投放管理，支持竞价排名，支持在banner、边栏、页内、列表内的广告展示，竞价或权重的高低决定广告出现的概率。支持按地区进行投放。
![image](https://user-images.githubusercontent.com/20254980/127089325-27b5bf4d-49ea-41ea-aae6-8829924bcc92.png)
![image](https://user-images.githubusercontent.com/20254980/127089358-7bab075c-5bb7-41ea-8900-29a2eecb71de.png)

#### 赞助管理
对网站打赏进行增删查改操作，自动掩码。
![image](https://user-images.githubusercontent.com/20254980/127089429-beb5baf0-c1d3-4880-85c0-9f897fb0de75.png)

#### 搜索统计
当前台用户每Session周期内的关键词搜索，不重复的关键词将会被记录，用于热词统计，仅记录最近一个月内的所有搜索关键词，用于统计当月、7天以及当天的搜索热词。
![image](https://user-images.githubusercontent.com/20254980/127089504-2c32288d-aa0d-4331-a3a2-90e97ba9f7a2.png)

#### 任务管理
hangfire的可视化管理页面
#### 文件管理
服务器文件的在线管理，支持浏览、预览、压缩、解压缩、创建文件夹、上传、下载、打包下载等文件的基本操作。
![image](https://user-images.githubusercontent.com/20254980/127089568-5d3bcef6-5ad7-4f44-b30d-b7253be2d3fb.png)
#### onedrive网盘程序
基于[YukiDrive](https://github.com/YukiCoco/YukiDrive)二次开发的内嵌网盘应用。
![image](https://user-images.githubusercontent.com/20254980/127090161-09fa9337-4601-4eaa-b47c-cefd8242910d.png)
![image](https://user-images.githubusercontent.com/20254980/127090259-868e38f8-abbe-474e-bdd3-4c241b49d1b5.png)

### 项目架构
- 项目采用单体架构，方便部署和配置，传统的MVC模式，ASP.NET Core MVC+EF Core的简单架构。  
- Controller→Service→Repository→DbContext  
![image](https://git.imweb.io/ldqk/imgbed/raw/master/5ccbcc714c3db.jpg)  
### 项目文件夹定义：
App_Data：存放网站的一些常规数据，以文本的形式存在，这类数据不需要频繁更新的。  
┠─cert文件夹：存放https证书  
┠─ban.txt：敏感词库  
┠─CustomKeywords.txt：搜索分词词库  
┠─denyip.txt：IP地址黑名单  
┠─DenyIPRange.txt：IP地址段黑名单  
┠─GeoLite2-City.mmdb：MaxMind地址库  
┠─ip2region.db：ip2region地址库  
┠─mod.txt：审查词库  
┠─whitelist.txt：IP地址白名单  
Common：之前老项目的Common项目；  
Configs：项目的一些配置对象  
Controllers：控制器  
Extensions：一些扩展类或一些项目的扩展功能，比如hangfire、ueditor、中间件、拦截器等；  
Infrastructure：数据访问基础设施，包含Repository和Services，相当于老项目的DAL和BLL；  
Migrations：数据库CodeFirst模式的迁移文件；  
Models：存放一些实体类或DTO；  
Views：razor视图  
wwwroot：项目的所有静态资源；  
### 核心功能点技术实现
#### 后端技术栈：
依赖注入容器：.NET Core自带的+Autofac，autofac主要负责批量注入和属性注入；  
实体映射框架：automapper 9.0；  
缓存框架：CacheManager统一管理网站的热数据，如Session、内存缓存，EFCoreSecondLevelCacheInterceptor负责管理EF Core的二级缓存；  
定时任务：hangfire统一管理定时任务，包含友链回链检查、文章定时发布、访客统计、搜索热词统计、Lucene库刷新等任务；  
Websocket：Blazor进行流推送实现服务器硬件健康状态的实时监控；  
硬件检测：Masuit.Tools封装的硬件检测功能；  
全文检索：Masuit.LuceneEFCore.SearchEngine基于Lucene.Net 4.8实现的全文检索中间件；  
中文分词：结巴分词结合本地词库实现中文分词；  
断点下载：Masuit.Tools封装的断点续传功能；  
Redis：CSRedis负责Redis的读写操作；  
文件压缩：Masuit.Tools封装的zip文件压缩功能；  
Html字符串操作：htmldiff.net-core实现文章版本的内容对比，HtmlAgilityPack实现html字符串的“DOM”操作，主要是用于提取img标签，HtmlSanitizer实现表单的html代码的仿XSS处理；  
图床：支持多个图床的上传：gitee、github、gitlab；  
拦截器：授权拦截器、请求拦截器负责网站全局流量的拦截和清洗、防火墙拦截器负责拦截网站自带防火墙规则的请求流量、异常拦截器、url重定向重写拦截器，主要用于将http的请求重定向到https；  
请求IP来源检查：maxmind+IP2Region+本地数据库实现请求IP的来源检查；  
RSS：WilderMinds.RssSyndication实现网站的RSS源；  
EF扩展功能：zzzproject相关nuget包  
Word文档转换：OpenXml实现浏览器端上传Word文档转换为html字符串。  
在线文件管理：angular-filemanager+文件管理代码实现服务器文件的在线管理  

#### 前端技术栈
##### 前台页面：
基于bootstrap3布局  
ueditor+layedit富文本编辑器  
notie提示栏+sweetyalert弹窗+layui组件  
angularjs  

##### 后台管理页：
- angularjs单一页面应用程序  
- material布局风格  
- echart图表组件  
- ng-table表格插件  
- material风格angular-filemanager文件管理器  
#### 性能和安全相关
- hangfire实现分布式任务调度；
- Z.EntityFramework.Plus实现数据访问层的高性能数据库批量操作；
- Lucene.NET实现高性能站内检索；
- 通过url的敏感词检查过滤恶意流量；
- 限制客户端的请求频次；
- 表单的AntiForgeryToken防止恶意提交；
- ip2region+MaxMind地址库实现请求来源审查；
- 用户信息采用端到端RSA非对称加密进行数据传输；
### 项目部署
以Windows系统为例，Linux系统请自行折腾。
#### 1.安装基础设施：
1. 安装.net6运行时：[https://dotnet.microsoft.com/zh-cn/download](https://dotnet.microsoft.com/zh-cn/download)
2. 安装mysql：[mysql 8 绿色版](https://masuit.org/1567),或pgsql：[pgsql 14 绿色版](https://masuit.org/2160)
3. 安装redis：[redis for windows绿色版](https://masuit.org/1567)
#### 2.生成网站应用
#### 方式一：编译源代码：
编译需要将[Masuit.Tools](https://github.com/ldqk/Masuit.Tools)项目和[Masuit.LuceneEFCore.SearchEngine](https://github.com/ldqk/Masuit.LuceneEFCore.SearchEngine)项目也一起clone下来，和本项目平级目录存放，才能正常编译，否则，将[Masuit.Tools](https://github.com/ldqk/Masuit.Tools)项目和[Masuit.LuceneEFCore.SearchEngine](https://github.com/ldqk/Masuit.LuceneEFCore.SearchEngine)项目移除，通过nuget安装也是可以的。  
![](https://git.imweb.io/ldqk/imgbed/raw/master/20191019/6370710386639200004363431.png)  
#### 方式二：下载编译好的现成的二进制文件
前往[Release](https://github.com/ldqk/Masuit.MyBlogs/releases)下载最新的压缩包解压即可。
#### 3.还原数据库脚本
创建数据库，名称随意，如：myblogs，然后前往[Release](https://github.com/ldqk/Masuit.MyBlogs/releases)或[https://github.com/ldqk/Masuit.MyBlogs/tree/master/database/mysql](https://github.com/ldqk/Masuit.MyBlogs/tree/master/database/mysql)下载最新的数据库文件,还原到新建的数据库。   
如果没有你目标数据库类型的还原文件，你可以先还原到mysql或pgsql中，然后使用[Full Convert](https://masuit.org/2163)转换成你需要的目标数据库类型即可。
#### 4.修改配置文件：
主要需要配置的是https证书、数据库连接字符、redis、BaiduAK以及图床配置，其他配置均为可选项，不配置则表示不启用；
![](https://p.pstatp.com/origin/1381c000155b45481aeec)  
同时，BaiduAK参与了数据库的加密，如果你没有BaiduAK，自行到百度地图开放平台申请，`免费的`。  
如果你使用了CDN，需要配置TrueClientIPHeader选项为真实IP请求转发头，如cloudflare的叫CF-Connecting-IP。
如果Redis不在本机，需要在配置文件中的Redis节下配置，固定为Redis，值的格式：127.0.0.1:6379,allowadmin=true，若未正确配置，将按默认值“127.0.0.1:6379,allowadmin=true,abortConnect=false”。  
其他配置请参考appsettings.json的注释按需配置即可。  
#### 5.启动网站
配置好环境和配置文件后，可直接通过dotnet Masuit.MyBlogs.Core.dll命令或直接双击Masuit.MyBlogs.Core.exe运行，也可以通过nssm挂在为Windows服务运行，或者你也可以尝试在Linux下部署。  
#### 其他方式部署
IIS：部署时必须将应用程序池的标识设置为LocalSystem，否则无法监控服务器硬件，同时需要安装.NET Core Hosting运行时环境，IIS程序池改为无托管代码。  
![](https://git.imweb.io/ldqk/imgbed/raw/master/5ccbf30b6a083.jpg)  
docker/Linux：自行爬文。  
#### 有偿代部署服务
请联系：admin@masuit.com

### 后台管理：
https://127.0.0.1:5001/dashboard
- 初始用户名：masuit  
- 初始密码：123abc@#$
`若密码不对，可在debug模式下进入后台【用户管理】下重置密码`

### 推荐项目
基于EntityFrameworkCore和Lucene.NET实现的全文检索搜索引擎：[Masuit.LuceneEFCore.SearchEngine](https://github.com/ldqk/Masuit.LuceneEFCore.SearchEngine "Masuit.LuceneEFCore.SearchEngine")

.NET万能框架工具库：[Masuit.Tools](https://github.com/ldqk/Masuit.Tools)
