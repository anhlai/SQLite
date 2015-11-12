using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0000Q00GetModalityCodeArgs : IContractArgs
	{
		private String _hangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public XRT0000Q00GetModalityCodeArgs() { }

		public XRT0000Q00GetModalityCodeArgs(String hangmogCode)
		{
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0000Q00GetModalityCodeRequest();
		}
	}
}