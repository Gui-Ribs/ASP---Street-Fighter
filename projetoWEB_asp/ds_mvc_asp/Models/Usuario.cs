using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds_mvc_asp.Models
{
    public class Usuario
    {
        [Display (Name = "Nome de usuário")]
        [Required (ErrorMessage = "O nome é obrigatório")]

        public string NomeUsuario { get; set;  }


        [Display (Name = "Idade")]
        [Range (8, 70, ErrorMessage = "Obrigatório inserir idade entre 8 e 70 anos")]

        public string Idade { get; set; }

        [Display (Name = "E-mail")]
        [RegularExpression (@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]

        public string Email { get; set; }


        [Display (Name = "Senha")]
        [Required (ErrorMessage = "Senha obrigatória")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string Confsenha { get; set; }

    }
}