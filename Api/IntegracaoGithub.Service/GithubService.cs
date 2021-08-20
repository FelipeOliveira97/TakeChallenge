using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegracaoGithub.Model;
using IntegracaoGithub.Service.Interface;
using RestEase;

namespace IntegracaoGithub.Service
{
    public class GithubService : IGithubService
    {
        private readonly IGithubClient _githubClient;
        public GithubService(IGithubClient githubClient)
        {
            _githubClient = githubClient;
        }
        public async Task<IEnumerable<GithubRepo>> GetReposByLanguageAsync(string language, int totalReturn, string user)
        {
            var repos = await _githubClient.GetReposAsync(user, "created", "asc");

            return repos
            .Where(x => x.Language == language)
            .OrderBy(x => x.CreatedAt.DateTime)
            .Take(totalReturn);
        }
    }
}
