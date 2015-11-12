using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS3003Q10GrdOrderArgs : IContractArgs
	{
		private String _naewonDate;
		private String _ioGubun;
		private String _orderGubun;
		private String _bunho;
		private String _pkOcskey;
		private String _jubsuNo;
		private String _gwa;
		private String _doctor;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String OrderGubun
		{
			get { return this._orderGubun; }
			set { this._orderGubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String PkOcskey
		{
			get { return this._pkOcskey; }
			set { this._pkOcskey = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
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

		public OCS3003Q10GrdOrderArgs() { }

		public OCS3003Q10GrdOrderArgs(String naewonDate, String ioGubun, String orderGubun, String bunho, String pkOcskey, String jubsuNo, String gwa, String doctor)
		{
			this._naewonDate = naewonDate;
			this._ioGubun = ioGubun;
			this._orderGubun = orderGubun;
			this._bunho = bunho;
			this._pkOcskey = pkOcskey;
			this._jubsuNo = jubsuNo;
			this._gwa = gwa;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS3003Q10GrdOrderRequest();
		}
	}
}