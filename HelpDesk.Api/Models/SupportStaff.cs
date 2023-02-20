namespace HelpDesk.Api.Models
{
    public class SupportStaff
    {
        public int Id { get; set; }
        public DateTime date_joined { get; set; }
        public DateTime date_left { get; set; }
        public string staff_name { get; set; }
        public string staff_phone { get; set; }
        public string staff_email { get; set; }
        public string staff_address { get; set; }
    }
}
