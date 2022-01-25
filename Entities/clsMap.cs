using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class clsMap
    {
        #region Attributes
        int id;
        String creator;
        int size;
        bool comunityMap;
        #endregion
        #region Builders

        public clsMap()
        {

        }

        public clsMap(int id,String creator,int size,bool comunityMap)
        {
            this.id = id;
            this.creator = creator;
            this.size = size;
            this.comunityMap = comunityMap;
        }
        #endregion
        #region Getters & Setters
        public bool ComunityMap { get => comunityMap; set => comunityMap = value; }
        public int Id { get => id; set => id = value; }
        public string Creator { get => creator; set => creator = value; }
        public int Size { get => size; set => size = value; }
        #endregion
    }
}
