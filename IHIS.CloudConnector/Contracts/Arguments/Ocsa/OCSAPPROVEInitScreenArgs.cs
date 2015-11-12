using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ComboDataSourceInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.ComboDataSourceInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCSAPPROVEInitScreenArgs : IContractArgs
	{
		private List<ComboDataSourceInfo> _cboListInfo = new List<ComboDataSourceInfo>();

		public List<ComboDataSourceInfo> CboListInfo
		{
			get { return this._cboListInfo; }
			set { this._cboListInfo = value; }
		}

		public OCSAPPROVEInitScreenArgs() { }

		public OCSAPPROVEInitScreenArgs(List<ComboDataSourceInfo> cboListInfo)
		{
			this._cboListInfo = cboListInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCSAPPROVEInitScreenRequest();
		}
	}
}