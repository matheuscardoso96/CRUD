namespace CRUD.model
{
    class TipoEndereco
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public TipoEndereco()
        {
        }

        public TipoEndereco(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
