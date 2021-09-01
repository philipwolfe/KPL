using System;
using System.Collections;

namespace Xheo.Licensing
{
  [Serializable]
  public class ExtendedLicensePack : CollectionBase, IDisposable, ICloneable
  {
	  public string Location { get { return @"c:\program files (x86)\The Phrogram Company\Phrogram\Phrogram.lic"; } }

  	public void Dispose()
  	{
  		
  	}

  	public object Clone()
  	{
  		return new ExtendedLicensePack();
  	}
  }
}
