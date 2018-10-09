using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D1 RID: 1745
	[ProtoContract(Name = "FriendSummaryUpdateNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendSummaryUpdateNtf : IExtensible
	{
		// Token: 0x06005DD0 RID: 24016 RVA: 0x001AA720 File Offset: 0x001A8920
		public FriendSummaryUpdateNtf()
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

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x001AA788 File Offset: 0x001A8988
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x001AA790 File Offset: 0x001A8990
		[ProtoMember(1, IsRequired = true, Name = "Friend", DataFormat = DataFormat.Default)]
		public ProUserSummary Friend
		{
			get
			{
				return this._Friend;
			}
			set
			{
				this._Friend = value;
			}
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x001AA79C File Offset: 0x001A899C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x001AA7AC File Offset: 0x001A89AC
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

		// Token: 0x06005DD5 RID: 24021 RVA: 0x001AA878 File Offset: 0x001A8A78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendSummaryUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004636 RID: 17974
		private ProUserSummary _Friend;

		// Token: 0x04004637 RID: 17975
		private IExtension extensionObject;

		// Token: 0x04004638 RID: 17976
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004639 RID: 17977
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400463A RID: 17978
		private LuaFunction m_ctor_hotfix;
	}
}
