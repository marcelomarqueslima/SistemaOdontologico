using Entidades;
using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces
{
    [ServiceContract]
    public interface IDentista
    {
        [OperationContract]
        void Cadastrar(Dentista objDentista);
        [OperationContract]
        Dentista Buscar(int Id);
        [OperationContract]
        List<Dentista> Listar();
        [OperationContract]
        void Deletar(int Id);
        [OperationContract]
        void Editar(Dentista objDentistaNovo);
    }
}
