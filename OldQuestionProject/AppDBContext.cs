using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.EntityFrameworkCore;
using OldQuestionProject.Models;
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
        public DbSet<OQHeadModel> OQ { get; set; }
        public DbSet<ListdetlModel> List { get; set; }
    }
}