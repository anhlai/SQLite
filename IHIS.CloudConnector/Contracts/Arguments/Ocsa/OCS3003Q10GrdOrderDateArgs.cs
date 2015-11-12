using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS3003Q10GrdOrderDateArgs : IContractArgs
	{
		private String _ioGubun;
		private String _bunho;
		private String _orderDate;
		private String _orderGubun;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String OrderGubun
		{
			get { return this._orderGubun; }
			set { this._orderGubun = value; }
		}

		public OCS3003Q10GrdOrderDateArgs() { }

		public OCS3003Q10GrdOrderDateArgs(String ioGubun, String bunho, String orderDate, String orderGubun)
		{
			this._ioGubun = ioGubun;
			this._bunho = bunho;
			this._orderDate = orderDate;
			this._orderGubun = orderGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS3003Q10GrdOrderDateRequest();
		}
	}
}