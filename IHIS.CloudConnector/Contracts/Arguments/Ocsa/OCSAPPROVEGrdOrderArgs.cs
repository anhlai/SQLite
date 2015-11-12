using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCSAPPROVEGrdOrderArgs : IContractArgs
	{
		private String _pkOrder;
		private String _inputTab;
		private String _insteadYn;
		private String _approveYn;
		private String _prepostGubun;
		private String _bunho;
		private String _jubsuNo;
		private String _naewonDate;
		private String _doctor;

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

		public String InsteadYn
		{
			get { return this._insteadYn; }
			set { this._insteadYn = value; }
		}

		public String ApproveYn
		{
			get { return this._approveYn; }
			set { this._approveYn = value; }
		}

		public String PrepostGubun
		{
			get { return this._prepostGubun; }
			set { this._prepostGubun = value; }
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

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OCSAPPROVEGrdOrderArgs() { }

		public OCSAPPROVEGrdOrderArgs(String pkOrder, String inputTab, String insteadYn, String approveYn, String prepostGubun, String bunho, String jubsuNo, String naewonDate, String doctor)
		{
			this._pkOrder = pkOrder;
			this._inputTab = inputTab;
			this._insteadYn = insteadYn;
			this._approveYn = approveYn;
			this._prepostGubun = prepostGubun;
			this._bunho = bunho;
			this._jubsuNo = jubsuNo;
			this._naewonDate = naewonDate;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCSAPPROVEGrdOrderRequest();
		}
	}
}