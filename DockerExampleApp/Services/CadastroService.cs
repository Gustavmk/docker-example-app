using System;
using System.Data.SqlClient;
using DockerExampleApp.Models;

namespace DockerExampleApp.Services
{
    public class CadastroService
    {
        // Lembrando que o intuito da aplicação é somente uma página web para salvar em um banco hospedado em um contâiner Docker ;)
        public void Salvar(Cadastro model)
        {
            try
            {
                RodarMigrations();

                using (var conn = new SqlConnection("Server=container-sql;Database=master;User Id=sa;Password=Docker12345;"))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"INSERT INTO cadastro VALUES ('{model.Nome}', '{model.Telefone}')", conn);
                    cmd.ExecuteNonQuery();
                    model.MensagemDeRetorno = "PARABÉNS!";
                }
            }
            catch (Exception ex)
            {
                model.MensagemDeRetorno = $"Erro! {ex.Message}";
            }
        }

        private void RodarMigrations()
        {
            try
            {
                using (var conn = new SqlConnection("Server=container-sql;Database=master;User Id=sa;Password=Docker12345;"))
                {
                    conn.Open();
                    var cmd = new SqlCommand($"CREATE TABLE cadastro (nome VARCHAR(100), telefone VARCHAR(100)) ", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
            }
        }
    }
}