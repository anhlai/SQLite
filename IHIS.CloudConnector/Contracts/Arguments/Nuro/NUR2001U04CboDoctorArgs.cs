using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NUR2001U04CboDoctorArgs : IContractArgs
	{
		private String _gwa;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public NUR2001U04CboDoctorArgs() { }

		public NUR2001U04CboDoctorArgs(String gwa)
		{
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR2001U04CboDoctorRequest();
		}
	}
}