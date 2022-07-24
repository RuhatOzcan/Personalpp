using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager:IExperienceService
    {
        IExperienceDal _experinceDal;

        public ExperienceManager(IExperienceDal experinceDal)
        {
            _experinceDal = experinceDal;
        }

        public Experience TGetById(int id)
        {
            return _experinceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experinceDal.GetList();
        }

        public void TAdd(Experience t)
        {
            _experinceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experinceDal.Delete(t);
        }

        public void TUpdate(Experience t)
        {
            _experinceDal.Update(t);
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
