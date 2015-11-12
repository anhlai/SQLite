using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class FnInpLoadJaewonIlsuArgs : IContractArgs
	{
		private String _bunho;
		private String _naewonKey;
		private String _orderDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public FnInpLoadJaewonIlsuArgs() { }

		public FnInpLoadJaewonIlsuArgs(String bunho, String naewonKey, String orderDate)
		{
			this._bunho = bunho;
			this._naewonKey = naewonKey;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new FnInpLoadJaewonIlsuRequest();
		}
	}
}