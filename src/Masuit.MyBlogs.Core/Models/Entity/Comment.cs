﻿using Masuit.Tools.Core.Validator;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Masuit.MyBlogs.Core.Models.Entity;

/// <summary>
/// 评论表
/// </summary>
[Table("Comment")]
public class Comment : BaseEntity, ITreeEntity<Comment, int>, ITreeParent<Comment>, IEntityTypeConfiguration<Comment>
{
    public Comment()
    {
        Status = Status.Pending;
        IsMaster = false;
        Children = new List<Comment>();
    }

    /// <summary>
    /// 昵称
    /// </summary>
    [Required(ErrorMessage = "既然要评论，不留名怎么行呢！"), MaxLength(24, ErrorMessage = "别闹，你这名字太长了吧！"), MinLength(2, ErrorMessage = "昵称至少2个字！")]
    public string NickName { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    [IsEmail]
    public string Email { get; set; }

    /// <summary>
    /// 评论内容
    /// </summary>
    [Required(ErrorMessage = "评论内容不能为空！")]
    public string Content { get; set; }

    /// <summary>
    /// 父级ID
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// 文章ID
    /// </summary>
    public int PostId { get; set; }

    /// <summary>
    /// 发表时间
    /// </summary>
    public DateTime CommentDate { get; set; }

    /// <summary>
    /// 浏览器版本
    /// </summary>
    [StringLength(255)]
    public string Browser { get; set; }

    /// <summary>
    /// 操作系统版本
    /// </summary>
    [StringLength(255)]
    public string OperatingSystem { get; set; }

    /// <summary>
    /// 是否是博主
    /// </summary>
    [DefaultValue(false)]
    public bool IsMaster { get; set; }

    [NotMapped]
    public bool IsAuthor { get; set; }

    /// <summary>
    /// 支持数
    /// </summary>
    public int VoteCount { get; set; }

    /// <summary>
    /// 反对数
    /// </summary>
    public int AgainstCount { get; set; }

    /// <summary>
    /// 提交人IP地址
    /// </summary>
    public string IP { get; set; }

    /// <summary>
    /// 地理信息
    /// </summary>
    public string Location { get; set; }

    public string GroupTag { get; set; }

    public string Path { get; set; }

    [ForeignKey("PostId")]
    public virtual Post Post { get; set; }

    /// <summary>
    /// 子级
    /// </summary>
    public ICollection<Comment> Children { get; set; }

    /// <summary>
    /// 父节点
    /// </summary>
    public Comment Parent { get; set; }

    /// <summary>
    ///     Configures the entity of type <typeparamref name="TEntity" />.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasMany(e => e.Children).WithOne(c => c.Parent).HasForeignKey(c => c.ParentId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
        builder.Property(c => c.Path).IsRequired();
        builder.Property(c => c.GroupTag).IsRequired();
    }
}
