using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY8002U00GrdPHYArgs : IContractArgs
	{
		private String _fkOcs;
		private String _kanjaNo;
		private String _fkOcsIrai;

		public String FkOcs
		{
			get { return this._fkOcs; }
			set { this._fkOcs = value; }
		}

		public String KanjaNo
		{
			get { return this._kanjaNo; }
			set { this._kanjaNo = value; }
		}

		public String FkOcsIrai
		{
			get { return this._fkOcsIrai; }
			set { this._fkOcsIrai = value; }
		}

		public PHY8002U00GrdPHYArgs() { }

		public PHY8002U00GrdPHYArgs(String fkOcs, String kanjaNo, String fkOcsIrai)
		{
			this._fkOcs = fkOcs;
			this._kanjaNo = kanjaNo;
			this._fkOcsIrai = fkOcsIrai;
		}

		public IExtensible GetRequestInstance()
		{
			return new PHY8002U00GrdPHYRequest();
		}
	}
}