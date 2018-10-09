using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006EA RID: 1770
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendshipPointsClaimReq")]
	[Serializable]
	public class FriendshipPointsClaimReq : IExtensible
	{
		// Token: 0x06005E72 RID: 24178 RVA: 0x001AD38C File Offset: 0x001AB58C
		public FriendshipPointsClaimReq()
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

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x001AD400 File Offset: 0x001AB600
		[ProtoMember(1, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x001AD408 File Offset: 0x001AB608
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x001AD418 File Offset: 0x001AB618
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

		// Token: 0x06005E76 RID: 24182 RVA: 0x001AD4E4 File Offset: 0x001AB6E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendshipPointsClaimReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046BB RID: 18107
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x040046BC RID: 18108
		private IExtension extensionObject;

		// Token: 0x040046BD RID: 18109
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046BE RID: 18110
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040046BF RID: 18111
		private LuaFunction m_ctor_hotfix;
	}
}
