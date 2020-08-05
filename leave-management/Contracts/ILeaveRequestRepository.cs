using leave_management.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        Task<ICollection<LeaveRequest>> GetLeaveRequestsByEmployee(string employeeid);
    }
}
