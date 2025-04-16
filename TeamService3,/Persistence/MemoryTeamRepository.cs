using System;
using System.Collections.Generic;
using System.Linq;
using TeamService.Models;

namespace TeamService.Persistence
{
    public class MemoryTeamRepository : ITeamRepository
    {
        protected static ICollection<Team> teams = new List<Team>();

        public IEnumerable<Team> List() => teams;

        public Team Get(Guid id) => teams.FirstOrDefault(t => t.ID == id);

        public Team Add(Team team)
        {
            teams.Add(team);
            return team;
        }

        public Team Update(Team t)
        {
            Team team = this.Delete(t.ID);
            return team != null ? this.Add(t) : null;
        }

        public Team Delete(Guid id)
        {
            Team team = teams.FirstOrDefault(t => t.ID == id);
            if (team != null) teams.Remove(team);
            return team;
        }
    }
}
