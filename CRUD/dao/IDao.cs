using System.Data;

namespace CRUD.dao
{
    interface IDao
    {
        void Inserir( object obj);
        object BuscaCodigo( int codigo);
        DataSet Consultar();
        void Alterar( object obj);
        void Excluir( object obj);
    }
}
