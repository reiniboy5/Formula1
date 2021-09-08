using Formula1.Data;
using Formula1.Entities;
using Formula1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Repository
{
    public class DriversRepository : IAppRepository<Drivers>
    {
        readonly Formula1DbContext formula1Db;


        public DriversRepository(Formula1DbContext _formula1Db)
        {
            formula1Db = _formula1Db;
        }

        public void Add(Drivers drivers)
        {
            formula1Db.Drivers.Add(drivers);
            formula1Db.SaveChanges();
        }

        public void Delete(Drivers drivers)
        {
            formula1Db.Drivers.Remove(drivers);
            formula1Db.SaveChanges();
        }

        public Drivers Get(long id)
        {
            return formula1Db.Drivers.FirstOrDefault(x => x.DriversID == id);
        }

        public IEnumerable<Drivers> GetAll()
        {
            return formula1Db.Drivers.ToList();
        }

        public void Update(Drivers drivers, Drivers entity)
        {
            drivers.DriverName = entity.DriverName;
            drivers.DiverSurname = entity.DiverSurname;
            drivers.DriverNumber = entity.DriverNumber;
            drivers.DriverImage = entity.DriverImage;
            formula1Db.SaveChanges();
        }
    }
}
