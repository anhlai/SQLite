using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U01GrdMasterArgs : IContractArgs
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

		public DRG0102U01GrdMasterArgs() { }

		public DRG0102U01GrdMasterArgs(String codeType, String codeTypeName)
		{
			this._codeType = codeType;
			this._codeTypeName = codeTypeName;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U01GrdMasterRequest();
		}
	}
}