using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000801 RID: 2049
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "OperationalActivityExchangeItemGroupAck")]
	[Serializable]
	public class OperationalActivityExchangeItemGroupAck : IExtensible
	{
		// Token: 0x060067C6 RID: 26566 RVA: 0x001CDAFC File Offset: 0x001CBCFC
		public OperationalActivityExchangeItemGroupAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x001CDB64 File Offset: 0x001CBD64
		// (set) Token: 0x060067C8 RID: 26568 RVA: 0x001CDB6C File Offset: 0x001CBD6C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060067C9 RID: 26569 RVA: 0x001CDB78 File Offset: 0x001CBD78
		// (set) Token: 0x060067CA RID: 26570 RVA: 0x001CDB80 File Offset: 0x001CBD80
		[ProtoMember(2, IsRequired = true, Name = "OperationalActivityInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong OperationalActivityInstanceId
		{
			get
			{
				return this._OperationalActivityInstanceId;
			}
			set
			{
				this._OperationalActivityInstanceId = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x001CDB8C File Offset: 0x001CBD8C
		// (set) Token: 0x060067CC RID: 26572 RVA: 0x001CDB94 File Offset: 0x001CBD94
		[ProtoMember(3, IsRequired = true, Name = "ExchangeItemGroupIndex", DataFormat = DataFormat.TwosComplement)]
		public int ExchangeItemGroupIndex
		{
			get
			{
				return this._ExchangeItemGroupIndex;
			}
			set
			{
				this._ExchangeItemGroupIndex = value;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x001CDBA0 File Offset: 0x001CBDA0
		// (set) Token: 0x060067CE RID: 26574 RVA: 0x001CDBA8 File Offset: 0x001CBDA8
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x001CDBB4 File Offset: 0x001CBDB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x001CDBC4 File Offset: 0x001CBDC4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x001CDC90 File Offset: 0x001CBE90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityExchangeItemGroupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DBD RID: 19901
		private int _Result;

		// Token: 0x04004DBE RID: 19902
		private ulong _OperationalActivityInstanceId;

		// Token: 0x04004DBF RID: 19903
		private int _ExchangeItemGroupIndex;

		// Token: 0x04004DC0 RID: 19904
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004DC1 RID: 19905
		private IExtension extensionObject;

		// Token: 0x04004DC2 RID: 19906
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DC3 RID: 19907
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DC4 RID: 19908
		private LuaFunction m_ctor_hotfix;
	}
}
