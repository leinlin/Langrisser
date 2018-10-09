using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A9 RID: 681
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTrainingTechInfo")]
	[Serializable]
	public class ConfigDataTrainingTechInfo : IExtensible
	{
		// Token: 0x06002CA4 RID: 11428 RVA: 0x000B5A48 File Offset: 0x000B3C48
		public ConfigDataTrainingTechInfo()
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000B5AFC File Offset: 0x000B3CFC
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x000B5B04 File Offset: 0x000B3D04
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000B5B10 File Offset: 0x000B3D10
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x000B5B18 File Offset: 0x000B3D18
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000B5B24 File Offset: 0x000B3D24
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x000B5B2C File Offset: 0x000B3D2C
		[ProtoMember(4, IsRequired = true, Name = "Resource", DataFormat = DataFormat.Default)]
		public string Resource
		{
			get
			{
				return this._Resource;
			}
			set
			{
				this._Resource = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000B5B38 File Offset: 0x000B3D38
		[ProtoMember(5, Name = "PreTechIDs", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreTechIDs
		{
			get
			{
				return this._PreTechIDs;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000B5B40 File Offset: 0x000B3D40
		[ProtoMember(6, Name = "PreTechLevel", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreTechLevel
		{
			get
			{
				return this._PreTechLevel;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000B5B48 File Offset: 0x000B3D48
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x000B5B50 File Offset: 0x000B3D50
		[ProtoMember(7, IsRequired = true, Name = "RoomLevelRequired", DataFormat = DataFormat.TwosComplement)]
		public int RoomLevelRequired
		{
			get
			{
				return this._RoomLevelRequired;
			}
			set
			{
				this._RoomLevelRequired = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000B5B5C File Offset: 0x000B3D5C
		[ProtoMember(8, Name = "SoldierIDRelated", DataFormat = DataFormat.TwosComplement)]
		public List<int> SoldierIDRelated
		{
			get
			{
				return this._SoldierIDRelated;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000B5B64 File Offset: 0x000B3D64
		[ProtoMember(9, Name = "ArmyIDRelated", DataFormat = DataFormat.TwosComplement)]
		public List<int> ArmyIDRelated
		{
			get
			{
				return this._ArmyIDRelated;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000B5B6C File Offset: 0x000B3D6C
		// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x000B5B74 File Offset: 0x000B3D74
		[ProtoMember(10, IsRequired = true, Name = "IsSummon", DataFormat = DataFormat.Default)]
		public bool IsSummon
		{
			get
			{
				return this._IsSummon;
			}
			set
			{
				this._IsSummon = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000B5B80 File Offset: 0x000B3D80
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x000B5B88 File Offset: 0x000B3D88
		[ProtoMember(11, IsRequired = true, Name = "TechType", DataFormat = DataFormat.TwosComplement)]
		public TechDisplayType TechType
		{
			get
			{
				return this._TechType;
			}
			set
			{
				this._TechType = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000B5B94 File Offset: 0x000B3D94
		[ProtoMember(12, Name = "TechLevelupInfoList", DataFormat = DataFormat.TwosComplement)]
		public List<int> TechLevelupInfoList
		{
			get
			{
				return this._TechLevelupInfoList;
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000B5B9C File Offset: 0x000B3D9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000B5BAC File Offset: 0x000B3DAC
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

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000B5C78 File Offset: 0x000B3E78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTrainingTechInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B8C RID: 7052
		private int _ID;

		// Token: 0x04001B8D RID: 7053
		private string _Name;

		// Token: 0x04001B8E RID: 7054
		private string _Resource;

		// Token: 0x04001B8F RID: 7055
		private readonly List<int> _PreTechIDs = new List<int>();

		// Token: 0x04001B90 RID: 7056
		private readonly List<int> _PreTechLevel = new List<int>();

		// Token: 0x04001B91 RID: 7057
		private int _RoomLevelRequired;

		// Token: 0x04001B92 RID: 7058
		private readonly List<int> _SoldierIDRelated = new List<int>();

		// Token: 0x04001B93 RID: 7059
		private readonly List<int> _ArmyIDRelated = new List<int>();

		// Token: 0x04001B94 RID: 7060
		private bool _IsSummon;

		// Token: 0x04001B95 RID: 7061
		private TechDisplayType _TechType;

		// Token: 0x04001B96 RID: 7062
		private readonly List<int> _TechLevelupInfoList = new List<int>();

		// Token: 0x04001B97 RID: 7063
		private IExtension extensionObject;

		// Token: 0x04001B98 RID: 7064
		public List<ConfigDataTrainingTechLevelInfo> m_techLevelupInfo = new List<ConfigDataTrainingTechLevelInfo>();

		// Token: 0x04001B99 RID: 7065
		public List<TrainingTechInfo> m_Infos = new List<TrainingTechInfo>();

		// Token: 0x04001B9A RID: 7066
		public int m_courseId;

		// Token: 0x04001B9B RID: 7067
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B9C RID: 7068
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B9D RID: 7069
		private LuaFunction m_ctor_hotfix;
	}
}
