using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS3003Q10GrdSangArgs : IContractArgs
	{
		private String _ioGubun;
		private String _jubsuNo;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;
		private String _naewonType;
		private String _bunho;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
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

		public String NaewonType
		{
			get { return this._naewonType; }
			set { this._naewonType = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public OCS3003Q10GrdSangArgs() { }

		public OCS3003Q10GrdSangArgs(String ioGubun, String jubsuNo, String naewonDate, String gwa, String doctor, String naewonType, String bunho)
		{
			this._ioGubun = ioGubun;
			this._jubsuNo = jubsuNo;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
			this._naewonType = naewonType;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS3003Q10GrdSangRequest();
		}
	}
}