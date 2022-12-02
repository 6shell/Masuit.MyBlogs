using Masuit.Tools.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Masuit.MyBlogs.Core.Models.Entity;

/// <summary>
/// ���·���
/// </summary>
[Table("Category")]
public class Category : BaseEntity, ITree<Category>
{
	public Category()
	{
		Post = new HashSet<Post>();
		Status = Status.Available;
	}

	/// <summary>
	/// ������
	/// </summary>
	[Required(ErrorMessage = "����������Ϊ��"), MaxLength(64, ErrorMessage = "�������������64���ַ�"), MinLength(2, ErrorMessage = "����������2���ַ�")]
	public string Name { get; set; }

	/// <summary>
	/// ��������
	/// </summary>
	public string Description { get; set; }

	/// <summary>
	/// ����id
	/// </summary>
	public int? ParentId { get; set; }

	public string Path { get; set; }

	public virtual ICollection<Post> Post { get; set; }

	public virtual ICollection<PostHistoryVersion> PostHistoryVersion { get; set; }

	/// <summary>
	/// ���ڵ�
	/// </summary>
	public virtual Category Parent { get; set; }

	/// <summary>
	/// �Ӽ�
	/// </summary>
	public virtual ICollection<Category> Children { get; set; }
}