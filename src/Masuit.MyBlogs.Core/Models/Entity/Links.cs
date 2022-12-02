using Masuit.Tools.Core.AspNetCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Masuit.MyBlogs.Core.Models.Entity;

/// <summary>
/// ��������
/// </summary>
[Table("Links")]
public class Links : BaseEntity
{
	public Links()
	{
		Status = Status.Available;
		Except = false;
		UpdateTime = DateTime.Now;
	}

	/// <summary>
	/// ����
	/// </summary>
	[Required(ErrorMessage = "վ��������Ϊ�գ�"), MaxLength(32, ErrorMessage = "վ�����������32����")]
	public string Name { get; set; }

	/// <summary>
	/// URL
	/// </summary>
	[Required(ErrorMessage = "վ���URL����Ϊ�գ�"), MaxLength(64, ErrorMessage = "վ���URL����64���ַ�")]
	public string Url { get; set; }

	/// <summary>
	/// ��ҳ��ַ
	/// </summary>
	[Required(ErrorMessage = "վ�����ҳURL����Ϊ�գ�"), MaxLength(64, ErrorMessage = "վ�����ҳURL����64���ַ�")]
	public string UrlBase { get; set; }

	/// <summary>
	/// �Ƿ��������
	/// </summary>
	public bool Except { get; set; }

	/// <summary>
	/// �Ƿ����Ƽ�վ��
	/// </summary>
	public bool Recommend { get; set; }

	/// <summary>
	/// ����ʱ��
	/// </summary>
	public DateTime UpdateTime { get; set; }

	[UpdateIgnore]
	public virtual ICollection<LinkLoopback> Loopbacks { get; set; }
}