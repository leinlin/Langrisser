using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D0 RID: 1744
	[ProtoContract(Name = "FriendSuggestedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendSuggestedAck : IExtensible
	{
		// Token: 0x06005DC9 RID: 24009 RVA: 0x001AA54C File Offset: 0x001A874C
		public FriendSuggestedAck()
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x001AA5C0 File Offset: 0x001A87C0
		// (set) Token: 0x06005DCB RID: 24011 RVA: 0x001AA5C8 File Offset: 0x001A87C8
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x001AA5D4 File Offset: 0x001A87D4
		[ProtoMember(2, Name = "SuggestedUsers", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> SuggestedUsers
		{
			get
			{
				return this._SuggestedUsers;
			}
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x001AA5DC File Offset: 0x001A87DC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x001AA5EC File Offset: 0x001A87EC
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

		// Token: 0x06005DCF RID: 24015 RVA: 0x001AA6B8 File Offset: 0x001A88B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendSuggestedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004630 RID: 17968
		private int _Result;

		// Token: 0x04004631 RID: 17969
		private readonly List<ProUserSummary> _SuggestedUsers = new List<ProUserSummary>();

		// Token: 0x04004632 RID: 17970
		private IExtension extensionObject;

		// Token: 0x04004633 RID: 17971
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004634 RID: 17972
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004635 RID: 17973
		private LuaFunction m_ctor_hotfix;
	}
}
