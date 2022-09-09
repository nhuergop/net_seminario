using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserApp.DAL.Entities
{

    [Table("Group")]
    public class Group
    {
        [Key]
        public int groupId { get; set; }
        public string groupName { get; set; }
        public bool Inactive { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}