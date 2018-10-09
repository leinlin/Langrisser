using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000615 RID: 1557
	[ProtoContract(Name = "ChatGroupLeaveChatGroupAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupLeaveChatGroupAck : IExtensible
	{
		// Token: 0x060055F5 RID: 22005 RVA: 0x0019370C File Offset: 0x0019190C
		public ChatGroupLeaveChatGroupAck()
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

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x00193774 File Offset: 0x00191974
		// (set) Token: 0x060055F7 RID: 22007 RVA: 0x0019377C File Offset: 0x0019197C
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

		// Token: 0x060055F8 RID: 22008 RVA: 0x00193788 File Offset: 0x00191988
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00193798 File Offset: 0x00191998
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

		// Token: 0x060055FA RID: 22010 RVA: 0x00193864 File Offset: 0x00191A64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupLeaveChatGroupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004098 RID: 16536
		private int _Result;

		// Token: 0x04004099 RID: 16537
		private IExtension extensionObject;

		// Token: 0x0400409A RID: 16538
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400409B RID: 16539
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400409C RID: 16540
		private LuaFunction m_ctor_hotfix;
	}
}
