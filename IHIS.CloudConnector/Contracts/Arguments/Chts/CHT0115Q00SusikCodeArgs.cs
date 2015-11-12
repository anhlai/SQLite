using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0115Q00SusikCodeArgs : IContractArgs
	{
		private String _susikCode;

		public String SusikCode
		{
			get { return this._susikCode; }
			set { this._susikCode = value; }
		}

		public CHT0115Q00SusikCodeArgs() { }

		public CHT0115Q00SusikCodeArgs(String susikCode)
		{
			this._susikCode = susikCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0115Q00SusikCodeRequest();
		}
	}
}