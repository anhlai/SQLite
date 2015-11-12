using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001FormJusaBedLayGroupedArgs : IContractArgs
	{
		private String _hospCode;
		private String _codeName;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public INJ1001FormJusaBedLayGroupedArgs() { }

		public INJ1001FormJusaBedLayGroupedArgs(String hospCode, String codeName)
		{
			this._hospCode = hospCode;
			this._codeName = codeName;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001FormJusaBedLayGroupedRequest();
		}
	}
}