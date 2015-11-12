using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class MultiResultViewGrdSigeyul2Args : IContractArgs
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

		public MultiResultViewGrdSigeyul2Args() { }

		public MultiResultViewGrdSigeyul2Args(String bunho, String groupHangmog)
		{
			this._bunho = bunho;
			this._groupHangmog = groupHangmog;
		}

		public IExtensible GetRequestInstance()
		{
			return new MultiResultViewGrdSigeyul2Request();
		}
	}
}