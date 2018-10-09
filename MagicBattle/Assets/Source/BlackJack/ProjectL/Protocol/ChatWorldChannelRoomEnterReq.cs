using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000622 RID: 1570
	[ProtoContract(Name = "ChatWorldChannelRoomEnterReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatWorldChannelRoomEnterReq : IExtensible
	{
		// Token: 0x0600566C RID: 22124 RVA: 0x00194F98 File Offset: 0x00193198
		public ChatWorldChannelRoomEnterReq()
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

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600566D RID: 22125 RVA: 0x00195000 File Offset: 0x00193200
		// (set) Token: 0x0600566E RID: 22126 RVA: 0x00195008 File Offset: 0x00193208
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public int RoomId
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

		// Token: 0x0600566F RID: 22127 RVA: 0x00195014 File Offset: 0x00193214
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x00195024 File Offset: 0x00193224
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

		// Token: 0x06005671 RID: 22129 RVA: 0x001950F0 File Offset: 0x001932F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatWorldChannelRoomEnterReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040EE RID: 16622
		private int _RoomId;

		// Token: 0x040040EF RID: 16623
		private IExtension extensionObject;

		// Token: 0x040040F0 RID: 16624
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040F1 RID: 16625
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040F2 RID: 16626
		private LuaFunction m_ctor_hotfix;
	}
}
