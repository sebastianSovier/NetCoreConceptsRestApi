﻿
namespace NetCoreConcepts.Models
{
    public class LoginModels
    {
        public class LoginRequest { 
        
            public string? Username { get; set; }
            public string? Password { get; set; }

        }
        public class LoginResponse { 
        
            public string? access_Token { get; set; }
            public bool? auth { get; set; }
            public Int64? id { get; set; }
            public string? correo { get; set; }
        }
    }
    public class UsuarioModels { 
        
        public Int64 usuario_id { get; set; }
        public string? usuario { get; set; }
        public string? contrasena { get; set; }
        public string? nombre_completo { get; set; }
        public string? correo { get; set; }
    
    }
}
