using ProjectTemplatePepWizard.Instrucoes.Propriedades;

namespace ProjectTemplatePepWizard
{
  partial class PropsInput
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropsInput));
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modificadorAcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tipoDadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.somenteLeituraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.setPrivadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.sequencialUnicoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.propriedadeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.txtTabela = new System.Windows.Forms.TextBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.propriedadeModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.dataGridView1);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.dataGridView1, "dataGridView1");
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.modificadorAcessoDataGridViewTextBoxColumn,
            this.tipoDadoDataGridViewTextBoxColumn,
            this.somenteLeituraDataGridViewCheckBoxColumn,
            this.setPrivadoDataGridViewCheckBoxColumn,
            this.sequencialUnicoDataGridViewCheckBoxColumn});
      this.dataGridView1.DataSource = this.propriedadeModelBindingSource;
      this.dataGridView1.EnableHeadersVisualStyles = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // nomeDataGridViewTextBoxColumn
      // 
      this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
      resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
      this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
      // 
      // modificadorAcessoDataGridViewTextBoxColumn
      // 
      this.modificadorAcessoDataGridViewTextBoxColumn.DataPropertyName = "ModificadorAcesso";
      resources.ApplyResources(this.modificadorAcessoDataGridViewTextBoxColumn, "modificadorAcessoDataGridViewTextBoxColumn");
      this.modificadorAcessoDataGridViewTextBoxColumn.Name = "modificadorAcessoDataGridViewTextBoxColumn";
      // 
      // tipoDadoDataGridViewTextBoxColumn
      // 
      this.tipoDadoDataGridViewTextBoxColumn.DataPropertyName = "TipoDado";
      resources.ApplyResources(this.tipoDadoDataGridViewTextBoxColumn, "tipoDadoDataGridViewTextBoxColumn");
      this.tipoDadoDataGridViewTextBoxColumn.Name = "tipoDadoDataGridViewTextBoxColumn";
      // 
      // somenteLeituraDataGridViewCheckBoxColumn
      // 
      this.somenteLeituraDataGridViewCheckBoxColumn.DataPropertyName = "SomenteLeitura";
      resources.ApplyResources(this.somenteLeituraDataGridViewCheckBoxColumn, "somenteLeituraDataGridViewCheckBoxColumn");
      this.somenteLeituraDataGridViewCheckBoxColumn.Name = "somenteLeituraDataGridViewCheckBoxColumn";
      // 
      // setPrivadoDataGridViewCheckBoxColumn
      // 
      this.setPrivadoDataGridViewCheckBoxColumn.DataPropertyName = "SetPrivado";
      resources.ApplyResources(this.setPrivadoDataGridViewCheckBoxColumn, "setPrivadoDataGridViewCheckBoxColumn");
      this.setPrivadoDataGridViewCheckBoxColumn.Name = "setPrivadoDataGridViewCheckBoxColumn";
      // 
      // sequencialUnicoDataGridViewCheckBoxColumn
      // 
      this.sequencialUnicoDataGridViewCheckBoxColumn.DataPropertyName = "SequencialUnico";
      resources.ApplyResources(this.sequencialUnicoDataGridViewCheckBoxColumn, "sequencialUnicoDataGridViewCheckBoxColumn");
      this.sequencialUnicoDataGridViewCheckBoxColumn.Name = "sequencialUnicoDataGridViewCheckBoxColumn";
      // 
      // propriedadeModelBindingSource
      // 
      this.propriedadeModelBindingSource.DataSource = typeof(ProjectTemplatePepWizard.Instrucoes.Propriedades.PropriedadeModel);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label3.Name = "label3";
      // 
      // txtTabela
      // 
      this.txtTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtTabela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTabela.ForeColor = System.Drawing.Color.White;
      resources.ApplyResources(this.txtTabela, "txtTabela");
      this.txtTabela.Name = "txtTabela";
      // 
      // btnOk
      // 
      this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.btnOk.FlatAppearance.BorderSize = 0;
      resources.ApplyResources(this.btnOk, "btnOk");
      this.btnOk.ForeColor = System.Drawing.Color.White;
      this.btnOk.Name = "btnOk";
      this.btnOk.UseVisualStyleBackColor = false;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // PropsInput
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.ControlBox = false;
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.txtTabela);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PropsInput";
      this.ShowIcon = false;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PropsInput_FormClosed);
      this.Load += new System.EventHandler(this.PropsInput_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.propriedadeModelBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn modificadorAcessoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tipoDadoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn somenteLeituraDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn setPrivadoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn sequencialUnicoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.BindingSource propriedadeModelBindingSource;
    private System.Windows.Forms.TextBox txtTabela;
    private System.Windows.Forms.Button btnOk;
  }
}