using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        public void Cadastrar(Dentista objDentista)
        {
            using(var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(objDentista);
                ctx.SaveChanges();
            }
        }
        public Dentista Buscar(int id)
        {
            Dentista objDentista = new Dentista();
            using (var ctx = new SistemaContext())
            {
                objDentista = ctx.Dentistas.Find(id);
            }
            return objDentista;
        }
        public List<Dentista> Listar()
        {
            using(var ctx = new SistemaContext())
            {
                var Dentistas = (from objDentista in ctx.Dentistas select objDentista).OrderBy(p => p.Nome).ToList();
                return Dentistas;
            }
        }
        public void Deletar(int Id)
        {
            using( var ctx = new SistemaContext())
            {
                Dentista objDentista = ctx.Dentistas.Find(Id);
                ctx.Dentistas.Remove(objDentista);
                ctx.SaveChanges();
            }
        }
        public void Editar(Dentista objDentistaNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista objDentista = ctx.Dentistas.Find(objDentistaNovo.Id);
                objDentista.Nome = objDentistaNovo.Nome;
                objDentista.Telefone = objDentistaNovo.Telefone;
                objDentista.Celular = objDentistaNovo.Celular;
                objDentista.CRO = objDentistaNovo.CRO;
                objDentista.Email = objDentistaNovo.Email;
                ctx.SaveChanges();
            }
        }
    }
}
