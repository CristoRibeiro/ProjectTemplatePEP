using RM.Lib;
using System.Collections.Generic;
using $safeprojectname$.Model;

namespace $safeprojectname$
{
  public interface IPep$dominio$Servico
  {
    IEnumerable<Pep$dominio$Negocio> Listar$dominio$s(int codColigada, RMSApiQuery apiQuery);
    Pep$dominio$Negocio Detalhar(int codColigada, int $codigodominio$);
    Pep$dominio$Negocio Inserir$dominio$(Pep$dominio$Negocio $instanciadominio$);
  }
}
