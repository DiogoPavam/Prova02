using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prova02
{

    public partial class FormPrincipal : Form
    {
        private DataGridView principalDataGridView;
        private DataTable produtosDataTable;

        public FormPrincipal()
        {
            InitializeComponent();
            produtosDataTable = new DataTable();
        }

        public FormPrincipal(Form1 form1) : this()
        {
            // Você pode adicionar lógica adicional aqui, se necessário
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.principalDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // principalDataGridView
            // 
            this.principalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.principalDataGridView.Location = new System.Drawing.Point(12, 12);
            this.principalDataGridView.Name = "principalDataGridView";
            this.principalDataGridView.Size = new System.Drawing.Size(772, 484);
            this.principalDataGridView.TabIndex = 0;
            this.principalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.principalDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.principalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarExibicaoProdutosFormPrincipal();
        }

        private DataTable ObterDadosDoBanco()
        {
            using (SqlConnection conexao = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=ControleEstoque;Trusted_Connection=True;"))
            {
                string sql = "SELECT ID, Nome, Descricao, Quantidade, Categoria, Fornecedor FROM Produtos";
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    DataTable dataTable = new DataTable();
                    conexao.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
        }

        public void AtualizarExibicaoProdutosFormPrincipal()
        {
            produtosDataTable = ObterDadosDoBanco();
            principalDataGridView.DataSource = produtosDataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para manipular o clique nas células do DataGridView
        }
    }
}
