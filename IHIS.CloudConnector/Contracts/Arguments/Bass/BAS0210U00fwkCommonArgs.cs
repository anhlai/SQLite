using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00fwkCommonArgs : IContractArgs
	{
		private String _find;

		public String Find
		{
			get { return this._find; }
			set { this._find = value; }
		}

		public BAS0210U00fwkCommonArgs() { }

		public BAS0210U00fwkCommonArgs(String find)
		{
			this._find = find;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00fwkCommonRequest();
		}
	}
}