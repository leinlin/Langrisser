using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C9 RID: 1737
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendUnblockReq")]
	[Serializable]
	public class FriendUnblockReq : IExtensible
	{
		// Token: 0x06005D98 RID: 23960 RVA: 0x001A98A8 File Offset: 0x001A7AA8
		public FriendUnblockReq()
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

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06005D99 RID: 23961 RVA: 0x001A9910 File Offset: 0x001A7B10
		// (set) Token: 0x06005D9A RID: 23962 RVA: 0x001A9918 File Offset: 0x001A7B18
		[ProtoMember(1, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x001A9924 File Offset: 0x001A7B24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x001A9934 File Offset: 0x001A7B34
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

		// Token: 0x06005D9D RID: 23965 RVA: 0x001A9A00 File Offset: 0x001A7C00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendUnblockReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004608 RID: 17928
		private string _TargetUserId;

		// Token: 0x04004609 RID: 17929
		private IExtension extensionObject;

		// Token: 0x0400460A RID: 17930
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400460B RID: 17931
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400460C RID: 17932
		private LuaFunction m_ctor_hotfix;
	}
}
