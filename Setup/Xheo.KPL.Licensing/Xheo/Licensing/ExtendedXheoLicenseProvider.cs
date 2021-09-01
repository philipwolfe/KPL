using System.ComponentModel;
using System.Diagnostics;

namespace Xheo.Licensing
{
  public class ExtendedXheoLicenseProvider : LicenseProvider
  {
	  [DebuggerHidden]
	  public override License GetLicense(
		LicenseContext context,
		System.Type type,
		object instance,
		bool allowExceptions)
	  {
		  return new ExtendedXheoLicense();
	  }
  }
}
