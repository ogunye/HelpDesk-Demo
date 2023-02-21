using System.ComponentModel.DataAnnotations;

namespace HelpDesk_Domain.Models
{
    public class Ref_Skill_Codes 
    {
        [Key]
        public int SkillCode { get; set; }
        public string? Description { get; set; }
    }
}
