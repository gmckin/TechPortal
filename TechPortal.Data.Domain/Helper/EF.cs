using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPortal.Data.Domain.DataAccessObjects;

namespace TechPortal.Data.Domain.Helper
{
    public class EF : IEF
    {

        private TPDBEntities db;

        public EF(TPDBEntities context)
        {
            db = context;
        }



        #region Gets
        public List<JobTitle> GetJobTitles()
        {
            return db.JobTitle.ToList();
        }

        public List<Location> GetLocations()
        {
            return db.Location.ToList();
        }

        public List<ShiftStatus> GetStatuss()
        {
            return db.ShiftStatus.ToList();
        }

        public List<TechRole> GetTechRoles()
        {
            return db.TechRole.ToList();
        }

        public List<Tech> GetTechs()
        {
            return db.Tech.ToList();
        }
        #endregion

        #region Inserts
        public bool InsertJobTitle(JobTitle j)
        {
            db.JobTitle.Add(j);
            return db.SaveChanges() > 0;
        }

        public bool InsertLocation(Location l)
        {
            db.Location.Add(l);
            return db.SaveChanges() > 0;
        }

        public bool InsertStatus(ShiftStatus s)
        {
            db.ShiftStatus.Add(s);
            return db.SaveChanges() > 0;
        }

        public bool InsertTech(Tech t)
        {
            db.Tech.Add(t);
            return db.SaveChanges() > 0;
        }

        public bool InsertTechRole(TechRole tr)
        {
            db.TechRole.Add(tr);
            return db.SaveChanges() > 0;
        }
        #endregion

        #region Updates
        public bool UpdateJobTitle(JobTitle old, JobTitle j)
        {
            db.Entry(old).CurrentValues.SetValues(j);
            return db.SaveChanges() > 0;
        }

        public bool UpdateLocation(Location old, Location l)
        {
            db.Entry(old).CurrentValues.SetValues(l);
            return db.SaveChanges() > 0;
        }

        public bool UpdateStatus(ShiftStatus old, ShiftStatus s)
        {
            db.Entry(old).CurrentValues.SetValues(s);
            return db.SaveChanges() > 0;
        }

        public bool UpdateTech(Tech old, Tech t)
        {
            db.Entry(old).CurrentValues.SetValues(t);
            return db.SaveChanges() > 0;
        }

        public bool UpdateTechRole(TechRole old, TechRole tr)
        {
            db.Entry(old).CurrentValues.SetValues(tr);
            return db.SaveChanges() > 0;
        }
        #endregion

        #region Deletes
        public bool DeleteJobTitle(JobTitle j)
        {
            if (j.IsActive != false)
                db.Entry(j).CurrentValues.SetValues(j.IsActive = false);

            return db.SaveChanges() > 0;
        }

        public bool DeleteLocation(Location l)
        {
            db.Location.Remove(l);
            return db.SaveChanges() > 0;
        }

        public bool DeleteStatus(ShiftStatus s)
        {
            db.ShiftStatus.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool DeleteTech(Tech t)
        {
            db.Tech.Remove(t);
            return db.SaveChanges() > 0;
        }

        public bool DeleteTechRole(TechRole tr)
        {
            db.TechRole.Remove(tr);
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
