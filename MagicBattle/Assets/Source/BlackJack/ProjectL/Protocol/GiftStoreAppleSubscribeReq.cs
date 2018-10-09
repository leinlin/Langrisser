using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000740 RID: 1856
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GiftStoreAppleSubscribeReq")]
	[Serializable]
	public class GiftStoreAppleSubscribeReq : IExtensible
	{
		// Token: 0x06006187 RID: 24967 RVA: 0x001B76A4 File Offset: 0x001B58A4
		public GiftStoreAppleSubscribeReq()
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

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x001B770C File Offset: 0x001B590C
		// (set) Token: 0x06006189 RID: 24969 RVA: 0x001B7714 File Offset: 0x001B5914
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

		// Token: 0x0600618A RID: 24970 RVA: 0x001B7720 File Offset: 0x001B5920
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x001B7730 File Offset: 0x001B5930
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

		// Token: 0x0600618C RID: 24972 RVA: 0x001B77FC File Offset: 0x001B59FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreAppleSubscribeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400490B RID: 18699
		private int _GoodsId;

		// Token: 0x0400490C RID: 18700
		private IExtension extensionObject;

		// Token: 0x0400490D RID: 18701
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400490E RID: 18702
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400490F RID: 18703
		private LuaFunction m_ctor_hotfix;
	}
}
