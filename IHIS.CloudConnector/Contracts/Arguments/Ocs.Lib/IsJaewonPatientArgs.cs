using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class IsJaewonPatientArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public IsJaewonPatientArgs() { }

		public IsJaewonPatientArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new IsJaewonPatientRequest();
		}
	}
}