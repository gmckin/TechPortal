using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPortal.Data.Domain.DataAccessObjects;
using TechPortal.Data.Domain.Helper;

namespace TechPortal.Data.Domain.Crud
{
    public partial class AccessHelper
    {
        #region job title
        public List<JobTitleDAO> GetJobTitles()
        {
            try
            {
                var jts = ef.GetJobTitles();
                var result = new List<JobTitleDAO>();
                foreach (var item in jts)
                {
                    if (item != null)
                    {
                        if (item.IsActive)
                        {
                            result.Add(mapper.MapToDao(item));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }


        #endregion


        #region shift status
        public List<ShiftStatusDAO> GetShiftStatus()
        {
            try
            {
                var ss = ef.GetStatuss();
                var result = new List<ShiftStatusDAO>();
                foreach (var item in ss)
                {
                    if (item != null)
                    {
                        if (item.IsActive)
                        {
                            result.Add(mapper.MapToDao(item));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion


        #region location
        public List<LocationDAO> GetLocations()
        {
            try
            {
                var l = ef.GetLocations();
                var result = new List<LocationDAO>();
                foreach (var item in l)
                {
                    if (item != null)
                    {
                        if (item.IsActive)
                        {
                            result.Add(mapper.MapToDao(item));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion


        #region tech roles
        public List<TechRoleDAO> GetTechRoles()
        {
            try
            {
                var tr = ef.GetTechRoles();
                var result = new List<TechRoleDAO>();
                foreach (var item in tr)
                {
                    if (item != null)
                    {
                        if (item.IsActive)
                        {
                            result.Add(mapper.MapToDao(item));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion


        #region tech
        public List<TechDAO> GetTechs()
        {
            try
            {
                var t = ef.GetTechs();
                var result = new List<TechDAO>();
                foreach (var item in t)
                {
                    if (item != null)
                    {
                        if (item.IsActive)
                        {
                            result.Add(mapper.MapToDao(item));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion
    }
}
