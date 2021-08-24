using Formula1.Data;
using Formula1.Entities;
using Formula1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Repository
{
    public class TeamsRepository : IAppRepository<Teams>
    {
        readonly Formula1DbContext formula1Db;


        public TeamsRepository(Formula1DbContext _formula1Db)
        {
            formula1Db = _formula1Db;
        }
        public void Add(Teams teams)
        {
            formula1Db.Teams.Add(teams);
            formula1Db.SaveChanges();
        }

        public void Delete(Teams teams)
        {
            formula1Db.Teams.Remove(teams);
            formula1Db.SaveChanges();
        }

        public Teams Get(long id)
        {
            return formula1Db.Teams.FirstOrDefault(x => x.TeamID == id);
        }

        public IEnumerable<Teams> GetAll()
        {
            return formula1Db.Teams.ToList();
        }

        public void Update(Teams teams, Teams entity)
        {
            teams.TeamName = entity.TeamName;
            teams.TeamBase = entity.TeamBase;
            teams.TeamChief = entity.TeamChief;
            teams.TeamChassis = entity.TeamChassis;
            teams.TeamPowerUnit = entity.TeamPowerUnit;
            teams.TeamWorldChampionships = entity.TeamWorldChampionships;
            teams.TeamPolePositions = entity.TeamPolePositions;
            teams.TeamFastestLaps = entity.TeamFastestLaps;
            formula1Db.SaveChanges();
        }
    }
}
