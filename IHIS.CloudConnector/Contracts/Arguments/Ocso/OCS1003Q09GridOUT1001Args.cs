using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003Q09GridOUT1001Args : IContractArgs
	{
		private String _gwa;
		private String _kijun;
		private String _bunho;
		private String _inputGubun;
		private String _telYn;
		private String _hospCode;
		private String _ioGubun;
		private String _inputTab;
		private String _selectedInputTab;
		private String _naewonDate;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Kijun
		{
			get { return this._kijun; }
			set { this._kijun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public String TelYn
		{
			get { return this._telYn; }
			set { this._telYn = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String SelectedInputTab
		{
			get { return this._selectedInputTab; }
			set { this._selectedInputTab = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public OCS1003Q09GridOUT1001Args() { }

		public OCS1003Q09GridOUT1001Args(String gwa, String kijun, String bunho, String inputGubun, String telYn, String hospCode, String ioGubun, String inputTab, String selectedInputTab, String naewonDate)
		{
			this._gwa = gwa;
			this._kijun = kijun;
			this._bunho = bunho;
			this._inputGubun = inputGubun;
			this._telYn = telYn;
			this._hospCode = hospCode;
			this._ioGubun = ioGubun;
			this._inputTab = inputTab;
			this._selectedInputTab = selectedInputTab;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003Q09GridOUT1001Request();
		}
	}
}