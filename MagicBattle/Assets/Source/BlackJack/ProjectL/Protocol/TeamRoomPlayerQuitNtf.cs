using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000841 RID: 2113
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomPlayerQuitNtf")]
	[Serializable]
	public class TeamRoomPlayerQuitNtf : IExtensible
	{
		// Token: 0x060069C7 RID: 27079 RVA: 0x001DC498 File Offset: 0x001DA698
		public TeamRoomPlayerQuitNtf()
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

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060069C8 RID: 27080 RVA: 0x001DC500 File Offset: 0x001DA700
		// (set) Token: 0x060069C9 RID: 27081 RVA: 0x001DC508 File Offset: 0x001DA708
		[ProtoMember(1, IsRequired = true, Name = "LeaderSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong LeaderSessionId
		{
			get
			{
				return this._LeaderSessionId;
			}
			set
			{
				this._LeaderSessionId = value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x001DC514 File Offset: 0x001DA714
		// (set) Token: 0x060069CB RID: 27083 RVA: 0x001DC51C File Offset: 0x001DA71C
		[ProtoMember(2, IsRequired = true, Name = "LeaderKickOutTime", DataFormat = DataFormat.TwosComplement)]
		public long LeaderKickOutTime
		{
			get
			{
				return this._LeaderKickOutTime;
			}
			set
			{
				this._LeaderKickOutTime = value;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x001DC528 File Offset: 0x001DA728
		// (set) Token: 0x060069CD RID: 27085 RVA: 0x001DC530 File Offset: 0x001DA730
		[ProtoMember(3, IsRequired = true, Name = "QuitPlayerSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong QuitPlayerSessionId
		{
			get
			{
				return this._QuitPlayerSessionId;
			}
			set
			{
				this._QuitPlayerSessionId = value;
			}
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x001DC53C File Offset: 0x001DA73C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x001DC54C File Offset: 0x001DA74C
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

		// Token: 0x060069D0 RID: 27088 RVA: 0x001DC618 File Offset: 0x001DA818
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerQuitNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005185 RID: 20869
		private ulong _LeaderSessionId;

		// Token: 0x04005186 RID: 20870
		private long _LeaderKickOutTime;

		// Token: 0x04005187 RID: 20871
		private ulong _QuitPlayerSessionId;

		// Token: 0x04005188 RID: 20872
		private IExtension extensionObject;

		// Token: 0x04005189 RID: 20873
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400518A RID: 20874
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400518B RID: 20875
		private LuaFunction m_ctor_hotfix;
	}
}
