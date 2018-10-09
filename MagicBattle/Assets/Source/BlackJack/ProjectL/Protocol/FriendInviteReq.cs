using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BC RID: 1724
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteReq")]
	[Serializable]
	public class FriendInviteReq : IExtensible
	{
		// Token: 0x06005D3D RID: 23869 RVA: 0x001A8134 File Offset: 0x001A6334
		public FriendInviteReq()
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

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x001A81A8 File Offset: 0x001A63A8
		[ProtoMember(1, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x001A81B0 File Offset: 0x001A63B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x001A81C0 File Offset: 0x001A63C0
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

		// Token: 0x06005D41 RID: 23873 RVA: 0x001A828C File Offset: 0x001A648C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045BE RID: 17854
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x040045BF RID: 17855
		private IExtension extensionObject;

		// Token: 0x040045C0 RID: 17856
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045C1 RID: 17857
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045C2 RID: 17858
		private LuaFunction m_ctor_hotfix;
	}
}
