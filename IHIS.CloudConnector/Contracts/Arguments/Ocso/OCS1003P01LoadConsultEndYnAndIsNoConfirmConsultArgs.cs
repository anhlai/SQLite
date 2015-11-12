using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadConsultEndYNInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadConsultEndYNInfo;
using NoConfirmConsultInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.NoConfirmConsultInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01LoadConsultEndYnAndIsNoConfirmConsultArgs : IContractArgs
	{
		private LoadConsultEndYNInfo _itemInfo;
		private NoConfirmConsultInfo _confirmConsultInfo;

		public LoadConsultEndYNInfo ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public NoConfirmConsultInfo ConfirmConsultInfo
		{
			get { return this._confirmConsultInfo; }
			set { this._confirmConsultInfo = value; }
		}

		public OCS1003P01LoadConsultEndYnAndIsNoConfirmConsultArgs() { }

		public OCS1003P01LoadConsultEndYnAndIsNoConfirmConsultArgs(LoadConsultEndYNInfo itemInfo, NoConfirmConsultInfo confirmConsultInfo)
		{
			this._itemInfo = itemInfo;
			this._confirmConsultInfo = confirmConsultInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01LoadConsultEndYnAndIsNoConfirmConsultRequest();
		}
	}
}