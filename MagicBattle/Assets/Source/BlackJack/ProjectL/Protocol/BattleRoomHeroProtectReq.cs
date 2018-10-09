using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005EE RID: 1518
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroProtectReq")]
	[Serializable]
	public class BattleRoomHeroProtectReq : IExtensible
	{
		// Token: 0x06005490 RID: 21648 RVA: 0x0018ED1C File Offset: 0x0018CF1C
		public BattleRoomHeroProtectReq()
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

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x0018ED84 File Offset: 0x0018CF84
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x0018ED8C File Offset: 0x0018CF8C
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x0018ED98 File Offset: 0x0018CF98
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x0018EDA0 File Offset: 0x0018CFA0
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

		// Token: 0x06005495 RID: 21653 RVA: 0x0018EDAC File Offset: 0x0018CFAC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0018EDBC File Offset: 0x0018CFBC
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

		// Token: 0x06005497 RID: 21655 RVA: 0x0018EE88 File Offset: 0x0018D088
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroProtectReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F8C RID: 16268
		private ulong _RoomId;

		// Token: 0x04003F8D RID: 16269
		private int _Position;

		// Token: 0x04003F8E RID: 16270
		private IExtension extensionObject;

		// Token: 0x04003F8F RID: 16271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F90 RID: 16272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F91 RID: 16273
		private LuaFunction m_ctor_hotfix;
	}
}
