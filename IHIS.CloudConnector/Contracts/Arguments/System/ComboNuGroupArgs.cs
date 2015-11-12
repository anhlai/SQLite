using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboNuGroupArgs : IContractArgs
	{
		private Boolean _isAll;

		public Boolean IsAll
		{
			get { return this._isAll; }
			set { this._isAll = value; }
		}

		public ComboNuGroupArgs() { }

		public ComboNuGroupArgs(Boolean isAll)
		{
			this._isAll = isAll;
		}

		public IExtensible GetRequestInstance()
		{
			return new ComboNuGroupRequest();
		}
	}
}