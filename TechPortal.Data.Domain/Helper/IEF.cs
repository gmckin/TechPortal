using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPortal.Data.Domain.Helper
{
    public interface IEF
    {
        List<ShiftStatus> GetStatuss();
        List<ShiftStatus> GetStatus();
        List<Location> GetLocations();
        List<Location> GetLocation();
        List<JobTitle> GetJobTitles();
        List<TechRole> GetTechRoles();
        List<TechRole> GetTechRole();
        List<Tech> GetTechs();
        List<Tech> GetTech();
        List<JobTitle> GetInactiveJobTitle();
        JobTitle GetJobTitle(string name);

        bool DeleteStatus(ShiftStatus s);
        bool DeleteLocation(Location l);
        bool DeleteJobTitle(JobTitle j);
        bool DeleteTechRole(TechRole tr);
        bool DeleteTech(Tech t);

        bool ReActivateLocation(Location old, Location loc);
        bool ReActivateTechRole(TechRole old, TechRole tr);
        bool ReActivateShiftStatus(ShiftStatus old, ShiftStatus ss);
        bool ReActivateTech(Tech old, Tech tech);
        bool ReActivateJobTitle(JobTitle old, JobTitle jobTitle);

        bool InsertStatus(ShiftStatus s);
        bool InsertLocation(Location l);
        bool InsertJobTitle(JobTitle j);
        bool InsertTechRole(TechRole tr);
        bool InsertTech(Tech t);

        bool UpdateStatus(ShiftStatus old, ShiftStatus s);
        bool UpdateLocation(Location old, Location l);
        bool UpdateJobTitle(JobTitle old, JobTitle j);
        bool UpdateTechRole(TechRole old, TechRole tr);
        bool UpdateTech(Tech old, Tech t);

    }
}
