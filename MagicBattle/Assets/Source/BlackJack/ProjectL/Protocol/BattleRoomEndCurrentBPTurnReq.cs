using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F2 RID: 1522
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomEndCurrentBPTurnReq")]
	[Serializable]
	public class BattleRoomEndCurrentBPTurnReq : IExtensible
	{
		// Token: 0x060054AC RID: 21676 RVA: 0x0018F444 File Offset: 0x0018D644
		public BattleRoomEndCurrentBPTurnReq()
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

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060054AD RID: 21677 RVA: 0x0018F4AC File Offset: 0x0018D6AC
		// (set) Token: 0x060054AE RID: 21678 RVA: 0x0018F4B4 File Offset: 0x0018D6B4
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public ulong RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				this._RoomId = value;
			}
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0018F4C0 File Offset: 0x0018D6C0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x0018F4D0 File Offset: 0x0018D6D0
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

		// Token: 0x060054B1 RID: 21681 RVA: 0x0018F59C File Offset: 0x0018D79C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomEndCurrentBPTurnReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FA2 RID: 16290
		private ulong _RoomId;

		// Token: 0x04003FA3 RID: 16291
		private IExtension extensionObject;

		// Token: 0x04003FA4 RID: 16292
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FA5 RID: 16293
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FA6 RID: 16294
		private LuaFunction m_ctor_hotfix;
	}
}
