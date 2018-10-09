using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000684 RID: 1668
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatGroupInfo")]
	[Serializable]
	public class ProChatGroupInfo : IExtensible
	{
		// Token: 0x06005AE3 RID: 23267 RVA: 0x001A1354 File Offset: 0x0019F554
		public ProChatGroupInfo()
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

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06005AE4 RID: 23268 RVA: 0x001A13C8 File Offset: 0x0019F5C8
		// (set) Token: 0x06005AE5 RID: 23269 RVA: 0x001A13D0 File Offset: 0x0019F5D0
		[ProtoMember(1, IsRequired = true, Name = "CompactInfo", DataFormat = DataFormat.Default)]
		public ProChatGroupCompactInfo CompactInfo
		{
			get
			{
				return this._CompactInfo;
			}
			set
			{
				this._CompactInfo = value;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x001A13DC File Offset: 0x0019F5DC
		[ProtoMember(2, Name = "Members", DataFormat = DataFormat.Default)]
		public List<ProChatUserInfo> Members
		{
			get
			{
				return this._Members;
			}
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001A13E4 File Offset: 0x0019F5E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001A13F4 File Offset: 0x0019F5F4
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

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001A14C0 File Offset: 0x0019F6C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400440C RID: 17420
		private ProChatGroupCompactInfo _CompactInfo;

		// Token: 0x0400440D RID: 17421
		private readonly List<ProChatUserInfo> _Members = new List<ProChatUserInfo>();

		// Token: 0x0400440E RID: 17422
		private IExtension extensionObject;

		// Token: 0x0400440F RID: 17423
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004410 RID: 17424
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004411 RID: 17425
		private LuaFunction m_ctor_hotfix;
	}
}
