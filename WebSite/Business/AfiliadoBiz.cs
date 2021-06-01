using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.Data.Services;
using WebSite.Entities.Models;

namespace WebSite.Business
{
    public class AfiliadoBiz
    {
        public void Agregar(Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Create(model);

        }
        
        public List<Afiliado> Listar()
        {
            var db = new BaseDataService<Afiliado>();
            var lista = db.GetAll();
            return lista;
        }

        public Afiliado TraerAfiliado(int id)
        {
            var db = new BaseDataService<Afiliado>();
            return db.GetById(id);
        }

        public void Eliminar(Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Delete(model);
        }

        public void Actualizar(Afiliado model) 
        {
            var db = new BaseDataService<Afiliado>();
            db.Update(model);
        }
    }
}