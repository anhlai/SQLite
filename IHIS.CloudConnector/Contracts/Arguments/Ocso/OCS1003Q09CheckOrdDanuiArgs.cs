using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003Q09CheckOrdDanuiArgs : IContractArgs
	{
		private String _hangmogCode;
		private String _ordDanui;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String OrdDanui
		{
			get { return this._ordDanui; }
			set { this._ordDanui = value; }
		}

		public OCS1003Q09CheckOrdDanuiArgs() { }

		public OCS1003Q09CheckOrdDanuiArgs(String hangmogCode, String ordDanui)
		{
			this._hangmogCode = hangmogCode;
			this._ordDanui = ordDanui;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003Q09CheckOrdDanuiRequest();
		}
	}
}