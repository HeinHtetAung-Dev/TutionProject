using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutionProject.OldQuestionProject.Models
{
    [Table("Tbl_User")]
    public class UsersModel
    {
        [Key]
        public int UserId { get; set; }
        //[Column("BlogTitle")]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}

