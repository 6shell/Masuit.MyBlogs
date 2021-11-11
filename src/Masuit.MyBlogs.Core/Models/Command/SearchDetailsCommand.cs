using System.ComponentModel.DataAnnotations;

namespace Masuit.MyBlogs.Core.Models.Command
{
    /// <summary>
    /// ������ϸ��¼����ģ��
    /// </summary>
    public class SearchDetailsCommand
    {
        public SearchDetailsCommand()
        {
            SearchTime = DateTime.Now;
        }

        /// <summary>
        /// �ؼ���
        /// </summary>
        [Required(ErrorMessage = "�ؼ��ʲ���Ϊ��"), MaxLength(64, ErrorMessage = "�ؼ����������64���ַ�")]
        public string Keywords { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime SearchTime { get; set; }

        /// <summary>
        /// ������IP
        /// </summary>
        public string IP { get; set; }
    }
}