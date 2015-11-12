using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01GridReserOrderListArgs : IContractArgs
	{
		private String _bunho;
		private String _naewonDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public OcsoOCS1003P01GridReserOrderListArgs() { }

		public OcsoOCS1003P01GridReserOrderListArgs(String bunho, String naewonDate)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01GridReserOrderListRequest();
		}
	}
}