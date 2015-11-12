using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0503U01CommonDataArgs : IContractArgs
	{
		private String _fCode;

		public String FCode
		{
			get { return this._fCode; }
			set { this._fCode = value; }
		}

		public OcsaOCS0503U01CommonDataArgs() { }

		public OcsaOCS0503U01CommonDataArgs(String fCode)
		{
			this._fCode = fCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0503U01CommonDataRequest();
		}
	}
}