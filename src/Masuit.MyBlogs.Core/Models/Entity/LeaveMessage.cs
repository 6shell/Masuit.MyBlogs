using Masuit.MyBlogs.Core.Models.Validation;
using Masuit.Tools.Core.Validator;
using Masuit.Tools.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Masuit.MyBlogs.Core.Models.Entity;

/// <summary>
/// ���԰�
/// </summary>
[Table("LeaveMessage")]
public class LeaveMessage : BaseEntity, ITreeParent<LeaveMessage>, ITreeChildren<LeaveMessage>, IEntityTypeConfiguration<LeaveMessage>
{
    public LeaveMessage()
    {
        PostDate = DateTime.Now;
        Status = Status.Pending;
        IsMaster = false;
        Children = new List<LeaveMessage>();
    }

    /// <summary>
    /// �ǳ�
    /// </summary>
    [Required(ErrorMessage = "�ǳƲ���Ϊ�գ�")]
    public string NickName { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), SubmitCheck]
    public string Content { get; set; }

    /// <summary>
    /// ����ʱ��
    /// </summary>
    public DateTime PostDate { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    [IsEmail]
    public string Email { get; set; }

    /// <summary>
    /// ����ID
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// ������汾
    /// </summary>
    [StringLength(255)]
    public string Browser { get; set; }

    /// <summary>
    /// ����ϵͳ�汾
    /// </summary>
    [StringLength(255)]
    public string OperatingSystem { get; set; }

    /// <summary>
    /// �Ƿ��ǲ���
    /// </summary>
    [DefaultValue(false)]
    public bool IsMaster { get; set; }

    /// <summary>
    /// �ύ��IP
    /// </summary>
    public string IP { get; set; }

    /// <summary>
    /// ������Ϣ
    /// </summary>
    public string Location { get; set; }

    public string GroupTag { get; set; }

    public string Path { get; set; }

    /// <summary>
    /// ���ڵ�
    /// </summary>
    public LeaveMessage Parent { get; set; }

    /// <summary>
    /// �Ӽ�
    /// </summary>
    public ICollection<LeaveMessage> Children { get; set; }

    /// <summary>
    ///     Configures the entity of type <typeparamref name="TEntity" />.
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<LeaveMessage> builder)
    {
        builder.HasMany(e => e.Children).WithOne(c => c.Parent).HasForeignKey(c => c.ParentId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
        builder.Property(c => c.Path).IsRequired();
        builder.Property(c => c.GroupTag).IsRequired();
    }
}
