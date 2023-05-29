using System.ComponentModel.DataAnnotations;


namespace GalloFlix.DataTransferObjects;

    public class RegisterDto
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteries")]
        public string Name { get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        public DateTime DataOfBirth { get; set;}


        [Required(ErrorMessage = "Por favor, informe seu Email")]
        [EmailAddress(ErrorMessage = "Por favor, informe um Email Válido!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "O Email deve possuir no minimo 20 e no máximo 20 caracteries")]
        public string Email { get; set;}

        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso")]
        [Required(ErrorMessage = "Por favor, informe sua Senha de Acesso")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteries")]
    
        public string Password { get; set;} 

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha de Acesso")]
        [Compare("Password", ErrorMessage = "As Senhas não Conferem.")]    
        public string ConfirmPassword { get; set;}
    }
