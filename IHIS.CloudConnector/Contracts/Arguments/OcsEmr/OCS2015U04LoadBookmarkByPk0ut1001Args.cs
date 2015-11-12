using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U04LoadBookmarkByPk0ut1001Args : IContractArgs
	{
		private String _emrRecordId;
		private String _pkout1001;
		private String _sysId;

		public String EmrRecordId
		{
			get { return this._emrRecordId; }
			set { this._emrRecordId = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public OCS2015U04LoadBookmarkByPk0ut1001Args() { }

		public OCS2015U04LoadBookmarkByPk0ut1001Args(String emrRecordId, String pkout1001, String sysId)
		{
			this._emrRecordId = emrRecordId;
			this._pkout1001 = pkout1001;
			this._sysId = sysId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U04LoadBookmarkByPk0ut1001Request();
		}
	}
}