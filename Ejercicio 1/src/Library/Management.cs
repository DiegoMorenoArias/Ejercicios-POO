using System;
using System.Collections.Generic;
namespace Library
{

    public class Management
    {
        public string AdminName  {get;} // Administración, digamos que es la biblioteca en sí
        public List<Sector> Sectors {get;} // Lista de sectores

        public Management (string SectorNumber) // Constructor del objeto Management que tendrá un nombre y una lista de sectores asignada.
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