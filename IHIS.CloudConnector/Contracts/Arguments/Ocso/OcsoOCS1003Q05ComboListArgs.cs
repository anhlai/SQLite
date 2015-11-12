using System;
using ProtoBuf;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003Q05ComboListArgs : IContractArgs
	{
		private List<ComboDataSourceInfo> _cboItem = new List<ComboDataSourceInfo>();

		public List<ComboDataSourceInfo> CboItem
		{
			get { return this._cboItem; }
			set { this._cboItem = value; }
		}

		public OcsoOCS1003Q05ComboListArgs() { }

		public OcsoOCS1003Q05ComboListArgs(List<ComboDataSourceInfo> cboItem)
		{
			this._cboItem = cboItem;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.OcsoOCS1003Q05ComboListRequest();
		}
	}
}