using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OBCheckSpecialDrugForPatientArgs : IContractArgs
	{
		private String _bunho;
		private String _hangmogCode;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public OBCheckSpecialDrugForPatientArgs() { }

		public OBCheckSpecialDrugForPatientArgs(String bunho, String hangmogCode)
		{
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OBCheckSpecialDrugForPatientRequest();
		}
	}
}