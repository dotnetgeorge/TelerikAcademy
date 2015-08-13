namespace StudentSystem.Data.Mapping
{
    using System;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using StudentSystem.Model;

    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            this.HasKey(x => x.CourseID);
            this.Property(x => x.Name).HasMaxLength(100).IsUnicode(true);
            this.Property(x => x.Description).HasMaxLength(4000).IsUnicode(true);
            this.Property(x => x.Materials).HasMaxLength(4000).IsUnicode(true);
        }
    }
}
