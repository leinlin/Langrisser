using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FCD RID: 4045
	[HotFix]
	public class TreasureMapBackgroundActor : IFxEventListener
	{
		// Token: 0x060143D1 RID: 82897 RVA: 0x00525FB4 File Offset: 0x005241B4
		public TreasureMapBackgroundActor()
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

		// Token: 0x060143D2 RID: 82898 RVA: 0x0052601C File Offset: 0x0052421C
		public void Create(string name, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateStringGameObject_hotfix != null)
			{
				this.m_CreateStringGameObject_hotfix.call(new object[]
				{
					this,
					name,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_spineGraphic = new UISpineGraphic();
			this.m_spineGraphic.Create(name);
			this.m_spineGraphic.SetParent(parent);
			FxEvent component = parent.GetComponent<FxEvent>();
			if (component != null)
			{
				component.SetListener(this);
			}
		}

		// Token: 0x060143D3 RID: 82899 RVA: 0x005260DC File Offset: 0x005242DC
		public void Destroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Destroy_hotfix != null)
			{
				this.m_Destroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
		}

		// Token: 0x060143D4 RID: 82900 RVA: 0x0052615C File Offset: 0x0052435C
		public void OnSound(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoundFxEventString_hotfix != null)
			{
				this.m_OnSoundFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound(name);
		}

		// Token: 0x060143D5 RID: 82901 RVA: 0x005261E4 File Offset: 0x005243E4
		public void OnCameraEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCameraEffectFxEventString_hotfix != null)
			{
				this.m_OnCameraEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060143D6 RID: 82902 RVA: 0x00526264 File Offset: 0x00524464
		public void OnScreenEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScreenEffectFxEventString_hotfix != null)
			{
				this.m_OnScreenEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060143D7 RID: 82903 RVA: 0x005262E4 File Offset: 0x005244E4
		public void OnGeneral(FxEvent e, string cmd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGeneralFxEventString_hotfix != null)
			{
				this.m_OnGeneralFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					cmd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic == null)
			{
				return;
			}
			string name = string.Empty;
			bool loop = false;
			string[] array = cmd.Split(new char[]
			{
				','
			});
			if (array.Length > 0)
			{
				name = array[0];
			}
			if (array.Length > 1)
			{
				loop = (int.Parse(array[1]) != 0);
			}
			this.m_spineGraphic.PlayAnimation(name, loop, 0);
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x060143D8 RID: 82904 RVA: 0x005263C0 File Offset: 0x005245C0
		// (set) Token: 0x060143D9 RID: 82905 RVA: 0x005263E0 File Offset: 0x005245E0
		[DoNotToLua]
		public TreasureMapBackgroundActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureMapBackgroundActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060143DA RID: 82906 RVA: 0x005263EC File Offset: 0x005245EC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_CreateStringGameObject_hotfix = (luaObj.RawGet("Create") as LuaFunction);
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_OnSoundFxEventString_hotfix = (luaObj.RawGet("OnSound") as LuaFunction);
					this.m_OnCameraEffectFxEventString_hotfix = (luaObj.RawGet("OnCameraEffect") as LuaFunction);
					this.m_OnScreenEffectFxEventString_hotfix = (luaObj.RawGet("OnScreenEffect") as LuaFunction);
					this.m_OnGeneralFxEventString_hotfix = (luaObj.RawGet("OnGeneral") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060143DB RID: 82907 RVA: 0x00526550 File Offset: 0x00524750
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureMapBackgroundActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B298 RID: 45720
		private UISpineGraphic m_spineGraphic;

		// Token: 0x0400B299 RID: 45721
		[DoNotToLua]
		private TreasureMapBackgroundActor.LuaExportHelper luaExportHelper;

		// Token: 0x0400B29A RID: 45722
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B29B RID: 45723
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B29C RID: 45724
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400B29D RID: 45725
		private LuaFunction m_CreateStringGameObject_hotfix;

		// Token: 0x0400B29E RID: 45726
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x0400B29F RID: 45727
		private LuaFunction m_OnSoundFxEventString_hotfix;

		// Token: 0x0400B2A0 RID: 45728
		private LuaFunction m_OnCameraEffectFxEventString_hotfix;

		// Token: 0x0400B2A1 RID: 45729
		private LuaFunction m_OnScreenEffectFxEventString_hotfix;

		// Token: 0x0400B2A2 RID: 45730
		private LuaFunction m_OnGeneralFxEventString_hotfix;

		// Token: 0x02000FCE RID: 4046
		public class LuaExportHelper
		{
			// Token: 0x060143DC RID: 82908 RVA: 0x005265B8 File Offset: 0x005247B8
			public LuaExportHelper(TreasureMapBackgroundActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003C43 RID: 15427
			// (get) Token: 0x060143DD RID: 82909 RVA: 0x005265C8 File Offset: 0x005247C8
			// (set) Token: 0x060143DE RID: 82910 RVA: 0x005265D8 File Offset: 0x005247D8
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x0400B2A3 RID: 45731
			private TreasureMapBackgroundActor m_owner;
		}
	}
}
