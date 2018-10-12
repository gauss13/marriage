using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
   public class Usuario
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string UserName { get; set; }

        public string Password { get; set; }
        public int RoleId { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Correo { get; set; }
        [StringLength(50)]
        public string Hoteles { get; set; }
        [StringLength(250)]
        public string Img { get; set; }
        public Role Role { get; set; }
    }

    public  class Role
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }

}
