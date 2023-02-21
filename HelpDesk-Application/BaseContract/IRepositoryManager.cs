using HelpDesk_Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Application.BaseContract
{
    public interface IRepositoryManager
    {
        IProblemRepository Problem { get; }
        IEquipmentRepository Equipment { get; }

        Task SaveAsync();
    }
}
