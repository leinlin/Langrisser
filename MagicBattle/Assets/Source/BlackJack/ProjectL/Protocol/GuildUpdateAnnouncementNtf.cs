using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000756 RID: 1878
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildUpdateAnnouncementNtf")]
	[Serializable]
	public class GuildUpdateAnnouncementNtf : IExtensible
	{
		// Token: 0x0600623A RID: 25146 RVA: 0x001B9F10 File Offset: 0x001B8110
		public GuildUpdateAnnouncementNtf()
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

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x001B9F78 File Offset: 0x001B8178
		// (set) Token: 0x0600623C RID: 25148 RVA: 0x001B9F80 File Offset: 0x001B8180
		[ProtoMember(1, IsRequired = true, Name = "Log", DataFormat = DataFormat.Default)]
		public ProGuildLog Log
		{
			get
			{
				return this._Log;
			}
			set
			{
				this._Log = value;
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x001B9F8C File Offset: 0x001B818C
		// (set) Token: 0x0600623E RID: 25150 RVA: 0x001B9F94 File Offset: 0x001B8194
		[ProtoMember(2, IsRequired = true, Name = "Guild", DataFormat = DataFormat.Default)]
		public ProGuild Guild
		{
			get
			{
				return this._Guild;
			}
			set
			{
				this._Guild = value;
			}
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x001B9FA0 File Offset: 0x001B81A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x001B9FB0 File Offset: 0x001B81B0
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

		// Token: 0x06006241 RID: 25153 RVA: 0x001BA07C File Offset: 0x001B827C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildUpdateAnnouncementNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004991 RID: 18833
		private ProGuildLog _Log;

		// Token: 0x04004992 RID: 18834
		private ProGuild _Guild;

		// Token: 0x04004993 RID: 18835
		private IExtension extensionObject;

		// Token: 0x04004994 RID: 18836
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004995 RID: 18837
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004996 RID: 18838
		private LuaFunction m_ctor_hotfix;
	}
}
