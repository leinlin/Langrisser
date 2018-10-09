using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000623 RID: 1571
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatWorldChannelRoomEnterAck")]
	[Serializable]
	public class ChatWorldChannelRoomEnterAck : IExtensible
	{
		// Token: 0x06005672 RID: 22130 RVA: 0x00195158 File Offset: 0x00193358
		public ChatWorldChannelRoomEnterAck()
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

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x001951C0 File Offset: 0x001933C0
		// (set) Token: 0x06005674 RID: 22132 RVA: 0x001951C8 File Offset: 0x001933C8
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x001951D4 File Offset: 0x001933D4
		// (set) Token: 0x06005676 RID: 22134 RVA: 0x001951DC File Offset: 0x001933DC
		[DefaultValue(0)]
		[ProtoMember(2, IsRequired = false, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005677 RID: 22135 RVA: 0x001951E8 File Offset: 0x001933E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x001951F8 File Offset: 0x001933F8
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

		// Token: 0x06005679 RID: 22137 RVA: 0x001952C4 File Offset: 0x001934C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatWorldChannelRoomEnterAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040F3 RID: 16627
		private int _Result;

		// Token: 0x040040F4 RID: 16628
		private int _RoomId;

		// Token: 0x040040F5 RID: 16629
		private IExtension extensionObject;

		// Token: 0x040040F6 RID: 16630
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040F7 RID: 16631
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040F8 RID: 16632
		private LuaFunction m_ctor_hotfix;
	}
}
