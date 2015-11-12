using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH0201Q12GrdListArgs : IContractArgs
	{
		private String _gwa;
		private String _doctor;
		private String _reserGubun;
		private String _statFlg;
		private String _naewonDate;
		private String _bunho;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String ReserGubun
		{
			get { return this._reserGubun; }
			set { this._reserGubun = value; }
		}

		public String StatFlg
		{
			get { return this._statFlg; }
			set { this._statFlg = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public SCH0201Q12GrdListArgs() { }

		public SCH0201Q12GrdListArgs(String gwa, String doctor, String reserGubun, String statFlg, String naewonDate, String bunho)
		{
			this._gwa = gwa;
			this._doctor = doctor;
			this._reserGubun = reserGubun;
			this._statFlg = statFlg;
			this._naewonDate = naewonDate;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH0201Q12GrdListRequest();
		}
	}
}