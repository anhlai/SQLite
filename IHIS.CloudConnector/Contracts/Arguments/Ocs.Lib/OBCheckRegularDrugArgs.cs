using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OBCheckRegularDrugArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _hangmog;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Hangmog
		{
			get { return this._hangmog; }
			set { this._hangmog = value; }
		}

		public OBCheckRegularDrugArgs() { }

		public OBCheckRegularDrugArgs(String bunho, String gwa, String hangmog)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._hangmog = hangmog;
		}

		public IExtensible GetRequestInstance()
		{
			return new OBCheckRegularDrugRequest();
		}
	}
}