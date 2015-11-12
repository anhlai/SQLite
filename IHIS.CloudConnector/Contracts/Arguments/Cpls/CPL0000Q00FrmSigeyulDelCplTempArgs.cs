using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00FrmSigeyulDelCplTempArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL0000Q00FrmSigeyulDelCplTempArgs() { }

		public CPL0000Q00FrmSigeyulDelCplTempArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00FrmSigeyulDelCplTempRequest();
		}
	}
}