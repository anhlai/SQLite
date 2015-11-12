using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003Q02GridOUT1001Args : IContractArgs
	{
		private String _naewonDate;
		private String _bunho;
		private String _gwa;
		private String _doctor;
		private String _naewonYn;

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

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public OCS1003Q02GridOUT1001Args() { }

		public OCS1003Q02GridOUT1001Args(String naewonDate, String bunho, String gwa, String doctor, String naewonYn)
		{
			this._naewonDate = naewonDate;
			this._bunho = bunho;
			this._gwa = gwa;
			this._doctor = doctor;
			this._naewonYn = naewonYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003Q02GridOUT1001Request();
		}
	}
}