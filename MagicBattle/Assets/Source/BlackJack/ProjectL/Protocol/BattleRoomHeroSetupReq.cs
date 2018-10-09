using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E8 RID: 1512
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroSetupReq")]
	[Serializable]
	public class BattleRoomHeroSetupReq : IExtensible
	{
		// Token: 0x06005462 RID: 21602 RVA: 0x0018E238 File Offset: 0x0018C438
		public BattleRoomHeroSetupReq()
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

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x0018E2A0 File Offset: 0x0018C4A0
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x0018E2A8 File Offset: 0x0018C4A8
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

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x0018E2B4 File Offset: 0x0018C4B4
		// (set) Token: 0x06005466 RID: 21606 RVA: 0x0018E2BC File Offset: 0x0018C4BC
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x0018E2C8 File Offset: 0x0018C4C8
		// (set) Token: 0x06005468 RID: 21608 RVA: 0x0018E2D0 File Offset: 0x0018C4D0
		[ProtoMember(3, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005469 RID: 21609 RVA: 0x0018E2DC File Offset: 0x0018C4DC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x0018E2EC File Offset: 0x0018C4EC
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

		// Token: 0x0600546B RID: 21611 RVA: 0x0018E3B8 File Offset: 0x0018C5B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroSetupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F69 RID: 16233
		private ulong _RoomId;

		// Token: 0x04003F6A RID: 16234
		private int _HeroId;

		// Token: 0x04003F6B RID: 16235
		private int _Position;

		// Token: 0x04003F6C RID: 16236
		private IExtension extensionObject;

		// Token: 0x04003F6D RID: 16237
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F6E RID: 16238
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F6F RID: 16239
		private LuaFunction m_ctor_hotfix;
	}
}
