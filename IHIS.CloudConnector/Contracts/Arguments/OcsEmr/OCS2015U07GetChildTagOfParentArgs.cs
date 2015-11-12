using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U07GetChildTagOfParentArgs : IContractArgs
	{
		private String _fParentTag;

		public String FParentTag
		{
			get { return this._fParentTag; }
			set { this._fParentTag = value; }
		}

		public OCS2015U07GetChildTagOfParentArgs() { }

		public OCS2015U07GetChildTagOfParentArgs(String fParentTag)
		{
			this._fParentTag = fParentTag;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U07GetChildTagOfParentRequest();
		}
	}
}