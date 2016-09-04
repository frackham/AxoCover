﻿namespace AxoCover.Models.Data.CoverageReport
{
  public class Module
  {
    public Summary Summary { get; set; }

    public string ModulePath { get; set; }

    public string ModuleName { get; set; }

    public File[] Files { get; set; }

    public Class[] Classes { get; set; }
  }
}