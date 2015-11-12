using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01FormJusaBedLayPatientArgs : IContractArgs
	{
		private String _codeName;
		private String _hospCode;

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public INJ1001U01FormJusaBedLayPatientArgs() { }

		public INJ1001U01FormJusaBedLayPatientArgs(String codeName, String hospCode)
		{
			this._codeName = codeName;
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01FormJusaBedLayPatientRequest();
		}
	}
}