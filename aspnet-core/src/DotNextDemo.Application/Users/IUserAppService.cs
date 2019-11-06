using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DotNextDemo.Roles.Dto;
using DotNextDemo.Users.Dto;

namespace DotNextDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
