using ProjectTemplatePepWizard.Repositorio;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTemplatePepWizard.Instrucoes.Propriedades
{
  public class PropriedadeService
  {
    public PropriedadesRepositorio PropriedadesRepositorio  { get; set; }


    public PropriedadeService() {
      PropriedadesRepositorio = new PropriedadesRepositorio();
    }
    
    public List<PropriedadeModel> ListarPropriedades()
    {
      return PropriedadesRepositorio.ListarPropriedades();
    }

    public string ConvertPropriedades(List<PropriedadeModel> propriedades) {
      
      StringBuilder listaPropriedades = new StringBuilder();

      foreach (PropriedadeModel item in propriedades)
      {
        if (string.IsNullOrEmpty(item.Nome))
          continue;

        listaPropriedades.Append(item.ModificadorAcesso);
        listaPropriedades.Append(" ");
        listaPropriedades.Append(item.TipoDado);
        listaPropriedades.Append(" ");
        listaPropriedades.Append(item.Nome);
        listaPropriedades.Append(" { get; ");

        if (!item.SomenteLeitura)
        {
          if (item.SetPrivado)
            listaPropriedades.Append(" private set; }");
          else
            listaPropriedades.Append(" set; }");
        }
        else
          listaPropriedades.Append("}");

        listaPropriedades.AppendLine();
      }

      return listaPropriedades.ToString();

    }
    public void AtualizarPropriedade(List<PropriedadeModel> propriedades)
    {
      PropriedadesRepositorio.AtualizarPropriedade(propriedades);
    }
  }
}
