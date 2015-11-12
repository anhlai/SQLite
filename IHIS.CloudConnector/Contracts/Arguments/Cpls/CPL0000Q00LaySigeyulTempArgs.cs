using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00LaySigeyulTempArgs : IContractArgs
	{
		private String _groupHangmog;
		private String _specimenCode;
		private String _hangmogCode;

		public String GroupHangmog
		{
			get { return this._groupHangmog; }
			set { this._groupHangmog = value; }
		}

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public CPL0000Q00LaySigeyulTempArgs() { }

		public CPL0000Q00LaySigeyulTempArgs(String groupHangmog, String specimenCode, String hangmogCode)
		{
			this._groupHangmog = groupHangmog;
			this._specimenCode = specimenCode;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00LaySigeyulTempRequest();
		}
	}
}