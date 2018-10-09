using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075B RID: 1883
	[ProtoContract(Name = "GuildJoinApplyRefuseReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinApplyRefuseReq : IExtensible
	{
		// Token: 0x06006260 RID: 25184 RVA: 0x001BA820 File Offset: 0x001B8A20
		public GuildJoinApplyRefuseReq()
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x001BA888 File Offset: 0x001B8A88
		// (set) Token: 0x06006262 RID: 25186 RVA: 0x001BA890 File Offset: 0x001B8A90
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

		// Token: 0x06006263 RID: 25187 RVA: 0x001BA89C File Offset: 0x001B8A9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x001BA8AC File Offset: 0x001B8AAC
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

		// Token: 0x06006265 RID: 25189 RVA: 0x001BA978 File Offset: 0x001B8B78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyRefuseReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049AE RID: 18862
		private string _UserId;

		// Token: 0x040049AF RID: 18863
		private IExtension extensionObject;

		// Token: 0x040049B0 RID: 18864
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049B1 RID: 18865
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049B2 RID: 18866
		private LuaFunction m_ctor_hotfix;
	}
}
