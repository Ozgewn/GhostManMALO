using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class clsLeaderBoard
    {
        #region Attributes
        int idMap;
        String nick;
        int score;
        #endregion
        #region Builders
        public clsLeaderBoard()
        {

        }
        public clsLeaderBoard(int idMap,String nick,int score)
        {
            this.idMap = idMap;
            this.nick = nick;
            this.score = score;
        }
        #endregion
        #region Getters & Setters
        public int IdMap { get => idMap; set => idMap = value; }
        public string Nick { get => nick; set => nick = value; }
        public int Score { get => score; set => score = value; }
        #endregion
    }
}
