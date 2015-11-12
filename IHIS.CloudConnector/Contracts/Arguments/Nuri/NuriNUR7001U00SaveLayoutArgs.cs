using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NuriNUR7001U00MeasurePhysicalConditionListItemInfo = IHIS.CloudConnector.Contracts.Models.Nuri.NuriNUR7001U00MeasurePhysicalConditionListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR7001U00SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<NuriNUR7001U00MeasurePhysicalConditionListItemInfo> _listInfo = new List<NuriNUR7001U00MeasurePhysicalConditionListItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<NuriNUR7001U00MeasurePhysicalConditionListItemInfo> ListInfo
		{
			get { return this._listInfo; }
			set { this._listInfo = value; }
		}

		public NuriNUR7001U00SaveLayoutArgs() { }

		public NuriNUR7001U00SaveLayoutArgs(String userId, List<NuriNUR7001U00MeasurePhysicalConditionListItemInfo> listInfo)
		{
			this._userId = userId;
			this._listInfo = listInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR7001U00SaveLayoutRequest();
		}
	}
}