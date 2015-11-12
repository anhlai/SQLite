using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM401UAsmArgs : IContractArgs
	{
		private String _asmName;

		public String AsmName
		{
			get { return this._asmName; }
			set { this._asmName = value; }
		}

		public ADM401UAsmArgs() { }

		public ADM401UAsmArgs(String asmName)
		{
			this._asmName = asmName;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM401UAsmRequest();
		}
	}
}