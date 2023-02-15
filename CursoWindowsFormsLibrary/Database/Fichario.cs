using CursoWindowsFormsLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace CursoWindowsFormsLibrary.Database
{
    public class Fichario
    {
        public string Diretorio { get; set; }
        public string Mensagem { get; set; }
        public bool Status { get; set; }

        public Fichario(string conexao)
        {
            Status = true;
            try
            {
                if (!Directory.Exists(conexao))
                {
                    Directory.CreateDirectory(conexao);
                }
                this.Diretorio = conexao;
                Mensagem = "Conexão com o fichário bem sucedida";
            }
            catch (Exception e)
            {
                Status = false;
                Mensagem = "Conexão com o fichário falhou" + e.Message;
            }
        }

        public bool Incluir(string id, string cliente)
        {
            try
            {
                if (!File.Exists(Diretorio + "\\" + id + ".json"))
                {
                    File.WriteAllText(Diretorio + "\\" + id + ".json", cliente);
                    Mensagem = $"Inclusão com sucesso. Identficador {id}";
                    return true;
                }
                else
                {
                    Mensagem = $"Inclusão falhou: Identificador {id} já existente";
                    return false;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Conexão com o fichário falhou" + e.Message;
                return false;
            }
        }

        public string Buscar(string id)
        {
            Status = true;
            try
            {
                if (File.Exists(Diretorio + "\\" + id + ".json"))
                {
                    return File.ReadAllText(Diretorio + "\\" + id + ".json");
                }
                else
                {
                    Mensagem = "Cliente não localizado";
                    Status = false;
                }
            }
            catch (Exception e)
            {
                Status = false;
                Mensagem = "Erro ao buscar o cliente" + e.Message;
            }
            return "";
        }

        public List<string> BuscarTudo()
        {
            Status = true;
            List<string> list = new List<string>();
            try
            {
                string[] arquivos = Directory.GetFiles(Diretorio, "*.json");
                foreach (string str in arquivos)
                {
                    list.Add(File.ReadAllText(str));                    
                }
            }
            catch (Exception e)
            {
                Status = false;
                Mensagem = "Erro ao buscar o cliente" + e.Message;
            }
            return list;
        }

        public bool Apagar(string id)
        {
            try
            {
                if (File.Exists(Diretorio + "\\" + id + ".json"))
                {
                    File.Delete(Diretorio + "\\" + id + ".json");
                    return true;
                }
                else
                {
                    Mensagem = "Cliente não localizado";
                    return false;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Erro ao buscar o cliente" + e.Message;
                return false;
            }
        }

        public bool Alterar(string id, string cliente)
        {
            try
            {
                if (!File.Exists(Diretorio + "\\" + id + ".json"))
                {
                    Mensagem = $"Alteração falhou. Identificador {id} não existente";
                    return false;
                }
                else
                {
                    File.Delete(Diretorio + "\\" + id + ".json");
                    File.WriteAllText(Diretorio + "\\" + id + ".json", cliente);
                    Mensagem = $"Alteração bem sucedida: Identificador {id}";
                    return true;
                }
            }
            catch (Exception e)
            {
                Mensagem = "Conexão com o fichário falhou" + e.Message;
                return false;
            }
        }
    }
}
