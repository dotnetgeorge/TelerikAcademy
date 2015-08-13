namespace StudentSystem.Data.Mapping
{
    using System;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using StudentSystem.Model;

    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            this.HasKey(x => x.StudentID);
            this.Property(x => x.Name).HasMaxLength(70).IsUnicode(true);
            this.Property(x => x.Number);
        }
    }
}
