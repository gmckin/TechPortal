using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPortal.Data.Domain.DataAccessObjects;
using AutoMapper;

namespace TechPortal.Data.Domain
{
    public class AccessMapper
    {
        public readonly MapperConfiguration JobTitleMapper = new MapperConfiguration(c => c.CreateMap<JobTitle, JobTitleDAO>().ReverseMap());
        public readonly MapperConfiguration LocationMapper = new MapperConfiguration(c => c.CreateMap<Location, LocationDAO>().ReverseMap());
        public readonly MapperConfiguration ShiftStatusMapper = new MapperConfiguration(c => c.CreateMap<ShiftStatus, ShiftStatusDAO>().ReverseMap());
        public readonly MapperConfiguration TechRoleMapper = new MapperConfiguration(c => c.CreateMap<TechRole, TechRoleDAO>().ReverseMap());
        public readonly MapperConfiguration TechMapper = new MapperConfiguration(c => c.CreateMap<Tech, TechDAO>().ReverseMap());

        private readonly TPDBEntities db;

        public List<JobTitle> jT;
        public List<ShiftStatus> sS;
        public List<TechRole> tR;
        public List<Location> L;
        public List<Tech> T;

        public AccessMapper()
        {
            db = new TPDBEntities();
            jT = db.JobTitle.ToList();
            sS = db.ShiftStatus.ToList();
            tR = db.TechRole.ToList();
            L = db.Location.ToList();
            T = db.Tech.ToList();
        }
        public AccessMapper(TPDBEntities context)
        {
            db = context;
            jT = db.JobTitle.ToList();
            sS = db.ShiftStatus.ToList();
            tR = db.TechRole.ToList();
            L = db.Location.ToList();
            T = db.Tech.ToList();
        }
        #region shift status 

        /// <summary>
        /// map the entity to the dao
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ShiftStatusDAO MapToDao(ShiftStatus s)
        {
            var mapper = ShiftStatusMapper.CreateMapper();
            if (s != null)
            {
                ShiftStatusDAO ssdao = mapper.Map<ShiftStatusDAO>(s);
                return ssdao;
            }
            else
            {
                return new ShiftStatusDAO();
            }
        }

       

        /// <summary>
        ///  map the dao to the entity
        /// </summary>
        /// <param name="ssdao"></param>
        /// <returns></returns>
        public ShiftStatus MapToEntity(ShiftStatusDAO ssdao)
        {
            ShiftStatus s = null;
            ShiftStatus fromDB = null;
            //use automapper to map matching properties
            var mapper = ShiftStatusMapper.CreateMapper();
            if (ssdao != null)
            {
                s = mapper.Map<ShiftStatus>(ssdao);

                //get original object from db
                if (!string.IsNullOrWhiteSpace(ssdao.SSDescription))
                {
                    fromDB = db.ShiftStatus.Where(m => m.SSDescription.Equals(ssdao.SSDescription)).FirstOrDefault();
                    
                }
                //if db object exist then use existing object and map properties sent from dao
                if (fromDB != null)
                {
                    s = fromDB;
                    if (!string.IsNullOrWhiteSpace(ssdao.SSDescription))
                    {
                        s.SSDescription = ssdao.SSDescription;                       
                    }
                }
                //if db object does not exist use automapper version of object and set active to true            
                else
                {
                    s.IsActive = true;
                }
            }
            return s;
        }
        #endregion


        #region job title
        /// <summary>
        /// map the entity to the dao
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public JobTitleDAO MapToDao(JobTitle jt)
        {
            var mapper = ShiftStatusMapper.CreateMapper();
            if (jt != null)
            {
                JobTitleDAO jtdao = mapper.Map<JobTitleDAO>(jt);
                return jtdao;
            }
            else
            {
                return new JobTitleDAO();
            }
        }

        /// <summary>
        ///  map the dao to the entity
        /// </summary>
        /// <param name="ssdao"></param>
        /// <returns></returns>
        public JobTitle MapToEntity(JobTitleDAO jtdao)
        {
            JobTitle jt = null;
            JobTitle fromDB = null;
            //use automapper to map matching properties
            var mapper = JobTitleMapper.CreateMapper();
            if (jtdao != null)
            {
                jt = mapper.Map<JobTitle>(jtdao);

                //get original object from db
                if (!string.IsNullOrWhiteSpace(jtdao.JobTitleName))
                {
                    fromDB = db.JobTitle.Where(m => m.JobTitleName.Equals(jtdao.JobTitleName)).FirstOrDefault();

                }
                //if db object exist then use existing object and map properties sent from dao
                if (fromDB != null)
                {
                    jt = fromDB;
                    if (!string.IsNullOrWhiteSpace(jtdao.JobTitleName))
                    {
                        jt.JobTitleName = jtdao.JobTitleName;
                    }
                }
                //if db object does not exist use automapper version of object and set active to true            
                else
                {
                    jt.IsActive = true;
                }
            }
            return jt;
        }
        #endregion


