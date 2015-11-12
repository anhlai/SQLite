using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH0109U00GrdMasterArgs : IContractArgs
	{
		private String _codeType;
		private String _codeTypeName;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String CodeTypeName
		{
			get { return this._codeTypeName; }
			set { this._codeTypeName = value; }
		}

		public SCH0109U00GrdMasterArgs() { }

		public SCH0109U00GrdMasterArgs(String codeType, String codeTypeName)
		{
			this._codeType = codeType;
			this._codeTypeName = codeTypeName;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH0109U00GrdMasterRequest();
		}
	}
}