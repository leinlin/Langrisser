using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A3 RID: 675
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTowerBonusHeroGroupInfo")]
	[Serializable]
	public class ConfigDataTowerBonusHeroGroupInfo : IExtensible
	{
		// Token: 0x06002C4C RID: 11340 RVA: 0x000B4D70 File Offset: 0x000B2F70
		public ConfigDataTowerBonusHeroGroupInfo()
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000B4DE4 File Offset: 0x000B2FE4
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x000B4DEC File Offset: 0x000B2FEC
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

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
		[ProtoMember(3, Name = "BonusHeroIdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> BonusHeroIdList
		{
			get
			{
				return this._BonusHeroIdList;
			}
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x000B4E00 File Offset: 0x000B3000
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x000B4E10 File Offset: 0x000B3010
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

		// Token: 0x06002C52 RID: 11346 RVA: 0x000B4EDC File Offset: 0x000B30DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTowerBonusHeroGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B4F RID: 6991
		private int _ID;

		// Token: 0x04001B50 RID: 6992
		private readonly List<int> _BonusHeroIdList = new List<int>();

		// Token: 0x04001B51 RID: 6993
		private IExtension extensionObject;

		// Token: 0x04001B52 RID: 6994
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B53 RID: 6995
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B54 RID: 6996
		private LuaFunction m_ctor_hotfix;
	}
}
