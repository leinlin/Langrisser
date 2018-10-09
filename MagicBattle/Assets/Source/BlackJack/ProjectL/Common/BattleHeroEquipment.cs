using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000361 RID: 865
	[HotFix]
	public class BattleHeroEquipment
	{
		// Token: 0x0600315B RID: 12635 RVA: 0x000C0D40 File Offset: 0x000BEF40
		public BattleHeroEquipment()
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x000C0E34 File Offset: 0x000BF034
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x000C0DB4 File Offset: 0x000BEFB4
		public int Id
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Id_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Id_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_id;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IdInt32_hotfix != null)
				{
					this.m_set_IdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_id = value;
				this.UpdateEquipmentInfo();
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x000C0EA8 File Offset: 0x000BF0A8
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x000C0F1C File Offset: 0x000BF11C
		public int Exp
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Exp_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Exp_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Exp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ExpInt32_hotfix != null)
				{
					this.m_set_ExpInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Exp>k__BackingField = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000C0F94 File Offset: 0x000BF194
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x000C1008 File Offset: 0x000BF208
		public int Level
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Level_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Level_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Level>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_LevelInt32_hotfix != null)
				{
					this.m_set_LevelInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Level>k__BackingField = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x000C1080 File Offset: 0x000BF280
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x000C10F4 File Offset: 0x000BF2F4
		public int StarLevel
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_StarLevel_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_StarLevel_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<StarLevel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_StarLevelInt32_hotfix != null)
				{
					this.m_set_StarLevelInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<StarLevel>k__BackingField = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x000C116C File Offset: 0x000BF36C
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x000C11E0 File Offset: 0x000BF3E0
		public int ResonanceId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ResonanceId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ResonanceId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ResonanceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ResonanceIdInt32_hotfix != null)
				{
					this.m_set_ResonanceIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ResonanceId>k__BackingField = value;
			}
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000C1258 File Offset: 0x000BF458
		public static ProBattleHeroEquipment BattleHeroEquipmentToPBBattleHeroEquipment(BattleHeroEquipment equipment)
		{
			ProBattleHeroEquipment proBattleHeroEquipment = new ProBattleHeroEquipment
			{
				Id = equipment.Id,
				Level = equipment.Level,
				StarLevel = equipment.StarLevel,
				Exp = equipment.Exp,
				ResonanceId = equipment.ResonanceId
			};
			foreach (CommonBattleProperty property in equipment.EnchantProperties)
			{
				proBattleHeroEquipment.EnchantProperties.Add(CommonBattleProperty.CommonBattlePropertyToPBCommonBattleProperty(property));
			}
			return proBattleHeroEquipment;
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000C1304 File Offset: 0x000BF504
		public static BattleHeroEquipment PBBattleHeroEquipmentToBattleHeroEquipment(ProBattleHeroEquipment pbEquipment)
		{
			BattleHeroEquipment battleHeroEquipment = new BattleHeroEquipment
			{
				Id = pbEquipment.Id,
				Level = pbEquipment.Level,
				StarLevel = pbEquipment.StarLevel,
				Exp = pbEquipment.Exp,
				ResonanceId = pbEquipment.ResonanceId
			};
			foreach (ProCommonBattleProperty pbProperty in pbEquipment.EnchantProperties)
			{
				battleHeroEquipment.EnchantProperties.Add(CommonBattleProperty.PBCommonBattlePropertyToCommonBattleProperty(pbProperty));
			}
			return battleHeroEquipment;
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000C13B0 File Offset: 0x000BF5B0
		private void UpdateEquipmentInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateEquipmentInfo_hotfix != null)
			{
				this.m_UpdateEquipmentInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.EquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(this.Id);
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x000C14AC File Offset: 0x000BF6AC
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x000C1434 File Offset: 0x000BF634
		public ConfigDataEquipmentInfo EquipmentInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EquipmentInfo_hotfix != null)
				{
					return (ConfigDataEquipmentInfo)this.m_get_EquipmentInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<EquipmentInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EquipmentInfoConfigDataEquipmentInfo_hotfix != null)
				{
					this.m_set_EquipmentInfoConfigDataEquipmentInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<EquipmentInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000C1520 File Offset: 0x000BF720
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x000C1540 File Offset: 0x000BF740
		[DoNotToLua]
		public BattleHeroEquipment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleHeroEquipment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000C154C File Offset: 0x000BF74C
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
					this.m_set_IdInt32_hotfix = (luaObj.RawGet("set_Id") as LuaFunction);
					this.m_get_Id_hotfix = (luaObj.RawGet("get_Id") as LuaFunction);
					this.m_get_Exp_hotfix = (luaObj.RawGet("get_Exp") as LuaFunction);
					this.m_set_ExpInt32_hotfix = (luaObj.RawGet("set_Exp") as LuaFunction);
					this.m_get_Level_hotfix = (luaObj.RawGet("get_Level") as LuaFunction);
					this.m_set_LevelInt32_hotfix = (luaObj.RawGet("set_Level") as LuaFunction);
					this.m_get_StarLevel_hotfix = (luaObj.RawGet("get_StarLevel") as LuaFunction);
					this.m_set_StarLevelInt32_hotfix = (luaObj.RawGet("set_StarLevel") as LuaFunction);
					this.m_get_ResonanceId_hotfix = (luaObj.RawGet("get_ResonanceId") as LuaFunction);
					this.m_set_ResonanceIdInt32_hotfix = (luaObj.RawGet("set_ResonanceId") as LuaFunction);
					this.m_UpdateEquipmentInfo_hotfix = (luaObj.RawGet("UpdateEquipmentInfo") as LuaFunction);
					this.m_set_EquipmentInfoConfigDataEquipmentInfo_hotfix = (luaObj.RawGet("set_EquipmentInfo") as LuaFunction);
					this.m_get_EquipmentInfo_hotfix = (luaObj.RawGet("get_EquipmentInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000C175C File Offset: 0x000BF95C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleHeroEquipment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040025ED RID: 9709
		private int m_id;

		// Token: 0x040025F1 RID: 9713
		public List<CommonBattleProperty> EnchantProperties = new List<CommonBattleProperty>();

		// Token: 0x040025F4 RID: 9716
		[DoNotToLua]
		private BattleHeroEquipment.LuaExportHelper luaExportHelper;

		// Token: 0x040025F5 RID: 9717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040025F6 RID: 9718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040025F7 RID: 9719
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040025F8 RID: 9720
		private LuaFunction m_set_IdInt32_hotfix;

		// Token: 0x040025F9 RID: 9721
		private LuaFunction m_get_Id_hotfix;

		// Token: 0x040025FA RID: 9722
		private LuaFunction m_get_Exp_hotfix;

		// Token: 0x040025FB RID: 9723
		private LuaFunction m_set_ExpInt32_hotfix;

		// Token: 0x040025FC RID: 9724
		private LuaFunction m_get_Level_hotfix;

		// Token: 0x040025FD RID: 9725
		private LuaFunction m_set_LevelInt32_hotfix;

		// Token: 0x040025FE RID: 9726
		private LuaFunction m_get_StarLevel_hotfix;

		// Token: 0x040025FF RID: 9727
		private LuaFunction m_set_StarLevelInt32_hotfix;

		// Token: 0x04002600 RID: 9728
		private LuaFunction m_get_ResonanceId_hotfix;

		// Token: 0x04002601 RID: 9729
		private LuaFunction m_set_ResonanceIdInt32_hotfix;

		// Token: 0x04002602 RID: 9730
		private LuaFunction m_UpdateEquipmentInfo_hotfix;

		// Token: 0x04002603 RID: 9731
		private LuaFunction m_set_EquipmentInfoConfigDataEquipmentInfo_hotfix;

		// Token: 0x04002604 RID: 9732
		private LuaFunction m_get_EquipmentInfo_hotfix;

		// Token: 0x02000362 RID: 866
		public class LuaExportHelper
		{
			// Token: 0x0600316F RID: 12655 RVA: 0x000C17C4 File Offset: 0x000BF9C4
			public LuaExportHelper(BattleHeroEquipment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000E1C RID: 3612
			// (get) Token: 0x06003170 RID: 12656 RVA: 0x000C17D4 File Offset: 0x000BF9D4
			// (set) Token: 0x06003171 RID: 12657 RVA: 0x000C17E4 File Offset: 0x000BF9E4
			public int m_id
			{
				get
				{
					return this.m_owner.m_id;
				}
				set
				{
					this.m_owner.m_id = value;
				}
			}

			// Token: 0x17000E1D RID: 3613
			// (set) Token: 0x06003172 RID: 12658 RVA: 0x000C17F4 File Offset: 0x000BF9F4
			public ConfigDataEquipmentInfo EquipmentInfo
			{
				set
				{
					this.m_owner.EquipmentInfo = value;
				}
			}

			// Token: 0x06003173 RID: 12659 RVA: 0x000C1804 File Offset: 0x000BFA04
			public void UpdateEquipmentInfo()
			{
				this.m_owner.UpdateEquipmentInfo();
			}

			// Token: 0x04002605 RID: 9733
			private BattleHeroEquipment m_owner;
		}
	}
}
