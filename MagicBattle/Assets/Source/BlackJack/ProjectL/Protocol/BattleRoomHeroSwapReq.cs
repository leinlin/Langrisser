using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005EA RID: 1514
	[ProtoContract(Name = "BattleRoomHeroSwapReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomHeroSwapReq : IExtensible
	{
		// Token: 0x06005472 RID: 21618 RVA: 0x0018E5E0 File Offset: 0x0018C7E0
		public BattleRoomHeroSwapReq()
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

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x0018E648 File Offset: 0x0018C848
		// (set) Token: 0x06005474 RID: 21620 RVA: 0x0018E650 File Offset: 0x0018C850
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

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x0018E65C File Offset: 0x0018C85C
		// (set) Token: 0x06005476 RID: 21622 RVA: 0x0018E664 File Offset: 0x0018C864
		[ProtoMember(2, IsRequired = true, Name = "FromPosition", DataFormat = DataFormat.TwosComplement)]
		public int FromPosition
		{
			get
			{
				return this._FromPosition;
			}
			set
			{
				this._FromPosition = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x0018E670 File Offset: 0x0018C870
		// (set) Token: 0x06005478 RID: 21624 RVA: 0x0018E678 File Offset: 0x0018C878
		[ProtoMember(3, IsRequired = true, Name = "ToPosition", DataFormat = DataFormat.TwosComplement)]
		public int ToPosition
		{
			get
			{
				return this._ToPosition;
			}
			set
			{
				this._ToPosition = value;
			}
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0018E684 File Offset: 0x0018C884
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0018E694 File Offset: 0x0018C894
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

		// Token: 0x0600547B RID: 21627 RVA: 0x0018E760 File Offset: 0x0018C960
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroSwapReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F75 RID: 16245
		private ulong _RoomId;

		// Token: 0x04003F76 RID: 16246
		private int _FromPosition;

		// Token: 0x04003F77 RID: 16247
		private int _ToPosition;

		// Token: 0x04003F78 RID: 16248
		private IExtension extensionObject;

		// Token: 0x04003F79 RID: 16249
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F7A RID: 16250
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F7B RID: 16251
		private LuaFunction m_ctor_hotfix;
	}
}
