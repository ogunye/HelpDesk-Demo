using HelpDesk.Api.Data;
using HelpDesk.Api.Models;
using HelpDesk.Api.Repository.Interfaces;

namespace HelpDesk.Api.Repository
{
    public class SupportStaffRepository : ISupportStaffRepository
    {
        private RepositoryContext _repositoryContext;

        public SupportStaffRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void CreateSupportStaff(SupportStaff supportStaff)
        {
            var supportStaffEntity = _repositoryContext.Add(supportStaff);
            _repositoryContext.SaveChanges();
        }

        public void DeleteSupportStaff(SupportStaff supportStaff)
        {
               
        }

        public Task<IEnumerable<SupportStaff>> GetAllSupportStaff()
        {
            throw new NotImplementedException();
        }

        public Task<SupportStaff> GetSupportStaffAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupportStaff(SupportStaff supportStaff)
        {
            throw new NotImplementedException();
        }
    }
}
