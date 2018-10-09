using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000848 RID: 2120
	[ProtoContract(Name = "TeamRoomInviteeLevelInfoNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomInviteeLevelInfoNtf : IExtensible
	{
		// Token: 0x060069F5 RID: 27125 RVA: 0x001DD100 File Offset: 0x001DB300
		public TeamRoomInviteeLevelInfoNtf()
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060069F6 RID: 27126 RVA: 0x001DD168 File Offset: 0x001DB368
		// (set) Token: 0x060069F7 RID: 27127 RVA: 0x001DD170 File Offset: 0x001DB370
		[ProtoMember(1, IsRequired = true, Name = "InviteeUserId", DataFormat = DataFormat.Default)]
		public string InviteeUserId
		{
			get
			{
				return this._InviteeUserId;
			}
			set
			{
				this._InviteeUserId = value;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060069F8 RID: 27128 RVA: 0x001DD17C File Offset: 0x001DB37C
		// (set) Token: 0x060069F9 RID: 27129 RVA: 0x001DD184 File Offset: 0x001DB384
		[ProtoMember(2, IsRequired = true, Name = "LevelUnlocked", DataFormat = DataFormat.TwosComplement)]
		public int LevelUnlocked
		{
			get
			{
				return this._LevelUnlocked;
			}
			set
			{
				this._LevelUnlocked = value;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x001DD190 File Offset: 0x001DB390
		// (set) Token: 0x060069FB RID: 27131 RVA: 0x001DD198 File Offset: 0x001DB398
		[ProtoMember(3, IsRequired = true, Name = "GuildMassiveCombatAvailable", DataFormat = DataFormat.TwosComplement)]
		public int GuildMassiveCombatAvailable
		{
			get
			{
				return this._GuildMassiveCombatAvailable;
			}
			set
			{
				this._GuildMassiveCombatAvailable = value;
			}
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x001DD1A4 File Offset: 0x001DB3A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x001DD1B4 File Offset: 0x001DB3B4
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

		// Token: 0x060069FE RID: 27134 RVA: 0x001DD280 File Offset: 0x001DB480
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteeLevelInfoNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051AA RID: 20906
		private string _InviteeUserId;

		// Token: 0x040051AB RID: 20907
		private int _LevelUnlocked;

		// Token: 0x040051AC RID: 20908
		private int _GuildMassiveCombatAvailable;

		// Token: 0x040051AD RID: 20909
		private IExtension extensionObject;

		// Token: 0x040051AE RID: 20910
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051AF RID: 20911
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051B0 RID: 20912
		private LuaFunction m_ctor_hotfix;
	}
}
