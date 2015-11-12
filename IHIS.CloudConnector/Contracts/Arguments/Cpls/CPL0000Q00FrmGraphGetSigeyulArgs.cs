using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00FrmGraphGetSigeyulArgs : IContractArgs
	{
		private String _bunho;
		private String _userId;
		private String _baseDate;
		private String _conditionValue;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String BaseDate
		{
			get { return this._baseDate; }
			set { this._baseDate = value; }
		}

		public String ConditionValue
		{
			get { return this._conditionValue; }
			set { this._conditionValue = value; }
		}

		public CPL0000Q00FrmGraphGetSigeyulArgs() { }

		public CPL0000Q00FrmGraphGetSigeyulArgs(String bunho, String userId, String baseDate, String conditionValue)
		{
			this._bunho = bunho;
			this._userId = userId;
			this._baseDate = baseDate;
			this._conditionValue = conditionValue;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00FrmGraphGetSigeyulRequest();
		}
	}
}