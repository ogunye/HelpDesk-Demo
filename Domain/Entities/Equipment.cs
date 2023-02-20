using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public int EquipmentTypeCode { get; set; }
        public DateOnly EquipmentAqcuired { get; set; }
        public DateOnly EquipmentDisposed { get; set; }
        public int EquipmentCode { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentDescription { get; set; }
        public string? ManufacturerName { get; set; }
    }
}
