using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    [Serializable]
	public class SchsSCH0201Q01GumsaComboListArgs : IContractArgs
	{
		private String _hangmogCode;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public SchsSCH0201Q01GumsaComboListArgs() { }

		public SchsSCH0201Q01GumsaComboListArgs(String hangmogCode)
		{
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01GumsaComboListRequest();
		}
	}
}