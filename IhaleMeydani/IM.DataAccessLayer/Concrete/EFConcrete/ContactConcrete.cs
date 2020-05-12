using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class ContactConcrete : BaseConcrete, IDataAccessDal<Contact>
    {
        public void Add(Contact entity)
        {
            DB.Contacts.Add(entity);
            DB.SaveChanges();
        }

        public Contact Get(int id)
        {
            return DB.Contacts.Find(id);
        }

        public List<Contact> GetAll()
        {
            return DB.Contacts.ToList();
        }

        public IEnumerable<Contact> GetFilter(Expression<Func<Contact, bool>> expression)
        {
            return DB.Contacts.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Contacts.Remove(Get(id));
        }

        public void RemoveAll(Contact t)
        {
            DB.Contacts.Remove(t);
        }

        public void Update(Contact t)
        {
            DB.Contacts.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();

        }
    }
}
