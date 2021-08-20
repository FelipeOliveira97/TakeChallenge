using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IntegracaoGithub.Model;
using RestEase;

namespace IntegracaoGithub.Service.Interface
{
    [Header("Accept","application/vnd.github.v3+json")]
    [Header("User-Agent", "RestEase Sample")]
    public interface IGithubClient
    {
        [Get("users/{username}/repos")]
        Task<IEnumerable<GithubRepo>> GetReposAsync(
            [Path("username")] string username,
            [Query("sort")] string sort,
            [Query("direction")] string direction);
    }
}
