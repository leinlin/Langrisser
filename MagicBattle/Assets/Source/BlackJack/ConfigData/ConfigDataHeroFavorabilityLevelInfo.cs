using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000247 RID: 583
	[ProtoContract(Name = "ConfigDataHeroFavorabilityLevelInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroFavorabilityLevelInfo : IExtensible
	{
		// Token: 0x0600241C RID: 9244 RVA: 0x000A6908 File Offset: 0x000A4B08
		public ConfigDataHeroFavorabilityLevelInfo()
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000A6970 File Offset: 0x000A4B70
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x000A6978 File Offset: 0x000A4B78
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000A6984 File Offset: 0x000A4B84
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x000A698C File Offset: 0x000A4B8C
		[ProtoMember(3, IsRequired = true, Name = "NextExp", DataFormat = DataFormat.TwosComplement)]
		public int NextExp
		{
			get
			{
				return this._NextExp;
			}
			set
			{
				this._NextExp = value;
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x000A6998 File Offset: 0x000A4B98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000A69A8 File Offset: 0x000A4BA8
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

		// Token: 0x06002423 RID: 9251 RVA: 0x000A6A74 File Offset: 0x000A4C74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroFavorabilityLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015F4 RID: 5620
		private int _ID;

		// Token: 0x040015F5 RID: 5621
		private int _NextExp;

		// Token: 0x040015F6 RID: 5622
		private IExtension extensionObject;

		// Token: 0x040015F7 RID: 5623
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015F8 RID: 5624
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015F9 RID: 5625
		private LuaFunction m_ctor_hotfix;
	}
}
