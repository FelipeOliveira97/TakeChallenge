using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegracaoGithub.Model;
using IntegracaoGithub.Service;
using IntegracaoGithub.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IntegracaoGithub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoriesController : ControllerBase
    {
        private readonly IGithubService _githubService;
        public RepositoriesController(IGithubService githubService)
        {
            _githubService = githubService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var repos = await _githubService.GetReposByLanguageAsync("C#", 5, "takenet");

            return Ok(repos);
        }
    }
}
