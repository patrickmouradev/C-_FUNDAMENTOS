﻿using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UsuarioBLL
    {
        public Usuario UsuarioLogado
        {
            get
            {
                Usuario usr = new Usuario
                {
                    Login = "admin",
                    Nome = "Administrador"
                };

                return usr;
            }
        }
        public bool Logar(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                return true;
            }
            return false;
        }
    }
}