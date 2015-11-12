using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00FwkJundalGubunArgs : IContractArgs
	{
		private String _codeType;
		private String _find1;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public CPL3020U00FwkJundalGubunArgs() { }

		public CPL3020U00FwkJundalGubunArgs(String codeType, String find1)
		{
			this._codeType = codeType;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00FwkJundalGubunRequest();
		}
	}
}