using ProjectTemplatePepWizard.Extensions;
using ProjectTemplatePepWizard.VariaveisCustomizadas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectTemplatePepWizard
{
  public partial class UserInputForm : Form
  {
    private TextBox txtPrefixo;
    private TextBox txtDominio;
    private Label label2;
    private Button button1;
    private TrackBar tkbQtdPrefixo;
    private Label label3;
    private Label label4;
    private TextBox txtVersao;
    private Button button2;
    private Label label1;

    public Dictionary<string, string> ReplacementsDictionary { get; set; }
    public VariaveisCustomizadasService serviceVariaveisCustomizadas {get;}
    private string NomeProjeto { get; set; }
    public UserInputForm()
    {
      InitializeComponent();
      serviceVariaveisCustomizadas = new VariaveisCustomizadasService(ReplacementsDictionary);
    }

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputForm));
      this.txtPrefixo = new System.Windows.Forms.TextBox();
      this.txtDominio = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.tkbQtdPrefixo = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtVersao = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.tkbQtdPrefixo)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPrefixo
      // 
      this.txtPrefixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtPrefixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPrefixo.Cursor = System.Windows.Forms.Cursors.No;
      resources.ApplyResources(this.txtPrefixo, "txtPrefixo");
      this.txtPrefixo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.txtPrefixo.Name = "txtPrefixo";
      this.txtPrefixo.ReadOnly = true;
      // 
      // txtDominio
      // 
      this.txtDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtDominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDominio.Cursor = System.Windows.Forms.Cursors.No;
      resources.ApplyResources(this.txtDominio, "txtDominio");
      this.txtDominio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.txtDominio.Name = "txtDominio";
      this.txtDominio.ReadOnly = true;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label2.Name = "label2";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.button1.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.button1, "button1");
      this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tkbQtdPrefixo
      // 
      resources.ApplyResources(this.tkbQtdPrefixo, "tkbQtdPrefixo");
      this.tkbQtdPrefixo.Maximum = 4;
      this.tkbQtdPrefixo.Minimum = 1;
      this.tkbQtdPrefixo.Name = "tkbQtdPrefixo";
      this.tkbQtdPrefixo.Value = 2;
      this.tkbQtdPrefixo.Scroll += new System.EventHandler(this.tkbQtdPrefixo_Scroll);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label4.Name = "label4";
      // 
      // txtVersao
      // 
      this.txtVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtVersao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      resources.ApplyResources(this.txtVersao, "txtVersao");
      this.txtVersao.Name = "txtVersao";
      this.txtVersao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVersao_KeyDown);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.button2.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.button2, "button2");
      this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.button2.Name = "button2";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // UserInputForm
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      resources.ApplyResources(this, "$this");
      this.ControlBox = false;
      this.Controls.Add(this.button2);
      this.Controls.Add(this.txtVersao);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tkbQtdPrefixo);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDominio);
      this.Controls.Add(this.txtPrefixo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "UserInputForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.UserInputForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tkbQtdPrefixo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      CriarProjeto();
    }

    private void CriarProjeto()
    {
      if (string.IsNullOrWhiteSpace(txtVersao.Text))
      {
        txtVersao.Focus();
        txtVersao.BackColor = Color.PapayaWhip;
        txtVersao.ForeColor = Color.Black;
        return;
      }
      serviceVariaveisCustomizadas.AdicionarVariavel("$versao$", txtVersao.Text);
      ReplacementsDictionary = serviceVariaveisCustomizadas.ObterVariaveisCustomizadas();
      Close();
    }

    private void UserInputForm_Load(object sender, EventArgs e)
    {
      NomeProjeto = ReplacementsDictionary["$safeprojectname$"];
      DefinirVariaveisTemplate();
    }

    private void DefinirVariaveisTemplate()
    {
      string prefixo = string.Empty;
      string dominio = string.Empty;

      if (NomeProjeto.Contains("."))
      {

        string padrao = @"(([^.]*\.){" + tkbQtdPrefixo.Value + "})([^.]+)";

        Match match = Regex.Match(NomeProjeto, padrao);

        if (match.Groups.Count > 1)
          prefixo = match.Groups[1].Value.TrimEnd('.');

        if (match.Groups.Count > 3)
          dominio = match.Groups[3].Value;
      }

      string instanciaDominio = dominio.ToCamelCase();
      serviceVariaveisCustomizadas.AdicionarVariavel("$prefixoprojeto$", prefixo);
      serviceVariaveisCustomizadas.AdicionarVariavel("$dominio$", dominio);
      serviceVariaveisCustomizadas.AdicionarVariavel("$instanciadominio$", instanciaDominio);

      txtPrefixo.Text = prefixo;
      txtDominio.Text = dominio;
    }

    private void tkbQtdPrefixo_Scroll(object sender, EventArgs e)
    {
      DefinirVariaveisTemplate();
    }

    private void txtVersao_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        CriarProjeto();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      PropsInput propsInputForm = new PropsInput(ReplacementsDictionary);      
      propsInputForm.ShowDialog();
    }
  }
}