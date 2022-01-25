using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class clsMap
    {
        #region Attributes
        int id;
        String nick;
        int size;
        bool communityMap;
        #endregion
        #region Builders

        public clsMap()
        {

        }

        public clsMap(int id,String creator,int size,bool comunityMap)
        {
            this.id = id;
            this.nick = creator;
            this.size = size;
            this.communityMap = comunityMap;
        }
        #endregion
        #region Getters & Setters
        public bool ComunityMap { get => communityMap; set => communityMap = value; }
        public int Id { get => id; set => id = value; }
        public string Creator { get => nick; set => nick = value; }
        public int Size { get => size; set => size = value; }
        #endregion
    }
}
