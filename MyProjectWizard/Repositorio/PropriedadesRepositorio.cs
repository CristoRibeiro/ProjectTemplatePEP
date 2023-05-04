using Newtonsoft.Json;
using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplatePepWizard.Repositorio
{
  public class PropriedadesRepositorio
  {
    const string nomeArquivo = @"../../Propriedades.json";
    public List<PropriedadeModel> PropriedadesDB { get; private set; }

    public PropriedadesRepositorio()
    {
      InicializarBanco();
    }
    private void InicializarBanco()
    {
      if (File.Exists(nomeArquivo))
      {
        string jsonFromFile = File.ReadAllText(nomeArquivo);
        PropriedadesDB = JsonConvert.DeserializeObject<List<PropriedadeModel>>(jsonFromFile);
      }
      else
        PropriedadesDB = new List<PropriedadeModel> { };
    }
    public PropriedadeModel AdicionarPropriedade(PropriedadeModel propriedade)
    {
      PropriedadesDB.Add(propriedade);

      File.WriteAllText(nomeArquivo, JsonConvert.SerializeObject(PropriedadesDB));

      return propriedade;
    }

    public List<PropriedadeModel> ListarPropriedades()
    {
      return PropriedadesDB.ToList();
    }

    public List<PropriedadeModel> AtualizarPropriedade(List<PropriedadeModel> propriedades)
    {

      PropriedadesDB = propriedades;

      File.WriteAllText(nomeArquivo, JsonConvert.SerializeObject(PropriedadesDB));

      return PropriedadesDB;
    }

    //private void ConvertToDB(List<PropriedadeModel> propriedades)
    //{
    //  propriedades.ForEach(x =>
    //  {
    //    PropriedadesDB.Add(
    //      new PropriedadeDB
    //      {
    //        CriadoEm = DateTime.Now,
    //        ModificadorAcesso = x.ModificadorAcesso,
    //        Nome = x.Nome,
    //        SetPrivado = x.SetPrivado,
    //        SomenteLeitura = x.SomenteLeitura,
    //        TipoDado = x.TipoDado,
    //        SequencialUnico = x.SequencialUnico,
    //      }
    //      );

    //  });
    //}

    //private List<PropriedadeModel> ConvertToModel()
    //{
    //  var propriedadesModel = new List<PropriedadeModel>();

    //  PropriedadesDB.ForEach(x =>
    //  {
    //    propriedadesModel.Add(
    //        new PropriedadeModel
    //        {
    //          ModificadorAcesso = x.ModificadorAcesso,
    //          Nome = x.Nome,
    //          SetPrivado = x.SetPrivado,
    //          SomenteLeitura = x.SomenteLeitura,
    //          TipoDado = x.TipoDado,
    //          SequencialUnico = x.SequencialUnico,
    //        }
    //        );
    //  });
    //  return propriedadesModel;
    //}

    //private PropriedadeDB ConvertToDB(PropriedadeModel propriedade)
    //{
    //  return
    //    new PropriedadeDB
    //    {
    //      CriadoEm = DateTime.Now,
    //      ModificadorAcesso = propriedade.ModificadorAcesso,
    //      Nome = propriedade.Nome,
    //      SetPrivado = propriedade.SetPrivado,
    //      SomenteLeitura = propriedade.SomenteLeitura,
    //      TipoDado = propriedade.TipoDado,
    //      SequencialUnico = propriedade.SequencialUnico,
    //    };
    //}

  }
}
