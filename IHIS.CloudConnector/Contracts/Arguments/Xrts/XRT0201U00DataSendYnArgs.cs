using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00DataSendYnArgs : IContractArgs
	{
		private String _inOutGubun;
		private String _pkocs;

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String Pkocs
		{
			get { return this._pkocs; }
			set { this._pkocs = value; }
		}

		public XRT0201U00DataSendYnArgs() { }

		public XRT0201U00DataSendYnArgs(String inOutGubun, String pkocs)
		{
			this._inOutGubun = inOutGubun;
			this._pkocs = pkocs;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00DataSendYnRequest();
		}
	}
}