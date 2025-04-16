using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TeamService.Models;
using TeamService.Persistence;

namespace TeamService.Controllers
{
    [Route("/teams/{teamId}/[controller]")]
    public class MembersController : Controller
    {
        ITeamRepository repository;

        public MembersController(ITeamRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IActionResult GetMembers(Guid teamID)
        {
            Team team = repository.Get(teamID);
            return team != null ? Ok(team.Members) : NotFound();
        }
    }
}
