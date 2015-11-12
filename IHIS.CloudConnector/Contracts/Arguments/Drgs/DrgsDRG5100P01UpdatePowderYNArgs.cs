using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01UpdatePowderYNArgs : IContractArgs
	{
		private String _powderYn;
		private String _fkocs1003;

		public String PowderYn
		{
			get { return this._powderYn; }
			set { this._powderYn = value; }
		}

		public String Fkocs1003
		{
			get { return this._fkocs1003; }
			set { this._fkocs1003 = value; }
		}

		public DrgsDRG5100P01UpdatePowderYNArgs() { }

		public DrgsDRG5100P01UpdatePowderYNArgs(String powderYn, String fkocs1003)
		{
			this._powderYn = powderYn;
			this._fkocs1003 = fkocs1003;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01UpdatePowderYNRequest();
		}
	}
}