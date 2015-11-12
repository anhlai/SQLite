using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class MultiResultViewGrdSigeyul1Args : IContractArgs
	{
		private String _bunho;
		private String _groupHangmog;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String GroupHangmog
		{
			get { return this._groupHangmog; }
			set { this._groupHangmog = value; }
		}

		public MultiResultViewGrdSigeyul1Args() { }

		public MultiResultViewGrdSigeyul1Args(String bunho, String groupHangmog)
		{
			this._bunho = bunho;
			this._groupHangmog = groupHangmog;
		}

		public IExtensible GetRequestInstance()
		{
			return new MultiResultViewGrdSigeyul1Request();
		}
	}
}