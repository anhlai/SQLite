using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class GetPatientInfoArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public GetPatientInfoArgs() { }

		public GetPatientInfoArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetPatientInfoRequest();
		}
	}
}