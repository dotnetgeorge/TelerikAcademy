namespace StudentSystem.Data.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using StudentSystem.Model;

    public class HomeworkMapping : EntityTypeConfiguration<Homework>
    {
        public HomeworkMapping()
        {
            this.HasKey(x => x.HomeworkID);
            this.Property(x => x.Content).HasMaxLength(4000).IsUnicode(true);
            this.Property(x => x.TimeSent);
        }
    }
}
