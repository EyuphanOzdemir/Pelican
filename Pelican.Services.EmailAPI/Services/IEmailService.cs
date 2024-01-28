using Pelican.Services.EmailAPI.Message;
using Pelican.Services.EmailAPI.Models.Dto;

namespace Pelican.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
