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
        List<Location> GetLocations();
        List<JobTitle> GetJobTitles();
        List<TechRole> GetTechRoles();
        List<Tech> GetTechs();

        bool DeleteStatus(ShiftStatus s);
        bool DeleteLocation(Location l);
        bool DeleteJobTitle(JobTitle j);
        bool DeleteTechRole(TechRole tr);
        bool DeleteTech(Tech t);

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
