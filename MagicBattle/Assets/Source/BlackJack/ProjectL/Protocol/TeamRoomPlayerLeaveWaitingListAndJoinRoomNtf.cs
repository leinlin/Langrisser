using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000842 RID: 2114
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf")]
	[Serializable]
	public class TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf : IExtensible
	{
		// Token: 0x060069D1 RID: 27089 RVA: 0x001DC680 File Offset: 0x001DA880
		public TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf()
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

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001DC6E8 File Offset: 0x001DA8E8
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x001DC6F0 File Offset: 0x001DA8F0
		[ProtoMember(1, IsRequired = true, Name = "Room", DataFormat = DataFormat.Default)]
		public ProTeamRoom Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				this._Room = value;
			}
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x001DC6FC File Offset: 0x001DA8FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x001DC70C File Offset: 0x001DA90C
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

		// Token: 0x060069D6 RID: 27094 RVA: 0x001DC7D8 File Offset: 0x001DA9D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400518C RID: 20876
		private ProTeamRoom _Room;

		// Token: 0x0400518D RID: 20877
		private IExtension extensionObject;

		// Token: 0x0400518E RID: 20878
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400518F RID: 20879
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005190 RID: 20880
		private LuaFunction m_ctor_hotfix;
	}
}
