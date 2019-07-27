using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
    public class SystemCountryCodePoco
    {
        [Key]
        public string Code { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        //FK Relationship
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }

    }
}
