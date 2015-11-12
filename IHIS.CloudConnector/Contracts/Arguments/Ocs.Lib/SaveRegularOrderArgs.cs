using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class SaveRegularOrderArgs : IContractArgs
	{
		private String _workGubun;
		private String _pkKey;

		public String WorkGubun
		{
			get { return this._workGubun; }
			set { this._workGubun = value; }
		}

		public String PkKey
		{
			get { return this._pkKey; }
			set { this._pkKey = value; }
		}

		public SaveRegularOrderArgs() { }

		public SaveRegularOrderArgs(String workGubun, String pkKey)
		{
			this._workGubun = workGubun;
			this._pkKey = pkKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new SaveRegularOrderRequest();
		}
	}
}