using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000800 RID: 2048
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "OperationalActivityExchangeItemGroupReq")]
	[Serializable]
	public class OperationalActivityExchangeItemGroupReq : IExtensible
	{
		// Token: 0x060067BE RID: 26558 RVA: 0x001CD928 File Offset: 0x001CBB28
		public OperationalActivityExchangeItemGroupReq()
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060067BF RID: 26559 RVA: 0x001CD990 File Offset: 0x001CBB90
		// (set) Token: 0x060067C0 RID: 26560 RVA: 0x001CD998 File Offset: 0x001CBB98
		[ProtoMember(1, IsRequired = true, Name = "OperationalActivityInstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x001CD9A4 File Offset: 0x001CBBA4
		// (set) Token: 0x060067C2 RID: 26562 RVA: 0x001CD9AC File Offset: 0x001CBBAC
		[ProtoMember(2, IsRequired = true, Name = "ExchangeItemGroupIndex", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060067C3 RID: 26563 RVA: 0x001CD9B8 File Offset: 0x001CBBB8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x001CD9C8 File Offset: 0x001CBBC8
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

		// Token: 0x060067C5 RID: 26565 RVA: 0x001CDA94 File Offset: 0x001CBC94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityExchangeItemGroupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DB7 RID: 19895
		private ulong _OperationalActivityInstanceId;

		// Token: 0x04004DB8 RID: 19896
		private int _ExchangeItemGroupIndex;

		// Token: 0x04004DB9 RID: 19897
		private IExtension extensionObject;

		// Token: 0x04004DBA RID: 19898
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DBB RID: 19899
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DBC RID: 19900
		private LuaFunction m_ctor_hotfix;
	}
}
