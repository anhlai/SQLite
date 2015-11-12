using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00GrdOCS0103Args : IContractArgs
	{
		private String _slipCode;
		private String _hangmogNameInx;

		public String SlipCode
		{
			get { return this._slipCode; }
			set { this._slipCode = value; }
		}

		public String HangmogNameInx
		{
			get { return this._hangmogNameInx; }
			set { this._hangmogNameInx = value; }
		}

		public OCS0113U00GrdOCS0103Args() { }

		public OCS0113U00GrdOCS0103Args(String slipCode, String hangmogNameInx)
		{
			this._slipCode = slipCode;
			this._hangmogNameInx = hangmogNameInx;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00GrdOCS0103Request();
		}
	}
}