using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DataStringListItemInfo = IHIS.CloudConnector.Contracts.Models.System.DataStringListItemInfo;
using SCH3001U00GrdJukyongDateInfo = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdJukyongDateInfo;
using SCH3001U00GrdSCH0001Info = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdSCH0001Info;
using SCH3001U00GrdSCH0002Info = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdSCH0002Info;
using SCH3001U00GrdSCH3000Info = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdSCH3000Info;
using SCH3001U00GrdSCH3100Info = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdSCH3100Info;
using SCH3001U00GrdSCH3101Info = IHIS.CloudConnector.Contracts.Models.Schs.SCH3001U00GrdSCH3101Info;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00BtnBtnListUpdateArgs : IContractArgs
	{
		private List<SCH3001U00GrdSCH0001Info> _grdSch0001Info = new List<SCH3001U00GrdSCH0001Info>();
		private List<SCH3001U00GrdSCH0002Info> _grdSch0002Info = new List<SCH3001U00GrdSCH0002Info>();
		private List<SCH3001U00GrdJukyongDateInfo> _grdJukyongDateInfo = new List<SCH3001U00GrdJukyongDateInfo>();
		private List<SCH3001U00GrdSCH3000Info> _grdSch3000Info = new List<SCH3001U00GrdSCH3000Info>();
		private List<SCH3001U00GrdSCH3100Info> _grdSch3100Info = new List<SCH3001U00GrdSCH3100Info>();
		private List<SCH3001U00GrdSCH3101Info> _grdSch3101Info = new List<SCH3001U00GrdSCH3101Info>();
		private String _userId;
		private List<DataStringListItemInfo> _selectedYoil = new List<DataStringListItemInfo>();

		public List<SCH3001U00GrdSCH0001Info> GrdSch0001Info
		{
			get { return this._grdSch0001Info; }
			set { this._grdSch0001Info = value; }
		}

		public List<SCH3001U00GrdSCH0002Info> GrdSch0002Info
		{
			get { return this._grdSch0002Info; }
			set { this._grdSch0002Info = value; }
		}

		public List<SCH3001U00GrdJukyongDateInfo> GrdJukyongDateInfo
		{
			get { return this._grdJukyongDateInfo; }
			set { this._grdJukyongDateInfo = value; }
		}

		public List<SCH3001U00GrdSCH3000Info> GrdSch3000Info
		{
			get { return this._grdSch3000Info; }
			set { this._grdSch3000Info = value; }
		}

		public List<SCH3001U00GrdSCH3100Info> GrdSch3100Info
		{
			get { return this._grdSch3100Info; }
			set { this._grdSch3100Info = value; }
		}

		public List<SCH3001U00GrdSCH3101Info> GrdSch3101Info
		{
			get { return this._grdSch3101Info; }
			set { this._grdSch3101Info = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<DataStringListItemInfo> SelectedYoil
		{
			get { return this._selectedYoil; }
			set { this._selectedYoil = value; }
		}

		public SCH3001U00BtnBtnListUpdateArgs() { }

		public SCH3001U00BtnBtnListUpdateArgs(List<SCH3001U00GrdSCH0001Info> grdSch0001Info, List<SCH3001U00GrdSCH0002Info> grdSch0002Info, List<SCH3001U00GrdJukyongDateInfo> grdJukyongDateInfo, List<SCH3001U00GrdSCH3000Info> grdSch3000Info, List<SCH3001U00GrdSCH3100Info> grdSch3100Info, List<SCH3001U00GrdSCH3101Info> grdSch3101Info, String userId, List<DataStringListItemInfo> selectedYoil)
		{
			this._grdSch0001Info = grdSch0001Info;
			this._grdSch0002Info = grdSch0002Info;
			this._grdJukyongDateInfo = grdJukyongDateInfo;
			this._grdSch3000Info = grdSch3000Info;
			this._grdSch3100Info = grdSch3100Info;
			this._grdSch3101Info = grdSch3101Info;
			this._userId = userId;
			this._selectedYoil = selectedYoil;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00BtnBtnListUpdateRequest();
		}
	}
}