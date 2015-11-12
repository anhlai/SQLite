using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OcsoSelectedPatientInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.OcsoSelectedPatientInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OcsoProcHQNInterfaceArgs : IContractArgs
	{
		private OcsoSelectedPatientInfo _patientInfo;
		private String _ioGubun;
		private String _dataDubun;
		private String _userId;

		public OcsoSelectedPatientInfo PatientInfo
		{
			get { return this._patientInfo; }
			set { this._patientInfo = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String DataDubun
		{
			get { return this._dataDubun; }
			set { this._dataDubun = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OcsoProcHQNInterfaceArgs() { }

		public OcsoProcHQNInterfaceArgs(OcsoSelectedPatientInfo patientInfo, String ioGubun, String dataDubun, String userId)
		{
			this._patientInfo = patientInfo;
			this._ioGubun = ioGubun;
			this._dataDubun = dataDubun;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoProcHQNInterfaceRequest();
		}
	}
}