using System.Collections.Generic;
using System.Threading.Tasks;
using TestTaskForMekashop.DOMAIN.Entity;
using TestTaskForMekashop.DOMAIN.Response;
using TestTaskForMekashop.DOMAIN.ViewModels.User;

namespace TestTaskForMekashop.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model);
        
        BaseResponse<Dictionary<int, string>> GetRoles();
        
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();
        
        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}