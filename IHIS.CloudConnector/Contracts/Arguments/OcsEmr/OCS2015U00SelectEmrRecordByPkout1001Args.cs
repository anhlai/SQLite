using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U00SelectEmrRecordByPkout1001Args : IContractArgs
	{
		private String _bunho;
		private String _hospCode;
		private String _pkout1001;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public OCS2015U00SelectEmrRecordByPkout1001Args() { }

		public OCS2015U00SelectEmrRecordByPkout1001Args(String bunho, String hospCode, String pkout1001)
		{
			this._bunho = bunho;
			this._hospCode = hospCode;
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U00SelectEmrRecordByPkout1001Request();
		}
	}
}