using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class InitializeComboListItemArgs : IContractArgs
	{
		private String _codeType;
		private String _comboTimeType;
		private String _codeTypeCboTel;
		private String _codeTypeChojae;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String ComboTimeType
		{
			get { return this._comboTimeType; }
			set { this._comboTimeType = value; }
		}

		public String CodeTypeCboTel
		{
			get { return this._codeTypeCboTel; }
			set { this._codeTypeCboTel = value; }
		}

		public String CodeTypeChojae
		{
			get { return this._codeTypeChojae; }
			set { this._codeTypeChojae = value; }
		}

		public InitializeComboListItemArgs() { }

		public InitializeComboListItemArgs(String codeType, String comboTimeType, String codeTypeCboTel, String codeTypeChojae)
		{
			this._codeType = codeType;
			this._comboTimeType = comboTimeType;
			this._codeTypeCboTel = codeTypeCboTel;
			this._codeTypeChojae = codeTypeChojae;
		}

		public IExtensible GetRequestInstance()
		{
			return new InitializeComboListItemRequest();
		}
	}
}