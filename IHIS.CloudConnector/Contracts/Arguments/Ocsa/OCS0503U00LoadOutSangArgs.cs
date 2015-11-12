using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00LoadOutSangArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _ioGubun;

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

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public OCS0503U00LoadOutSangArgs() { }

		public OCS0503U00LoadOutSangArgs(String bunho, String gwa, String ioGubun)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._ioGubun = ioGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00LoadOutSangRequest();
		}
	}
}