using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003DloCheckLayoutArgs : IContractArgs
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _inputGubun;
		private String _telYn;

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

		public OCS1003DloCheckLayoutArgs() { }

		public OCS1003DloCheckLayoutArgs(String bunho, String naewonDate, String gwa, String inputGubun, String telYn)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._inputGubun = inputGubun;
			this._telYn = telYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003DloCheckLayoutRequest();
		}
	}
}