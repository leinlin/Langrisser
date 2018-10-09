using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C5 RID: 1733
	[ProtoContract(Name = "FriendDeleteReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendDeleteReq : IExtensible
	{
		// Token: 0x06005D7C RID: 23932 RVA: 0x001A9180 File Offset: 0x001A7380
		public FriendDeleteReq()
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

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06005D7D RID: 23933 RVA: 0x001A91E8 File Offset: 0x001A73E8
		// (set) Token: 0x06005D7E RID: 23934 RVA: 0x001A91F0 File Offset: 0x001A73F0
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

		// Token: 0x06005D7F RID: 23935 RVA: 0x001A91FC File Offset: 0x001A73FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x001A920C File Offset: 0x001A740C
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

		// Token: 0x06005D81 RID: 23937 RVA: 0x001A92D8 File Offset: 0x001A74D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendDeleteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045F2 RID: 17906
		private string _TargetUserId;

		// Token: 0x040045F3 RID: 17907
		private IExtension extensionObject;

		// Token: 0x040045F4 RID: 17908
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045F5 RID: 17909
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045F6 RID: 17910
		private LuaFunction m_ctor_hotfix;
	}
}
