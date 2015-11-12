using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003Q05OrderListArgs : IContractArgs
	{
		private String _genericYn;
		private String _pkOrder;
		private String _inputTab;
		private String _inputGubun;
		private String _telYn;
		private String _bunho;
		private String _jubsuNo;
		private String _kijun;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;

		public String GenericYn
		{
			get { return this._genericYn; }
			set { this._genericYn = value; }
		}

		public String PkOrder
		{
			get { return this._pkOrder; }
			set { this._pkOrder = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
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

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
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

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OcsoOCS1003Q05OrderListArgs() { }

		public OcsoOCS1003Q05OrderListArgs(String genericYn, String pkOrder, String inputTab, String inputGubun, String telYn, String bunho, String jubsuNo, String kijun, String naewonDate, String gwa, String doctor)
		{
			this._genericYn = genericYn;
			this._pkOrder = pkOrder;
			this._inputTab = inputTab;
			this._inputGubun = inputGubun;
			this._telYn = telYn;
			this._bunho = bunho;
			this._jubsuNo = jubsuNo;
			this._kijun = kijun;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003Q05OrderListRequest();
		}
	}
}