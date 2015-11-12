using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0101U00CheckHangMogCopyArgs : IContractArgs
	{
		private String _hangmogCode;
		private String _specimenCode;
		private String _newEmergency;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String NewEmergency
		{
			get { return this._newEmergency; }
			set { this._newEmergency = value; }
		}

		public CPL0101U00CheckHangMogCopyArgs() { }

		public CPL0101U00CheckHangMogCopyArgs(String hangmogCode, String specimenCode, String newEmergency)
		{
			this._hangmogCode = hangmogCode;
			this._specimenCode = specimenCode;
			this._newEmergency = newEmergency;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0101U00CheckHangMogCopyRequest();
		}
	}
}