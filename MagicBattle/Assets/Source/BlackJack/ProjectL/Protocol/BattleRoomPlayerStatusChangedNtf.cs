using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000601 RID: 1537
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomPlayerStatusChangedNtf")]
	[Serializable]
	public class BattleRoomPlayerStatusChangedNtf : IExtensible
	{
		// Token: 0x06005548 RID: 21832 RVA: 0x00191180 File Offset: 0x0018F380
		public BattleRoomPlayerStatusChangedNtf()
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

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x001911E8 File Offset: 0x0018F3E8
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x001911F0 File Offset: 0x0018F3F0
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x001911FC File Offset: 0x0018F3FC
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x00191204 File Offset: 0x0018F404
		[ProtoMember(2, IsRequired = true, Name = "PlayerBattleStatus", DataFormat = DataFormat.TwosComplement)]
		public int PlayerBattleStatus
		{
			get
			{
				return this._PlayerBattleStatus;
			}
			set
			{
				this._PlayerBattleStatus = value;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x00191210 File Offset: 0x0018F410
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x00191218 File Offset: 0x0018F418
		[ProtoMember(3, IsRequired = true, Name = "Offline", DataFormat = DataFormat.Default)]
		public bool Offline
		{
			get
			{
				return this._Offline;
			}
			set
			{
				this._Offline = value;
			}
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00191224 File Offset: 0x0018F424
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00191234 File Offset: 0x0018F434
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

		// Token: 0x06005551 RID: 21841 RVA: 0x00191300 File Offset: 0x0018F500
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerStatusChangedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004013 RID: 16403
		private ulong _SessionId;

		// Token: 0x04004014 RID: 16404
		private int _PlayerBattleStatus;

		// Token: 0x04004015 RID: 16405
		private bool _Offline;

		// Token: 0x04004016 RID: 16406
		private IExtension extensionObject;

		// Token: 0x04004017 RID: 16407
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004018 RID: 16408
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004019 RID: 16409
		private LuaFunction m_ctor_hotfix;
	}
}
