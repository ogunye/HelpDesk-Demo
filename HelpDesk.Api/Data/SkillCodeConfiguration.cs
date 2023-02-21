using HelpDesk.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDesk.Api.Data
{
    public class SkillCodeConfiguration : IEntityTypeConfiguration<Ref_Skill_Codes>
    {
        public void Configure(EntityTypeBuilder<Ref_Skill_Codes> builder)
        {
            builder.HasData
            (
                new Ref_Skill_Codes
                {
                    SkillCode = 1,
                    Description = "Hardware Repair"
                },
                new Ref_Skill_Codes
                {
                    SkillCode = 2,
                    Description = "Database Dev"
                },
                new Ref_Skill_Codes
                {
                    SkillCode = 3,
                    Description = "Backend Dev"
                }

            );
        }
    }
}
