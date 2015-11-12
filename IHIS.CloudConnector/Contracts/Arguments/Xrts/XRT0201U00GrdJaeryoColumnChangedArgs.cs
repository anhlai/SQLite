using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00GrdJaeryoColumnChangedArgs : IContractArgs
	{
		private String _hangmogCode;
		private String _sHangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String SHangmogCode
		{
			get { return this._sHangmogCode; }
			set { this._sHangmogCode = value; }
		}

		public XRT0201U00GrdJaeryoColumnChangedArgs() { }

		public XRT0201U00GrdJaeryoColumnChangedArgs(String hangmogCode, String sHangmogCode)
		{
			this._hangmogCode = hangmogCode;
			this._sHangmogCode = sHangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00GrdJaeryoColumnChangedRequest();
		}
	}
}