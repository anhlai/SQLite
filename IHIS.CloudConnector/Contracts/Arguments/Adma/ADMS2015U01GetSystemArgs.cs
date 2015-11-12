using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADMS2015U01GetSystemArgs : IContractArgs
	{
		private String _hospCode;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public ADMS2015U01GetSystemArgs() { }

		public ADMS2015U01GetSystemArgs(String hospCode)
		{
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADMS2015U01GetSystemRequest();
		}
	}
}