using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCSAPPROVEGrdPatientListArgs : IContractArgs
	{
		private String _inputGubun;
		private String _ioGubun;
		private String _doctor;
		private String _insteadYn;
		private String _approveYn;
		private String _inputTab;

		public String InputGubun
		{
			get { return this._inputGubun; }
			set { this._inputGubun = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
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

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OCSAPPROVEGrdPatientListArgs() { }

		public OCSAPPROVEGrdPatientListArgs(String inputGubun, String ioGubun, String doctor, String insteadYn, String approveYn, String inputTab)
		{
			this._inputGubun = inputGubun;
			this._ioGubun = ioGubun;
			this._doctor = doctor;
			this._insteadYn = insteadYn;
			this._approveYn = approveYn;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCSAPPROVEGrdPatientListRequest();
		}
	}
}