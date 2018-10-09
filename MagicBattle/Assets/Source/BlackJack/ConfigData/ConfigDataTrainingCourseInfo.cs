using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A6 RID: 678
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTrainingCourseInfo")]
	[Serializable]
	public class ConfigDataTrainingCourseInfo : IExtensible
	{
		// Token: 0x06002C7F RID: 11391 RVA: 0x000B5428 File Offset: 0x000B3628
		public ConfigDataTrainingCourseInfo()
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000B54A4 File Offset: 0x000B36A4
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x000B54AC File Offset: 0x000B36AC
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000B54B8 File Offset: 0x000B36B8
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x000B54C0 File Offset: 0x000B36C0
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

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000B54CC File Offset: 0x000B36CC
		[ProtoMember(4, Name = "Resource", DataFormat = DataFormat.Default)]
		public List<string> Resource
		{
			get
			{
				return this._Resource;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x000B54D4 File Offset: 0x000B36D4
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x000B54DC File Offset: 0x000B36DC
		[ProtoMember(5, IsRequired = true, Name = "RoomID", DataFormat = DataFormat.TwosComplement)]
		public int RoomID
		{
			get
			{
				return this._RoomID;
			}
			set
			{
				this._RoomID = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000B54E8 File Offset: 0x000B36E8
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x000B54F0 File Offset: 0x000B36F0
		[ProtoMember(6, IsRequired = true, Name = "RoomLevel", DataFormat = DataFormat.TwosComplement)]
		public int RoomLevel
		{
			get
			{
				return this._RoomLevel;
			}
			set
			{
				this._RoomLevel = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x000B54FC File Offset: 0x000B36FC
		[ProtoMember(7, Name = "Techs", DataFormat = DataFormat.TwosComplement)]
		public List<int> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000B5504 File Offset: 0x000B3704
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x000B550C File Offset: 0x000B370C
		[ProtoMember(8, IsRequired = true, Name = "SkillTreeName", DataFormat = DataFormat.Default)]
		public string SkillTreeName
		{
			get
			{
				return this._SkillTreeName;
			}
			set
			{
				this._SkillTreeName = value;
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000B5518 File Offset: 0x000B3718
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000B5528 File Offset: 0x000B3728
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

		// Token: 0x06002C8E RID: 11406 RVA: 0x000B55F4 File Offset: 0x000B37F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTrainingCourseInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B71 RID: 7025
		private int _ID;

		// Token: 0x04001B72 RID: 7026
		private string _Name;

		// Token: 0x04001B73 RID: 7027
		private readonly List<string> _Resource = new List<string>();

		// Token: 0x04001B74 RID: 7028
		private int _RoomID;

		// Token: 0x04001B75 RID: 7029
		private int _RoomLevel;

		// Token: 0x04001B76 RID: 7030
		private readonly List<int> _Techs = new List<int>();

		// Token: 0x04001B77 RID: 7031
		private string _SkillTreeName;

		// Token: 0x04001B78 RID: 7032
		private IExtension extensionObject;

		// Token: 0x04001B79 RID: 7033
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B7A RID: 7034
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B7B RID: 7035
		private LuaFunction m_ctor_hotfix;
	}
}
