using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A5 RID: 677
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataTowerLevelInfo")]
	[Serializable]
	public class ConfigDataTowerLevelInfo : IExtensible
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x000B51F0 File Offset: 0x000B33F0
		public ConfigDataTowerLevelInfo()
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

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x000B5264 File Offset: 0x000B3464
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x000B526C File Offset: 0x000B346C
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

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000B5278 File Offset: 0x000B3478
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x000B5280 File Offset: 0x000B3480
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000B528C File Offset: 0x000B348C
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x000B5294 File Offset: 0x000B3494
		[ProtoMember(4, IsRequired = true, Name = "LevelRes", DataFormat = DataFormat.Default)]
		public string LevelRes
		{
			get
			{
				return this._LevelRes;
			}
			set
			{
				this._LevelRes = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000B52A0 File Offset: 0x000B34A0
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x000B52A8 File Offset: 0x000B34A8
		[ProtoMember(5, IsRequired = true, Name = "ThumbImage", DataFormat = DataFormat.Default)]
		public string ThumbImage
		{
			get
			{
				return this._ThumbImage;
			}
			set
			{
				this._ThumbImage = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000B52B4 File Offset: 0x000B34B4
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x000B52BC File Offset: 0x000B34BC
		[ProtoMember(6, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battle_ID
		{
			get
			{
				return this._Battle_ID;
			}
			set
			{
				this._Battle_ID = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000B52C8 File Offset: 0x000B34C8
		[ProtoMember(7, Name = "BattleRuleList", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleRuleList
		{
			get
			{
				return this._BattleRuleList;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000B52D0 File Offset: 0x000B34D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x000B52E0 File Offset: 0x000B34E0
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x000B52E8 File Offset: 0x000B34E8
		public ConfigDataBattleInfo BattleInfo { get; set; }

		// Token: 0x06002C7D RID: 11389 RVA: 0x000B52F4 File Offset: 0x000B34F4
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

		// Token: 0x06002C7E RID: 11390 RVA: 0x000B53C0 File Offset: 0x000B35C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTowerLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B66 RID: 7014
		private int _ID;

		// Token: 0x04001B67 RID: 7015
		private string _Name;

		// Token: 0x04001B68 RID: 7016
		private string _LevelRes;

		// Token: 0x04001B69 RID: 7017
		private string _ThumbImage;

		// Token: 0x04001B6A RID: 7018
		private int _Battle_ID;

		// Token: 0x04001B6B RID: 7019
		private readonly List<int> _BattleRuleList = new List<int>();

		// Token: 0x04001B6C RID: 7020
		private IExtension extensionObject;

		// Token: 0x04001B6E RID: 7022
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B6F RID: 7023
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B70 RID: 7024
		private LuaFunction m_ctor_hotfix;
	}
}
