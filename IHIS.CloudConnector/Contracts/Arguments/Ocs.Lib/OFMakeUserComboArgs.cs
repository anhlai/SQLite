using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OFMakeUserComboArgs : IContractArgs
	{
		private Boolean _isDoctorMode;

		public Boolean IsDoctorMode
		{
			get { return this._isDoctorMode; }
			set { this._isDoctorMode = value; }
		}

		public OFMakeUserComboArgs() { }

		public OFMakeUserComboArgs(Boolean isDoctorMode)
		{
			this._isDoctorMode = isDoctorMode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OFMakeUserComboRequest();
		}
	}
}