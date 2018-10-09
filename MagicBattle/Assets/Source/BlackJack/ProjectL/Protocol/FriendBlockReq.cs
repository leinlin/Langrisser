using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C7 RID: 1735
	[ProtoContract(Name = "FriendBlockReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendBlockReq : IExtensible
	{
		// Token: 0x06005D8A RID: 23946 RVA: 0x001A9514 File Offset: 0x001A7714
		public FriendBlockReq()
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

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06005D8B RID: 23947 RVA: 0x001A957C File Offset: 0x001A777C
		// (set) Token: 0x06005D8C RID: 23948 RVA: 0x001A9584 File Offset: 0x001A7784
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

		// Token: 0x06005D8D RID: 23949 RVA: 0x001A9590 File Offset: 0x001A7790
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x001A95A0 File Offset: 0x001A77A0
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

		// Token: 0x06005D8F RID: 23951 RVA: 0x001A966C File Offset: 0x001A786C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendBlockReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045FD RID: 17917
		private string _TargetUserId;

		// Token: 0x040045FE RID: 17918
		private IExtension extensionObject;

		// Token: 0x040045FF RID: 17919
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004600 RID: 17920
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004601 RID: 17921
		private LuaFunction m_ctor_hotfix;
	}
}
