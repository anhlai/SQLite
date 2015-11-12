using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class SpeciFicCommentInputYnArgs : IContractArgs
	{
		private String _hanmogCode;
		private String _pkocskey;

		public String HanmogCode
		{
			get { return this._hanmogCode; }
			set { this._hanmogCode = value; }
		}

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public SpeciFicCommentInputYnArgs() { }

		public SpeciFicCommentInputYnArgs(String hanmogCode, String pkocskey)
		{
			this._hanmogCode = hanmogCode;
			this._pkocskey = pkocskey;
		}

		public IExtensible GetRequestInstance()
		{
			return new SpeciFicCommentInputYnRequest();
		}
	}
}