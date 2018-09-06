using Fidelizando.DataBase;
using Fidelizando.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Fidelizando.Service
{
    public class UsuarioService
    {
        public static DbAccess<Usuario> dbAccess = new DbAccess<Usuario>();

        public static void AdicionarPontos(string email)
        {
            var usuario = dbAccess.Find(x => x.Email.ToLower().Equals(email.ToLower()));
            usuario.Pontos += 1;
            Edit(usuario);
        }

        public static int PegarPontos(string email)
        {
            var usuario = dbAccess.Find(x => x.Email.ToLower().Equals(email.ToLower()));
            return usuario.Pontos;
        }


        public static void Insert(Usuario usuario)
        {
            usuario.Pontos = 0;
            usuario.IsLogged = true;
            dbAccess.Save(usuario);
        }

        public static Usuario Authenticate(string email, string password)
        {
            var usuario = dbAccess.Find(x => x.Email.ToLower().Equals(email.ToLower()) && x.Senha.Equals(password));
            if (usuario != null)
            {
                usuario.IsLogged = true;
                Edit(usuario);
                return usuario;
            }

            return null;
        }

        public static void Edit(Usuario usuario)
        {
            dbAccess.Update(usuario);
        }

        public static Usuario Load(int id)
        {
            return dbAccess.Find(x => x.Id == id);
        }

        public static void Remove(int id)
        {
            dbAccess.Delete(id);
        }

        public static Usuario GetUserLogged()
        {
            return List(x => x.IsLogged).FirstOrDefault();
        }

        public static void Logout(Usuario usuario)
        {
            usuario.IsLogged = false;
            Edit(usuario);
        }

        public static List<Usuario> List(Expression<Func<Usuario, bool>> predicate)
        {
            return dbAccess.List(predicate).ToList();
        }

        public static List<Usuario> ListAll()
        {
            return dbAccess.ListAll().ToList();
        }

    }
}
