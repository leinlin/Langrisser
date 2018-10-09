using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000625 RID: 1573
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatVoiceContentAck")]
	[Serializable]
	public class ChatVoiceContentAck : IExtensible
	{
		// Token: 0x06005682 RID: 22146 RVA: 0x00195500 File Offset: 0x00193700
		public ChatVoiceContentAck()
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

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x00195568 File Offset: 0x00193768
		// (set) Token: 0x06005684 RID: 22148 RVA: 0x00195570 File Offset: 0x00193770
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

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06005685 RID: 22149 RVA: 0x0019557C File Offset: 0x0019377C
		// (set) Token: 0x06005686 RID: 22150 RVA: 0x00195584 File Offset: 0x00193784
		[ProtoMember(2, IsRequired = false, Name = "ChatContentVoice", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProChatContentVoice ChatContentVoice
		{
			get
			{
				return this._ChatContentVoice;
			}
			set
			{
				this._ChatContentVoice = value;
			}
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x00195590 File Offset: 0x00193790
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x001955A0 File Offset: 0x001937A0
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

		// Token: 0x06005689 RID: 22153 RVA: 0x0019566C File Offset: 0x0019386C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatVoiceContentAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040FF RID: 16639
		private int _Result;

		// Token: 0x04004100 RID: 16640
		private ProChatContentVoice _ChatContentVoice;

		// Token: 0x04004101 RID: 16641
		private IExtension extensionObject;

		// Token: 0x04004102 RID: 16642
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004103 RID: 16643
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004104 RID: 16644
		private LuaFunction m_ctor_hotfix;
	}
}
