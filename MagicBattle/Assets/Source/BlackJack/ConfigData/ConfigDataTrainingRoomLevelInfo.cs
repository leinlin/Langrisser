using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A8 RID: 680
	[ProtoContract(Name = "ConfigDataTrainingRoomLevelInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataTrainingRoomLevelInfo : IExtensible
	{
		// Token: 0x06002C9A RID: 11418 RVA: 0x000B5860 File Offset: 0x000B3A60
		public ConfigDataTrainingRoomLevelInfo()
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000B58C8 File Offset: 0x000B3AC8
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x000B58D0 File Offset: 0x000B3AD0
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000B58DC File Offset: 0x000B3ADC
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x000B58E4 File Offset: 0x000B3AE4
		[ProtoMember(3, IsRequired = true, Name = "CurrentLevel", DataFormat = DataFormat.TwosComplement)]
		public int CurrentLevel
		{
			get
			{
				return this._CurrentLevel;
			}
			set
			{
				this._CurrentLevel = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000B58F0 File Offset: 0x000B3AF0
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x000B58F8 File Offset: 0x000B3AF8
		[ProtoMember(4, IsRequired = true, Name = "ExpToNextLevel", DataFormat = DataFormat.TwosComplement)]
		public int ExpToNextLevel
		{
			get
			{
				return this._ExpToNextLevel;
			}
			set
			{
				this._ExpToNextLevel = value;
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000B5904 File Offset: 0x000B3B04
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000B5914 File Offset: 0x000B3B14
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

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000B59E0 File Offset: 0x000B3BE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTrainingRoomLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B85 RID: 7045
		private int _ID;

		// Token: 0x04001B86 RID: 7046
		private int _CurrentLevel;

		// Token: 0x04001B87 RID: 7047
		private int _ExpToNextLevel;

		// Token: 0x04001B88 RID: 7048
		private IExtension extensionObject;

		// Token: 0x04001B89 RID: 7049
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B8A RID: 7050
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B8B RID: 7051
		private LuaFunction m_ctor_hotfix;
	}
}
