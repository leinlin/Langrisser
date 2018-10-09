using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074A RID: 1866
	[ProtoContract(Name = "RechargeStoreCancelBuyReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RechargeStoreCancelBuyReq : IExtensible
	{
		// Token: 0x060061D4 RID: 25044 RVA: 0x001B88D8 File Offset: 0x001B6AD8
		public RechargeStoreCancelBuyReq()
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

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x001B8940 File Offset: 0x001B6B40
		// (set) Token: 0x060061D6 RID: 25046 RVA: 0x001B8948 File Offset: 0x001B6B48
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x001B8954 File Offset: 0x001B6B54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x001B8964 File Offset: 0x001B6B64
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

		// Token: 0x060061D9 RID: 25049 RVA: 0x001B8A30 File Offset: 0x001B6C30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreCancelBuyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004946 RID: 18758
		private int _GoodsId;

		// Token: 0x04004947 RID: 18759
		private IExtension extensionObject;

		// Token: 0x04004948 RID: 18760
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004949 RID: 18761
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400494A RID: 18762
		private LuaFunction m_ctor_hotfix;
	}
}
