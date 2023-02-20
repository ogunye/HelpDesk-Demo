using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Problem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Equipment Id is a required field.")]
        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set; }

        [Required(ErrorMessage = "User is a required field.")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Problem Description is a required field.")]
        [StringLength(500, ErrorMessage ="Maximum character length is 500.")]
        public string ProblemDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual User User { get; set; }
    }
}
