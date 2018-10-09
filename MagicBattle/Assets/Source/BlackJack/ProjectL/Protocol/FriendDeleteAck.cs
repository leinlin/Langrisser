using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C6 RID: 1734
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendDeleteAck")]
	[Serializable]
	public class FriendDeleteAck : IExtensible
	{
		// Token: 0x06005D82 RID: 23938 RVA: 0x001A9340 File Offset: 0x001A7540
		public FriendDeleteAck()
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

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x001A93A8 File Offset: 0x001A75A8
		// (set) Token: 0x06005D84 RID: 23940 RVA: 0x001A93B0 File Offset: 0x001A75B0
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

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x001A93BC File Offset: 0x001A75BC
		// (set) Token: 0x06005D86 RID: 23942 RVA: 0x001A93C4 File Offset: 0x001A75C4
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendDeleteReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x001A93D0 File Offset: 0x001A75D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x001A93E0 File Offset: 0x001A75E0
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

		// Token: 0x06005D89 RID: 23945 RVA: 0x001A94AC File Offset: 0x001A76AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendDeleteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045F7 RID: 17911
		private int _Result;

		// Token: 0x040045F8 RID: 17912
		private FriendDeleteReq _Req;

		// Token: 0x040045F9 RID: 17913
		private IExtension extensionObject;

		// Token: 0x040045FA RID: 17914
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045FB RID: 17915
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045FC RID: 17916
		private LuaFunction m_ctor_hotfix;
	}
}
