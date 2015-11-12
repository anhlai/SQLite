using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class HIGetGenericNameArgs : IContractArgs
	{
		private String _hangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public HIGetGenericNameArgs() { }

		public HIGetGenericNameArgs(String hangmogCode)
		{
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new HIGetGenericNameRequest();
		}
	}
}