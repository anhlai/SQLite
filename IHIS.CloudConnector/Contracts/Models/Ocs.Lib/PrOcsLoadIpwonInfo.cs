using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class PrOcsLoadIpwonInfo
	{
		private String _chisikYn;
		private String _weightInputYn;
		private String _wonyoiOrderYn;
		private String _wonnaeSayuCode;
		private String _wonnaeSayuName;
		private String _chtIpwonDate;
		private String _doubleIpwonType;
		private String _ipwonGwa;
		private String _parentGwa;
		private String _resident;
		private String _residentName;
		private String _drgYn;
		private String _drgNo;
		private String _inpDoubleIpwonType;
		private String _toiwonGojiYn;
		private String _toiwonDate;
		private String _incuYn;
		private String _jinryoResult;
		private String _gaToiwonDate;
		private String _simsaMagamYn;
		private String _toiwonResDate;
		private String _flag;

		public String ChisikYn
		{
			get { return this._chisikYn; }
			set { this._chisikYn = value; }
		}

		public String WeightInputYn
		{
			get { return this._weightInputYn; }
			set { this._weightInputYn = value; }
		}

		public String WonyoiOrderYn
		{
			get { return this._wonyoiOrderYn; }
			set { this._wonyoiOrderYn = value; }
		}

		public String WonnaeSayuCode
		{
			get { return this._wonnaeSayuCode; }
			set { this._wonnaeSayuCode = value; }
		}

		public String WonnaeSayuName
		{
			get { return this._wonnaeSayuName; }
			set { this._wonnaeSayuName = value; }
		}

		public String ChtIpwonDate
		{
			get { return this._chtIpwonDate; }
			set { this._chtIpwonDate = value; }
		}

		public String DoubleIpwonType
		{
			get { return this._doubleIpwonType; }
			set { this._doubleIpwonType = value; }
		}

		public String IpwonGwa
		{
			get { return this._ipwonGwa; }
			set { this._ipwonGwa = value; }
		}

		public String ParentGwa
		{
			get { return this._parentGwa; }
			set { this._parentGwa = value; }
		}

		public String Resident
		{
			get { return this._resident; }
			set { this._resident = value; }
		}

		public String ResidentName
		{
			get { return this._residentName; }
			set { this._residentName = value; }
		}

		public String DrgYn
		{
			get { return this._drgYn; }
			set { this._drgYn = value; }
		}

		public String DrgNo
		{
			get { return this._drgNo; }
			set { this._drgNo = value; }
		}

		public String InpDoubleIpwonType
		{
			get { return this._inpDoubleIpwonType; }
			set { this._inpDoubleIpwonType = value; }
		}

		public String ToiwonGojiYn
		{
			get { return this._toiwonGojiYn; }
			set { this._toiwonGojiYn = value; }
		}

		public String ToiwonDate
		{
			get { return this._toiwonDate; }
			set { this._toiwonDate = value; }
		}

		public String IncuYn
		{
			get { return this._incuYn; }
			set { this._incuYn = value; }
		}

		public String JinryoResult
		{
			get { return this._jinryoResult; }
			set { this._jinryoResult = value; }
		}

		public String GaToiwonDate
		{
			get { return this._gaToiwonDate; }
			set { this._gaToiwonDate = value; }
		}

		public String SimsaMagamYn
		{
			get { return this._simsaMagamYn; }
			set { this._simsaMagamYn = value; }
		}

		public String ToiwonResDate
		{
			get { return this._toiwonResDate; }
			set { this._toiwonResDate = value; }
		}

		public String Flag
		{
			get { return this._flag; }
			set { this._flag = value; }
		}

		public PrOcsLoadIpwonInfo() { }

		public PrOcsLoadIpwonInfo(String chisikYn, String weightInputYn, String wonyoiOrderYn, String wonnaeSayuCode, String wonnaeSayuName, String chtIpwonDate, String doubleIpwonType, String ipwonGwa, String parentGwa, String resident, String residentName, String drgYn, String drgNo, String inpDoubleIpwonType, String toiwonGojiYn, String toiwonDate, String incuYn, String jinryoResult, String gaToiwonDate, String simsaMagamYn, String toiwonResDate, String flag)
		{
			this._chisikYn = chisikYn;
			this._weightInputYn = weightInputYn;
			this._wonyoiOrderYn = wonyoiOrderYn;
			this._wonnaeSayuCode = wonnaeSayuCode;
			this._wonnaeSayuName = wonnaeSayuName;
			this._chtIpwonDate = chtIpwonDate;
			this._doubleIpwonType = doubleIpwonType;
			this._ipwonGwa = ipwonGwa;
			this._parentGwa = parentGwa;
			this._resident = resident;
			this._residentName = residentName;
			this._drgYn = drgYn;
			this._drgNo = drgNo;
			this._inpDoubleIpwonType = inpDoubleIpwonType;
			this._toiwonGojiYn = toiwonGojiYn;
			this._toiwonDate = toiwonDate;
			this._incuYn = incuYn;
			this._jinryoResult = jinryoResult;
			this._gaToiwonDate = gaToiwonDate;
			this._simsaMagamYn = simsaMagamYn;
			this._toiwonResDate = toiwonResDate;
			this._flag = flag;
		}

	}
}