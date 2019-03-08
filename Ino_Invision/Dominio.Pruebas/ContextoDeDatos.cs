using System;
using System.Linq;
using Dominio.Contexto;
using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Implementacion.Gestores;
using Servicios.Interfaces.Usuario;

namespace Dominio.Pruebas
{
    [TestClass]
    public class ContextoDeDatos
    {
        IGestorDeUsuarios _gestorDeUsuarios = new GestorDeUsuarios();

        [TestMethod]
        public void Creacion()
        {
            using (InoBD db = new InoBD())
            {
                db.Usuarios.ToList();
            }
        }

        [TestMethod]
        public void Login()
        {
            string usuario = "Administrador";
            string clave = "Passw0rd00";
            var usuarioLogin = _gestorDeUsuarios.Login(usuario, clave);
            Assert.AreEqual("Informatica", usuarioLogin.nombres);
        }

        //[TestMethod]
        //public void AgregarCategoria()
        //{
        //    using (InoBD db = new InoBD())
        //    {
        //        Categoria categoria = new Categoria();
        //        categoria.Nombre = "Frutas";
        //        db.Categorias.Add(categoria);
        //        db.SaveChanges();
        //    }
        //}

        //[TestMethod]
        //public void AgregarProductos()
        //{
        //    using (InoBD db = new InoBD())
        //    {
        //        Categoria categoria = new Categoria();
        //        categoria.Nombre = "Vegetales";
        //        db.Categorias.Add(categoria);

        //        db.Productos.Add(new Producto()
        //        {
        //            Nombre = "Cebolla",
        //            Precio = 1,
        //            Categoria = categoria
        //        }
        //        );

        //        Producto producto2 = new Producto();
        //        producto2.Nombre = "Maiz";
        //        producto2.Precio = 2;
        //        db.Productos.Add(producto2);

        //        db.SaveChanges();

        //        var categoriaVegetal = db.Categorias.Include("Productos").FirstOrDefault(x => x.Nombre.Equals("Vegetales"));
        //        Assert.AreEqual(2, categoriaVegetal.Productos.Count);

        //        var queryDeCategory = db.Categorias.AsQueryable();


        //        queryDeCategory = queryDeCategory.Where(x => x.Id > 2);

        //        var categorias = queryDeCategory.ToList();

        //    }
        //}
    }
}
