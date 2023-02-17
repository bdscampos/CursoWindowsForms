using CursoWindowsFormsLibrary.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

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
            public int NaoTemPai { get; set; }
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

            public Unit (string id, string nome, string nomePai, string nomeMae, int temPai, string cPF, int genero, string cEP, string logradouro, string complemento, string bairro, string cidade, string estado, string telefone, string profissao, double rendaFamiliar)
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
                if (this.NaoTemPai == 0 && this.NomePai == "") throw new System.Exception("Nome do Pai não pode ser vazio");
                if (!Utils.Valida(this.CPF)) throw new System.Exception("CPF Inválido");
        }

            #region CRUD Fichario System.IO

            public void IncluirFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                string json = JsonConvert.SerializeObject(this);
                if (f.Status)
                {
                    
                    if (f.Incluir(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public Unit BuscarClienteFichario(string conexao, string id)
            {
                Fichario f = new Fichario(conexao);
                if (f.Status)
                {
                    return Cliente.DeserializeClassUnit(f.Buscar(id));
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void AlterarFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                string json = Cliente.SerializeClassUnit(this);
                if (f.Status)
                {
                    if (f.Alterar(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public bool ApagarFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.Status)
                {
                    if (f.Apagar(this.Id))
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public List<string> BuscarTudoFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.Status)
                {
                    List<string> list = f.BuscarTudo();
                    return list;
                }
                else
                {
                    throw new Exception();
                }
            }

            #endregion            
            
            #region CRUD FicharioDB

            public void IncluirFicharioDB(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);
                string json = JsonConvert.SerializeObject(this);
                if (f.Status)
                {
                    
                    if (f.Incluir(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Message);
                    }
                }
                else
                {
                    throw new Exception(f.Message);
                }
            }

            public Unit BuscarClienteFicharioDB(string conexao, string id)
            {
                FicharioDB f = new FicharioDB(conexao);
                if (f.Status)
                {
                    return Cliente.DeserializeClassUnit(f.Buscar(id));
                }
                else
                {
                    throw new Exception(f.Message);
                }
            }

            public void AlterarFicharioDB(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);
                string json = Cliente.SerializeClassUnit(this);
                if (f.Status)
                {
                    if (f.Alterar(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Message);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public bool ApagarFicharioDB(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);
                if (f.Status)
                {
                    if (f.Apagar(this.Id))
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public List<string> BuscarTudoFicharioDB(string conexao)
            {
                FicharioDB f = new FicharioDB(conexao);
                if (f.Status)
                {
                    List<string> list = f.BuscarTudo();
                    return list;
                }
                else
                {
                    throw new Exception();
                }
            }

            #endregion 
            
            #region CRUD SQLServer

            public void IncluirFicharioSQL(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);
                string json = JsonConvert.SerializeObject(this);
                if (f.Status)
                {
                    
                    if (f.Incluir(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Message);
                    }
                }
                else
                {
                    throw new Exception(f.Message);
                }
            }

            public Unit BuscarClienteFicharioSQL(string conexao, string id)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);
                if (f.Status)
                {
                    return Cliente.DeserializeClassUnit(f.Buscar(id));
                }
                else
                {
                    throw new Exception(f.Message);
                }
            }

            public void AlterarFicharioSQL(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);
                string json = Cliente.SerializeClassUnit(this);
                if (f.Status)
                {
                    if (f.Alterar(this.Id, json))
                    {
                        MessageBox.Show("Sucesso: Cliente alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(f.Message);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public bool ApagarFicharioSQL(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);
                if (f.Status)
                {
                    if (f.Apagar(this.Id))
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

            public List<string> BuscarTudoFicharioSQL(string conexao)
            {
                FicharioSQLServer f = new FicharioSQLServer(conexao);
                if (f.Status)
                {
                    List<string> list = f.BuscarTudo();
                    return list;
                }
                else
                {
                    throw new Exception();
                }
            }

            #endregion

            #region CRUD SQLServer Relacional

            #region Funções Auxiliares

            public string ToInsert()
            {
                string sql;

                sql = @"INSERT INTO TB_Cliente 
                    (Id,
                    Nome,
                    NomePai,
                    NomeMae,
                    NaoTemPai,
                    CPF,
                    Genero,
                    CEP,
                    Logradouro,
                    Complemento,
                    Bairro,
                    Cidade,
                    Estado,
                    Telefone,
                    Profissao,
                    RendaFamiliar) 
                    VALUES ";
                sql += $"('{this.Id}','{this.Nome}','{this.NomePai}','{this.NomeMae}',{this.NaoTemPai},'{this.CPF}',{this.Genero},'{this.CEP}'," +
                    $"'{this.Logradouro}','{this.Complemento}','{this.Bairro}','{this.Cidade}','{this.Estado}','{this.Telefone}','{this.Profissao}',{this.RendaFamiliar})";

                return sql;
            }

            public string ToUpdate(string id)
            {
                string sql;

                sql = @"UPDATE TB_Cliente 
                    SET ";

                sql += $"Id = '{this.Id}',Nome = '{this.Nome}',NomePai = '{this.NomePai}',NomeMae = '{this.NomeMae}',NaoTemPai = {this.NaoTemPai},CPF = '{this.CPF}'," +
                    $"Genero = {this.Genero},CEP = '{this.CEP}',Logradouro = '{this.Logradouro}',Complemento = '{this.Complemento}'," +
                    $"Bairro = '{this.Bairro}',Cidade = '{this.Cidade}',Estado = '{this.Estado}',Telefone = '{this.Telefone}'," +
                    $"Profissao = '{this.Profissao}',RendaFamiliar = {this.RendaFamiliar} ";
                sql += $"WHERE Id= '{id}'";

                return sql;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                return new Unit(dr["Id"].ToString(), dr["Nome"].ToString(), dr["NomePai"].ToString(), dr["NomeMae"].ToString(), int.Parse(dr["NaoTemPai"].ToString()),
                    dr["CPF"].ToString(), int.Parse(dr["Genero"].ToString()), dr["CEP"].ToString(), dr["Logradouro"].ToString(), dr["Complemento"].ToString(), dr["Bairro"].ToString(),
                    dr["Cidade"].ToString(), dr["Estado"].ToString(), dr["Telefone"].ToString(), dr["Profissao"].ToString(), double.Parse(dr["RendaFamiliar"].ToString()));
            }

            #endregion

            public void IncluirFicharioSQLRel()
            {
                try
                {
                    string sql;
                    sql = this.ToInsert();
                    SQLServerClass db = new SQLServerClass();
                    db.SQLCommand(sql);
                    db.CloseConnection();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha na inclusão: {ex.Message}");
                }
            }

            public Unit BuscarFicharioSQLRel(string id)
            {
                try
                {
                    string sql = $"SELECT * FROM [TB_Cliente] WHERE Id = '{id}'";
                    SQLServerClass db = new SQLServerClass();
                    DataTable dt = db.SQLQuery(sql);
                    if (dt.Rows.Count != 0)
                    {
                        Unit u = this.DataRowToUnit(dt.Rows[0]);
                        return u;
                    }
                    else
                    {
                        db.CloseConnection();
                        throw new Exception("Cliente não localizado");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha ao buscar o cliente: {ex.Message}");
                }
            }

            public void AlterarFicharioSQLRel()
            {
                try
                {
                    string sql = $"SELECT * FROM [TB_Cliente] WHERE Id = {this.Id}";
                    SQLServerClass db = new SQLServerClass();
                    DataTable dt = db.SQLQuery(sql);
                    if (dt.Rows.Count != 0)
                    {
                        sql = this.ToUpdate(this.Id);
                        db.SQLCommand(sql);
                        db.CloseConnection();                        
                    }
                    else
                    {
                        db.CloseConnection();
                        throw new Exception("Cliente não localizado");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha ao buscar o cliente: {ex.Message}");
                }
            }

            public bool ApagarFicharioSQLRel()
            {
                try
                {
                    string sql = $"SELECT * FROM [TB_Cliente] WHERE Id = {this.Id}";
                    SQLServerClass db = new SQLServerClass();
                    DataTable dt = db.SQLQuery(sql);
                    if (dt.Rows.Count != 0)
                    {
                        sql = $"DELETE FROM [TB_Cliente] WHERE Id = {this.Id}";
                        db.SQLCommand(sql);
                        db.CloseConnection();
                        return true;
                    }
                    else
                    {
                        db.CloseConnection();
                        throw new Exception("Cliente não localizado");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha ao buscar o cliente: {ex.Message}");
                }
            }

            public List<List<String>> BuscarTudoFicharioSQLRel()
            {
                List<List<String>> list = new List<List<String>>();
                try
                {
                    string sql = $"SELECT * FROM [TB_Cliente]";
                    SQLServerClass db = new SQLServerClass();
                    DataTable dt = db.SQLQuery(sql);
                    if (dt.Rows.Count != 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            list.Add(new List<String> { dr["Id"].ToString(), dr["Nome"].ToString() });
                        }
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha ao buscar os clientes: {ex.Message}");
                }
                return list;
            }

            #endregion
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DeserializeClassUnit(string json)
        {
            return JsonConvert.DeserializeObject<Unit>(json);
        }

        public static string SerializeClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
