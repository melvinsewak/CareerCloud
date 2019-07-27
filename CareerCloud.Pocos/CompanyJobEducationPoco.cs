using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CareerCloud.Pocos
{
    [Table("Company_Job_Educations")]
    public class CompanyJobEducationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Job { get; set; }

        public string Major { get; set; }

        public short Importance { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        //FK Relationship
        public virtual CompanyJobPoco CompanyJobs { get; set; }

    }
}
