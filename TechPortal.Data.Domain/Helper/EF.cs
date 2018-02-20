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

        public List<JobTitle> GetInactiveJobTitle()
        {
            return db.JobTitle.ToList();
        }

        public List<Location> GetLocations()
        {
            return db.Location.ToList();
        }
        public List<Location> GetLocation()
        {
            return db.Location.ToList();
        }

        public List<ShiftStatus> GetStatuss()
        {
            return db.ShiftStatus.ToList();
        }
        public List<ShiftStatus> GetStatus()
        {
            return db.ShiftStatus.ToList();
        }

        public List<TechRole> GetTechRoles()
        {
            return db.TechRole.ToList();
        }
        public List<TechRole> GetTechRole()
        {
            return db.TechRole.ToList();
        }

        public List<Tech> GetTechs()
        {
            return db.Tech.ToList();
        }
        public List<Tech> GetTech()
        {
            return db.Tech.ToList();
        }

        public JobTitle GetJobTitle(string name)
        {
            var temp = db.JobTitle.FirstOrDefault(x => x.JobTitleName == name);

            return temp ;
        }
        #endregion

        #region Re-Activations

        public bool ReActivateTech(Tech old, Tech tech)
        {
            db.Entry(old).CurrentValues.SetValues(tech);
            return db.SaveChanges() > 0;
        }

        public bool ReActivateJobTitle(JobTitle old, JobTitle jobTitle)
        {
            db.Entry(old).CurrentValues.SetValues(jobTitle);
            return db.SaveChanges() > 0;
        }

        public bool ReActivateLocation(Location old, Location loc)
        {
            db.Entry(old).CurrentValues.SetValues(loc);
            return db.SaveChanges() > 0;
        }

        public bool ReActivateTechRole(TechRole old, TechRole tr)
        {
            db.Entry(old).CurrentValues.SetValues(tr);
            return db.SaveChanges() > 0;
        }

        public bool ReActivateShiftStatus(ShiftStatus old, ShiftStatus ss)
        {
            db.Entry(old).CurrentValues.SetValues(ss);
            return db.SaveChanges() > 0;
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
            if (l.IsActive != false)
                db.Entry(l).CurrentValues.SetValues(l.IsActive = false);
            return db.SaveChanges() > 0;
        }

        public bool DeleteStatus(ShiftStatus s)
        {
            if (s.IsActive != false)
                db.Entry(s).CurrentValues.SetValues(s.IsActive = false);
            return db.SaveChanges() > 0;
        }

        public bool DeleteTech(Tech t)
        {
            if (t.IsActive != false)
                db.Entry(t).CurrentValues.SetValues(t.IsActive = false);
            return db.SaveChanges() > 0;
        }

        public bool DeleteTechRole(TechRole tr)
        {
            if (tr.IsActive != false)
                db.Entry(tr).CurrentValues.SetValues(tr.IsActive = false);
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
