using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200037D RID: 893
	[HotFix]
	public class BattleActorEquipment
	{
		// Token: 0x06003466 RID: 13414 RVA: 0x000DEB18 File Offset: 0x000DCD18
		public BattleActorEquipment()
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

		// Token: 0x06003467 RID: 13415 RVA: 0x000DEB80 File Offset: 0x000DCD80
		public int GetActiveSkillId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActiveSkillId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetActiveSkillId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.EquipmentInfo.GetActiveSkillId(this.Level);
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x000DEC00 File Offset: 0x000DCE00
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x000DEC20 File Offset: 0x000DCE20
		[DoNotToLua]
		public BattleActorEquipment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleActorEquipment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x000DEC2C File Offset: 0x000DCE2C
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
					this.m_GetActiveSkillId_hotfix = (luaObj.RawGet("GetActiveSkillId") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000DED10 File Offset: 0x000DCF10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleActorEquipment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002809 RID: 10249
		public ConfigDataEquipmentInfo EquipmentInfo;

		// Token: 0x0400280A RID: 10250
		public int Level;

		// Token: 0x0400280B RID: 10251
		public CommonBattleProperty[] EnchantProperties;

		// Token: 0x0400280C RID: 10252
		[DoNotToLua]
		private BattleActorEquipment.LuaExportHelper luaExportHelper;

		// Token: 0x0400280D RID: 10253
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400280E RID: 10254
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400280F RID: 10255
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002810 RID: 10256
		private LuaFunction m_GetActiveSkillId_hotfix;

		// Token: 0x0200037E RID: 894
		public class LuaExportHelper
		{
			// Token: 0x0600346C RID: 13420 RVA: 0x000DED78 File Offset: 0x000DCF78
			public LuaExportHelper(BattleActorEquipment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002811 RID: 10257
			private BattleActorEquipment m_owner;
		}
	}
}
