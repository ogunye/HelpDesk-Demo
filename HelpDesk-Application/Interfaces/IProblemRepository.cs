using HelpDesk_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Application.Interfaces
{
    public interface IProblemRepository
    {
        Task<IEnumerable<Problem>> GetFaultsAsync(bool trackChanges);
        Task<Problem> GetFaultById(int Id, bool trackChanges);
        void CreateFault(Problem problem);
        void DeleteFault(Problem problem);
    }

}
