using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT1001U01InsertJubsuArgs : IContractArgs
	{
		private String _sysId;
		private String _updId;
		private String _pkout1001;
		private String _naewonDate;
		private String _bunho;
		private String _gwa;
		private String _gubun;
		private String _doctor;
		private String _chojae;
		private String _jubsuTime;
		private String _naewonYn;
		private String _naewonType;
		private String _sunnabYn;
		private String _jubsuGubun;
		private String _inpTransYn;
		private String _bigo;
		private String _jubsuNo;
		private String _sujinNo;
		private String _wonyoiOrderYn;

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
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

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Chojae
		{
			get { return this._chojae; }
			set { this._chojae = value; }
		}

		public String JubsuTime
		{
			get { return this._jubsuTime; }
			set { this._jubsuTime = value; }
		}

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public String NaewonType
		{
			get { return this._naewonType; }
			set { this._naewonType = value; }
		}

		public String SunnabYn
		{
			get { return this._sunnabYn; }
			set { this._sunnabYn = value; }
		}

		public String JubsuGubun
		{
			get { return this._jubsuGubun; }
			set { this._jubsuGubun = value; }
		}

		public String InpTransYn
		{
			get { return this._inpTransYn; }
			set { this._inpTransYn = value; }
		}

		public String Bigo
		{
			get { return this._bigo; }
			set { this._bigo = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public String SujinNo
		{
			get { return this._sujinNo; }
			set { this._sujinNo = value; }
		}

		public String WonyoiOrderYn
		{
			get { return this._wonyoiOrderYn; }
			set { this._wonyoiOrderYn = value; }
		}

		public NuroOUT1001U01InsertJubsuArgs() { }

		public NuroOUT1001U01InsertJubsuArgs(String sysId, String updId, String pkout1001, String naewonDate, String bunho, String gwa, String gubun, String doctor, String chojae, String jubsuTime, String naewonYn, String naewonType, String sunnabYn, String jubsuGubun, String inpTransYn, String bigo, String jubsuNo, String sujinNo, String wonyoiOrderYn)
		{
			this._sysId = sysId;
			this._updId = updId;
			this._pkout1001 = pkout1001;
			this._naewonDate = naewonDate;
			this._bunho = bunho;
			this._gwa = gwa;
			this._gubun = gubun;
			this._doctor = doctor;
			this._chojae = chojae;
			this._jubsuTime = jubsuTime;
			this._naewonYn = naewonYn;
			this._naewonType = naewonType;
			this._sunnabYn = sunnabYn;
			this._jubsuGubun = jubsuGubun;
			this._inpTransYn = inpTransYn;
			this._bigo = bigo;
			this._jubsuNo = jubsuNo;
			this._sujinNo = sujinNo;
			this._wonyoiOrderYn = wonyoiOrderYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT1001U01InsertJubsuRequest();
		}
	}
}