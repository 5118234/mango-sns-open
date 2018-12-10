using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Mango.Entity
{
    public partial class m_PostsCommentsRecords
    {
		
        /// <summary>
        /// ��¼Id
        /// </summary>
        [Key]
        public int? RecordsId { get; set; }
		
        /// <summary>
        /// ����Id
        /// </summary>
        
        public int? CommentId { get; set; }
		
        /// <summary>
        /// �û�Id
        /// </summary>
        
        public int? UserId { get; set; }
		
        /// <summary>
        /// ���ʱ��
        /// </summary>
        
        public DateTime? AppendTime { get; set; }
		
        /// <summary>
        /// ��¼���� 1��ʾ���޲��� 2��ʾ���Բ���
        /// </summary>
        
        public int? RecordsType { get; set; }
		
    }
}