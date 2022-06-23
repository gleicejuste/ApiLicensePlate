using System.ComponentModel.DataAnnotations;

namespace ALP.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {1} caracteres")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {1} caracteres")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11, ErrorMessage = "Máximo {1} caracteres")]
        public String TaxId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(15, ErrorMessage = "Máximo {1} caracteres")]
        public String Rg { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11, ErrorMessage = "Máximo {1} caracteres")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(120, ErrorMessage = "Máximo {1} caracteres")]
        public String Password { get; set; }

        public User(Guid id, string name, string email, string taxId, string rg, string phone, bool isActive, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.TaxId = taxId;
            this.Rg = rg;
            this.Phone = phone;
            this.IsActive = isActive;
            this.Password = password;
        }
    }
}