        #region tech role
        /// <summary>
        /// map the entity to the dao
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public TechRoleDAO MapToDao(TechRole tr)
        {
            var mapper = TechRoleMapper.CreateMapper();
            if (tr != null)
            {
                TechRoleDAO trdao = mapper.Map<TechRoleDAO>(tr);
                return trdao;
            }
            else
            {
                return new TechRoleDAO();
            }
        }

        /// <summary>
        ///  map the dao to the entity
        /// </summary>
        /// <param name="ssdao"></param>
        /// <returns></returns>
        public TechRole MapToEntity(TechRoleDAO trdao)
        {
            TechRole tr = null;
            TechRole fromDB = null;
            //use automapper to map matching properties
            var mapper = TechRoleMapper.CreateMapper();
            if (trdao != null)
            {
                tr = mapper.Map<TechRole>(trdao);

                //get original object from db
                if (!string.IsNullOrWhiteSpace(trdao.TRName))
                {
                    fromDB = db.TechRole.Where(m => m.TRName.Equals(trdao.TRName)).FirstOrDefault();

                }
                //if db object exist then use existing object and map properties sent from dao
                if (fromDB != null)
                {
                    tr = fromDB;
                    if (!string.IsNullOrWhiteSpace(trdao.TRName))
                    {
                        tr.TRName = trdao.TRName;
                    }
                }
                //if db object does not exist use automapper version of object and set active to true            
                else
                {
                    tr.IsActive = true;
                }
            }
            return tr;
        }
        #endregion


        #region location
        /// <summary>
        /// map the entity to the dao
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public LocationDAO MapToDao(Location l)
        {
            var mapper = LocationMapper.CreateMapper();
            if (l != null)
            {
                LocationDAO ldao = mapper.Map<LocationDAO>(l);
                return ldao;
            }
            else
            {
                return new LocationDAO();
            }
        }

        /// <summary>
        ///  map the dao to the entity
        /// </summary>
        /// <param name="ssdao"></param>
        /// <returns></returns>
        public Location MapToEntity(LocationDAO ldao)
        {
            Location l = null;
            Location fromDB = null;
            //use automapper to map matching properties
            var mapper = LocationMapper.CreateMapper();
            if (ldao != null)
            {
                l = mapper.Map<Location>(ldao);

                //get original object from db
                if (!string.IsNullOrWhiteSpace(ldao.LocationName))
                {
                    fromDB = db.Location.Where(m => m.LocationName.Equals(ldao.LocationName)).FirstOrDefault();

                }
                //if db object exist then use existing object and map properties sent from dao
                if (fromDB != null)
                {
                    l = fromDB;
                    if (!string.IsNullOrWhiteSpace(ldao.LocationName))
                    {
                        l.LocationName = ldao.LocationName;
                    }
                }
                //if db object does not exist use automapper version of object and set active to true            
                else
                {
                    l.IsActive = true;
                }
            }
            return l;
        }
        #endregion


        #region tech
        /// <summary>
        /// map the entity to the dao
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public TechDAO MapToDao(Tech t)
        {
            var mapper = TechMapper.CreateMapper();
            if (t != null)
            {
                TechDAO tdao = mapper.Map<TechDAO>(t);
                return tdao;
            }
            else
            {
                return new TechDAO();
            }
        }
        internal Tech MapToEntity(Tech t)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tdao"></param>
        /// <returns></returns>
        public Tech MapToEntity(TechDAO tdao)
        {
            Tech t = null;
            Tech fromDB = null;
            //use automapper to map matching properties
            var mapper = TechMapper.CreateMapper();
            if (tdao != null)
            {
                t = mapper.Map<Tech>(tdao);

                //get original object from db
                if (!string.IsNullOrWhiteSpace(tdao.Name))
                {
                    fromDB = db.Tech.FirstOrDefault(m => m.Email.Equals(tdao.Email));

                }
                //if db object exist then use existing object and map properties sent from dao
                if (fromDB != null)
                {
                    t = fromDB;
                    if (!string.IsNullOrWhiteSpace(tdao.Email))
                    {
                        t.Email = tdao.Email;
                    }
                }
                //if db object does not exist use automapper version of object and set active to true            
                else
                {
                    t.IsActive = true;
                }
            }
            return t;
        }
        #endregion
    }
}
