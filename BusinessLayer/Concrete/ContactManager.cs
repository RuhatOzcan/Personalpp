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
    public class ContactManager:IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public Contact TGetById(int id)
        {
            return contactDal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            contactDal.Update(t);
        }

        public List<Contact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
