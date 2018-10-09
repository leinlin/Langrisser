using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AA RID: 682
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTrainingTechLevelInfo")]
	[Serializable]
	public class ConfigDataTrainingTechLevelInfo : IExtensible
	{
		// Token: 0x06002CB9 RID: 11449 RVA: 0x000B5CE0 File Offset: 0x000B3EE0
		public ConfigDataTrainingTechLevelInfo()
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000B5D54 File Offset: 0x000B3F54
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x000B5D5C File Offset: 0x000B3F5C
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000B5D68 File Offset: 0x000B3F68
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x000B5D70 File Offset: 0x000B3F70
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x000B5D84 File Offset: 0x000B3F84
		[ProtoMember(4, IsRequired = true, Name = "Description", DataFormat = DataFormat.Default)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000B5D90 File Offset: 0x000B3F90
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x000B5D98 File Offset: 0x000B3F98
		[ProtoMember(5, IsRequired = true, Name = "PreTechIDs", DataFormat = DataFormat.TwosComplement)]
		public int PreTechIDs
		{
			get
			{
				return this._PreTechIDs;
			}
			set
			{
				this._PreTechIDs = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x000B5DAC File Offset: 0x000B3FAC
		[ProtoMember(6, IsRequired = true, Name = "LevelupGoldCost", DataFormat = DataFormat.TwosComplement)]
		public int LevelupGoldCost
		{
			get
			{
				return this._LevelupGoldCost;
			}
			set
			{
				this._LevelupGoldCost = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		[ProtoMember(7, Name = "LevelupMaterialsCost", DataFormat = DataFormat.Default)]
		public List<Goods> LevelupMaterialsCost
		{
			get
			{
				return this._LevelupMaterialsCost;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000B5DC0 File Offset: 0x000B3FC0
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000B5DC8 File Offset: 0x000B3FC8
		[ProtoMember(8, IsRequired = true, Name = "RoomExp", DataFormat = DataFormat.TwosComplement)]
		public int RoomExp
		{
			get
			{
				return this._RoomExp;
			}
			set
			{
				this._RoomExp = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000B5DD4 File Offset: 0x000B3FD4
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x000B5DDC File Offset: 0x000B3FDC
		[ProtoMember(9, IsRequired = true, Name = "SoldierIDUnlocked", DataFormat = DataFormat.TwosComplement)]
		public int SoldierIDUnlocked
		{
			get
			{
				return this._SoldierIDUnlocked;
			}
			set
			{
				this._SoldierIDUnlocked = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000B5DE8 File Offset: 0x000B3FE8
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x000B5DF0 File Offset: 0x000B3FF0
		[ProtoMember(10, IsRequired = true, Name = "SoldierSkillLevelup", DataFormat = DataFormat.TwosComplement)]
		public int SoldierSkillLevelup
		{
			get
			{
				return this._SoldierSkillLevelup;
			}
			set
			{
				this._SoldierSkillLevelup = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000B5DFC File Offset: 0x000B3FFC
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x000B5E04 File Offset: 0x000B4004
		[ProtoMember(11, IsRequired = true, Name = "SoldierSkillID", DataFormat = DataFormat.TwosComplement)]
		public int SoldierSkillID
		{
			get
			{
				return this._SoldierSkillID;
			}
			set
			{
				this._SoldierSkillID = value;
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000B5E10 File Offset: 0x000B4010
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000B5E20 File Offset: 0x000B4020
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

		// Token: 0x06002CCF RID: 11471 RVA: 0x000B5EEC File Offset: 0x000B40EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTrainingTechLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B9E RID: 7070
		private int _ID;

		// Token: 0x04001B9F RID: 7071
		private string _Name;

		// Token: 0x04001BA0 RID: 7072
		private string _Description;

		// Token: 0x04001BA1 RID: 7073
		private int _PreTechIDs;

		// Token: 0x04001BA2 RID: 7074
		private int _LevelupGoldCost;

		// Token: 0x04001BA3 RID: 7075
		private readonly List<Goods> _LevelupMaterialsCost = new List<Goods>();

		// Token: 0x04001BA4 RID: 7076
		private int _RoomExp;

		// Token: 0x04001BA5 RID: 7077
		private int _SoldierIDUnlocked;

		// Token: 0x04001BA6 RID: 7078
		private int _SoldierSkillLevelup;

		// Token: 0x04001BA7 RID: 7079
		private int _SoldierSkillID;

		// Token: 0x04001BA8 RID: 7080
		private IExtension extensionObject;

		// Token: 0x04001BA9 RID: 7081
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BAA RID: 7082
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BAB RID: 7083
		private LuaFunction m_ctor_hotfix;
	}
}
