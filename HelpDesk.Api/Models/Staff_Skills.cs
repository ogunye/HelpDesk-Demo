using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Api.Models
{
    public class Staff_Skills
    {
        [Key]
        [ForeignKey(nameof(SupportStaff))]
        public int StaffId { get; set; }

        [Key]
        [ForeignKey(nameof(Ref_Skill_Codes))]
        public int SkillCode { get; set; }
        public DateTime SkillObtained { get; set; }
    }
}
