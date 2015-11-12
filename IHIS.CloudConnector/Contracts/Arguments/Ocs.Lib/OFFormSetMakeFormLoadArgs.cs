using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OFFormSetMakeFormLoadArgs : IContractArgs
	{
		private Boolean _isDoctorMode;
		private String _sabun;
		private String _memb;
		private String _inputTab;

		public Boolean IsDoctorMode
		{
			get { return this._isDoctorMode; }
			set { this._isDoctorMode = value; }
		}

		public String Sabun
		{
			get { return this._sabun; }
			set { this._sabun = value; }
		}

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OFFormSetMakeFormLoadArgs() { }

		public OFFormSetMakeFormLoadArgs(Boolean isDoctorMode, String sabun, String memb, String inputTab)
		{
			this._isDoctorMode = isDoctorMode;
			this._sabun = sabun;
			this._memb = memb;
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OFFormSetMakeFormLoadRequest();
		}
	}
}