using HelpDesk_Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Domain.Models
{
    public class Equipment : AuditableEntity
    {
        public int EquipmentTypeCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime EquipmentAqcuired { get; set; }

        [DataType(DataType.Date)]
        public DateTime EquipmentDisposed { get; set; }

        [Range(1, int.MaxValue)]
        public int EquipmentCode { get; set; }

        [Required(ErrorMessage ="Equipment Name is a required field.")]
        [StringLength(200, ErrorMessage ="Maximum character length is 200.")]
        public string? EquipmentName { get; set; }

        
        [StringLength(500, ErrorMessage = "Maximum character length is 500.")]
        public string? EquipmentDescription { get; set; }

        [StringLength(100, ErrorMessage = "Maximum character length is 100.")]
        public string? ManufacturerName { get; set; }
    }
}
