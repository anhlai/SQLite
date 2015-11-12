using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0208Q01GrdDrg0120Args : IContractArgs
	{
		private String _chiryoGubun;
		private String _banghyang;
		private String _jaeryoCode;
		private String _useYn;
		private String _bogyongGubun;

		public String ChiryoGubun
		{
			get { return this._chiryoGubun; }
			set { this._chiryoGubun = value; }
		}

		public String Banghyang
		{
			get { return this._banghyang; }
			set { this._banghyang = value; }
		}

		public String JaeryoCode
		{
			get { return this._jaeryoCode; }
			set { this._jaeryoCode = value; }
		}

		public String UseYn
		{
			get { return this._useYn; }
			set { this._useYn = value; }
		}

		public String BogyongGubun
		{
			get { return this._bogyongGubun; }
			set { this._bogyongGubun = value; }
		}

		public OCS0208Q01GrdDrg0120Args() { }

		public OCS0208Q01GrdDrg0120Args(String chiryoGubun, String banghyang, String jaeryoCode, String useYn, String bogyongGubun)
		{
			this._chiryoGubun = chiryoGubun;
			this._banghyang = banghyang;
			this._jaeryoCode = jaeryoCode;
			this._useYn = useYn;
			this._bogyongGubun = bogyongGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0208Q01GrdDrg0120Request();
		}
	}
}