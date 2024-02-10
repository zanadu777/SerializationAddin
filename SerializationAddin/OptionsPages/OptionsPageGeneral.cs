using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;

namespace SerializationAddin.OptionsPages
{
  public class OptionsPageGeneral: DialogPage
  {
    private string _mySetting = "Default Value";

    public string MySetting
    {
      get { return _mySetting; }
      set { _mySetting = value; }
    }
  }
}
