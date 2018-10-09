using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A7 RID: 679
	[ProtoContract(Name = "ConfigDataTrainingRoomInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataTrainingRoomInfo : IExtensible
	{
		// Token: 0x06002C8F RID: 11407 RVA: 0x000B565C File Offset: 0x000B385C
		public ConfigDataTrainingRoomInfo()
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

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000B56D8 File Offset: 0x000B38D8
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x000B56E0 File Offset: 0x000B38E0
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x000B56EC File Offset: 0x000B38EC
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x000B56F4 File Offset: 0x000B38F4
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

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000B5700 File Offset: 0x000B3900
		[ProtoMember(4, Name = "SoldierType", DataFormat = DataFormat.TwosComplement)]
		public List<int> SoldierType
		{
			get
			{
				return this._SoldierType;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000B5708 File Offset: 0x000B3908
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x000B5710 File Offset: 0x000B3910
		[ProtoMember(5, IsRequired = true, Name = "LevelToUnlock", DataFormat = DataFormat.TwosComplement)]
		public int LevelToUnlock
		{
			get
			{
				return this._LevelToUnlock;
			}
			set
			{
				this._LevelToUnlock = value;
			}
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x000B571C File Offset: 0x000B391C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000B572C File Offset: 0x000B392C
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

		// Token: 0x06002C99 RID: 11417 RVA: 0x000B57F8 File Offset: 0x000B39F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTrainingRoomInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B7C RID: 7036
		private int _ID;

		// Token: 0x04001B7D RID: 7037
		private string _Name;

		// Token: 0x04001B7E RID: 7038
		private readonly List<int> _SoldierType = new List<int>();

		// Token: 0x04001B7F RID: 7039
		private int _LevelToUnlock;

		// Token: 0x04001B80 RID: 7040
		private IExtension extensionObject;

		// Token: 0x04001B81 RID: 7041
		public List<int> m_totalLevelupExpSteps = new List<int>();

		// Token: 0x04001B82 RID: 7042
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B83 RID: 7043
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B84 RID: 7044
		private LuaFunction m_ctor_hotfix;
	}
}
