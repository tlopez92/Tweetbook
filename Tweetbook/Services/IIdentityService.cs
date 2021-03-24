using System.Threading.Tasks;
using Tweetbook.Contracts.V1.Requests;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<AuthenticationResult> RefreshTokenAsync(string requestToken, string requestRefreshToken);
    }
}