using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using TutionProject.OldQuestionProject.Models;

namespace OldQuestionProject
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<LoginModel> Blog { get; set; }
        public DbSet<UsersModel> User { get; set; }
    }
}