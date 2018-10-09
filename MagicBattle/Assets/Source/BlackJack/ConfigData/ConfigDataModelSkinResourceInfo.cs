using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000262 RID: 610
	[ProtoContract(Name = "ConfigDataModelSkinResourceInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataModelSkinResourceInfo : IExtensible
	{
		// Token: 0x06002720 RID: 10016 RVA: 0x000AB334 File Offset: 0x000A9534
		public ConfigDataModelSkinResourceInfo()
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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000AB39C File Offset: 0x000A959C
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x000AB3A4 File Offset: 0x000A95A4
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000AB3B0 File Offset: 0x000A95B0
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x000AB3B8 File Offset: 0x000A95B8
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

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000AB3C4 File Offset: 0x000A95C4
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x000AB3CC File Offset: 0x000A95CC
		[ProtoMember(4, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000AB3D8 File Offset: 0x000A95D8
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000AB3E0 File Offset: 0x000A95E0
		[ProtoMember(5, IsRequired = true, Name = "CombatModel", DataFormat = DataFormat.Default)]
		public string CombatModel
		{
			get
			{
				return this._CombatModel;
			}
			set
			{
				this._CombatModel = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000AB3EC File Offset: 0x000A95EC
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x000AB3F4 File Offset: 0x000A95F4
		[ProtoMember(6, IsRequired = true, Name = "MeleeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int MeleeATK_ID
		{
			get
			{
				return this._MeleeATK_ID;
			}
			set
			{
				this._MeleeATK_ID = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000AB400 File Offset: 0x000A9600
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x000AB408 File Offset: 0x000A9608
		[ProtoMember(7, IsRequired = true, Name = "RangeATK_ID", DataFormat = DataFormat.TwosComplement)]
		public int RangeATK_ID
		{
			get
			{
				return this._RangeATK_ID;
			}
			set
			{
				this._RangeATK_ID = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000AB414 File Offset: 0x000A9614
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x000AB41C File Offset: 0x000A961C
		[ProtoMember(8, IsRequired = true, Name = "Skill_ID", DataFormat = DataFormat.TwosComplement)]
		public int Skill_ID
		{
			get
			{
				return this._Skill_ID;
			}
			set
			{
				this._Skill_ID = value;
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000AB428 File Offset: 0x000A9628
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000AB438 File Offset: 0x000A9638
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

		// Token: 0x06002731 RID: 10033 RVA: 0x000AB504 File Offset: 0x000A9704
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataModelSkinResourceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017F1 RID: 6129
		private int _ID;

		// Token: 0x040017F2 RID: 6130
		private string _Name;

		// Token: 0x040017F3 RID: 6131
		private string _Model;

		// Token: 0x040017F4 RID: 6132
		private string _CombatModel;

		// Token: 0x040017F5 RID: 6133
		private int _MeleeATK_ID;

		// Token: 0x040017F6 RID: 6134
		private int _RangeATK_ID;

		// Token: 0x040017F7 RID: 6135
		private int _Skill_ID;

		// Token: 0x040017F8 RID: 6136
		private IExtension extensionObject;

		// Token: 0x040017F9 RID: 6137
		public ConfigDataSkillInfo m_meleeSkillInfo;

		// Token: 0x040017FA RID: 6138
		public ConfigDataSkillInfo m_rangeSkillInfo;

		// Token: 0x040017FB RID: 6139
		public ConfigDataSkillInfo m_skinSkillInfo;

		// Token: 0x040017FC RID: 6140
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017FD RID: 6141
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017FE RID: 6142
		private LuaFunction m_ctor_hotfix;
	}
}
