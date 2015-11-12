using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadPatientNaewonListInfo
	{
		private String _ioeGubun;
		private String _dataGubun;
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;
		private String _doctorName;
		private String _naewonType;
		private String _jubsuNo;
		private String _jinryoTime;
		private String _pkKey;
		private String _reserDataYn;
		private String _gubun;
		private String _gubunName;
		private String _chojae;
		private String _chojaeName;
		private String _specialYn;
		private String _naewonYn;
		private String _sunnabYn;
		private String _hoDong;
		private String _hoCode;
		private String _jaewonFlag;
		private String _ipwonReserYn;
		private String _realNaewonYn;
		private String _approveDoctor;

		public String IoeGubun
		{
			get { return this._ioeGubun; }
			set { this._ioeGubun = value; }
		}

		public String DataGubun
		{
			get { return this._dataGubun; }
			set { this._dataGubun = value; }
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

		public String DoctorName
		{
			get { return this._doctorName; }
			set { this._doctorName = value; }
		}

		public String NaewonType
		{
			get { return this._naewonType; }
			set { this._naewonType = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public String JinryoTime
		{
			get { return this._jinryoTime; }
			set { this._jinryoTime = value; }
		}

		public String PkKey
		{
			get { return this._pkKey; }
			set { this._pkKey = value; }
		}

		public String ReserDataYn
		{
			get { return this._reserDataYn; }
			set { this._reserDataYn = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String GubunName
		{
			get { return this._gubunName; }
			set { this._gubunName = value; }
		}

		public String Chojae
		{
			get { return this._chojae; }
			set { this._chojae = value; }
		}

		public String ChojaeName
		{
			get { return this._chojaeName; }
			set { this._chojaeName = value; }
		}

		public String SpecialYn
		{
			get { return this._specialYn; }
			set { this._specialYn = value; }
		}

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public String SunnabYn
		{
			get { return this._sunnabYn; }
			set { this._sunnabYn = value; }
		}

		public String HoDong
		{
			get { return this._hoDong; }
			set { this._hoDong = value; }
		}

		public String HoCode
		{
			get { return this._hoCode; }
			set { this._hoCode = value; }
		}

		public String JaewonFlag
		{
			get { return this._jaewonFlag; }
			set { this._jaewonFlag = value; }
		}

		public String IpwonReserYn
		{
			get { return this._ipwonReserYn; }
			set { this._ipwonReserYn = value; }
		}

		public String RealNaewonYn
		{
			get { return this._realNaewonYn; }
			set { this._realNaewonYn = value; }
		}

		public String ApproveDoctor
		{
			get { return this._approveDoctor; }
			set { this._approveDoctor = value; }
		}

		public LoadPatientNaewonListInfo() { }

		public LoadPatientNaewonListInfo(String ioeGubun, String dataGubun, String bunho, String naewonDate, String gwa, String doctor, String doctorName, String naewonType, String jubsuNo, String jinryoTime, String pkKey, String reserDataYn, String gubun, String gubunName, String chojae, String chojaeName, String specialYn, String naewonYn, String sunnabYn, String hoDong, String hoCode, String jaewonFlag, String ipwonReserYn, String realNaewonYn, String approveDoctor)
		{
			this._ioeGubun = ioeGubun;
			this._dataGubun = dataGubun;
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
			this._doctorName = doctorName;
			this._naewonType = naewonType;
			this._jubsuNo = jubsuNo;
			this._jinryoTime = jinryoTime;
			this._pkKey = pkKey;
			this._reserDataYn = reserDataYn;
			this._gubun = gubun;
			this._gubunName = gubunName;
			this._chojae = chojae;
			this._chojaeName = chojaeName;
			this._specialYn = specialYn;
			this._naewonYn = naewonYn;
			this._sunnabYn = sunnabYn;
			this._hoDong = hoDong;
			this._hoCode = hoCode;
			this._jaewonFlag = jaewonFlag;
			this._ipwonReserYn = ipwonReserYn;
			this._realNaewonYn = realNaewonYn;
			this._approveDoctor = approveDoctor;
		}

	}
}