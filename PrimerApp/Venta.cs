namespace Clases.PrimerApp
{
    public class Venta
    {
        #region Atributos
        private string _comentarios;
        #endregion

        #region Constructor
        public Venta(int id, string comentario, int idUsuario)
        {
            Id = id;
            _comentarios = comentario;
            idUsuario = idUsuario;
        }
        #endregion

        #region Propiedades
        public int Id { get; set; }
        public string Comentarios { get { return _comentarios; } set { _comentarios = value; } }
        public int idUsuario { get; set; }
        #endregion
    }
}
