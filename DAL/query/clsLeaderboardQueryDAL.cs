using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace DAL.query
{
    public class clsLeaderBoardQueryDAL
    {
        /// <summary>
        ///     <header>public static List<clsLeaderboard> generarListadoDepartamentosDAL()</header>
        ///     <description> This method calls the database and returns a list of clsLeaderboard</description>
        ///     <precondition> None </precondition>
        ///     <postcondition> returns List<clsLeaderboard> leaderboards to the BL </postcondition>
        /// </summary>
        /// <returns>returns List<clsLeaderboard> leaderboards</returns>
        public static List<clsLeaderboard> generarListadoDepartamentosDAL()
        {
            conecction.clsConnection conexion = new conecction.clsConnection();
            List<clsLeaderboard> leaderboards = new List<clsLeaderboard>();
            SqlConnection conection = null;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsLeaderboard oLeaderboard;

            try
            {
                conection = conexion.getConnection();
                miComando.CommandText = "SELECT * FROM Leaderboard";
                miComando.Connection = conection;
                miLector = miComando.ExecuteReader();
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oLeaderboard = new clsLeaderboard();
                        oLeaderboard.IdMap = (int)miLector["idMap"];
                        oLeaderboard.Nick = (String)miLector["nick"];
                        oLeaderboard.Score = (int)miLector["score"];
                        leaderboards.Add(oLeaderboard);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                miLector.Close();
                conexion.closeConnection(ref conection);
            }
            return leaderboards;
        }
    }
}
