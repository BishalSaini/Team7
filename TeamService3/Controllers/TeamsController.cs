using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TeamService.Models;
using TeamService.Persistence;

namespace TeamService.Controllers
{
    [Route("[controller]")]
    public class TeamsController : Controller
    {
        ITeamRepository repository;

        public TeamsController(ITeamRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IActionResult GetAllTeams()
        {
            return Ok(repository.List());
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(Guid id)
        {
            Team team = repository.Get(id);
            return team != null ? Ok(team) : NotFound();
        }

        [HttpPost]
        public IActionResult CreateTeam([FromBody] Team newTeam)
        {
            repository.Add(newTeam);
            return Created($"/teams/{newTeam.ID}", newTeam);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTeam([FromBody] Team team, Guid id)
        {
            team.ID = id;
            return repository.Update(team) != null ? Ok(team) : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(Guid id)
        {
            Team team = repository.Delete(id);
            return team != null ? Ok(team.ID) : NotFound();
        }
    }
}
