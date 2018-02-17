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
        private static readonly TPDBEntities db = new TPDBEntities();
        public static AccessMapper mapper = new AccessMapper(db);

        private static IEF ef;

        static AccessHelper() { }

        public AccessHelper()
        {
            ef = new EF(db);
        }

        public AccessHelper(IEF ief)
        {
            ef = ief;
        }

        #region Insert status
        /// <summary>
        ///     Insert Shift Status
        /// </summary>
        /// <param name="ss"></param>
        /// <returns>true if successful</returns>
        public bool InsertShiftStatus(ShiftStatusDAO ss)
        {
            try
            {
                if (ss != null)
                {
                    //map it to EF object
                    var itm = mapper.MapToEntity(ss);
                    db.ShiftStatus.Add(itm);
                    return db.SaveChanges() > 0;
                }
                else
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

        #region insert location

        /// <summary>
        /// insert location
        /// </summary>
        /// <param name="l"></param>
        /// <returns>true if successful</returns>
        public bool InsertLocation(LocationDAO l)
        {
            try
            {
                if (l != null)
                {
                    //map it to EF object
                    var itm = mapper.MapToEntity(l);
                    db.Location.Add(itm);
                    return db.SaveChanges() > 0;
                }
                else
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

        #region insert job title

        /// <summary>
        /// insert job title
        /// </summary>
        /// <param name="jt"></param>
        /// <returns>true if successful</returns>
        public bool InsertJobTitle(JobTitleDAO jt)
        {
            try
            {
                if (jt != null)
                {
                    //map it to EF object
                    var itm = mapper.MapToEntity(jt);
                    db.JobTitle.Add(itm);
                    return db.SaveChanges() > 0;
                }
                else
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

        #region insert tech role

        /// <summary>
        /// insert tech role
        /// </summary>
        /// <param name="tr"></param>
        /// <returns>true if successful</returns>
        public bool InsertTechRole(TechRoleDAO tr)
        {
            try
            {
                if (tr != null)
                {
                    //map it to EF object
                    var itm = mapper.MapToEntity(tr);
                    db.TechRole.Add(itm);
                    return db.SaveChanges() > 0;
                }
                else
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

        #region insert tech

        /// <summary>
        /// insert tech
        /// </summary>
        /// <param name="t"></param>
        /// <returns>true if successful</returns>
        public bool InsertTech(TechDAO t)
        {
            try
            {
                if (t != null)
                {
                    //map it to EF object
                    var itm = mapper.MapToEntity(t);
                    db.Tech.Add(itm);
                    return db.SaveChanges() > 0;
                }
                else
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
