using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using MultiResultViewGrdSigeyulInfo = IHIS.CloudConnector.Contracts.Models.Cpls.MultiResultViewGrdSigeyulInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class MultiResultViewGetPreJubsuSigeyulArgs : IContractArgs
	{
		private List<MultiResultViewGrdSigeyulInfo> _grdSigeyulItem = new List<MultiResultViewGrdSigeyulInfo>();
		private String _userId;

		public List<MultiResultViewGrdSigeyulInfo> GrdSigeyulItem
		{
			get { return this._grdSigeyulItem; }
			set { this._grdSigeyulItem = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public MultiResultViewGetPreJubsuSigeyulArgs() { }

		public MultiResultViewGetPreJubsuSigeyulArgs(List<MultiResultViewGrdSigeyulInfo> grdSigeyulItem, String userId)
		{
			this._grdSigeyulItem = grdSigeyulItem;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new MultiResultViewGetPreJubsuSigeyulRequest();
		}
	}
}