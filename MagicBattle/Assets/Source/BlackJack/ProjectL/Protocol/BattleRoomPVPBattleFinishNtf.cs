using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000608 RID: 1544
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomPVPBattleFinishNtf")]
	[Serializable]
	public class BattleRoomPVPBattleFinishNtf : IExtensible
	{
		// Token: 0x0600557E RID: 21886 RVA: 0x00191E94 File Offset: 0x00190094
		public BattleRoomPVPBattleFinishNtf()
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600557F RID: 21887 RVA: 0x00191EFC File Offset: 0x001900FC
		// (set) Token: 0x06005580 RID: 21888 RVA: 0x00191F04 File Offset: 0x00190104
		[ProtoMember(1, IsRequired = true, Name = "WinSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong WinSessionId
		{
			get
			{
				return this._WinSessionId;
			}
			set
			{
				this._WinSessionId = value;
			}
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x00191F10 File Offset: 0x00190110
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00191F20 File Offset: 0x00190120
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

		// Token: 0x06005583 RID: 21891 RVA: 0x00191FEC File Offset: 0x001901EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPVPBattleFinishNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004041 RID: 16449
		private ulong _WinSessionId;

		// Token: 0x04004042 RID: 16450
		private IExtension extensionObject;

		// Token: 0x04004043 RID: 16451
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004044 RID: 16452
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004045 RID: 16453
		private LuaFunction m_ctor_hotfix;
	}
}
