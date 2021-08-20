using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegracaoGithub.Model;
using IntegracaoGithub.Service.Interface;
using RestEase;

namespace IntegracaoGithub.Service
{
    public class GithubService
    {
        public async Task<IEnumerable<GithubRepo>> GetReposByLanguageAsync(string language, int totalReturn, string user)
        {
            var githubClient = RestClient.For<IGithubClient>("https://api.github.com");
            var repos = await githubClient.GetReposAsync(user, "created", "asc");

            return repos
            .Where(x => x.Language == language)
            .OrderBy(x => x.CreatedAt.DateTime)
            .Take(totalReturn);
        }
    }
}
