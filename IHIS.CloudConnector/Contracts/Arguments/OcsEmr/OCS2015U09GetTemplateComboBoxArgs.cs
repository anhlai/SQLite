using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U09GetTemplateComboBoxArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS2015U09GetTemplateComboBoxArgs() { }

		public OCS2015U09GetTemplateComboBoxArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U09GetTemplateComboBoxRequest();
		}
	}
}