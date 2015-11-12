using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00GrdOCS0113Args : IContractArgs
	{
		private String _hangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public OCS0113U00GrdOCS0113Args() { }

		public OCS0113U00GrdOCS0113Args(String hangmogCode)
		{
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00GrdOCS0113Request();
		}
	}
}