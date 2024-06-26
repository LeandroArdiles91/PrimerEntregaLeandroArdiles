﻿namespace Clases.Modelos
{
    public class Usuario
    {
        #region Propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }

        #endregion

        #region Constructor

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }

        #endregion
    }
}
