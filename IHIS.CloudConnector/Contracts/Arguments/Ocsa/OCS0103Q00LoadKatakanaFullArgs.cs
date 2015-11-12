using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103Q00LoadKatakanaFullArgs : IContractArgs
	{
		private String _text;

		public String Text
		{
			get { return this._text; }
			set { this._text = value; }
		}

		public OCS0103Q00LoadKatakanaFullArgs() { }

		public OCS0103Q00LoadKatakanaFullArgs(String text)
		{
			this._text = text;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103Q00LoadKatakanaFullRequest();
		}
	}
}