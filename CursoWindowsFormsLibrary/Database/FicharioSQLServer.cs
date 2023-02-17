using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsLibrary.Database
{
    public class FicharioSQLServer
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Table { get; set; }
        public SQLServerClass SQLServerClass { get; set; }

        public FicharioSQLServer(string table)
        {
            Status = true;
            try
            {
                SQLServerClass = new SQLServerClass();
                this.Table = table;
                this.Message = "Conexão bem sucedida.";
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = "Conexão falhou: " + ex.Message;
            }
        }

        public bool Incluir(string id, string json)
        {
            Status = true;

            try
            {
                string sql = $"INSERT INTO {Table} (Id, JSON) VALUES ('{id}','{json}')";
                SQLServerClass.SQLCommand(sql);
                this.Message = $"Inserção com sucesso. ID: {id}";
                return true;
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = $"Falha na inserção: {ex.Message}";
            }
            return false;

        }

        public string Buscar(string id)
        {
            Status = true;
            try
            {
                string sql = $"SELECT * FROM {Table} WHERE Id = {id}";
                DataTable dt = SQLServerClass.SQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    this.Message = "Busca bem sucedida";
                    return conteudo;
                }
                else
                {
                    Status = false;
                    this.Message = "Cliente não localizado";
                }
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = $"Falha ao buscar cliente: {ex.Message}";
            }
            return "";
        }

        public List<string> BuscarTudo()
        {
            Status = true;
            List<string> list = new List<string>();
            try
            {
                string sql = $"SELECT * FROM {Table}";
                DataTable dt = SQLServerClass.SQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string conteudo = dr["JSON"].ToString();
                        list.Add(conteudo);
                    }
                    this.Message = "Lista populada com sucesso";
                    return list;
                }
                else
                {
                    Status = false;
                    this.Message = "Não existem clientes cadastrados";
                }
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = $"Falha ao buscar os clientes: {ex.Message}";
            }
            return list;
        }

        public bool Apagar(string id)
        {
            Status = true;
            try
            {
                string sql = $"SELECT * FROM {Table} WHERE Id = '{id}'";
                DataTable dt = SQLServerClass.SQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    sql = $"DELETE FROM {Table} WHERE Id = '{id}'";
                    SQLServerClass.SQLCommand(sql);
                    this.Message = "Cliente excluído com sucesso";
                    return Status;
                }
                else
                {
                    Status = false;
                    this.Message = "Falha ao remover o cliente";
                    return Status;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = $"Falha: {ex.Message}";
            }
            return false;
        }

        public bool Alterar(string id, string json)
        {
            Status = true;
            try
            {
                string sql = $"SELECT * FROM {Table} WHERE Id = '{id}'";
                DataTable dt = SQLServerClass.SQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    sql = $"UPDATE {Table} SET JSON = '{json}' WHERE Id = '{id}'";
                    SQLServerClass.SQLCommand(sql);
                    this.Message = "Cliente atualizado com sucesso";
                    return Status;
                }
                else
                {
                    Status = false;
                    this.Message = "Falha ao atualizar o cliente";
                    return Status;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                this.Message = $"Falha na conexão: {ex.Message}";
            }
            return false;
        }

    }
}
