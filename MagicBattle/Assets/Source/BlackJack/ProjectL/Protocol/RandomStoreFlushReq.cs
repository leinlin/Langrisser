using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000808 RID: 2056
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomStoreFlushReq")]
	[Serializable]
	public class RandomStoreFlushReq : IExtensible
	{
		// Token: 0x06006801 RID: 26625 RVA: 0x001D5BF8 File Offset: 0x001D3DF8
		public RandomStoreFlushReq()
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

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x001D5C60 File Offset: 0x001D3E60
		// (set) Token: 0x06006803 RID: 26627 RVA: 0x001D5C68 File Offset: 0x001D3E68
		[ProtoMember(1, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x001D5C74 File Offset: 0x001D3E74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x001D5C84 File Offset: 0x001D3E84
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

		// Token: 0x06006806 RID: 26630 RVA: 0x001D5D50 File Offset: 0x001D3F50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreFlushReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005029 RID: 20521
		private int _StoreId;

		// Token: 0x0400502A RID: 20522
		private IExtension extensionObject;

		// Token: 0x0400502B RID: 20523
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400502C RID: 20524
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400502D RID: 20525
		private LuaFunction m_ctor_hotfix;
	}
}
