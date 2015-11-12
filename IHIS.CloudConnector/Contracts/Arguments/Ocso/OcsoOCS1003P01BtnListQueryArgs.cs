using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01BtnListQueryArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _naewonDate;
		private String _fkout1001;
		private String _queryGubun;
		private String _inputGubun;
		private String _bunho2;
		private String _naewonDate2;

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

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Fkout1001
		{
			get { return this._fkout1001; }
			set { this._fkout1001 = value; }
		}

		public String QueryGubun
		{
			get { return this._queryGubun; }
			set { this._queryGubun = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public String Bunho2
		{
			get { return this._bunho2; }
			set { this._bunho2 = value; }
		}

		public String NaewonDate2
		{
			get { return this._naewonDate2; }
			set { this._naewonDate2 = value; }
		}

		public OcsoOCS1003P01BtnListQueryArgs() { }

		public OcsoOCS1003P01BtnListQueryArgs(String bunho, String gwa, String naewonDate, String fkout1001, String queryGubun, String inputGubun, String bunho2, String naewonDate2)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._naewonDate = naewonDate;
			this._fkout1001 = fkout1001;
			this._queryGubun = queryGubun;
			this._inputGubun = inputGubun;
			this._bunho2 = bunho2;
			this._naewonDate2 = naewonDate2;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01BtnListQueryRequest();
		}
	}
}