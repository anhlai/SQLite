using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CHT0117GrdCHT0117InitListItemInfo = IHIS.CloudConnector.Contracts.Models.Chts.CHT0117GrdCHT0117InitListItemInfo;
using CHT0117GrdCHT0118InitListItemInfo = IHIS.CloudConnector.Contracts.Models.Chts.CHT0117GrdCHT0118InitListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0117TransactionalArgs : IContractArgs
	{
		private List<CHT0117GrdCHT0117InitListItemInfo> _listInput1 = new List<CHT0117GrdCHT0117InitListItemInfo>();
		private List<CHT0117GrdCHT0118InitListItemInfo> _listInput2 = new List<CHT0117GrdCHT0118InitListItemInfo>();
		private String _userId;
		private String _callerId;

		public List<CHT0117GrdCHT0117InitListItemInfo> ListInput1
		{
			get { return this._listInput1; }
			set { this._listInput1 = value; }
		}

		public List<CHT0117GrdCHT0118InitListItemInfo> ListInput2
		{
			get { return this._listInput2; }
			set { this._listInput2 = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String CallerId
		{
			get { return this._callerId; }
			set { this._callerId = value; }
		}

		public CHT0117TransactionalArgs() { }

		public CHT0117TransactionalArgs(List<CHT0117GrdCHT0117InitListItemInfo> listInput1, List<CHT0117GrdCHT0118InitListItemInfo> listInput2, String userId, String callerId)
		{
			this._listInput1 = listInput1;
			this._listInput2 = listInput2;
			this._userId = userId;
			this._callerId = callerId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0117TransactionalRequest();
		}
	}
}