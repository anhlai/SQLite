using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00LaySubHangmogArgs : IContractArgs
	{
		private String _bunho;
		private String _hangmogCode;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public CPL0000Q00LaySubHangmogArgs() { }

		public CPL0000Q00LaySubHangmogArgs(String bunho, String hangmogCode)
		{
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00LaySubHangmogRequest();
		}
	}
}