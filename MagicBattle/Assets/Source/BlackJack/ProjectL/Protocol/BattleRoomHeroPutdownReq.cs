using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005EC RID: 1516
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroPutdownReq")]
	[Serializable]
	public class BattleRoomHeroPutdownReq : IExtensible
	{
		// Token: 0x06005482 RID: 21634 RVA: 0x0018E988 File Offset: 0x0018CB88
		public BattleRoomHeroPutdownReq()
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

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06005483 RID: 21635 RVA: 0x0018E9F0 File Offset: 0x0018CBF0
		// (set) Token: 0x06005484 RID: 21636 RVA: 0x0018E9F8 File Offset: 0x0018CBF8
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

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x0018EA04 File Offset: 0x0018CC04
		// (set) Token: 0x06005486 RID: 21638 RVA: 0x0018EA0C File Offset: 0x0018CC0C
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

		// Token: 0x06005487 RID: 21639 RVA: 0x0018EA18 File Offset: 0x0018CC18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0018EA28 File Offset: 0x0018CC28
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

		// Token: 0x06005489 RID: 21641 RVA: 0x0018EAF4 File Offset: 0x0018CCF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroPutdownReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F81 RID: 16257
		private ulong _RoomId;

		// Token: 0x04003F82 RID: 16258
		private int _Position;

		// Token: 0x04003F83 RID: 16259
		private IExtension extensionObject;

		// Token: 0x04003F84 RID: 16260
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F85 RID: 16261
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F86 RID: 16262
		private LuaFunction m_ctor_hotfix;
	}
}
