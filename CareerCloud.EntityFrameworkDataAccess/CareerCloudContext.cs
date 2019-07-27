using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext: DbContext
    {
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }


        public CareerCloudContext():base(SqlUtility.ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //FK relationships
            RelateApplicantProfile(modelBuilder);
            RelateCompanyJob(modelBuilder);
            RelateSystemCountryCode(modelBuilder);
            RelateSecurityLogin(modelBuilder);
            RelateSecurityRole(modelBuilder);
            RelateCompanyProfile(modelBuilder);
            RelateSystemLanguageCode(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void RelateApplicantProfile(DbModelBuilder modelBuilder) {

            //ApplicantProfilePoco -< ApplicantWorkHistories
            modelBuilder
                .Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantWorkHistories)
                .WithRequired(awh => awh.ApplicantProfiles)
                .HasForeignKey(awh => awh.Applicant)
                .WillCascadeOnDelete(true);

            //ApplicantProfilePoco -< ApplicantEducations
            modelBuilder
                .Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantEducations)
                .WithRequired(ae => ae.ApplicantProfiles)
                .HasForeignKey(ae => ae.Applicant)
                .WillCascadeOnDelete(true);

            //ApplicantProfilePoco -< ApplicantResumes
            modelBuilder
                .Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantResumes)
                .WithRequired(ar => ar.ApplicantProfiles)
                .HasForeignKey(ar => ar.Applicant)
                .WillCascadeOnDelete(true);

            //ApplicantProfilePoco -< ApplicantSkills
            modelBuilder
                .Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantSkills)
                .WithRequired(ask => ask.ApplicantProfiles)
                .HasForeignKey(ask => ask.Applicant)
                .WillCascadeOnDelete(true);

            //ApplicantProfilePoco -< ApplicantJobApplications
            modelBuilder
                .Entity<ApplicantProfilePoco>()
                .HasMany(ap => ap.ApplicantJobApplications)
                .WithRequired(aja => aja.ApplicantProfiles)
                .HasForeignKey(aja => aja.Applicant)
                .WillCascadeOnDelete(true);

        }

        private void RelateCompanyJob(DbModelBuilder modelBuilder)
        {
            //CompanyJobPoco -< ApplicantJobApplications
            modelBuilder
                .Entity<CompanyJobPoco>()
                .HasMany(cj => cj.ApplicantJobApplications)
                .WithRequired(aja => aja.CompanyJobs)
                .HasForeignKey(aja => aja.Job)
                .WillCascadeOnDelete(true);

            //CompanyJobPoco -< CompanyJobDescriptions
            modelBuilder
                .Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobDescriptions)
                .WithRequired(cjd => cjd.CompanyJobs)
                .HasForeignKey(cjd => cjd.Job)
                .WillCascadeOnDelete(true);

            //CompanyJobPoco -< CompanyJobEducations
            modelBuilder
                .Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobEducations)
                .WithRequired(cje => cje.CompanyJobs)
                .HasForeignKey(cje => cje.Job)
                .WillCascadeOnDelete(true);

            //CompanyJobPoco -< CompanyJobSkills
            modelBuilder
                .Entity<CompanyJobPoco>()
                .HasMany(cj => cj.CompanyJobSkills)
                .WithRequired(cjs => cjs.CompanyJobs)
                .HasForeignKey(cjs => cjs.Job)
                .WillCascadeOnDelete(true);

        }

        private void RelateSystemCountryCode(DbModelBuilder modelBuilder)
        {
            //SystemCountryCodePoco -< ApplicantWorkHistories
            modelBuilder
                .Entity<SystemCountryCodePoco>()
                .HasMany(scc => scc.ApplicantWorkHistories)
                .WithRequired(awh => awh.SystemCountryCodes)
                .HasForeignKey(awh => awh.CountryCode)
                .WillCascadeOnDelete(true);

            //SystemCountryCodePoco -< ApplicantWorkHistories
            modelBuilder
                .Entity<SystemCountryCodePoco>()
                .HasMany(scc => scc.ApplicantProfiles)
                .WithRequired(ap => ap.SystemCountryCodes)
                .HasForeignKey(ap => ap.Country) //Different name for CountryCode
                .WillCascadeOnDelete(true);
        }

        private void RelateSecurityLogin(DbModelBuilder modelBuilder)
        {
            //SecurityLoginPoco -< ApplicantProfiles
            modelBuilder
                .Entity<SecurityLoginPoco>()
                .HasMany(sl => sl.ApplicantProfiles)
                .WithRequired(ap => ap.SecurityLogins)
                .HasForeignKey(ap => ap.Login)
                .WillCascadeOnDelete(true);

            //SecurityLoginPoco -< SecurityLoginsLogs
            modelBuilder
                .Entity<SecurityLoginPoco>()
                .HasMany(sl => sl.SecurityLoginsLogs)
                .WithRequired(sll => sll.SecurityLogins)
                .HasForeignKey(sll => sll.Login)
                .WillCascadeOnDelete(true);

            //SecurityLoginPoco -< SecurityLoginsRoles
            modelBuilder
                .Entity<SecurityLoginPoco>()
                .HasMany(sl => sl.SecurityLoginsRoles)
                .WithRequired(slr => slr.SecurityLogins)
                .HasForeignKey(slr => slr.Login)
                .WillCascadeOnDelete(true);
        }

        private void RelateSecurityRole(DbModelBuilder modelBuilder)
        {
            //SecurityRolePoco -< SecurityLoginsRoles
            modelBuilder
                .Entity<SecurityRolePoco>()
                .HasMany(sr => sr.SecurityLoginsRoles)
                .WithRequired(slr => slr.SecurityRoles)
                .HasForeignKey(slr => slr.Role)
                .WillCascadeOnDelete(true);
        }

        private void RelateCompanyProfile(DbModelBuilder modelBuilder)
        {
            //CompanyProfilePoco -< CompanyLocations
            modelBuilder
                .Entity<CompanyProfilePoco>()
                .HasMany(cp => cp.CompanyLocations)
                .WithRequired(cl => cl.CompanyProfiles)
                .HasForeignKey(cl => cl.Company)
                .WillCascadeOnDelete(true);

            //CompanyProfilePoco -< CompanyJobs
            modelBuilder
                .Entity<CompanyProfilePoco>()
                .HasMany(cp => cp.CompanyJobs)
                .WithRequired(cj => cj.CompanyProfiles)
                .HasForeignKey(cj => cj.Company)
                .WillCascadeOnDelete(true);

            //CompanyProfilePoco -< CompanyDescriptions
            modelBuilder
                .Entity<CompanyProfilePoco>()
                .HasMany(cp => cp.CompanyDescriptions)
                .WithRequired(cd => cd.CompanyProfiles)
                .HasForeignKey(cd => cd.Company)
                .WillCascadeOnDelete(true);
        }

        private void RelateSystemLanguageCode(DbModelBuilder modelBuilder)
        {
            //SystemLanguageCodePoco -< CompanyDescriptions
            modelBuilder
                .Entity<SystemLanguageCodePoco>()
                .HasMany(slc => slc.CompanyDescriptions)
                .WithRequired(cd => cd.SystemLanguageCodes)
                .HasForeignKey(cd => cd.LanguageId)
                .WillCascadeOnDelete(true);
        }

    }
}
