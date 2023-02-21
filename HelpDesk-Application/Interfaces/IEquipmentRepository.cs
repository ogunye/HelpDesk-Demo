using HelpDesk_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Application.Interfaces
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAllEquipmentAsync(bool trackChanges);
        Task<Equipment> GetEquipmentAsync(int id, bool trackChanges);
        void RegisterNewEquipment(Equipment equipment);
        void UnregisterNewEquipment(Equipment equipment);
    }
}
