using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E6 RID: 1510
	[ProtoContract(Name = "BattleRoomPlayerStatusChangeReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomPlayerStatusChangeReq : IExtensible
	{
		// Token: 0x06005456 RID: 21590 RVA: 0x0018DEB8 File Offset: 0x0018C0B8
		public BattleRoomPlayerStatusChangeReq()
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x0018DF20 File Offset: 0x0018C120
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x0018DF28 File Offset: 0x0018C128
		[ProtoMember(1, IsRequired = true, Name = "PlayerBattleStatus", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005459 RID: 21593 RVA: 0x0018DF34 File Offset: 0x0018C134
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x0018DF44 File Offset: 0x0018C144
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

		// Token: 0x0600545B RID: 21595 RVA: 0x0018E010 File Offset: 0x0018C210
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerStatusChangeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F5F RID: 16223
		private int _PlayerBattleStatus;

		// Token: 0x04003F60 RID: 16224
		private IExtension extensionObject;

		// Token: 0x04003F61 RID: 16225
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F62 RID: 16226
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F63 RID: 16227
		private LuaFunction m_ctor_hotfix;
	}
}
