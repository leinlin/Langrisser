using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000436 RID: 1078
	[HotFix]
	public class ChatComponentCommon : IComponentBase
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x00124258 File Offset: 0x00122458
		public ChatComponentCommon()
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

		// Token: 0x06003F2D RID: 16173 RVA: 0x001242C0 File Offset: 0x001224C0
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Chat";
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00124334 File Offset: 0x00122534
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatDS = new DataSectionChat();
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x001243A0 File Offset: 0x001225A0
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_guild = (this.Owner.GetOwnerComponent("Guild") as GuildComponentCommon);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00124438 File Offset: 0x00122638
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00124498 File Offset: 0x00122698
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x00124508 File Offset: 0x00122708
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00124588 File Offset: 0x00122788
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x001245F8 File Offset: 0x001227F8
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x00124658 File Offset: 0x00122858
		// (set) Token: 0x06003F36 RID: 16182 RVA: 0x001246CC File Offset: 0x001228CC
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00124744 File Offset: 0x00122944
		public virtual int CanSendChatMessage(int channelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSendChatMessageInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSendChatMessageInt32_hotfix.call(new object[]
				{
					this,
					channelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsBanned())
			{
				return -1402;
			}
			int result = 0;
			switch (channelId)
			{
			case 0:
				if (this.m_basicInfo.GetLevel() < this.m_configDataLoader.ConfigableConstId_AllowChatPlayerLevel)
				{
					result = -1400;
				}
				else if (!this.m_chatDS.CanSendWorldChatByTime(this.m_configDataLoader.ConfigableConstId_WorldChatIntervalTime, this.m_basicInfo.GetCurrentTime()))
				{
					result = -1401;
				}
				return result;
			case 2:
			{
				BattleComponentCommon battleComponentCommon = this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon;
				if (battleComponentCommon.IsAttackingInBattleServer())
				{
					return 0;
				}
				TeamComponentCommon teamComponentCommon = this.Owner.GetOwnerComponent("Team") as TeamComponentCommon;
				if (!teamComponentCommon.IsInRoom())
				{
					result = -1411;
				}
				return result;
			}
			case 3:
				return result;
			case 4:
				return result;
			case 5:
				if (!this.m_guild.HasOwnGuild())
				{
					result = -1420;
				}
				return result;
			}
			result = -1403;
			return result;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x001248D0 File Offset: 0x00122AD0
		public string TruncateChatMessage(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TruncateChatMessageString_hotfix != null)
			{
				return (string)this.m_TruncateChatMessageString_hotfix.call(new object[]
				{
					this,
					content
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (content.Length > this.m_configDataLoader.ConfigableConstId_ChatMessageMaxLength)
			{
				return content.Substring(0, this.m_configDataLoader.ConfigableConstId_ChatMessageMaxLength);
			}
			return content;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00124978 File Offset: 0x00122B78
		public bool IsBanned()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBanned_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBanned_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_chatDS.IsBanned(this.m_basicInfo.GetCurrentTime());
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x001249FC File Offset: 0x00122BFC
		public void Ban(DateTime bannedTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BanDateTime_hotfix != null)
			{
				this.m_BanDateTime_hotfix.call(new object[]
				{
					this,
					bannedTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatDS.Ban(bannedTime);
			if (bannedTime == DateTime.MinValue)
			{
				this.OnUnBan();
			}
			else
			{
				this.OnBan();
			}
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00124A9C File Offset: 0x00122C9C
		protected virtual void OnBan()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBan_hotfix != null)
			{
				this.m_OnBan_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x00124AFC File Offset: 0x00122CFC
		protected virtual void OnUnBan()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnBan_hotfix != null)
			{
				this.m_OnUnBan_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x00124B5C File Offset: 0x00122D5C
		// (set) Token: 0x06003F3E RID: 16190 RVA: 0x00124B7C File Offset: 0x00122D7C
		[DoNotToLua]
		public ChatComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00124B88 File Offset: 0x00122D88
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_CanSendChatMessageInt32_hotfix = (luaObj.RawGet("CanSendChatMessage") as LuaFunction);
					this.m_TruncateChatMessageString_hotfix = (luaObj.RawGet("TruncateChatMessage") as LuaFunction);
					this.m_IsBanned_hotfix = (luaObj.RawGet("IsBanned") as LuaFunction);
					this.m_BanDateTime_hotfix = (luaObj.RawGet("Ban") as LuaFunction);
					this.m_OnBan_hotfix = (luaObj.RawGet("OnBan") as LuaFunction);
					this.m_OnUnBan_hotfix = (luaObj.RawGet("OnUnBan") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00124DE4 File Offset: 0x00122FE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002FAF RID: 12207
		protected DataSectionChat m_chatDS;

		// Token: 0x04002FB0 RID: 12208
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002FB1 RID: 12209
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002FB2 RID: 12210
		protected GuildComponentCommon m_guild;

		// Token: 0x04002FB3 RID: 12211
		[DoNotToLua]
		private ChatComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002FB4 RID: 12212
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002FB5 RID: 12213
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002FB6 RID: 12214
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002FB7 RID: 12215
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002FB8 RID: 12216
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002FB9 RID: 12217
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002FBA RID: 12218
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002FBB RID: 12219
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002FBC RID: 12220
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002FBD RID: 12221
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002FBE RID: 12222
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002FBF RID: 12223
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002FC0 RID: 12224
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04002FC1 RID: 12225
		private LuaFunction m_CanSendChatMessageInt32_hotfix;

		// Token: 0x04002FC2 RID: 12226
		private LuaFunction m_TruncateChatMessageString_hotfix;

		// Token: 0x04002FC3 RID: 12227
		private LuaFunction m_IsBanned_hotfix;

		// Token: 0x04002FC4 RID: 12228
		private LuaFunction m_BanDateTime_hotfix;

		// Token: 0x04002FC5 RID: 12229
		private LuaFunction m_OnBan_hotfix;

		// Token: 0x04002FC6 RID: 12230
		private LuaFunction m_OnUnBan_hotfix;

		// Token: 0x02000437 RID: 1079
		public class LuaExportHelper
		{
			// Token: 0x06003F41 RID: 16193 RVA: 0x00124E4C File Offset: 0x0012304C
			public LuaExportHelper(ChatComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x06003F42 RID: 16194 RVA: 0x00124E5C File Offset: 0x0012305C
			// (set) Token: 0x06003F43 RID: 16195 RVA: 0x00124E6C File Offset: 0x0012306C
			public DataSectionChat m_chatDS
			{
				get
				{
					return this.m_owner.m_chatDS;
				}
				set
				{
					this.m_owner.m_chatDS = value;
				}
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x06003F44 RID: 16196 RVA: 0x00124E7C File Offset: 0x0012307C
			// (set) Token: 0x06003F45 RID: 16197 RVA: 0x00124E8C File Offset: 0x0012308C
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x06003F46 RID: 16198 RVA: 0x00124E9C File Offset: 0x0012309C
			// (set) Token: 0x06003F47 RID: 16199 RVA: 0x00124EAC File Offset: 0x001230AC
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x06003F48 RID: 16200 RVA: 0x00124EBC File Offset: 0x001230BC
			// (set) Token: 0x06003F49 RID: 16201 RVA: 0x00124ECC File Offset: 0x001230CC
			public GuildComponentCommon m_guild
			{
				get
				{
					return this.m_owner.m_guild;
				}
				set
				{
					this.m_owner.m_guild = value;
				}
			}

			// Token: 0x06003F4A RID: 16202 RVA: 0x00124EDC File Offset: 0x001230DC
			public void OnBan()
			{
				this.m_owner.OnBan();
			}

			// Token: 0x06003F4B RID: 16203 RVA: 0x00124EEC File Offset: 0x001230EC
			public void OnUnBan()
			{
				this.m_owner.OnUnBan();
			}

			// Token: 0x04002FC7 RID: 12231
			private ChatComponentCommon m_owner;
		}
	}
}
