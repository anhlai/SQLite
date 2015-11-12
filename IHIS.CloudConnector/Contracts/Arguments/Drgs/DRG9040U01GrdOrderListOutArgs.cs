using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG9040U01GrdOrderListOutArgs : IContractArgs
	{
		private String _orderDate;
		private String _drgBunho;
		private String _bunho;

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

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DRG9040U01GrdOrderListOutArgs() { }

		public DRG9040U01GrdOrderListOutArgs(String orderDate, String drgBunho, String bunho)
		{
			this._orderDate = orderDate;
			this._drgBunho = drgBunho;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG9040U01GrdOrderListOutRequest();
		}
	}
}