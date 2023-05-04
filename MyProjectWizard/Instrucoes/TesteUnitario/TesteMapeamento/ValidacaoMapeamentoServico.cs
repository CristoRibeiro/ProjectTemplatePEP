using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplatePepWizard.Instrucoes.TesteUnitario.TesteMapeamento
{
  public class ValidacaoMapeamentoServico
  {
    public string GerarCodigoValidacaoMapeamento(List<PropriedadeModel> propriedades) {
      StringBuilder classAssertMapeamento = new StringBuilder();

      foreach (var item in propriedades)
      {
        classAssertMapeamento.AppendLine($"Assert.AreEqual(objUIModel.{item.Nome}, objNegocio.{item.Nome});");
      }

      return classAssertMapeamento.ToString();
    }
  }
}
