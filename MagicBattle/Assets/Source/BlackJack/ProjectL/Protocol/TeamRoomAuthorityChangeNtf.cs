using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000843 RID: 2115
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomAuthorityChangeNtf")]
	[Serializable]
	public class TeamRoomAuthorityChangeNtf : IExtensible
	{
		// Token: 0x060069D7 RID: 27095 RVA: 0x001DC840 File Offset: 0x001DAA40
		public TeamRoomAuthorityChangeNtf()
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001DC8A8 File Offset: 0x001DAAA8
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x001DC8B0 File Offset: 0x001DAAB0
		[ProtoMember(1, IsRequired = true, Name = "Authority", DataFormat = DataFormat.TwosComplement)]
		public int Authority
		{
			get
			{
				return this._Authority;
			}
			set
			{
				this._Authority = value;
			}
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x001DC8BC File Offset: 0x001DAABC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x001DC8CC File Offset: 0x001DAACC
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

		// Token: 0x060069DC RID: 27100 RVA: 0x001DC998 File Offset: 0x001DAB98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAuthorityChangeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005191 RID: 20881
		private int _Authority;

		// Token: 0x04005192 RID: 20882
		private IExtension extensionObject;

		// Token: 0x04005193 RID: 20883
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005194 RID: 20884
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005195 RID: 20885
		private LuaFunction m_ctor_hotfix;
	}
}
