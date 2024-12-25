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
    [Table("Listdetl")]
    public class ListdetlModel
    {
        [Key]
        public int LsId { get; set; }
        public string? Code { get; set; }
        public string? Item { get; set; }
        public string? Descr { get; set; }
        public string? Usrdef01 { get; set; }
        public string? Usrdef02 { get; set; }
        public string? Usrdef03 { get; set; }
        public string? Usrdef04 { get; set; }
        public string? Usrdef05 { get; set; }
        public string? Usrdef05 { get; set; }
    }
}
