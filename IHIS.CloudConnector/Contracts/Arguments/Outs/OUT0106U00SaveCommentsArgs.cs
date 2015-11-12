using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OUT0106U00GridItemInfo = IHIS.CloudConnector.Contracts.Models.Outs.OUT0106U00GridItemInfo;
using OUT0106U00PatientCommentItemInfo = IHIS.CloudConnector.Contracts.Models.Outs.OUT0106U00PatientCommentItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
	public class OUT0106U00SaveCommentsArgs : IContractArgs
	{
		private List<OUT0106U00GridItemInfo> _gridItemInfo = new List<OUT0106U00GridItemInfo>();
		private List<OUT0106U00PatientCommentItemInfo> _patientCommentItemInfo = new List<OUT0106U00PatientCommentItemInfo>();
		private String _userId;

		public List<OUT0106U00GridItemInfo> GridItemInfo
		{
			get { return this._gridItemInfo; }
			set { this._gridItemInfo = value; }
		}

		public List<OUT0106U00PatientCommentItemInfo> PatientCommentItemInfo
		{
			get { return this._patientCommentItemInfo; }
			set { this._patientCommentItemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OUT0106U00SaveCommentsArgs() { }

		public OUT0106U00SaveCommentsArgs(List<OUT0106U00GridItemInfo> gridItemInfo, List<OUT0106U00PatientCommentItemInfo> patientCommentItemInfo, String userId)
		{
			this._gridItemInfo = gridItemInfo;
			this._patientCommentItemInfo = patientCommentItemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0106U00SaveCommentsRequest();
		}
	}
}