using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0131U00GrdOCS0132Args : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public OCS0131U00GrdOCS0132Args() { }

		public OCS0131U00GrdOCS0132Args(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0131U00GrdOCS0132Request();
		}
	}
}