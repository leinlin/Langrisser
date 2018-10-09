using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F6 RID: 1526
	[ProtoContract(Name = "BattleRoomQuitReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomQuitReq : IExtensible
	{
		// Token: 0x060054C5 RID: 21701 RVA: 0x0018FB58 File Offset: 0x0018DD58
		public BattleRoomQuitReq()
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

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x0018FBC0 File Offset: 0x0018DDC0
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x0018FBC8 File Offset: 0x0018DDC8
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

		// Token: 0x060054C8 RID: 21704 RVA: 0x0018FBD4 File Offset: 0x0018DDD4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x0018FBE4 File Offset: 0x0018DDE4
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

		// Token: 0x060054CA RID: 21706 RVA: 0x0018FCB0 File Offset: 0x0018DEB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomQuitReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FB7 RID: 16311
		private ulong _RoomId;

		// Token: 0x04003FB8 RID: 16312
		private IExtension extensionObject;

		// Token: 0x04003FB9 RID: 16313
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FBA RID: 16314
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FBB RID: 16315
		private LuaFunction m_ctor_hotfix;
	}
}
