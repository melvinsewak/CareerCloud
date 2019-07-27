using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Login { get; set; }

        public Guid Role { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        //FK Relationship
        public virtual SecurityLoginPoco SecurityLogins { get; set; }
        public virtual SecurityRolePoco SecurityRoles { get; set; }
    }
}
