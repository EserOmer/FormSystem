using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class FormContext : DbContext
    {
        public FormContext()
        {

        }
        public virtual DbSet<ENTUser> USER { get; set; }
        public virtual DbSet<ENTForm> FORM { get; set; }
        public virtual DbSet<ENTQuestion> QUESTION { get; set; }
        public virtual DbSet<ENTQuestionType> QUESTIONTYPE { get; set; }
        public virtual DbSet<ENTChoice> CHIOCE { get; set; }
        public virtual DbSet<ENTAnswer> ANSWER { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=OMER-ESER\SQLEXPRESS;Initial Catalog=FORMSYS;persist security info=True;user id=sa;password=123456;");
            }
        }
    }
}

//public static SqlConnection Baglanti = new SqlConnection(@"Data Source=OMER-ESER\SQLEXPRESS;Initial Catalog=FORMSYS;persist security info=True;user id=sa;password=123456;");