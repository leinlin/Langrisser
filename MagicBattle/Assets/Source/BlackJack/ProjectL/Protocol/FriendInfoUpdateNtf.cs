using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D4 RID: 1748
	[ProtoContract(Name = "FriendInfoUpdateNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendInfoUpdateNtf : IExtensible
	{
		// Token: 0x06005DE6 RID: 24038 RVA: 0x001AAC88 File Offset: 0x001A8E88
		public FriendInfoUpdateNtf()
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

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x001AACFC File Offset: 0x001A8EFC
		// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x001AAD04 File Offset: 0x001A8F04
		[ProtoMember(1, IsRequired = true, Name = "Likes", DataFormat = DataFormat.TwosComplement)]
		public int Likes
		{
			get
			{
				return this._Likes;
			}
			set
			{
				this._Likes = value;
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x001AAD10 File Offset: 0x001A8F10
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x001AAD18 File Offset: 0x001A8F18
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "FriendshipPointsReceived", DataFormat = DataFormat.Default)]
		public string FriendshipPointsReceived
		{
			get
			{
				return this._FriendshipPointsReceived;
			}
			set
			{
				this._FriendshipPointsReceived = value;
			}
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x001AAD24 File Offset: 0x001A8F24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x001AAD34 File Offset: 0x001A8F34
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

		// Token: 0x06005DED RID: 24045 RVA: 0x001AAE00 File Offset: 0x001A9000
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInfoUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004647 RID: 17991
		private int _Likes;

		// Token: 0x04004648 RID: 17992
		private string _FriendshipPointsReceived = string.Empty;

		// Token: 0x04004649 RID: 17993
		private IExtension extensionObject;

		// Token: 0x0400464A RID: 17994
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400464B RID: 17995
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400464C RID: 17996
		private LuaFunction m_ctor_hotfix;
	}
}
