using System.Collections.Generic;
using System.Threading.Tasks;
using IntegracaoGithub.Model;

namespace IntegracaoGithub.Service.Interface
{
    public interface IGithubService
    {
        Task<IEnumerable<GithubRepo>> GetReposByLanguageAsync(string language, int totalReturn, string user);
    }
}