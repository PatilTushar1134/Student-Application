using Microsoft.EntityFrameworkCore;
using Student__System_With_Code_First.Models;

namespace Student__System_With_Code_First.Context
{
    public class Db_Context:DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options):base(options)
        {

        }
        public DbSet<Student_Model> student_tbl { get; set; }
    }
}
