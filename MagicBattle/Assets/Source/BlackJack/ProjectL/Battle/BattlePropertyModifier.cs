using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003AD RID: 941
	[HotFix]
	public class BattlePropertyModifier
	{
		// Token: 0x06003726 RID: 14118 RVA: 0x000F690C File Offset: 0x000F4B0C
		public BattlePropertyModifier()
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

		// Token: 0x06003727 RID: 14119 RVA: 0x000F6980 File Offset: 0x000F4B80
		public int Get(PropertyModifyType t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPropertyModifyType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPropertyModifyType_hotfix.call(new object[]
				{
					this,
					t
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_values[(int)t];
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000F6A04 File Offset: 0x000F4C04
		public void Collect(PropertyModifyType t, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_CollectPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					t,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (t == PropertyModifyType.PropertyModifyType_None)
			{
				return;
			}
			this.m_values[(int)t] += value;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x000F6A9C File Offset: 0x000F4C9C
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_values.Length; i++)
			{
				this.m_values[i] = 0;
			}
			this.ExchangeAttack = (this.ExchangeDefense = (this.ExchangeMagic = (this.ExchangeMagicDefense = (this.ExchangeDexterity = (this.ExchangeHealthPointMax = 0)))));
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x000F6B54 File Offset: 0x000F4D54
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x000F6B74 File Offset: 0x000F4D74
		[DoNotToLua]
		public BattlePropertyModifier.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePropertyModifier.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x000F6B80 File Offset: 0x000F4D80
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
					this.m_GetPropertyModifyType_hotfix = (luaObj.RawGet("Get") as LuaFunction);
					this.m_CollectPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("Collect") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000F6C98 File Offset: 0x000F4E98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePropertyModifier));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A85 RID: 10885
		private int[] m_values = new int[110];

		// Token: 0x04002A86 RID: 10886
		public int ExchangeAttack;

		// Token: 0x04002A87 RID: 10887
		public int ExchangeDefense;

		// Token: 0x04002A88 RID: 10888
		public int ExchangeMagic;

		// Token: 0x04002A89 RID: 10889
		public int ExchangeMagicDefense;

		// Token: 0x04002A8A RID: 10890
		public int ExchangeDexterity;

		// Token: 0x04002A8B RID: 10891
		public int ExchangeHealthPointMax;

		// Token: 0x04002A8C RID: 10892
		[DoNotToLua]
		private BattlePropertyModifier.LuaExportHelper luaExportHelper;

		// Token: 0x04002A8D RID: 10893
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A8E RID: 10894
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A8F RID: 10895
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002A90 RID: 10896
		private LuaFunction m_GetPropertyModifyType_hotfix;

		// Token: 0x04002A91 RID: 10897
		private LuaFunction m_CollectPropertyModifyTypeInt32_hotfix;

		// Token: 0x04002A92 RID: 10898
		private LuaFunction m_Clear_hotfix;

		// Token: 0x020003AE RID: 942
		public class LuaExportHelper
		{
			// Token: 0x0600372E RID: 14126 RVA: 0x000F6D00 File Offset: 0x000F4F00
			public LuaExportHelper(BattlePropertyModifier owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F2E RID: 3886
			// (get) Token: 0x0600372F RID: 14127 RVA: 0x000F6D10 File Offset: 0x000F4F10
			// (set) Token: 0x06003730 RID: 14128 RVA: 0x000F6D20 File Offset: 0x000F4F20
			public int[] m_values
			{
				get
				{
					return this.m_owner.m_values;
				}
				set
				{
					this.m_owner.m_values = value;
				}
			}

			// Token: 0x04002A93 RID: 10899
			private BattlePropertyModifier m_owner;
		}
	}
}
