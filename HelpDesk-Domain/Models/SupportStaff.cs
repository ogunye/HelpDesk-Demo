using HelpDesk_Domain.BaseEntity;

namespace HelpDesk_Domain.Models
{
    public class SupportStaff : AuditableEntity
    {
        public DateTime date_joined { get; set; }
        public DateTime date_left { get; set; }
        public string? staff_name { get; set; }
        public string? staff_phone { get; set; }
        public string? staff_email { get; set; }
        public string? staff_address { get; set; }
    }
}
