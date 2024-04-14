using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutionProject.OldQuestionProject.Models
{
    [Table("Tbl_Login")]
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string SessionId { get; set; }
        public DateTime SessionExpired { get; set; }

    }
}