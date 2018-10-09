using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000754 RID: 1876
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinApplyReq")]
	[Serializable]
	public class GuildJoinApplyReq : IExtensible
	{
		// Token: 0x0600622A RID: 25130 RVA: 0x001B9B68 File Offset: 0x001B7D68
		public GuildJoinApplyReq()
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

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600622B RID: 25131 RVA: 0x001B9BD0 File Offset: 0x001B7DD0
		// (set) Token: 0x0600622C RID: 25132 RVA: 0x001B9BD8 File Offset: 0x001B7DD8
		[ProtoMember(1, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x001B9BE4 File Offset: 0x001B7DE4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x001B9BF4 File Offset: 0x001B7DF4
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

		// Token: 0x0600622F RID: 25135 RVA: 0x001B9CC0 File Offset: 0x001B7EC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004985 RID: 18821
		private string _GuildId;

		// Token: 0x04004986 RID: 18822
		private IExtension extensionObject;

		// Token: 0x04004987 RID: 18823
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004988 RID: 18824
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004989 RID: 18825
		private LuaFunction m_ctor_hotfix;
	}
}
