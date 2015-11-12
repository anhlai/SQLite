using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADMS2015U00GetSystemHospitalArgs : IContractArgs
	{
		private String _hospCode;
		private String _groupId;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String GroupId
		{
			get { return this._groupId; }
			set { this._groupId = value; }
		}

		public ADMS2015U00GetSystemHospitalArgs() { }

		public ADMS2015U00GetSystemHospitalArgs(String hospCode, String groupId)
		{
			this._hospCode = hospCode;
			this._groupId = groupId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADMS2015U00GetSystemHospitalRequest();
		}
	}
}