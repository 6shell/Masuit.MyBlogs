namespace Masuit.MyBlogs.Core.Models.Command;

/// <summary>
/// ���·�������ģ��
/// </summary>
public class CategoryCommand : BaseEntity
{
	public CategoryCommand()
	{
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
}