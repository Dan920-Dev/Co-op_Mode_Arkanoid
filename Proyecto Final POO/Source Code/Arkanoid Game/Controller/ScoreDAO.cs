using System.Collections.Generic;
using System.Data;

namespace Arkanoid_Game
{
    public class ScoreDAO
    {
        // Se obtienen los nombres de los jugadores y se agregan a una lista
        public static List<string> GetBestPlayers()
        {
            List<string> listBestPlayers = new List<string>();
            DataTable dt = null;
            dt = ConnectionDB.ExecuteQuery("SELECT nameplayer FROM PLAYERS ORDER BY score DESC, score LIMIT 10");
            foreach (DataRow row in dt.Rows)
            {
                listBestPlayers.Add(row[0].ToString());
            }
            return listBestPlayers;
        }
        
        // Se obtienen los puntajes y se agregana a una lista
        public static List<string> GetBestScores()
        {
            List<string> listBestScores = new List<string>();
            DataTable dt = null;
            dt = ConnectionDB.ExecuteQuery("SELECT score FROM PLAYERS ORDER BY score DESC, score LIMIT 10");
            foreach (DataRow row in dt.Rows)
            {
                listBestScores.Add(row[0].ToString());
            }
            return listBestScores;   
        }
    }
}