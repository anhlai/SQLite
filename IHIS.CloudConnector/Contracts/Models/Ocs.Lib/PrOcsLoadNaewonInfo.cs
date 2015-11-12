using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class PrOcsLoadNaewonInfo
	{
		private String _chisikYn;
		private String _weightInputYn;
		private String _wonyoiOrderYn;
		private String _wonnaeSayuCode;
		private String _wonnaeSayuName;
		private String _inpBonin;
		private String _sabun;
		private String _sabunName;
		private String _gaJubsuGubun;
		private String _outToiwonYn;
		private String _drgNalsu;
		private String _jinryoResult;
		private String _soaNutjidoYn;
		private String _atcYn;
		private String _sunnabYn;
		private String _hubalChangeYn;
		private String _nextJinryoYn;
		private String _dangilGumsaYn;
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

		public String InpBonin
		{
			get { return this._inpBonin; }
			set { this._inpBonin = value; }
		}

		public String Sabun
		{
			get { return this._sabun; }
			set { this._sabun = value; }
		}

		public String SabunName
		{
			get { return this._sabunName; }
			set { this._sabunName = value; }
		}

		public String GaJubsuGubun
		{
			get { return this._gaJubsuGubun; }
			set { this._gaJubsuGubun = value; }
		}

		public String OutToiwonYn
		{
			get { return this._outToiwonYn; }
			set { this._outToiwonYn = value; }
		}

		public String DrgNalsu
		{
			get { return this._drgNalsu; }
			set { this._drgNalsu = value; }
		}

		public String JinryoResult
		{
			get { return this._jinryoResult; }
			set { this._jinryoResult = value; }
		}

		public String SoaNutjidoYn
		{
			get { return this._soaNutjidoYn; }
			set { this._soaNutjidoYn = value; }
		}

		public String AtcYn
		{
			get { return this._atcYn; }
			set { this._atcYn = value; }
		}

		public String SunnabYn
		{
			get { return this._sunnabYn; }
			set { this._sunnabYn = value; }
		}

		public String HubalChangeYn
		{
			get { return this._hubalChangeYn; }
			set { this._hubalChangeYn = value; }
		}

		public String NextJinryoYn
		{
			get { return this._nextJinryoYn; }
			set { this._nextJinryoYn = value; }
		}

		public String DangilGumsaYn
		{
			get { return this._dangilGumsaYn; }
			set { this._dangilGumsaYn = value; }
		}

		public String Flag
		{
			get { return this._flag; }
			set { this._flag = value; }
		}

		public PrOcsLoadNaewonInfo() { }

		public PrOcsLoadNaewonInfo(String chisikYn, String weightInputYn, String wonyoiOrderYn, String wonnaeSayuCode, String wonnaeSayuName, String inpBonin, String sabun, String sabunName, String gaJubsuGubun, String outToiwonYn, String drgNalsu, String jinryoResult, String soaNutjidoYn, String atcYn, String sunnabYn, String hubalChangeYn, String nextJinryoYn, String dangilGumsaYn, String flag)
		{
			this._chisikYn = chisikYn;
			this._weightInputYn = weightInputYn;
			this._wonyoiOrderYn = wonyoiOrderYn;
			this._wonnaeSayuCode = wonnaeSayuCode;
			this._wonnaeSayuName = wonnaeSayuName;
			this._inpBonin = inpBonin;
			this._sabun = sabun;
			this._sabunName = sabunName;
			this._gaJubsuGubun = gaJubsuGubun;
			this._outToiwonYn = outToiwonYn;
			this._drgNalsu = drgNalsu;
			this._jinryoResult = jinryoResult;
			this._soaNutjidoYn = soaNutjidoYn;
			this._atcYn = atcYn;
			this._sunnabYn = sunnabYn;
			this._hubalChangeYn = hubalChangeYn;
			this._nextJinryoYn = nextJinryoYn;
			this._dangilGumsaYn = dangilGumsaYn;
			this._flag = flag;
		}

	}
}