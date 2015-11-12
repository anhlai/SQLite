using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12FbxJusaFindClickArgs : IContractArgs
	{
		private String _ioGubun;
		private String _find1;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public OCS0103U12FbxJusaFindClickArgs() { }

		public OCS0103U12FbxJusaFindClickArgs(String ioGubun, String find1)
		{
			this._ioGubun = ioGubun;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12FbxJusaFindClickRequest();
		}
	}
}