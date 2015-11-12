using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00FwkNoteGubunArgs : IContractArgs
	{
		private String _jundalGubun;
		private String _find1;

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public CPL3020U00FwkNoteGubunArgs() { }

		public CPL3020U00FwkNoteGubunArgs(String jundalGubun, String find1)
		{
			this._jundalGubun = jundalGubun;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00FwkNoteGubunRequest();
		}
	}
}