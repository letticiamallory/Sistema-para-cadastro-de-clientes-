using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Cadastro_de_clientes_visual_studio
{
    internal class Funcoes
    {
        public static void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Digite corretamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgAlerta(string msg)
        {
            MessageBox.Show(msg, "Digite corretamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Digite corretamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Pergunta(string msg)
        {
            if (MessageBox.Show(msg, "Digite corretamente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PriMaiuscula(Control ctr)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            string t = ctr.Text;

            t = textInfo.ToTitleCase(t);

            t = t.Replace("De ", "de ")
                    .Replace("Da ", "da ")
                    .Replace("Do ", "do ")
                    .Replace("Das ", "das ")
                    .Replace("Dos ", "dos ");

            ctr.Text = t;

            if (ctr is TextBox txt)
            {
                txt.SelectionStart = txt.Text.Length;
            }

            else if (ctr is ComboBox cmb)
            {
                cmb.SelectionStart = cmb.Text.Length;
            }


        }

        public static DataTable BuscaSql(string constring, string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection Conexao = new NpgsqlConnection(constring))
            {
                Conexao.Open();

                using (NpgsqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
