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

        
        #region delete job title
        /// <summary>
        /// delete job title
        /// </summary>
        /// <param name="jtdao"></param>
        /// <returns></returns>
        public bool DeleteJobTitle(JobTitleDAO jtdao)
        {
            try
            {
                if (jtdao != null)
                {
                    JobTitle jt = mapper.MapToEntity(jtdao);
                    JobTitle x = db.JobTitle.FirstOrDefault(z => z.JobTitleName.Equals(jt.JobTitleName));
                    if (x.IsActive)
                    {
                        var toDelete = ef.GetJobTitles().FirstOrDefault((m => m.JobTitleID == jt.JobTitleID));
                        return ef.DeleteJobTitle(toDelete);
                    }

                    return true;
                }
                
                {                    
                    return false;
                }
            }
            catch (Exception e)
            {                
                throw;
            }
        }
        #endregion

        #region delete status
        /// <summary>
        /// delete status
        /// </summary>
        /// <param name="ssdao"></param>
        /// <returns></returns>
        public bool DeleteShiftStatus(ShiftStatusDAO ssdao)
        {
            try
            {
                if (ssdao != null)
                {
                    ShiftStatus ss = mapper.MapToEntity(ssdao);
                    ShiftStatus x = db.ShiftStatus.FirstOrDefault(s => s.SSDescription.Equals(ss.SSDescription));

                    if (x.IsActive)
                    {
                        var toDelete = ef.GetStatuss().FirstOrDefault((m => m.SSDescription == ss.SSDescription));
                        return ef.DeleteStatus(toDelete);
                    }

                    return true;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion

        #region delete tech role
        /// <summary>
        /// delete tech role
        /// </summary>
        /// <param name="trdao"></param>
        /// <returns></returns>
        public bool DeleteTechRole(TechRoleDAO trdao)
        {
            try
            {
                if (trdao != null)
                {
                    TechRole tr = mapper.MapToEntity(trdao);
                    TechRole x = db.TechRole.FirstOrDefault(s => s.TRName.Equals(tr.TRName));

                    if (x.IsActive)
                    {
                        var toDelete = ef.GetTechRoles().FirstOrDefault((m => m.TRName == tr.TRName));
                        return ef.DeleteTechRole(toDelete);
                    }
                    return true;
                }
               
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion

        #region delete location
        /// <summary>
        /// delete location
        /// </summary>
        /// <param name="ldao"></param>
        /// <returns></returns>
        public bool DeleteLocation(LocationDAO ldao)
        {
            try
            {
                if (ldao != null)
                {
                    Location l = mapper.MapToEntity(ldao);
                    Location x = db.Location.FirstOrDefault(s => s.LocationName.Equals(l.LocationName));

                    if (x.IsActive)
                    {
                        var toDelete = ef.GetLocations().FirstOrDefault((m => m.LocationName == l.LocationName));
                        return ef.DeleteLocation(toDelete);
                    }
                    return true;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion

        #region delete tech
        /// <summary>
        /// delete tech
        /// </summary>
        /// <param name="tdao"></param>
        /// <returns></returns>
        public bool DeleteTech(TechDAO tdao)
        {
            try
            {
                if (tdao != null)
                {
                    Tech t = mapper.MapToEntity(tdao);
                    Tech x = db.Tech.FirstOrDefault(s => s.Email.Equals(t.Email));

                    if (x.IsActive)
                    {
                        var toDelete = ef.GetTechs().FirstOrDefault((m => m.TechID == t.TechID));
                        return ef.DeleteTech(toDelete);
                    }
                    return true;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }        
        #endregion
    }
}
