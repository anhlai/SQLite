using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadPatientNaewonAddInfoArgs : IContractArgs
	{
		private String _ioGubun;
		private String _ipwonReserYn;
		private String _naewonKey;
		private String _reserDate;
		private String _reserFkinp1001;
		private String _naewonDate;
		private String _jaewonFlag;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String IpwonReserYn
		{
			get { return this._ipwonReserYn; }
			set { this._ipwonReserYn = value; }
		}

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public String ReserFkinp1001
		{
			get { return this._reserFkinp1001; }
			set { this._reserFkinp1001 = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String JaewonFlag
		{
			get { return this._jaewonFlag; }
			set { this._jaewonFlag = value; }
		}

		public LoadPatientNaewonAddInfoArgs() { }

		public LoadPatientNaewonAddInfoArgs(String ioGubun, String ipwonReserYn, String naewonKey, String reserDate, String reserFkinp1001, String naewonDate, String jaewonFlag)
		{
			this._ioGubun = ioGubun;
			this._ipwonReserYn = ipwonReserYn;
			this._naewonKey = naewonKey;
			this._reserDate = reserDate;
			this._reserFkinp1001 = reserFkinp1001;
			this._naewonDate = naewonDate;
			this._jaewonFlag = jaewonFlag;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadPatientNaewonAddInfoRequest();
		}
	}
}