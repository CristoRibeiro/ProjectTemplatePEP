using ProjectTemplatePepWizard.Instrucoes.Propriedades;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplatePepWizard.Instrucoes.Mapper
{
  public class MapperService
  {
    public string GerarClasseMapper(Dictionary<string, string> replacementsDictionary, List<PropriedadeModel> propriedades) {

      var dominio = replacementsDictionary["$dominio$"];      

      StringBuilder classMapper = new StringBuilder();

      classMapper.AppendLine($"cfg.CreateMap<Pep{dominio}DBModel, Pep{dominio}Negocio>()");
      foreach (var item in propriedades)
      {
        classMapper.AppendLine($".ForMember(entity => entity.{item.Nome}, map => map.MapFrom(model => model.{item.Nome}))");
      }
      classMapper.AppendLine($".ReverseMap();");
      classMapper.AppendLine("");
      classMapper.AppendLine($"cfg.CreateMap<Pep{dominio}UIModel, Pep{dominio}Negocio>()");
      
      foreach (var item in propriedades)
      {
        classMapper.AppendLine($".ForMember(entity => entity.{item.Nome}, map => map.MapFrom(model => model.{item.Nome}))");
      }
      classMapper.AppendLine($".ReverseMap();");

      return classMapper.ToString();
    }
  }
}
