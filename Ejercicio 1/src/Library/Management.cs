using System;
using System.Collections.Generic;
namespace Library
{

    public class Management
    {
        public string AdminName  {get;}
        public List<Sector> Sectors {get;}

        public Management (string SectorNumber)
        {
            this.AdminName = SectorNumber;
            this.Sectors = new List<Sector>();
        }
        public void AddSector (string SectorNumber, Sector sector)
        {
            Sectors.Add (sector);
        }
    }
}