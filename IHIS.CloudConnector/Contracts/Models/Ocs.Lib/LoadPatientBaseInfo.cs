using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadPatientBaseInfo
	{
		private String _ioSuname;
		private String _ioSuname2;
		private String _ioSujumin1;
		private String _ioSujumin2;
		private String _ioSex;
		private String _ioBirth;
		private String _ioAge;
		private String _ioAgeNum;
		private String _ioWeight;
		private String _ioHeight;
		private String _ioZipCode1;
		private String _ioZipCode2;
		private String _ioAddress1;
		private String _ioAddress2;
		private String _ioTel;
		private String _ioTel1;
		private String _ioTelHp;
		private String _ioPaceMakerYn;
		private String _ioDummy2;
		private String _ioDummy3;
		private String _ioFlag;

		public String IoSuname
		{
			get { return this._ioSuname; }
			set { this._ioSuname = value; }
		}

		public String IoSuname2
		{
			get { return this._ioSuname2; }
			set { this._ioSuname2 = value; }
		}

		public String IoSujumin1
		{
			get { return this._ioSujumin1; }
			set { this._ioSujumin1 = value; }
		}

		public String IoSujumin2
		{
			get { return this._ioSujumin2; }
			set { this._ioSujumin2 = value; }
		}

		public String IoSex
		{
			get { return this._ioSex; }
			set { this._ioSex = value; }
		}

		public String IoBirth
		{
			get { return this._ioBirth; }
			set { this._ioBirth = value; }
		}

		public String IoAge
		{
			get { return this._ioAge; }
			set { this._ioAge = value; }
		}

		public String IoAgeNum
		{
			get { return this._ioAgeNum; }
			set { this._ioAgeNum = value; }
		}

		public String IoWeight
		{
			get { return this._ioWeight; }
			set { this._ioWeight = value; }
		}

		public String IoHeight
		{
			get { return this._ioHeight; }
			set { this._ioHeight = value; }
		}

		public String IoZipCode1
		{
			get { return this._ioZipCode1; }
			set { this._ioZipCode1 = value; }
		}

		public String IoZipCode2
		{
			get { return this._ioZipCode2; }
			set { this._ioZipCode2 = value; }
		}

		public String IoAddress1
		{
			get { return this._ioAddress1; }
			set { this._ioAddress1 = value; }
		}

		public String IoAddress2
		{
			get { return this._ioAddress2; }
			set { this._ioAddress2 = value; }
		}

		public String IoTel
		{
			get { return this._ioTel; }
			set { this._ioTel = value; }
		}

		public String IoTel1
		{
			get { return this._ioTel1; }
			set { this._ioTel1 = value; }
		}

		public String IoTelHp
		{
			get { return this._ioTelHp; }
			set { this._ioTelHp = value; }
		}

		public String IoPaceMakerYn
		{
			get { return this._ioPaceMakerYn; }
			set { this._ioPaceMakerYn = value; }
		}

		public String IoDummy2
		{
			get { return this._ioDummy2; }
			set { this._ioDummy2 = value; }
		}

		public String IoDummy3
		{
			get { return this._ioDummy3; }
			set { this._ioDummy3 = value; }
		}

		public String IoFlag
		{
			get { return this._ioFlag; }
			set { this._ioFlag = value; }
		}

		public LoadPatientBaseInfo() { }

		public LoadPatientBaseInfo(String ioSuname, String ioSuname2, String ioSujumin1, String ioSujumin2, String ioSex, String ioBirth, String ioAge, String ioAgeNum, String ioWeight, String ioHeight, String ioZipCode1, String ioZipCode2, String ioAddress1, String ioAddress2, String ioTel, String ioTel1, String ioTelHp, String ioPaceMakerYn, String ioDummy2, String ioDummy3, String ioFlag)
		{
			this._ioSuname = ioSuname;
			this._ioSuname2 = ioSuname2;
			this._ioSujumin1 = ioSujumin1;
			this._ioSujumin2 = ioSujumin2;
			this._ioSex = ioSex;
			this._ioBirth = ioBirth;
			this._ioAge = ioAge;
			this._ioAgeNum = ioAgeNum;
			this._ioWeight = ioWeight;
			this._ioHeight = ioHeight;
			this._ioZipCode1 = ioZipCode1;
			this._ioZipCode2 = ioZipCode2;
			this._ioAddress1 = ioAddress1;
			this._ioAddress2 = ioAddress2;
			this._ioTel = ioTel;
			this._ioTel1 = ioTel1;
			this._ioTelHp = ioTelHp;
			this._ioPaceMakerYn = ioPaceMakerYn;
			this._ioDummy2 = ioDummy2;
			this._ioDummy3 = ioDummy3;
			this._ioFlag = ioFlag;
		}

	}
}