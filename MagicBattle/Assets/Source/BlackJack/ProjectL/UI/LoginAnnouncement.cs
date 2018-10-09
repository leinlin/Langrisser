using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E3A RID: 3642
	[HotFix]
	public class LoginAnnouncement
	{
		// Token: 0x06011A58 RID: 72280 RVA: 0x00490124 File Offset: 0x0048E324
		public LoginAnnouncement(LoginAnnouncement.AnnounceType type, string title, string content)
		{
			this.CurrentType = type;
			this.Title = title;
			this.Content = content;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorAnnounceTypeStringString_hotfix != null)
			{
				this.m_ctorAnnounceTypeStringString_hotfix.call(new object[]
				{
					this,
					type,
					title,
					content
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x06011A59 RID: 72281 RVA: 0x004901D0 File Offset: 0x0048E3D0
		// (set) Token: 0x06011A5A RID: 72282 RVA: 0x00490244 File Offset: 0x0048E444
		public string Title
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Title_hotfix != null)
				{
					return (string)this.m_get_Title_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_TitleString_hotfix != null)
				{
					this.m_set_TitleString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Title>k__BackingField = value;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x06011A5B RID: 72283 RVA: 0x004902BC File Offset: 0x0048E4BC
		// (set) Token: 0x06011A5C RID: 72284 RVA: 0x00490330 File Offset: 0x0048E530
		public string Content
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Content_hotfix != null)
				{
					return (string)this.m_get_Content_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Content>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ContentString_hotfix != null)
				{
					this.m_set_ContentString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Content>k__BackingField = value;
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x06011A5D RID: 72285 RVA: 0x004903A8 File Offset: 0x0048E5A8
		// (set) Token: 0x06011A5E RID: 72286 RVA: 0x0049041C File Offset: 0x0048E61C
		public LoginAnnouncement.AnnounceType CurrentType
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CurrentType_hotfix != null)
				{
					return (LoginAnnouncement.AnnounceType)this.m_get_CurrentType_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CurrentType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CurrentTypeAnnounceType_hotfix != null)
				{
					this.m_set_CurrentTypeAnnounceType_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CurrentType>k__BackingField = value;
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x06011A5F RID: 72287 RVA: 0x00490494 File Offset: 0x0048E694
		// (set) Token: 0x06011A60 RID: 72288 RVA: 0x004904B4 File Offset: 0x0048E6B4
		[DoNotToLua]
		public LoginAnnouncement.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LoginAnnouncement.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011A61 RID: 72289 RVA: 0x004904C0 File Offset: 0x0048E6C0
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
					this.m_ctorAnnounceTypeStringString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_get_Title_hotfix = (luaObj.RawGet("get_Title") as LuaFunction);
					this.m_set_TitleString_hotfix = (luaObj.RawGet("set_Title") as LuaFunction);
					this.m_get_Content_hotfix = (luaObj.RawGet("get_Content") as LuaFunction);
					this.m_set_ContentString_hotfix = (luaObj.RawGet("set_Content") as LuaFunction);
					this.m_get_CurrentType_hotfix = (luaObj.RawGet("get_CurrentType") as LuaFunction);
					this.m_set_CurrentTypeAnnounceType_hotfix = (luaObj.RawGet("set_CurrentType") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011A62 RID: 72290 RVA: 0x00490624 File Offset: 0x0048E824
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginAnnouncement));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A0AD RID: 41133
		[DoNotToLua]
		private LoginAnnouncement.LuaExportHelper luaExportHelper;

		// Token: 0x0400A0AE RID: 41134
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A0AF RID: 41135
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A0B0 RID: 41136
		private LuaFunction m_ctorAnnounceTypeStringString_hotfix;

		// Token: 0x0400A0B1 RID: 41137
		private LuaFunction m_get_Title_hotfix;

		// Token: 0x0400A0B2 RID: 41138
		private LuaFunction m_set_TitleString_hotfix;

		// Token: 0x0400A0B3 RID: 41139
		private LuaFunction m_get_Content_hotfix;

		// Token: 0x0400A0B4 RID: 41140
		private LuaFunction m_set_ContentString_hotfix;

		// Token: 0x0400A0B5 RID: 41141
		private LuaFunction m_get_CurrentType_hotfix;

		// Token: 0x0400A0B6 RID: 41142
		private LuaFunction m_set_CurrentTypeAnnounceType_hotfix;

		// Token: 0x02000E3B RID: 3643
		public enum AnnounceType
		{
			// Token: 0x0400A0B8 RID: 41144
			Notice = 1,
			// Token: 0x0400A0B9 RID: 41145
			Activity,
			// Token: 0x0400A0BA RID: 41146
			None
		}

		// Token: 0x02000E3C RID: 3644
		public class LuaExportHelper
		{
			// Token: 0x06011A63 RID: 72291 RVA: 0x0049068C File Offset: 0x0048E88C
			public LuaExportHelper(LoginAnnouncement owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400A0BB RID: 41147
			private LoginAnnouncement m_owner;
		}
	}
}
