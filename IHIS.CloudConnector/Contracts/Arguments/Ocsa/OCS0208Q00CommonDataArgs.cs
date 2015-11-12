using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ComboDataSourceInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.ComboDataSourceInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0208Q00CommonDataArgs : IContractArgs
	{
		private ComboDataSourceInfo _dvTimeInfo;
		private ComboDataSourceInfo _dvInfo;
		private String _bogyongCode;

		public ComboDataSourceInfo DvTimeInfo
		{
			get { return this._dvTimeInfo; }
			set { this._dvTimeInfo = value; }
		}

		public ComboDataSourceInfo DvInfo
		{
			get { return this._dvInfo; }
			set { this._dvInfo = value; }
		}

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public OCS0208Q00CommonDataArgs() { }

		public OCS0208Q00CommonDataArgs(ComboDataSourceInfo dvTimeInfo, ComboDataSourceInfo dvInfo, String bogyongCode)
		{
			this._dvTimeInfo = dvTimeInfo;
			this._dvInfo = dvInfo;
			this._bogyongCode = bogyongCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0208Q00CommonDataRequest();
		}
	}
}