using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061D RID: 1565
	[ProtoContract(Name = "ChatGroupChangeNameAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupChangeNameAck : IExtensible
	{
		// Token: 0x06005630 RID: 22064 RVA: 0x00194584 File Offset: 0x00192784
		public ChatGroupChangeNameAck()
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

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x001945EC File Offset: 0x001927EC
		// (set) Token: 0x06005632 RID: 22066 RVA: 0x001945F4 File Offset: 0x001927F4
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

		// Token: 0x06005633 RID: 22067 RVA: 0x00194600 File Offset: 0x00192800
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00194610 File Offset: 0x00192810
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

		// Token: 0x06005635 RID: 22069 RVA: 0x001946DC File Offset: 0x001928DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupChangeNameAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040C6 RID: 16582
		private int _Result;

		// Token: 0x040040C7 RID: 16583
		private IExtension extensionObject;

		// Token: 0x040040C8 RID: 16584
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040C9 RID: 16585
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040CA RID: 16586
		private LuaFunction m_ctor_hotfix;
	}
}
