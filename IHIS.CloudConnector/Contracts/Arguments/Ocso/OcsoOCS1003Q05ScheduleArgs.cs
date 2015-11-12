using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003Q05ScheduleArgs : IContractArgs
	{
		private String _inputGubun;
		private String _telYn;
		private String _inputTab;
		private String _ioGubun;
		private String _selectedInputTab;
		private String _bunho;
		private String _kijun;
		private String _naewonDate;
		private String _gwa;

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

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String SelectedInputTab
		{
			get { return this._selectedInputTab; }
			set { this._selectedInputTab = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Kijun
		{
			get { return this._kijun; }
			set { this._kijun = value; }
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

		public OcsoOCS1003Q05ScheduleArgs() { }

		public OcsoOCS1003Q05ScheduleArgs(String inputGubun, String telYn, String inputTab, String ioGubun, String selectedInputTab, String bunho, String kijun, String naewonDate, String gwa)
		{
			this._inputGubun = inputGubun;
			this._telYn = telYn;
			this._inputTab = inputTab;
			this._ioGubun = ioGubun;
			this._selectedInputTab = selectedInputTab;
			this._bunho = bunho;
			this._kijun = kijun;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003Q05ScheduleRequest();
		}
	}
}