﻿using RM.Lib;
using $safeprojectname$.Model;
using System.Collections.Generic;

namespace $safeprojectname$.Interface
{
  public interface IPep$dominio$Modulo : IRMSModule
  {
    Pep$dominio$UIModel Detalhar(int $codigodominio$);
    IEnumerable<Pep$dominio$UIModel> Listar$dominio$s (RMSApiQuery apiQuery);
  }
}
