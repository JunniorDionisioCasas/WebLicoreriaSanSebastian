﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.NoDatabase
{
    public class LoginResponse
    {
        public string token { get; set; }
        public UsuarioModel usuario { get; set; }
    }
}
