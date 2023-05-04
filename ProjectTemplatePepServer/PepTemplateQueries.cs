using RM.Lib.Data.ORM.SQL;

namespace $safeprojectname$.Queries
{
  public class Pep$dominio$Queries
  {
    public static string Listar$dominio$s(ISqlDialect dialeto) => $@"SELECT {Colunas$dominio$} 
      FROM $tabeladominio$ ";

    public static string Detalhar(ISqlDialect dialeto) => $@"SELECT {Colunas$dominio$}
      FROM $tabeladominio$ {dialeto.NoLockStatment}
      WHERE $codigodominioDB$ = {dialeto.ParameterPrefix}$codigodominioDB$ ";

    public static string Colunas$dominio$ => $@"
      $colunasdominio$";
  }
}
