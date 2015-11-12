using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00PrintAdmMediCheckDrgArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _drgBunho;
		private String _bunho;
		private String _dataDubun;
		private String _inOutGubun;
		private String _fk;
		private String _ioGubun;
		private String _sendYn;
		private String _gubun;
		private String _userId;

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String DataDubun
		{
			get { return this._dataDubun; }
			set { this._dataDubun = value; }
		}

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String Fk
		{
			get { return this._fk; }
			set { this._fk = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String SendYn
		{
			get { return this._sendYn; }
			set { this._sendYn = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public DRG0201U00PrintAdmMediCheckDrgArgs() { }

		public DRG0201U00PrintAdmMediCheckDrgArgs(String jubsuDate, String drgBunho, String bunho, String dataDubun, String inOutGubun, String fk, String ioGubun, String sendYn, String gubun, String userId)
		{
			this._jubsuDate = jubsuDate;
			this._drgBunho = drgBunho;
			this._bunho = bunho;
			this._dataDubun = dataDubun;
			this._inOutGubun = inOutGubun;
			this._fk = fk;
			this._ioGubun = ioGubun;
			this._sendYn = sendYn;
			this._gubun = gubun;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00PrintAdmMediCheckDrgRequest();
		}
	}
}