using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000782 RID: 1922
	[ProtoContract(Name = "GuildLogGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildLogGetAck : IExtensible
	{
		// Token: 0x06006375 RID: 25461 RVA: 0x001BEE54 File Offset: 0x001BD054
		public GuildLogGetAck()
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

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x001BEEC8 File Offset: 0x001BD0C8
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x001BEED0 File Offset: 0x001BD0D0
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

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06006378 RID: 25464 RVA: 0x001BEEDC File Offset: 0x001BD0DC
		[ProtoMember(2, Name = "Logs", DataFormat = DataFormat.Default)]
		public List<ProGuildLog> Logs
		{
			get
			{
				return this._Logs;
			}
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x001BEEE4 File Offset: 0x001BD0E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x001BEEF4 File Offset: 0x001BD0F4
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

		// Token: 0x0600637B RID: 25467 RVA: 0x001BEFC0 File Offset: 0x001BD1C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildLogGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A89 RID: 19081
		private int _Result;

		// Token: 0x04004A8A RID: 19082
		private readonly List<ProGuildLog> _Logs = new List<ProGuildLog>();

		// Token: 0x04004A8B RID: 19083
		private IExtension extensionObject;

		// Token: 0x04004A8C RID: 19084
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A8D RID: 19085
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A8E RID: 19086
		private LuaFunction m_ctor_hotfix;
	}
}
