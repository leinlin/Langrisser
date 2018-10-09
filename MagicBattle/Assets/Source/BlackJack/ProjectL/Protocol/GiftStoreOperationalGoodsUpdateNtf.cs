using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000745 RID: 1861
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GiftStoreOperationalGoodsUpdateNtf")]
	[Serializable]
	public class GiftStoreOperationalGoodsUpdateNtf : IExtensible
	{
		// Token: 0x060061B3 RID: 25011 RVA: 0x001B7FF0 File Offset: 0x001B61F0
		public GiftStoreOperationalGoodsUpdateNtf()
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

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060061B4 RID: 25012 RVA: 0x001B8064 File Offset: 0x001B6264
		[ProtoMember(1, Name = "OperationalGoodsList", DataFormat = DataFormat.Default)]
		public List<ProGiftStoreOperationalGoods> OperationalGoodsList
		{
			get
			{
				return this._OperationalGoodsList;
			}
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x001B806C File Offset: 0x001B626C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x001B807C File Offset: 0x001B627C
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

		// Token: 0x060061B7 RID: 25015 RVA: 0x001B8148 File Offset: 0x001B6348
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreOperationalGoodsUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400492B RID: 18731
		private readonly List<ProGiftStoreOperationalGoods> _OperationalGoodsList = new List<ProGiftStoreOperationalGoods>();

		// Token: 0x0400492C RID: 18732
		private IExtension extensionObject;

		// Token: 0x0400492D RID: 18733
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400492E RID: 18734
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400492F RID: 18735
		private LuaFunction m_ctor_hotfix;
	}
}
