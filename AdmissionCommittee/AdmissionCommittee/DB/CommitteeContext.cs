using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmissionCommittee.Models;

namespace AdmissionCommittee.DB
{
    internal sealed class CommitteeContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; } = null!;
    }
}
