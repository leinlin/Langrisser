using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E8 RID: 1768
	[ProtoContract(Name = "FriendshipPointsSendReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendshipPointsSendReq : IExtensible
	{
		// Token: 0x06005E64 RID: 24164 RVA: 0x001ACFE4 File Offset: 0x001AB1E4
		public FriendshipPointsSendReq()
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

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x001AD058 File Offset: 0x001AB258
		[ProtoMember(1, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x001AD060 File Offset: 0x001AB260
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x001AD070 File Offset: 0x001AB270
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

		// Token: 0x06005E68 RID: 24168 RVA: 0x001AD13C File Offset: 0x001AB33C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendshipPointsSendReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046AF RID: 18095
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x040046B0 RID: 18096
		private IExtension extensionObject;

		// Token: 0x040046B1 RID: 18097
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046B2 RID: 18098
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046B3 RID: 18099
		private LuaFunction m_ctor_hotfix;
	}
}
