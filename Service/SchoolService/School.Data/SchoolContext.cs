using Microsoft.EntityFrameworkCore;
using School.Domain;

namespace School.Data
{
	public class SchoolContext : DbContext
	{
		private const string ConnectionString = "Data Source=localhost;Initial Catelog=SchoolProjectDB";

		public DbSet<Class> Classes { get; set; }
		public DbSet<ClassLevel> ClassLevels { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Creditor> Creditors { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Parent> Parents { get; set; }
		public DbSet<School.Domain.School> Schools { get; set; }
		public DbSet<SchoolEnrolment> SchoolEnrolments { get; set; }
		public DbSet<SchoolOpenClass> SchoolOpenClasses { get; set; }
		public DbSet<SchoolTerm> SchoolTerms { get; set; }
		public DbSet<SchoolVariable> SchoolVariables { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectionString);
		}
	}
}
