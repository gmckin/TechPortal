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
        /// <summary>
        /// get list of active job titles
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// find inactive
        /// </summary>
        /// <returns></returns>
        public List<JobTitleDAO> GetInactiveJobTitle()
        {
            try
            {
                var jts = ef.GetJobTitles();
                var result = new List<JobTitleDAO>();
                foreach (var item in jts)
                {
                    if (item != null)
                    {
                        if (!item.IsActive)
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

        public JobTitle GetJobTitle(string name)
        {

            try
            {
                if (name != null)
                {
                    var jt = ef.GetJobTitle(name);
                    var jts = ef.GetJobTitles().FirstOrDefault(e => e.JobTitleName == name);
                    if (jts.IsActive)
                    {
                        return jts;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }




        #endregion


        #region shift status
        /// <summary>
        /// get list of active status
        /// </summary>
        /// <returns></returns>
        public List<ShiftStatusDAO> GetShiftStatuss()
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

        /// <summary>
        /// get list of inactive status
        /// </summary>
        /// <returns></returns>
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
                        if (!item.IsActive)
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
        /// <summary>
        /// get list of active locations
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// get list of inactive locations
        /// </summary>
        /// <returns></returns>
        public List<LocationDAO> GetLocation()
        {
            try
            {
                var l = ef.GetLocations();
                var result = new List<LocationDAO>();
                foreach (var item in l)
                {
                    if (item != null)
                    {
                        if (!item.IsActive)
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

        /// <summary>
        /// get list of active tech roles
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// get list of inactive tech roles
        /// </summary>
        /// <returns></returns>
        public List<TechRoleDAO> GetTechRole()
        {
            try
            {
                var tr = ef.GetTechRoles();
                var result = new List<TechRoleDAO>();
                foreach (var item in tr)
                {
                    if (item != null)
                    {
                        if (!item.IsActive)
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
        /// <summary>
        /// get list of techs
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// get list of inactive techs
        /// </summary>
        /// <returns></returns>
        public List<TechDAO> GetTech()
        {
            try
            {
                var t = ef.GetTechs();
                var result = new List<TechDAO>();
                foreach (var item in t)
                {
                    if (item != null)
                    {
                        if (!item.IsActive)
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
