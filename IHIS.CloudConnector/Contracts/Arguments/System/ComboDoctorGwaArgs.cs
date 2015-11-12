using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboDoctorGwaArgs : IContractArgs
	{
		private String _memb;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public ComboDoctorGwaArgs() { }

		public ComboDoctorGwaArgs(String memb)
		{
			this._memb = memb;
		}

		public IExtensible GetRequestInstance()
		{
			return new ComboDoctorGwaRequest();
		}
	}
}