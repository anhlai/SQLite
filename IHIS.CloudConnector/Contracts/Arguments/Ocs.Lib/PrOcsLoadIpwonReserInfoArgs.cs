using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsLoadIpwonReserInfoArgs : IContractArgs
	{
		private String _reserDate;
		private String _naewonKey;

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public PrOcsLoadIpwonReserInfoArgs() { }

		public PrOcsLoadIpwonReserInfoArgs(String reserDate, String naewonKey)
		{
			this._reserDate = reserDate;
			this._naewonKey = naewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsLoadIpwonReserInfoRequest();
		}
	}
}