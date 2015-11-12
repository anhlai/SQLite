using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003Q09GridOCS1003Args : IContractArgs
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;
		private String _naewonType;
		private String _inputGubun;
		private String _telYn;
		private String _inputTab;
		private String _jubsuNo;
		private String _pkOrder;
		private String _genericYn;
		private String _kijun;
		private String _ioGubun;

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

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String NaewonType
		{
			get { return this._naewonType; }
			set { this._naewonType = value; }
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

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public String PkOrder
		{
			get { return this._pkOrder; }
			set { this._pkOrder = value; }
		}

		public String GenericYn
		{
			get { return this._genericYn; }
			set { this._genericYn = value; }
		}

		public String Kijun
		{
			get { return this._kijun; }
			set { this._kijun = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public OCS1003Q09GridOCS1003Args() { }

		public OCS1003Q09GridOCS1003Args(String bunho, String naewonDate, String gwa, String doctor, String naewonType, String inputGubun, String telYn, String inputTab, String jubsuNo, String pkOrder, String genericYn, String kijun, String ioGubun)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
			this._naewonType = naewonType;
			this._inputGubun = inputGubun;
			this._telYn = telYn;
			this._inputTab = inputTab;
			this._jubsuNo = jubsuNo;
			this._pkOrder = pkOrder;
			this._genericYn = genericYn;
			this._kijun = kijun;
			this._ioGubun = ioGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003Q09GridOCS1003Request();
		}
	}
}