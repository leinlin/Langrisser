using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F0 RID: 1520
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroBanReq")]
	[Serializable]
	public class BattleRoomHeroBanReq : IExtensible
	{
		// Token: 0x0600549E RID: 21662 RVA: 0x0018F0B0 File Offset: 0x0018D2B0
		public BattleRoomHeroBanReq()
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

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600549F RID: 21663 RVA: 0x0018F118 File Offset: 0x0018D318
		// (set) Token: 0x060054A0 RID: 21664 RVA: 0x0018F120 File Offset: 0x0018D320
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

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x0018F12C File Offset: 0x0018D32C
		// (set) Token: 0x060054A2 RID: 21666 RVA: 0x0018F134 File Offset: 0x0018D334
		[ProtoMember(2, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x0018F140 File Offset: 0x0018D340
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x0018F150 File Offset: 0x0018D350
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

		// Token: 0x060054A5 RID: 21669 RVA: 0x0018F21C File Offset: 0x0018D41C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroBanReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F97 RID: 16279
		private ulong _RoomId;

		// Token: 0x04003F98 RID: 16280
		private int _Position;

		// Token: 0x04003F99 RID: 16281
		private IExtension extensionObject;

		// Token: 0x04003F9A RID: 16282
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F9B RID: 16283
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F9C RID: 16284
		private LuaFunction m_ctor_hotfix;
	}
}
