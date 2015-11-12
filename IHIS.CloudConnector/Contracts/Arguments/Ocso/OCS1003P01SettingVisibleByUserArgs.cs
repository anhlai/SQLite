using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NaewonYNInfo1 = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.NaewonYNInfo1;
using NotApproveOrderCntInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.NotApproveOrderCntInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01SettingVisibleByUserArgs : IContractArgs
	{
		private NaewonYNInfo1 _naewonParam;
		private NotApproveOrderCntInfo _countParam;

		public NaewonYNInfo1 NaewonParam
		{
			get { return this._naewonParam; }
			set { this._naewonParam = value; }
		}

		public NotApproveOrderCntInfo CountParam
		{
			get { return this._countParam; }
			set { this._countParam = value; }
		}

		public OCS1003P01SettingVisibleByUserArgs() { }

		public OCS1003P01SettingVisibleByUserArgs(NaewonYNInfo1 naewonParam, NotApproveOrderCntInfo countParam)
		{
			this._naewonParam = naewonParam;
			this._countParam = countParam;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01SettingVisibleByUserRequest();
		}
	}
}