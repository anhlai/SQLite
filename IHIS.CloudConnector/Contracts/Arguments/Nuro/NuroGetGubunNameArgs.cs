using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroGetGubunNameArgs : IContractArgs
	{
		private String _gubun;
		private String _naewonDate;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public NuroGetGubunNameArgs() { }

		public NuroGetGubunNameArgs(String gubun, String naewonDate)
		{
			this._gubun = gubun;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroGetGubunNameRequest();
		}
	}
}