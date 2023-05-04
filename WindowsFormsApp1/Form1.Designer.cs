namespace WindowsFormsApp1
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modificadorAcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tipoDadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.somenteLeituraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.setPrivadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.sequencialUnicoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.propriedadeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.propriedadeModelBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
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
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // nomeDataGridViewTextBoxColumn
      // 
      this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
      resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
      this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
      this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // modificadorAcessoDataGridViewTextBoxColumn
      // 
      this.modificadorAcessoDataGridViewTextBoxColumn.DataPropertyName = "ModificadorAcesso";
      resources.ApplyResources(this.modificadorAcessoDataGridViewTextBoxColumn, "modificadorAcessoDataGridViewTextBoxColumn");
      this.modificadorAcessoDataGridViewTextBoxColumn.Name = "modificadorAcessoDataGridViewTextBoxColumn";
      this.modificadorAcessoDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // tipoDadoDataGridViewTextBoxColumn
      // 
      this.tipoDadoDataGridViewTextBoxColumn.DataPropertyName = "TipoDado";
      resources.ApplyResources(this.tipoDadoDataGridViewTextBoxColumn, "tipoDadoDataGridViewTextBoxColumn");
      this.tipoDadoDataGridViewTextBoxColumn.Name = "tipoDadoDataGridViewTextBoxColumn";
      this.tipoDadoDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // somenteLeituraDataGridViewCheckBoxColumn
      // 
      this.somenteLeituraDataGridViewCheckBoxColumn.DataPropertyName = "SomenteLeitura";
      resources.ApplyResources(this.somenteLeituraDataGridViewCheckBoxColumn, "somenteLeituraDataGridViewCheckBoxColumn");
      this.somenteLeituraDataGridViewCheckBoxColumn.Name = "somenteLeituraDataGridViewCheckBoxColumn";
      this.somenteLeituraDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // setPrivadoDataGridViewCheckBoxColumn
      // 
      this.setPrivadoDataGridViewCheckBoxColumn.DataPropertyName = "SetPrivado";
      resources.ApplyResources(this.setPrivadoDataGridViewCheckBoxColumn, "setPrivadoDataGridViewCheckBoxColumn");
      this.setPrivadoDataGridViewCheckBoxColumn.Name = "setPrivadoDataGridViewCheckBoxColumn";
      this.setPrivadoDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // sequencialUnicoDataGridViewCheckBoxColumn
      // 
      this.sequencialUnicoDataGridViewCheckBoxColumn.DataPropertyName = "SequencialUnico";
      resources.ApplyResources(this.sequencialUnicoDataGridViewCheckBoxColumn, "sequencialUnicoDataGridViewCheckBoxColumn");
      this.sequencialUnicoDataGridViewCheckBoxColumn.Name = "sequencialUnicoDataGridViewCheckBoxColumn";
      this.sequencialUnicoDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // propriedadeModelBindingSource
      // 
      this.propriedadeModelBindingSource.DataSource = typeof(ProjectTemplatePepWizard.Instrucoes.Propriedades.PropriedadeModel);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.dataGridView1);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // button1
      // 
      resources.ApplyResources(this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      resources.ApplyResources(this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
      // 
      // Form1
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.propriedadeModelBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn pKDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn modificadorAcessoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tipoDadoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn somenteLeituraDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn setPrivadoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn sequencialUnicoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.BindingSource propriedadeModelBindingSource;
  }
}

