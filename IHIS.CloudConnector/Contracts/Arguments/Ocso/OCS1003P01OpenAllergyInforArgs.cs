using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01OpenAllergyInforArgs : IContractArgs
	{
		private String _doctor;
		private String _gwa;
		private String _keyword;
		private String _ioGubun;
		private String _bunho;
		private String _naewonDate;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Keyword
		{
			get { return this._keyword; }
			set { this._keyword = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public OCS1003P01OpenAllergyInforArgs() { }

		public OCS1003P01OpenAllergyInforArgs(String doctor, String gwa, String keyword, String ioGubun, String bunho, String naewonDate)
		{
			this._doctor = doctor;
			this._gwa = gwa;
			this._keyword = keyword;
			this._ioGubun = ioGubun;
			this._bunho = bunho;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01OpenAllergyInforRequest();
		}
	}
}