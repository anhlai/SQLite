using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsLoadIpwonInfoArgs : IContractArgs
	{
		private String _naewonDate;
		private String _naewonKey;
		private String _jaewonFlag;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public String JaewonFlag
		{
			get { return this._jaewonFlag; }
			set { this._jaewonFlag = value; }
		}

		public PrOcsLoadIpwonInfoArgs() { }

		public PrOcsLoadIpwonInfoArgs(String naewonDate, String naewonKey, String jaewonFlag)
		{
			this._naewonDate = naewonDate;
			this._naewonKey = naewonKey;
			this._jaewonFlag = jaewonFlag;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsLoadIpwonInfoRequest();
		}
	}
}