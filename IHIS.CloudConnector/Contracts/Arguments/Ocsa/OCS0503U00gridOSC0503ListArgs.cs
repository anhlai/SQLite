using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00gridOSC0503ListArgs : IContractArgs
	{
		private String _bunho;
		private String _reqDoctor;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String ReqDoctor
		{
			get { return this._reqDoctor; }
			set { this._reqDoctor = value; }
		}

		public OCS0503U00gridOSC0503ListArgs() { }

		public OCS0503U00gridOSC0503ListArgs(String bunho, String reqDoctor)
		{
			this._bunho = bunho;
			this._reqDoctor = reqDoctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00gridOSC0503ListRequest();
		}
	}
}