﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]

    public class ApplicantJobApplicationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Applicant { get; set; }

        public Guid Job { get; set; }

        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        //FK Relationship
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }

        public virtual CompanyJobPoco CompanyJobs { get; set; }

    }
}
