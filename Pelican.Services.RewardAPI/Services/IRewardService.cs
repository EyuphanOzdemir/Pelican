using Pelican.Services.RewardAPI.Message;

namespace Pelican.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
