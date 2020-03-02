using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Mango.Framework.Data;
namespace Mango.Module.Core.Entity
{
    public partial class m_Message:EntityBase
    {
		
        /// <summary>
        /// ��ϢId
        /// </summary>
        [Key]
        public int? MessageId { get; set; }

        /// <summary>
        /// ��Ϣ����
        /// ϵͳ��Ϣ: 0:ϵͳ֪ͨ
        /// ������Ϣ: 1.���µ�����Ϣ,10:�ĵ����������Ϣ,11:�ĵ�������Ϣ
        /// </summary>

        public int? MessageType { get; set; }
		
        /// <summary>
        /// ����
        /// </summary>
        
        public string Contents { get; set; }
		
        /// <summary>
        /// �ύʱ��
        /// </summary>
        
        public DateTime? PostTime { get; set; }
		
        /// <summary>
        /// ��Ϣ�����˺�ID
        /// </summary>
        
        public int? AccountId { get; set; }
		
        /// <summary>
        /// ������Ϣ�˺�ID
        /// </summary>
        
        public int? AppendAccountId { get; set; }
		
        /// <summary>
        /// �洢����Id
        /// </summary>
        
        public int? ObjectId { get; set; }
		
        /// <summary>
        /// �Ƿ��Ѿ��Ķ�
        /// </summary>
        
        public bool? IsRead { get; set; }
		
    }
}