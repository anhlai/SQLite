using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01OrderOrderListArgs : IContractArgs
	{
		private String _orderDate;
		private String _drgBunho;
		private String _gubun;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public DrgsDRG5100P01OrderOrderListArgs() { }

		public DrgsDRG5100P01OrderOrderListArgs(String orderDate, String drgBunho, String gubun)
		{
			this._orderDate = orderDate;
			this._drgBunho = drgBunho;
			this._gubun = gubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01OrderOrderListRequest();
		}
	}
}