using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00VsvNoteArgs : IContractArgs
	{
		private String _jundalGubun;
		private String _code;

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public CPL3020U00VsvNoteArgs() { }

		public CPL3020U00VsvNoteArgs(String jundalGubun, String code)
		{
			this._jundalGubun = jundalGubun;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00VsvNoteRequest();
		}
	}
}