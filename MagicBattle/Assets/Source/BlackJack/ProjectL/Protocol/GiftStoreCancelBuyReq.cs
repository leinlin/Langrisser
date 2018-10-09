using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000748 RID: 1864
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GiftStoreCancelBuyReq")]
	[Serializable]
	public class GiftStoreCancelBuyReq : IExtensible
	{
		// Token: 0x060061C6 RID: 25030 RVA: 0x001B8544 File Offset: 0x001B6744
		public GiftStoreCancelBuyReq()
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

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x001B85AC File Offset: 0x001B67AC
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x001B85B4 File Offset: 0x001B67B4
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

		// Token: 0x060061C9 RID: 25033 RVA: 0x001B85C0 File Offset: 0x001B67C0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x001B85D0 File Offset: 0x001B67D0
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

		// Token: 0x060061CB RID: 25035 RVA: 0x001B869C File Offset: 0x001B689C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreCancelBuyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400493B RID: 18747
		private int _GoodsId;

		// Token: 0x0400493C RID: 18748
		private IExtension extensionObject;

		// Token: 0x0400493D RID: 18749
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400493E RID: 18750
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400493F RID: 18751
		private LuaFunction m_ctor_hotfix;
	}
}
