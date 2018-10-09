using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077F RID: 1919
	[ProtoContract(Name = "GuildNameChangeReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildNameChangeReq : IExtensible
	{
		// Token: 0x06006363 RID: 25443 RVA: 0x001BE914 File Offset: 0x001BCB14
		public GuildNameChangeReq()
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

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x001BE97C File Offset: 0x001BCB7C
		// (set) Token: 0x06006365 RID: 25445 RVA: 0x001BE984 File Offset: 0x001BCB84
		[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x001BE990 File Offset: 0x001BCB90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x001BE9A0 File Offset: 0x001BCBA0
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

		// Token: 0x06006368 RID: 25448 RVA: 0x001BEA6C File Offset: 0x001BCC6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildNameChangeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A7A RID: 19066
		private string _Name;

		// Token: 0x04004A7B RID: 19067
		private IExtension extensionObject;

		// Token: 0x04004A7C RID: 19068
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A7D RID: 19069
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A7E RID: 19070
		private LuaFunction m_ctor_hotfix;
	}
}
