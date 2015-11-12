using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01GrdSangArgs : IContractArgs
	{
		private String _hospCode;
		private String _bunho;
		private String _gwa;
		private String _reserDate;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

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

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public INJ1001U01GrdSangArgs() { }

		public INJ1001U01GrdSangArgs(String hospCode, String bunho, String gwa, String reserDate)
		{
			this._hospCode = hospCode;
			this._bunho = bunho;
			this._gwa = gwa;
			this._reserDate = reserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01GrdSangRequest();
		}
	}
}