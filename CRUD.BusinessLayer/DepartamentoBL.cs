using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.DataLayer;
using CRUD.EntityLayer;

namespace CRUD.BusinessLayer
{
    public class DepartamentoBL
    {

        DepartamentoDL departamentoDL = new DepartamentoDL();

        public List<Departamento> lista()
        {
            try
            {

                return departamentoDL.lista();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
