using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00GrdPaidArgs : IContractArgs
	{
		private String _orderDate;
		private String _gubun;
		private String _bunho;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DRG0201U00GrdPaidArgs() { }

		public DRG0201U00GrdPaidArgs(String orderDate, String gubun, String bunho)
		{
			this._orderDate = orderDate;
			this._gubun = gubun;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00GrdPaidRequest();
		}
	}
}