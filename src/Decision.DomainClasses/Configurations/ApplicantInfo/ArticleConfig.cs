﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.Entities.ApplicantInfo;

namespace Decision.DomainClasses.Configurations.ApplicantInfo
{
    /// <summary>
    /// نشان دهنده مپینگ  مربوط به کلاس مقاله متقاضی
    /// </summary>
    public class ArticleConfig : EntityTypeConfiguration<Article>
   {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ArticleConfig()
        {
            
            Property(j => j.Brief).IsMaxLength().IsOptional();
            Property(j => j.RowVersion).IsRowVersion();
            HasRequired(e => e.CreatedBy).WithMany().HasForeignKey(e => e.CreatedById).WillCascadeOnDelete(false);
            HasRequired(e => e.ModifiedBy).WithMany().HasForeignKey(e => e.ModifiedById).WillCascadeOnDelete(false);
        }
    }
}
