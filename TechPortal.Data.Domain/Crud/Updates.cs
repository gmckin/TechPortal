using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPortal.Data.Domain.DataAccessObjects;

namespace TechPortal.Data.Domain.Crud
{
    public partial class AccessHelper
    {

        /// <summary>
        /// update status
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="sdao"></param>
        /// <returns></returns>
        public bool UpdateStatus(string oldId, ShiftStatusDAO sdao)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(oldId) && sdao != null)
                {
                    ShiftStatus ns = mapper.MapToEntity(sdao);
                    ShiftStatus old = ef.GetStatuss().FirstOrDefault(a => a.SSDescription.Equals(oldId));
                    ns.ShiftStatusID = old.ShiftStatusID;                    
                    return ef.UpdateStatus(old, ns);
                }                
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool UpdateLocation(string oldId, LocationDAO ldao)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(oldId) && ldao != null)
                {
                    Location ns = mapper.MapToEntity(ldao);
                    Location old = ef.GetLocations().FirstOrDefault(a => a.LocationName.Equals(oldId));
                    ns.LocationID = old.LocationID;
                    return ef.UpdateLocation(old, ns);
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateTechRole(string oldId, TechRoleDAO trdao)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(oldId) && trdao != null)
                {
                    TechRole ns = mapper.MapToEntity(trdao);
                    TechRole old = ef.GetTechRoles().FirstOrDefault(a => a.TRName.Equals(oldId));
                    ns.TechRoleID = old.TechRoleID;
                    return ef.UpdateTechRole(old, ns);
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateJobTitle(string oldId, JobTitleDAO jtdao)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(oldId) && jtdao != null)
                {
                    JobTitle ns = mapper.MapToEntity(jtdao);
                    JobTitle old = ef.GetJobTitles().FirstOrDefault(a => a.JobTitleName.Equals(oldId));
                    ns.JobTitleID = old.JobTitleID;
                    return ef.UpdateJobTitle(old, ns);
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool UpdateTech(string oldId, TechDAO tdao)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(oldId) && tdao != null)
                {
                    Tech ns = mapper.MapToEntity(tdao);
                    Tech old = ef.GetTechs().FirstOrDefault(a => a.TechID.Equals(oldId));
                    ns.TechID = old.TechID;
                    return ef.UpdateTech(old, ns);
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
