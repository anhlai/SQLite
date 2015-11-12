using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class FnDrgGetCycleOrdDateArgs : IContractArgs
	{
		private String _orderDate;
		private String _hoDong;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String HoDong
		{
			get { return this._hoDong; }
			set { this._hoDong = value; }
		}

		public FnDrgGetCycleOrdDateArgs() { }

		public FnDrgGetCycleOrdDateArgs(String orderDate, String hoDong)
		{
			this._orderDate = orderDate;
			this._hoDong = hoDong;
		}

		public IExtensible GetRequestInstance()
		{
			return new FnDrgGetCycleOrdDateRequest();
		}
	}
}