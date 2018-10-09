using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A2 RID: 674
	[ProtoContract(Name = "ConfigDataTowerBattleRuleInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataTowerBattleRuleInfo : IExtensible
	{
		// Token: 0x06002C3E RID: 11326 RVA: 0x000B4B60 File Offset: 0x000B2D60
		public ConfigDataTowerBattleRuleInfo()
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000B4BC8 File Offset: 0x000B2DC8
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x000B4BD0 File Offset: 0x000B2DD0
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

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000B4BDC File Offset: 0x000B2DDC
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x000B4BE4 File Offset: 0x000B2DE4
		[ProtoMember(3, IsRequired = true, Name = "Skill_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000B4BF0 File Offset: 0x000B2DF0
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x000B4BF8 File Offset: 0x000B2DF8
		[ProtoMember(4, IsRequired = true, Name = "Target", DataFormat = DataFormat.TwosComplement)]
		public int Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				this._Target = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000B4C04 File Offset: 0x000B2E04
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x000B4C0C File Offset: 0x000B2E0C
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000B4C18 File Offset: 0x000B2E18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x000B4C28 File Offset: 0x000B2E28
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x000B4C30 File Offset: 0x000B2E30
		public ConfigDataSkillInfo SkillInfo { get; set; }

		// Token: 0x06002C4A RID: 11338 RVA: 0x000B4C3C File Offset: 0x000B2E3C
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

		// Token: 0x06002C4B RID: 11339 RVA: 0x000B4D08 File Offset: 0x000B2F08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTowerBattleRuleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B46 RID: 6982
		private int _ID;

		// Token: 0x04001B47 RID: 6983
		private int _Skill_ID;

		// Token: 0x04001B48 RID: 6984
		private int _Target;

		// Token: 0x04001B49 RID: 6985
		private string _Desc;

		// Token: 0x04001B4A RID: 6986
		private IExtension extensionObject;

		// Token: 0x04001B4C RID: 6988
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B4D RID: 6989
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B4E RID: 6990
		private LuaFunction m_ctor_hotfix;
	}
}
