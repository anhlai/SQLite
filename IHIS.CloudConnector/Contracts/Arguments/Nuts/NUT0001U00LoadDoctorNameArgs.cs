using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuts
{
	public class NUT0001U00LoadDoctorNameArgs : IContractArgs
	{
		private String _param;

		public String Param
		{
			get { return this._param; }
			set { this._param = value; }
		}

		public NUT0001U00LoadDoctorNameArgs() { }

		public NUT0001U00LoadDoctorNameArgs(String param)
		{
			this._param = param;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUT0001U00LoadDoctorNameRequest();
		}
	}
}