using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B63 RID: 2915
	[HotFix]
	public class ChatVoiceInfo
	{
		// Token: 0x0600C6C7 RID: 50887 RVA: 0x00370C84 File Offset: 0x0036EE84
		public ChatVoiceInfo()
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

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x00370CEC File Offset: 0x0036EEEC
		// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00370D0C File Offset: 0x0036EF0C
		[DoNotToLua]
		public ChatVoiceInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatVoiceInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C6CA RID: 50890 RVA: 0x00370D18 File Offset: 0x0036EF18
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

		// Token: 0x0600C6CB RID: 50891 RVA: 0x00370DE4 File Offset: 0x0036EFE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatVoiceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007DBC RID: 32188
		public int m_voiceRecordId;

		// Token: 0x04007DBD RID: 32189
		public byte[] m_voiceBytes;

		// Token: 0x04007DBE RID: 32190
		public float m_voiceLength;

		// Token: 0x04007DBF RID: 32191
		public int m_voiceSendChannel;

		// Token: 0x04007DC0 RID: 32192
		public int m_voiceFrequency;

		// Token: 0x04007DC1 RID: 32193
		public int m_sampleLength;

		// Token: 0x04007DC2 RID: 32194
		[DoNotToLua]
		private ChatVoiceInfo.LuaExportHelper luaExportHelper;

		// Token: 0x04007DC3 RID: 32195
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007DC4 RID: 32196
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007DC5 RID: 32197
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000B64 RID: 2916
		public class LuaExportHelper
		{
			// Token: 0x0600C6CC RID: 50892 RVA: 0x00370E4C File Offset: 0x0036F04C
			public LuaExportHelper(ChatVoiceInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04007DC6 RID: 32198
			private ChatVoiceInfo m_owner;
		}
	}
}
