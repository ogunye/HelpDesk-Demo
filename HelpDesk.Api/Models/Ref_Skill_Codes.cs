using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Api.Models
{
    public class Ref_Skill_Codes
    {
        [Key]
        public int SkillCode { get; set; }
        public string? Description { get; set; }
    }
}
