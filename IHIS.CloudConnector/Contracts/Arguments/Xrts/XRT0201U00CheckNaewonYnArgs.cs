using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00CheckNaewonYnArgs : IContractArgs
	{
		private String _pkout1001;

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public XRT0201U00CheckNaewonYnArgs() { }

		public XRT0201U00CheckNaewonYnArgs(String pkout1001)
		{
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00CheckNaewonYnRequest();
		}
	}
}