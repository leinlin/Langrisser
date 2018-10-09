using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FA RID: 1530
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomGetReq")]
	[Serializable]
	public class BattleRoomGetReq : IExtensible
	{
		// Token: 0x060054DD RID: 21725 RVA: 0x00190258 File Offset: 0x0018E458
		public BattleRoomGetReq()
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

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x001902C0 File Offset: 0x0018E4C0
		// (set) Token: 0x060054DF RID: 21727 RVA: 0x001902C8 File Offset: 0x0018E4C8
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

		// Token: 0x060054E0 RID: 21728 RVA: 0x001902D4 File Offset: 0x0018E4D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x001902E4 File Offset: 0x0018E4E4
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

		// Token: 0x060054E2 RID: 21730 RVA: 0x001903B0 File Offset: 0x0018E5B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FCB RID: 16331
		private ulong _RoomId;

		// Token: 0x04003FCC RID: 16332
		private IExtension extensionObject;

		// Token: 0x04003FCD RID: 16333
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FCE RID: 16334
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FCF RID: 16335
		private LuaFunction m_ctor_hotfix;
	}
}
