using ProjectTemplatePepWizard.Extensions;
using ProjectTemplatePepWizard.Instrucoes.ColunasDB;
using ProjectTemplatePepWizard.Instrucoes.Mapper;
using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using ProjectTemplatePepWizard.Instrucoes.TesteUnitario.TesteMapeamento;
using ProjectTemplatePepWizard.VariaveisCustomizadas;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectTemplatePepWizard
{
  public partial class PropsInput : Form
  {
    public Dictionary<string, string> ReplacementsDictionary { get; set; }
    public PropriedadeService propriedadeService { get; }
    public ColunasDominioService colunasDominioService { get; }
    public MapperService mapperService { get; }
    public ValidacaoMapeamentoServico validacaoMapeamentoServico { get; }
    public VariaveisCustomizadasService variaveisCustomizadasService { get; }
    public List<PropriedadeModel> Propriedades { get; set; }


    public PropsInput(Dictionary<string, string> replacementsDictionary)
    {
      InitializeComponent();
      ReplacementsDictionary = replacementsDictionary;
      propriedadeService = new PropriedadeService();
      colunasDominioService = new ColunasDominioService();
      mapperService = new MapperService();
      validacaoMapeamentoServico = new ValidacaoMapeamentoServico();
      variaveisCustomizadasService = new VariaveisCustomizadasService(ReplacementsDictionary);
    }

    private void PropsInput_FormClosed(object sender, FormClosedEventArgs e)
    {
      SalvarMetadados();
    }

    private void SalvarMetadados()
    {
      var propriedades = propriedadeService.ConvertPropriedades(Propriedades);
      variaveisCustomizadasService.AdicionarVariavel("$propriedades$", propriedades);


      propriedadeService.AtualizarPropriedade(Propriedades);

      variaveisCustomizadasService.AdicionarVariavel("$mapperclass$", mapperService.GerarClasseMapper(ReplacementsDictionary, Propriedades));
      variaveisCustomizadasService.AdicionarVariavel("$validacaoMapeamento$", validacaoMapeamentoServico.GerarCodigoValidacaoMapeamento(Propriedades));
      variaveisCustomizadasService.AdicionarVariavel("$tabeladominio$", txtTabela.Text.ToUpper());
      variaveisCustomizadasService.AdicionarVariavel("$colunasdominio$", colunasDominioService.GerarColunasDominio(Propriedades));
      variaveisCustomizadasService.AdicionarVariavel("$codigodominio$", Propriedades.FirstOrDefault(x => x.SequencialUnico).Nome.ToCamelCase());
      variaveisCustomizadasService.AdicionarVariavel("$codigodominioDB$", ReplacementsDictionary["$codigodominio$"].ToUpper());
    }

    private void CarregarDataGrid()
    {
      this.dataGridView1.DataSource = null;
      this.dataGridView1.DataSource = Propriedades;
    }

    private void PropsInput_Load(object sender, System.EventArgs e)
    {
      this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
      this.dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 56, 56, 56);

      Propriedades = propriedadeService.ListarPropriedades();

      if (Propriedades?.Count == 0)
        Propriedades.Add(new PropriedadeModel("Id") { SequencialUnico = true });

      CarregarDataGrid();
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      try
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
          if (Propriedades.Count > 0)
          {
            Propriedades.RemoveAt(((DataGridView)sender).CurrentRow.Index);
            CarregarDataGrid();
          }
        }
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    private bool ExisteRegistroNovo()
    {
      return Propriedades.Where(x => x.Nome.Equals("Novo_Registro")).Count() > 0;
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
      Close();
    }
  }
}

