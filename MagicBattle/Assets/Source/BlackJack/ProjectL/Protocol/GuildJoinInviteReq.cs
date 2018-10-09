using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000757 RID: 1879
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInviteReq")]
	[Serializable]
	public class GuildJoinInviteReq : IExtensible
	{
		// Token: 0x06006242 RID: 25154 RVA: 0x001BA0E4 File Offset: 0x001B82E4
		public GuildJoinInviteReq()
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

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x001BA14C File Offset: 0x001B834C
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x001BA154 File Offset: 0x001B8354
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x001BA160 File Offset: 0x001B8360
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x001BA170 File Offset: 0x001B8370
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

		// Token: 0x06006247 RID: 25159 RVA: 0x001BA23C File Offset: 0x001B843C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInviteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004997 RID: 18839
		private string _UserId;

		// Token: 0x04004998 RID: 18840
		private IExtension extensionObject;

		// Token: 0x04004999 RID: 18841
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400499A RID: 18842
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400499B RID: 18843
		private LuaFunction m_ctor_hotfix;
	}
}
