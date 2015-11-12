using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003GrdOUT1001RowFocusChangedArgs : IContractArgs
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _fkout1001;
		private String _inputGubun;
		private String _queryGubun;

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

		public String Fkout1001
		{
			get { return this._fkout1001; }
			set { this._fkout1001 = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public String QueryGubun
		{
			get { return this._queryGubun; }
			set { this._queryGubun = value; }
		}

		public OCS1003GrdOUT1001RowFocusChangedArgs() { }

		public OCS1003GrdOUT1001RowFocusChangedArgs(String bunho, String naewonDate, String gwa, String fkout1001, String inputGubun, String queryGubun)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._fkout1001 = fkout1001;
			this._inputGubun = inputGubun;
			this._queryGubun = queryGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003GrdOUT1001RowFocusChangedRequest();
		}
	}
}