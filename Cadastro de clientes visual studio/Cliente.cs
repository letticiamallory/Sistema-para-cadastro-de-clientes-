namespace Cadastro_de_clientes_visual_studio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Documento { get; set; } = "";
        public string Genero { get; set; } = "";
        public string EstadoCivil { get; set; } = "";
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Numero { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string Cidade { get; set; } = "";
        public string Estado { get; set; } = "";
        public string Celular { get; set; } = "";
        public string Email { get; set; } = "";
        public string Obs { get; set; } = "";
        public string Situacao { get; set; } = "Ativo";

        public Cliente() { }

        public Cliente(int id, string nome, string documento, string genero,
            string estadoCivil, DateTime dataNascimento, string cep,
            string endereco, string numero, string bairro, string cidade,
            string estado, string celular, string email, string obs, string situacao)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            Genero = genero;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Celular = celular;
            Email = email;
            Obs = obs;
            Situacao = situacao;
        }

        public bool EstaAtivo()
        {
            return Situacao == "Ativo";
        }

        public string TipoDocumento()
        {
            string apenasNumeros = Documento.Replace(".", "").Replace("-", "").Replace("/", "");
            if (apenasNumeros.Length == 11)
            {
                return "CPF";
            }
            else
            {
                return "CNPJ";
            }
        }

        public override string ToString()
        {
            return Id + " - " + Nome;
        }
    }
}