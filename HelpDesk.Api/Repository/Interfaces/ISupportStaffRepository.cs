using HelpDesk.Api.Models;

namespace HelpDesk.Api.Repository.Interfaces
{
    public interface ISupportStaffRepository
    {
        void CreateSupportStaff(SupportStaff supportStaff);
        void UpdateSupportStaff(SupportStaff supportStaff);
        void DeleteSupportStaff(SupportStaff supportStaff);
        Task<SupportStaff> GetSupportStaffAsync(int id);
        Task<IEnumerable<SupportStaff>> GetAllSupportStaff();
    }
}
