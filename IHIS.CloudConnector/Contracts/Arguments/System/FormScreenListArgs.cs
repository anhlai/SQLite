using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class FormScreenListArgs : IContractArgs
	{
		private String _screenId;

		public String ScreenId
		{
			get { return this._screenId; }
			set { this._screenId = value; }
		}

		public FormScreenListArgs() { }

		public FormScreenListArgs(String screenId)
		{
			this._screenId = screenId;
		}

		public IExtensible GetRequestInstance()
		{
			return new FormScreenListRequest();
		}
	}
}