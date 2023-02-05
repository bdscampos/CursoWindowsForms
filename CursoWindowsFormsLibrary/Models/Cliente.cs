using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoWindowsFormsLibrary.Models
{

    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código somente aceita valores numéricos")]
            [StringLength (6, MinimumLength = 6, ErrorMessage = "Código deve ter 6 dígitos")]
            public string Id { get; set; }
            [Required(ErrorMessage = "Nome é obrigatório")]
            [StringLength(70, ErrorMessage = "Nome deve ter no máximo 70 caracteres")]
            public string Nome { get; set; }
            [StringLength(70, ErrorMessage = "Nome do pai deve ter no máximo 70 caracteres")]
            public string NomePai { get; set; }
            [Required(ErrorMessage = "Nome da mãe é obrigatório")]
            [StringLength(70, ErrorMessage = "Nome da mãe deve ter no máximo 70 caracteres")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }
            [Required(ErrorMessage = "CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
            public string CPF { get; set; }
            [Required(ErrorMessage = "Gênero deve ser selecionado")]
            public int Genero { get; set; }
            [Required(ErrorMessage = "CEP é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP somente aceita valores numéricos")]
            [StringLength (8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos")]
            public string CEP { get; set; }
            [Required(ErrorMessage = "Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Complemento é obrigatório")]
            [StringLength(40, ErrorMessage = "Complemento deve ter no máximo 40 caracteres")]
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(40, ErrorMessage = "Bairro deve ter no máximo 40 caracteres")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "Telefone é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone aceita somente valores numéricos")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            [Required(ErrorMessage = "Renda é obrigatória")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Renda somente aceita valores numéricos")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda deve ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public Unit (string id, string nome, string nomePai, string nomeMae, bool temPai, string cPF, int genero, string cEP, string logradouro, string complemento, string bairro, string cidade, string estado, string telefone, string profissao, double rendaFamiliar)
            {
                this.Id = id;
                this.Nome = nome;
                this.NomePai = nomePai;
                this.NomeMae = nomeMae;
                this.NaoTemPai = temPai;
                this.CPF = cPF;
                this.Genero = genero;
                this.CEP = cEP;
                this.Logradouro = logradouro;
                this.Complemento = complemento;
                this.Bairro = bairro;
                this.Cidade = cidade;
                this.Estado = estado;
                this.Telefone = telefone;
                this.Profissao = profissao;
                this.RendaFamiliar = rendaFamiliar;
            }

            public Unit () { }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae) throw new System.Exception("Nome do Pai não pode ser igual ao nome da mãe");
                if (!this.NaoTemPai && this.NomePai == "") throw new System.Exception("Nome do Pai não pode ser vazio");
                if (!Utils.Valida(this.CPF)) throw new System.Exception("CPF Inválido");
        }
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        
    }
}
