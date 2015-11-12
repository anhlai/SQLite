using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00GrdRadioListArgs : IContractArgs
	{
		private String _orderDate;
		private String _bunho;
		private String _inOutGubun;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public XRT0201U00GrdRadioListArgs() { }

		public XRT0201U00GrdRadioListArgs(String orderDate, String bunho, String inOutGubun)
		{
			this._orderDate = orderDate;
			this._bunho = bunho;
			this._inOutGubun = inOutGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00GrdRadioListRequest();
		}
	}
}