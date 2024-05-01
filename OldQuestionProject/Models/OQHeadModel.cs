using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldQuestionProject.Models
{
    [Table("OQHead")]
    public class OQHeadModel
    {
        [Key]
        public int OQId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? Subject { get; set; }
        public string? Grade { get; set; }
        public string? Type { get; set; }
        public string? Usrdef01 { get; set; }
        public string? Usrdef02 { get; set; }
        public string? Usrdef03 { get; set; }
        public string? Usrdef04 { get; set; }
        public string? FilePath { get; set; }


    }
}
