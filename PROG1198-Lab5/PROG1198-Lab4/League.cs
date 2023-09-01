using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace PROG1198_Lab4
{
    public class League
    {
        private IDbConnection db;
        public League(string connStr)
        {
            db = new SqlConnection(connStr);
        }
        public Team GetTeamByID(int teamID)
        {
            //string sql = "SELECT * FROM TEAM WHERE teamID = @teamID";
            string sql = "usp_SelectTeamByTeamID";

            //Team teamObj = db.Query<Team>(sql, new { teamID }).SingleOrDefault();
            Team teamObj = db.Query<Team>(sql, new { teamID }, commandType: CommandType.StoredProcedure).SingleOrDefault();

            return teamObj;
        }
        public void UpdateTeamObject(Team teamObject)
        {
            //string sql = "UPDATE TEAM SET teamName = @teamName, teamCity = @teamCity, teamStadium = @teamStadium, teamStadiumCapacity = @teamStadiumCapacity WHERE teamID = @teamID";
            string sql = "usp_UpdateTeam";
            try
            {
                db.Execute(sql, new { teamName = teamObject.teamName, teamCity = teamObject.teamCity, teamStadium = teamObject.teamStadium, teamStadiumCapacity = teamObject.teamStadiumCapacity, teamID = teamObject.teamID }, commandType: CommandType.StoredProcedure);
            }
            catch
            {
                throw new Exception("Update Failed on: " + teamObject);
            }
        }
        public List<Team> ReturnAllTeamObjects()
        {
            string sql = "SELECT * FROM TEAM";
            
            try
            {
                return db.Query<Team>(sql).ToList();
            }
            catch
            {
                throw new Exception("Error on: SELECT * FROM TEAM");
            }
        }

        public List<Team> ReturnTeamsByStadiumAndCapacity(string stadiumName, int stadiumCapacity)
        {
            string sql = "usp_SelectTeamsByStadiumAndCapacity";
           

            try
            {
                return db.Query<Team>(sql, new {teamStadium = stadiumName, teamStadiumCapacity = stadiumCapacity }, commandType: CommandType.StoredProcedure).ToList();
            }
            catch
            {
                throw new Exception("Error on: " + sql);
            }
        }
    }
}
