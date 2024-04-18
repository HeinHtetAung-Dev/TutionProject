using Microsoft.AspNetCore.Routing.Patterns;
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
        
        private string _id = Guid.NewGuid().ToString();

        private string _id2 = Guid.NewGuid().ToString();
    }
}