using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetNextGroupSerArgs : IContractArgs
	{
		private String _bunho;
		private String _pkKey;
		private String _inputTab;
		private String _keyObj;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String PkKey
		{
			get { return this._pkKey; }
			set { this._pkKey = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String KeyObj
		{
			get { return this._keyObj; }
			set { this._keyObj = value; }
		}

		public GetNextGroupSerArgs() { }

		public GetNextGroupSerArgs(String bunho, String pkKey, String inputTab, String keyObj)
		{
			this._bunho = bunho;
			this._pkKey = pkKey;
			this._inputTab = inputTab;
			this._keyObj = keyObj;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetNextGroupSerRequest();
		}
	}
}