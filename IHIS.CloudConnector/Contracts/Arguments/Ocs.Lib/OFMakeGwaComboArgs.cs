using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OFMakeGwaComboArgs : IContractArgs
	{
		private String _sabun;

		public String Sabun
		{
			get { return this._sabun; }
			set { this._sabun = value; }
		}

		public OFMakeGwaComboArgs() { }

		public OFMakeGwaComboArgs(String sabun)
		{
			this._sabun = sabun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OFMakeGwaComboRequest();
		}
	}
}