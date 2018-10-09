using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C1 RID: 1729
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteAcceptNtf")]
	[Serializable]
	public class FriendInviteAcceptNtf : IExtensible
	{
		// Token: 0x06005D63 RID: 23907 RVA: 0x001A8A6C File Offset: 0x001A6C6C
		public FriendInviteAcceptNtf()
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

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x001A8AD4 File Offset: 0x001A6CD4
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x001A8ADC File Offset: 0x001A6CDC
		[ProtoMember(1, IsRequired = true, Name = "Accepter", DataFormat = DataFormat.Default)]
		public ProUserSummary Accepter
		{
			get
			{
				return this._Accepter;
			}
			set
			{
				this._Accepter = value;
			}
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x001A8AE8 File Offset: 0x001A6CE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x001A8AF8 File Offset: 0x001A6CF8
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

		// Token: 0x06005D68 RID: 23912 RVA: 0x001A8BC4 File Offset: 0x001A6DC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteAcceptNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045DD RID: 17885
		private ProUserSummary _Accepter;

		// Token: 0x040045DE RID: 17886
		private IExtension extensionObject;

		// Token: 0x040045DF RID: 17887
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045E0 RID: 17888
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045E1 RID: 17889
		private LuaFunction m_ctor_hotfix;
	}
}
