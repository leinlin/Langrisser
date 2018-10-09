using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CD RID: 1741
	[ProtoContract(Name = "FriendGetUserSummaryReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendGetUserSummaryReq : IExtensible
	{
		// Token: 0x06005DB5 RID: 23989 RVA: 0x001A9FE4 File Offset: 0x001A81E4
		public FriendGetUserSummaryReq()
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

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06005DB6 RID: 23990 RVA: 0x001AA058 File Offset: 0x001A8258
		[ProtoMember(1, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06005DB7 RID: 23991 RVA: 0x001AA060 File Offset: 0x001A8260
		// (set) Token: 0x06005DB8 RID: 23992 RVA: 0x001AA068 File Offset: 0x001A8268
		[ProtoMember(2, IsRequired = true, Name = "ClientOnlyToken", DataFormat = DataFormat.TwosComplement)]
		public int ClientOnlyToken
		{
			get
			{
				return this._ClientOnlyToken;
			}
			set
			{
				this._ClientOnlyToken = value;
			}
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x001AA074 File Offset: 0x001A8274
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x001AA084 File Offset: 0x001A8284
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

		// Token: 0x06005DBB RID: 23995 RVA: 0x001AA150 File Offset: 0x001A8350
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendGetUserSummaryReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400461F RID: 17951
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x04004620 RID: 17952
		private int _ClientOnlyToken;

		// Token: 0x04004621 RID: 17953
		private IExtension extensionObject;

		// Token: 0x04004622 RID: 17954
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004623 RID: 17955
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004624 RID: 17956
		private LuaFunction m_ctor_hotfix;
	}
}
