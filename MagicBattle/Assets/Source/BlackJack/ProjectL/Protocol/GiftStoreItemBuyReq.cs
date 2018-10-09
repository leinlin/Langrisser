using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073E RID: 1854
	[ProtoContract(Name = "GiftStoreItemBuyReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GiftStoreItemBuyReq : IExtensible
	{
		// Token: 0x06006179 RID: 24953 RVA: 0x001B7310 File Offset: 0x001B5510
		public GiftStoreItemBuyReq()
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

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x001B7378 File Offset: 0x001B5578
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x001B7380 File Offset: 0x001B5580
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

		// Token: 0x0600617C RID: 24956 RVA: 0x001B738C File Offset: 0x001B558C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x001B739C File Offset: 0x001B559C
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

		// Token: 0x0600617E RID: 24958 RVA: 0x001B7468 File Offset: 0x001B5668
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreItemBuyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004900 RID: 18688
		private int _GoodsId;

		// Token: 0x04004901 RID: 18689
		private IExtension extensionObject;

		// Token: 0x04004902 RID: 18690
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004903 RID: 18691
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004904 RID: 18692
		private LuaFunction m_ctor_hotfix;
	}
}
