using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C4 RID: 1732
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteDeclineNtf")]
	[Serializable]
	public class FriendInviteDeclineNtf : IExtensible
	{
		// Token: 0x06005D76 RID: 23926 RVA: 0x001A8FC0 File Offset: 0x001A71C0
		public FriendInviteDeclineNtf()
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

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x001A9028 File Offset: 0x001A7228
		// (set) Token: 0x06005D78 RID: 23928 RVA: 0x001A9030 File Offset: 0x001A7230
		[ProtoMember(1, IsRequired = true, Name = "Decliner", DataFormat = DataFormat.Default)]
		public ProUserSummary Decliner
		{
			get
			{
				return this._Decliner;
			}
			set
			{
				this._Decliner = value;
			}
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x001A903C File Offset: 0x001A723C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x001A904C File Offset: 0x001A724C
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

		// Token: 0x06005D7B RID: 23931 RVA: 0x001A9118 File Offset: 0x001A7318
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteDeclineNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045ED RID: 17901
		private ProUserSummary _Decliner;

		// Token: 0x040045EE RID: 17902
		private IExtension extensionObject;

		// Token: 0x040045EF RID: 17903
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045F0 RID: 17904
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045F1 RID: 17905
		private LuaFunction m_ctor_hotfix;
	}
}
