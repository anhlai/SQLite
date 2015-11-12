using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0000Q00LayPacsInfoArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public XRT0000Q00LayPacsInfoArgs() { }

		public XRT0000Q00LayPacsInfoArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0000Q00LayPacsInfoRequest();
		}
	}
}