using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200090F RID: 2319
	[HotFix]
	public class GmCommand
	{
		// Token: 0x06008660 RID: 34400 RVA: 0x00269178 File Offset: 0x00267378
		public GmCommand()
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

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06008661 RID: 34401 RVA: 0x002691E0 File Offset: 0x002673E0
		// (set) Token: 0x06008662 RID: 34402 RVA: 0x00269200 File Offset: 0x00267400
		[DoNotToLua]
		public GmCommand.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GmCommand.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x0026920C File Offset: 0x0026740C
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

		// Token: 0x06008664 RID: 34404 RVA: 0x002692D8 File Offset: 0x002674D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GmCommand));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005F57 RID: 24407
		public const string AddItem = "ADD_ITEM";

		// Token: 0x04005F58 RID: 24408
		public const string RemoveItem = "REMOVE_ITEM";

		// Token: 0x04005F59 RID: 24409
		public const string ClearBag = "CLEAR_BAG";

		// Token: 0x04005F5A RID: 24410
		public const string AddHero = "ADD_HERO";

		// Token: 0x04005F5B RID: 24411
		public const string SendTemplateMail = "POST_TEMPLATEMAIL";

		// Token: 0x04005F5C RID: 24412
		public const string CleanUserGuide = "CLEAN_USER_GUIDE";

		// Token: 0x04005F5D RID: 24413
		public const string AddActivity = "POST_GLOBALOPERATIONALACTIVITY";

		// Token: 0x04005F5E RID: 24414
		public const string BattleCheat = "BATTLE_CHEAT";

		// Token: 0x04005F5F RID: 24415
		public const string MaxTrainingTechs = "SET_MAXTRAININGTECHS";

		// Token: 0x04005F60 RID: 24416
		public const string LevelUpHeroFetter = "LevelUpHeroFetter";

		// Token: 0x04005F61 RID: 24417
		[DoNotToLua]
		private GmCommand.LuaExportHelper luaExportHelper;

		// Token: 0x04005F62 RID: 24418
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005F63 RID: 24419
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005F64 RID: 24420
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000910 RID: 2320
		public class LuaExportHelper
		{
			// Token: 0x06008665 RID: 34405 RVA: 0x00269340 File Offset: 0x00267540
			public LuaExportHelper(GmCommand owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04005F65 RID: 24421
			private GmCommand m_owner;
		}
	}
}
