using ProjectTemplatePepWizard.Instrucoes.ColunasDB;
using ProjectTemplatePepWizard.Instrucoes.Mapper;
using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using ProjectTemplatePepWizard.Instrucoes.TesteUnitario.TesteMapeamento;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public List<PropriedadeModel> Propriedades { get; set; }
    public PropriedadeService propriedadeService { get; set; }
    public ColunasDominioService colunasDominioService { get; set; }
    public ValidacaoMapeamentoServico validacaoMapeamentoServico { get; set; }
    public MapperService mapperService { get; set; }
    public Form1()
    {
      propriedadeService = new PropriedadeService();
      colunasDominioService = new ColunasDominioService();
      mapperService = new MapperService();
      validacaoMapeamentoServico = new ValidacaoMapeamentoServico();
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Propriedades = propriedadeService.ListarPropriedades();

      if (Propriedades?.Count == 0)
        Propriedades.Add(new PropriedadeModel("Id"));

      CarregarDataGrid();
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (!ExisteRegistroNovo())
        {
          Propriedades.Add(new PropriedadeModel());
          CarregarDataGrid();
        }
      }
      
      if (e.KeyCode == Keys.Delete)
      {
        if (Propriedades.Count > 0) {
          Propriedades.RemoveAt(((DataGridView)sender).CurrentRow.Index);
          CarregarDataGrid();
        }
      }
    }
    private bool ExisteRegistroNovo()
    {
      return Propriedades.Where(x => x.Nome.Equals("Novo_Registro")).Count() > 0;
    }
    private void CarregarDataGrid()
    {
      this.dataGridView1.DataSource = null;
      this.dataGridView1.DataSource = Propriedades;

      this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
      this.dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 56, 56, 56);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var teste = propriedadeService.ConvertPropriedades(Propriedades);
      textBox1.Text = teste;

      textBox1.Text += "##### Colunas #####";

      textBox1.Text += colunasDominioService.GerarColunasDominio(Propriedades);
      var dicionario = new Dictionary<string, string>
      {
        { "$dominio$", "Estoque" }
      };

      textBox1.Text += mapperService.GerarClasseMapper(dicionario, Propriedades);
      textBox1.Text += validacaoMapeamentoServico.GerarCodigoValidacaoMapeamento(Propriedades);

      propriedadeService.AtualizarPropriedade(Propriedades);

      Propriedades.FirstOrDefault(x => x.SequencialUnico);
    }


  }
}
