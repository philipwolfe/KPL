using System.ComponentModel;
using System.Runtime.Serialization;

namespace Xheo.Licensing
{
	public sealed class ExtendedXheoLicense : License, ISerializable
	{
		public string SerialNumber { get { return "1-1-1-1"; } }
		public string AbsoluteUser { get { return "User"; } }
		public bool IsTrial { get { return false; } }
		public string Type { get { return "Commercial"; } }
		public ExtendedLicensePack LicensePack { get { return new ExtendedLicensePack(); } }
		public string Tag { get { return AbsoluteUser; } }

		public bool ShowRegistrationForm()
		{
			return true;
		}

		public override void Dispose()
		{
		}

		public override string LicenseKey
		{
			get { return SerialNumber; }
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
