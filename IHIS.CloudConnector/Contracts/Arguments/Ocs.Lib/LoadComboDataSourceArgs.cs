using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ComboDataSourceInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.ComboDataSourceInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadComboDataSourceArgs : IContractArgs
	{
		private ComboDataSourceInfo _dataInfo;

		public ComboDataSourceInfo DataInfo
		{
			get { return this._dataInfo; }
			set { this._dataInfo = value; }
		}

		public LoadComboDataSourceArgs() { }

		public LoadComboDataSourceArgs(ComboDataSourceInfo dataInfo)
		{
			this._dataInfo = dataInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadComboDataSourceRequest();
		}
	}
}