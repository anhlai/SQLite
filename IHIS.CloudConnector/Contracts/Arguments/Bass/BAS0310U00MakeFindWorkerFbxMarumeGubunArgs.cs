using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00MakeFindWorkerFbxMarumeGubunArgs : IContractArgs
	{
		private String _find;
		private String _codeType;

		public String Find
		{
			get { return this._find; }
			set { this._find = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public BAS0310U00MakeFindWorkerFbxMarumeGubunArgs() { }

		public BAS0310U00MakeFindWorkerFbxMarumeGubunArgs(String find, String codeType)
		{
			this._find = find;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00MakeFindWorkerFbxMarumeGubunRequest();
		}
	}
}