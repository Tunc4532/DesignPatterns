using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CatagoryManager : ICatagoryService
    {
        ICatagoryDal _catagoryDal;

        public void TDelete(Catagory t)
        {
           _catagoryDal.Delete(t);
        }

        public Catagory TGetById(int id)
        {
            return _catagoryDal.GetById(id);
        }

        public List<Catagory> TGetList()
        {
            return _catagoryDal.GetList();
        }

        public void TInsert(Catagory t)
        {
            _catagoryDal.Insert(t);
        }

        public void TUpdate(Catagory t)
        {
            _catagoryDal.Update(t);
        }
    }
}
