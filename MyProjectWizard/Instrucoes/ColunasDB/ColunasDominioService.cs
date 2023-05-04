using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplatePepWizard.Instrucoes.ColunasDB
{
  public class ColunasDominioService
  {
    public string GerarColunasDominio(List<PropriedadeModel> propriedades) {

      return string.Join($", {Environment.NewLine}", propriedades.Select(x=>x.Nome)).ToUpper();
    }
  }
}
