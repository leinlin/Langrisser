using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F8 RID: 1528
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomPlayerActionBeginReq")]
	[Serializable]
	public class BattleRoomPlayerActionBeginReq : IExtensible
	{
		// Token: 0x060054D1 RID: 21713 RVA: 0x0018FED8 File Offset: 0x0018E0D8
		public BattleRoomPlayerActionBeginReq()
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x0018FF40 File Offset: 0x0018E140
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x0018FF48 File Offset: 0x0018E148
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

		// Token: 0x060054D4 RID: 21716 RVA: 0x0018FF54 File Offset: 0x0018E154
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x0018FF64 File Offset: 0x0018E164
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

		// Token: 0x060054D6 RID: 21718 RVA: 0x00190030 File Offset: 0x0018E230
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerActionBeginReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FC1 RID: 16321
		private ulong _RoomId;

		// Token: 0x04003FC2 RID: 16322
		private IExtension extensionObject;

		// Token: 0x04003FC3 RID: 16323
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FC4 RID: 16324
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FC5 RID: 16325
		private LuaFunction m_ctor_hotfix;
	}
}
