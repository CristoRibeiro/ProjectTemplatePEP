namespace ProjectTemplatePepWizard.Instrucoes.Propriedades
{
  public class PropriedadeModel
  {
    public string Nome { get; set; }
    public string ModificadorAcesso { get; set; }
    public string TipoDado { get; set; }
    public bool SomenteLeitura { get; set; }
    public bool SetPrivado { get; set; }
    public bool SequencialUnico { get; set; }

    public PropriedadeModel(string nome) {
      InicializarPropriedade();
      Nome = nome;
    }
    public PropriedadeModel()
    {
      InicializarPropriedade();
    }

    private void InicializarPropriedade() {
      Nome = "Novo_Registro";
      ModificadorAcesso = "public";
      SomenteLeitura = false;
      SetPrivado = false;
      TipoDado = "string";
    }

    
  }
}
