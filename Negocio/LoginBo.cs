﻿using Microsoft.Extensions.Configuration;
using NetCoreConcepts.Dal;
using NetCoreConcepts.Models;
using static NetCoreConcepts.Models.LoginModels;

namespace Negocio
{
    public class LoginBo
    {
        private readonly IConfiguration _config;

        public LoginBo(IConfiguration config)
        {
            _config = config;

        }


        public LoginBo() { }


        public UsuarioModels ObtenerUsuario(string userName)
        {
                UsuarioModels usuario = new UsuarioModels();
                UsuarioDal usuarioDal = new UsuarioDal(_config);
                usuario = usuarioDal.ObtenerUsuario(userName);
                return usuario;

        }
        public List<UsuarioModels> ObtenerTodosUsuarios()
        {
            List<UsuarioModels> usuario = new ();
            UsuarioDal usuarioDal = new UsuarioDal(_config);
            usuario = usuarioDal.ObtenerTodosUsuarios();
            return usuario;

        }
        public void CrearUsuario(UsuarioModels usuarioRequest)
        {
            UsuarioDal usuarioDal = new UsuarioDal(_config);

            usuarioDal.CrearUsuario(usuarioRequest);

            
        }
    }
}