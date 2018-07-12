using SCV.UTL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCV.DTO
{
    [Table("Cliente")]
    public class ClienteDTO: ObservableObject
    {
        private int clienteID;
        private string nome;
        private string cNPJ;
        private string endereco;
        private string telefone;
        private bool ativo;

        #region propriedades

        [Key]
        public int ClienteID
        {
            get { return clienteID; }
            set {
                if (value != clienteID)
                {
                    clienteID = value;
                    OnPropertyChanged("ClienteID");
                }
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != nome)
                {
                    nome = value;
                    OnPropertyChanged("Nome");
                }
            }
        }

        public string CNPJ
        {
            get { return cNPJ; }
            set
            {
                if (value != cNPJ)
                {
                    cNPJ = value;
                    OnPropertyChanged("CNPJ");
                }
            }
        }

        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (value != endereco)
                {
                    endereco = value;
                    OnPropertyChanged("Endereco");
                }
            }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value != telefone)
                {
                    telefone = value;
                    OnPropertyChanged("Telefone");
                }
            }
        }

        public bool Ativo
        {
            get { return ativo; }
            set
            {
                if (value != ativo)
                {
                    ativo = value;
                    OnPropertyChanged("Ativo");
                }
            }
        }

        #endregion
    }
}
