using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL2010U00GrdSpecimenListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL2010U00GrdSpecimenListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL2010U00SaveLayoutArgs : IContractArgs
	{
		private List<CPL2010U00GrdSpecimenListItemInfo> _inputList = new List<CPL2010U00GrdSpecimenListItemInfo>();
		private String _userId;
		private String _orderDatePr1;
		private String _bunhoPr1;
		private String _jubsujaPr1;
		private String _jubsuFlagPr1;
		private String _jubsuDatePr1;
		private String _jubsuTimePr1;
		private Boolean _rbxMijubsuChecked;
		private String _bunho;
		private String _jubsuDate;
		private String _partJubsuDatePr2;
		private String _partJubsuTimePr2;
		private String _partJubsujaPr2;
		private String _userIdPr2;
		private String _ipAddr;

		public List<CPL2010U00GrdSpecimenListItemInfo> InputList
		{
			get { return this._inputList; }
			set { this._inputList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String OrderDatePr1
		{
			get { return this._orderDatePr1; }
			set { this._orderDatePr1 = value; }
		}

		public String BunhoPr1
		{
			get { return this._bunhoPr1; }
			set { this._bunhoPr1 = value; }
		}

		public String JubsujaPr1
		{
			get { return this._jubsujaPr1; }
			set { this._jubsujaPr1 = value; }
		}

		public String JubsuFlagPr1
		{
			get { return this._jubsuFlagPr1; }
			set { this._jubsuFlagPr1 = value; }
		}

		public String JubsuDatePr1
		{
			get { return this._jubsuDatePr1; }
			set { this._jubsuDatePr1 = value; }
		}

		public String JubsuTimePr1
		{
			get { return this._jubsuTimePr1; }
			set { this._jubsuTimePr1 = value; }
		}

		public Boolean RbxMijubsuChecked
		{
			get { return this._rbxMijubsuChecked; }
			set { this._rbxMijubsuChecked = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String PartJubsuDatePr2
		{
			get { return this._partJubsuDatePr2; }
			set { this._partJubsuDatePr2 = value; }
		}

		public String PartJubsuTimePr2
		{
			get { return this._partJubsuTimePr2; }
			set { this._partJubsuTimePr2 = value; }
		}

		public String PartJubsujaPr2
		{
			get { return this._partJubsujaPr2; }
			set { this._partJubsujaPr2 = value; }
		}

		public String UserIdPr2
		{
			get { return this._userIdPr2; }
			set { this._userIdPr2 = value; }
		}

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public CPL2010U00SaveLayoutArgs() { }

		public CPL2010U00SaveLayoutArgs(List<CPL2010U00GrdSpecimenListItemInfo> inputList, String userId, String orderDatePr1, String bunhoPr1, String jubsujaPr1, String jubsuFlagPr1, String jubsuDatePr1, String jubsuTimePr1, Boolean rbxMijubsuChecked, String bunho, String jubsuDate, String partJubsuDatePr2, String partJubsuTimePr2, String partJubsujaPr2, String userIdPr2, String ipAddr)
		{
			this._inputList = inputList;
			this._userId = userId;
			this._orderDatePr1 = orderDatePr1;
			this._bunhoPr1 = bunhoPr1;
			this._jubsujaPr1 = jubsujaPr1;
			this._jubsuFlagPr1 = jubsuFlagPr1;
			this._jubsuDatePr1 = jubsuDatePr1;
			this._jubsuTimePr1 = jubsuTimePr1;
			this._rbxMijubsuChecked = rbxMijubsuChecked;
			this._bunho = bunho;
			this._jubsuDate = jubsuDate;
			this._partJubsuDatePr2 = partJubsuDatePr2;
			this._partJubsuTimePr2 = partJubsuTimePr2;
			this._partJubsujaPr2 = partJubsujaPr2;
			this._userIdPr2 = userIdPr2;
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL2010U00SaveLayoutRequest();
		}
	}
}