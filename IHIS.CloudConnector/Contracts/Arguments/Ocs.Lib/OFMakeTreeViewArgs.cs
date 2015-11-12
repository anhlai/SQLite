using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OFMakeTreeViewArgs : IContractArgs
	{
		private String _memb;
		private String _inputTab;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OFMakeTreeViewArgs() { }

		public OFMakeTreeViewArgs(String memb, String inputTab)
		{
			this._memb = memb;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OFMakeTreeViewRequest();
		}
	}
}