﻿using System;
using Decision.DomainClasses.Common;

namespace Decision.DomainClasses.ApplicantInfo
{
  
    public class EducationalBackground : BaseEntity
    {
        #region Properties

        public double Score { get; set; }

        public AcademicDegrees AcademicDegree { get; set; }

        public string ThesisTopic { get; set; }

        public DateTime GraduationDate { get; set; }

        public DateTime EntryDate { get; set; }

        public string Advisor { get; set; }
     
        public string Supervisor { get; set; }

        public string Description { get; set; }

        public decimal GPA { get; set; }

        public decimal ThesisScore { get; set; }

        public string Country { get; set; }

        public string University { get; set; }
 
        public string Field { get; set; }
        #endregion

        #region NavigationProperties

        public Guid ApplicantId { get; set; }

        public Applicant Applicant { get; set; }
        #endregion
    }
}