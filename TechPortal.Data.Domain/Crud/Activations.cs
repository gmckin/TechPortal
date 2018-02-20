using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPortal.Data.Domain.DataAccessObjects;
using TechPortal.Data.Domain.Helper;

namespace TechPortal.Data.Domain.Crud
{
    public partial class AccessHelper
    {
        public bool ReActivateJobTitle(JobTitleDAO jt)
        {
            try
            {

                if (jt != null)
                {
                    var old = ef.GetJobTitles().FirstOrDefault(a => a.JobTitleName.Equals(jt.JobTitleName));
                    //what if it already exist and is active?
                    while (!old.IsActive)
                    {
                        // otherwise it must exist and not be active so activate it.
                        // if (jt.JobTitleName.Equals(old.JobTitleName)) continue;
                        var ns = mapper.MapToEntity(jt);
                        ns.JobTitleID = old.JobTitleID;
                        ns.IsActive = true;
                        return ef.ReActivateJobTitle(old, ns);
                    }
                    return false;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool ReActivateLocation(LocationDAO loc)
        {
            try
            {

                if (loc != null)
                {
                    var old = ef.GetLocations().FirstOrDefault(a => a.LocationName.Equals(loc.LocationName));
                    //what if it already exist and is active?
                    while (!old.IsActive)
                    {
                        // otherwise it must exist and not be active so activate it.
                        // if (jt.JobTitleName.Equals(old.JobTitleName)) continue;
                        var ns = mapper.MapToEntity(loc);
                        ns.LocationID = old.LocationID;
                        ns.IsActive = true;
                        return ef.ReActivateLocation(old, ns);
                    }
                    return false;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool ReActivateTechRole(TechRoleDAO jt)
        {
            try
            {

                if (jt != null)
                {
                    var old = ef.GetTechRoles().FirstOrDefault(a => a.TRName.Equals(jt.TRName));
                    //what if it already exist and is active?
                    while (!old.IsActive)
                    {
                        // otherwise it must exist and not be active so activate it.
                        // if (jt.JobTitleName.Equals(old.JobTitleName)) continue;
                        var ns = mapper.MapToEntity(jt);
                        ns.TechRoleID = old.TechRoleID;
                        ns.IsActive = true;
                        return ef.ReActivateTechRole(old, ns);
                    }
                    return false;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ReActivateShiftStatus(ShiftStatusDAO ss)
        {
            try
            {

                if (ss != null)
                {
                    var old = ef.GetStatuss().FirstOrDefault(a => a.SSDescription.Equals(ss.SSDescription));
                    //what if it already exist and is active?
                    while (!old.IsActive)
                    {
                        // otherwise it must exist and not be active so activate it.
                        // if (jt.JobTitleName.Equals(old.JobTitleName)) continue;
                        var ns = mapper.MapToEntity(ss);
                        ns.ShiftStatusID = old.ShiftStatusID;
                        ns.IsActive = true;
                        return ef.ReActivateShiftStatus(old, ns);
                    }
                    return false;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ReActivateTech(Tech tech)
        {
            try
            {

                if (tech != null)
                {
                    //what if it already exist and is active?
                    Tech old = ef.GetTechs().FirstOrDefault(a => a.TechID.Equals(tech.TechID));
                    if (old.IsActive && tech.Email == old.Email)
                    {
                        try
                        {

                            throw new DuplicateNameException();
                        }
                        catch (DuplicateNameException e)
                        {

                            throw e;
                        }
                    }
                    if (!old.IsActive && tech.TechID == old.TechID)
                    {
                        Tech nt = mapper.MapToEntity(tech);

                        nt.TechID = old.TechID;
                        nt.IsActive = true;
                        return ef.ReActivateTech(old, nt);
                    }
                    return false;
                }
                
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
