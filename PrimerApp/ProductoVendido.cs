namespace Clases.Modelos
{
    public class ProductoVendido
    {
        #region Atributos
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        #endregion

        #region Constructor
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            Id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }

        #endregion

        #region Propiedades
        public int Id { get; set; }
        public int IdProducto { get { return _idProducto; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public int IdVenta { get { return _idVenta; } }
        #endregion
    }
}
