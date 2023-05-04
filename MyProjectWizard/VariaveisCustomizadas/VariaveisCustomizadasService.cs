using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplatePepWizard.VariaveisCustomizadas
{
  public class VariaveisCustomizadasService
  {
    Dictionary<string, string> replacementsDictionary { get;}

    public VariaveisCustomizadasService(Dictionary<string, string> ReplacementsDictionary) {
      replacementsDictionary = ReplacementsDictionary;
    }
    public void AdicionarVariavel(string chave, string valor) {
      if (replacementsDictionary.ContainsKey(chave))
        replacementsDictionary[chave] = valor;
      else
        replacementsDictionary.Add(chave, valor);
    }

    public Dictionary<string, string> ObterVariaveisCustomizadas()
    {
      return replacementsDictionary;
    }
  }
}
