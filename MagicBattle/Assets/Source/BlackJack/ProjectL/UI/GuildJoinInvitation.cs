using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CF1 RID: 3313
	[HotFix]
	public class GuildJoinInvitation
	{
		// Token: 0x0600F29A RID: 62106 RVA: 0x00405F08 File Offset: 0x00404108
		public GuildJoinInvitation()
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

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600F29B RID: 62107 RVA: 0x00405F70 File Offset: 0x00404170
		// (set) Token: 0x0600F29C RID: 62108 RVA: 0x00405FE4 File Offset: 0x004041E4
		public string GuildId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GuildId_hotfix != null)
				{
					return (string)this.m_get_GuildId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<GuildId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GuildIdString_hotfix != null)
				{
					this.m_set_GuildIdString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<GuildId>k__BackingField = value;
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600F29D RID: 62109 RVA: 0x0040605C File Offset: 0x0040425C
		// (set) Token: 0x0600F29E RID: 62110 RVA: 0x004060D0 File Offset: 0x004042D0
		public string GuildName
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GuildName_hotfix != null)
				{
					return (string)this.m_get_GuildName_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<GuildName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GuildNameString_hotfix != null)
				{
					this.m_set_GuildNameString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<GuildName>k__BackingField = value;
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600F29F RID: 62111 RVA: 0x00406148 File Offset: 0x00404348
		// (set) Token: 0x0600F2A0 RID: 62112 RVA: 0x004061BC File Offset: 0x004043BC
		public int HeadIcon
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeadIcon_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeadIcon_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeadIcon>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeadIconInt32_hotfix != null)
				{
					this.m_set_HeadIconInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeadIcon>k__BackingField = value;
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600F2A1 RID: 62113 RVA: 0x00406234 File Offset: 0x00404434
		// (set) Token: 0x0600F2A2 RID: 62114 RVA: 0x004062A8 File Offset: 0x004044A8
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

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600F2A3 RID: 62115 RVA: 0x00406320 File Offset: 0x00404520
		// (set) Token: 0x0600F2A4 RID: 62116 RVA: 0x00406394 File Offset: 0x00404594
		public string Name
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Name_hotfix != null)
				{
					return (string)this.m_get_Name_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_NameString_hotfix != null)
				{
					this.m_set_NameString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x0600F2A5 RID: 62117 RVA: 0x0040640C File Offset: 0x0040460C
		public static GuildJoinInvitation FromPb(ProGuildJoinInvitation pb)
		{
			return new GuildJoinInvitation
			{
				GuildId = pb.GuildId,
				GuildName = pb.GuildName,
				HeadIcon = pb.HeadIcon,
				Level = pb.Level,
				Name = pb.Name
			};
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600F2A6 RID: 62118 RVA: 0x00406460 File Offset: 0x00404660
		// (set) Token: 0x0600F2A7 RID: 62119 RVA: 0x00406480 File Offset: 0x00404680
		[DoNotToLua]
		public GuildJoinInvitation.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildJoinInvitation.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F2A8 RID: 62120 RVA: 0x0040648C File Offset: 0x0040468C
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
					this.m_get_GuildId_hotfix = (luaObj.RawGet("get_GuildId") as LuaFunction);
					this.m_set_GuildIdString_hotfix = (luaObj.RawGet("set_GuildId") as LuaFunction);
					this.m_get_GuildName_hotfix = (luaObj.RawGet("get_GuildName") as LuaFunction);
					this.m_set_GuildNameString_hotfix = (luaObj.RawGet("set_GuildName") as LuaFunction);
					this.m_get_HeadIcon_hotfix = (luaObj.RawGet("get_HeadIcon") as LuaFunction);
					this.m_set_HeadIconInt32_hotfix = (luaObj.RawGet("set_HeadIcon") as LuaFunction);
					this.m_get_Level_hotfix = (luaObj.RawGet("get_Level") as LuaFunction);
					this.m_set_LevelInt32_hotfix = (luaObj.RawGet("set_Level") as LuaFunction);
					this.m_get_Name_hotfix = (luaObj.RawGet("get_Name") as LuaFunction);
					this.m_set_NameString_hotfix = (luaObj.RawGet("set_Name") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F2A9 RID: 62121 RVA: 0x00406654 File Offset: 0x00404854
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitation));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008FE2 RID: 36834
		[DoNotToLua]
		private GuildJoinInvitation.LuaExportHelper luaExportHelper;

		// Token: 0x04008FE3 RID: 36835
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008FE4 RID: 36836
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008FE5 RID: 36837
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04008FE6 RID: 36838
		private LuaFunction m_get_GuildId_hotfix;

		// Token: 0x04008FE7 RID: 36839
		private LuaFunction m_set_GuildIdString_hotfix;

		// Token: 0x04008FE8 RID: 36840
		private LuaFunction m_get_GuildName_hotfix;

		// Token: 0x04008FE9 RID: 36841
		private LuaFunction m_set_GuildNameString_hotfix;

		// Token: 0x04008FEA RID: 36842
		private LuaFunction m_get_HeadIcon_hotfix;

		// Token: 0x04008FEB RID: 36843
		private LuaFunction m_set_HeadIconInt32_hotfix;

		// Token: 0x04008FEC RID: 36844
		private LuaFunction m_get_Level_hotfix;

		// Token: 0x04008FED RID: 36845
		private LuaFunction m_set_LevelInt32_hotfix;

		// Token: 0x04008FEE RID: 36846
		private LuaFunction m_get_Name_hotfix;

		// Token: 0x04008FEF RID: 36847
		private LuaFunction m_set_NameString_hotfix;

		// Token: 0x02000CF2 RID: 3314
		public class LuaExportHelper
		{
			// Token: 0x0600F2AA RID: 62122 RVA: 0x004066BC File Offset: 0x004048BC
			public LuaExportHelper(GuildJoinInvitation owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04008FF0 RID: 36848
			private GuildJoinInvitation m_owner;
		}
	}
}
