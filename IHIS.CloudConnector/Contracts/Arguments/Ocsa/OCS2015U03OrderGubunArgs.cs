using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U03OrderGubunArgs : IContractArgs
	{
		private String _fHopitalCode;
		private String _fPatientCode;
		private String _fReservationCode;

		public String FHopitalCode
		{
			get { return this._fHopitalCode; }
			set { this._fHopitalCode = value; }
		}

		public String FPatientCode
		{
			get { return this._fPatientCode; }
			set { this._fPatientCode = value; }
		}

		public String FReservationCode
		{
			get { return this._fReservationCode; }
			set { this._fReservationCode = value; }
		}

		public OCS2015U03OrderGubunArgs() { }

		public OCS2015U03OrderGubunArgs(String fHopitalCode, String fPatientCode, String fReservationCode)
		{
			this._fHopitalCode = fHopitalCode;
			this._fPatientCode = fPatientCode;
			this._fReservationCode = fReservationCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U03OrderGubunRequest();
		}
	}
}