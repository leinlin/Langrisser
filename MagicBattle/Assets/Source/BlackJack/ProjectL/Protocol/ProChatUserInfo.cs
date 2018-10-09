using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000682 RID: 1666
	[ProtoContract(Name = "ProChatUserInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProChatUserInfo : IExtensible
	{
		// Token: 0x06005ACB RID: 23243 RVA: 0x001A0F5C File Offset: 0x0019F15C
		public ProChatUserInfo()
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

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x001A0FC4 File Offset: 0x0019F1C4
		// (set) Token: 0x06005ACD RID: 23245 RVA: 0x001A0FCC File Offset: 0x0019F1CC
		[ProtoMember(1, IsRequired = true, Name = "CompactInfo", DataFormat = DataFormat.Default)]
		public ProChatUserCompactInfo CompactInfo
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

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06005ACE RID: 23246 RVA: 0x001A0FD8 File Offset: 0x0019F1D8
		// (set) Token: 0x06005ACF RID: 23247 RVA: 0x001A0FE0 File Offset: 0x0019F1E0
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06005AD0 RID: 23248 RVA: 0x001A0FEC File Offset: 0x0019F1EC
		// (set) Token: 0x06005AD1 RID: 23249 RVA: 0x001A0FF4 File Offset: 0x0019F1F4
		[ProtoMember(3, IsRequired = true, Name = "LogoutTime", DataFormat = DataFormat.TwosComplement)]
		public long LogoutTime
		{
			get
			{
				return this._LogoutTime;
			}
			set
			{
				this._LogoutTime = value;
			}
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x001A1000 File Offset: 0x0019F200
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x001A1010 File Offset: 0x0019F210
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

		// Token: 0x06005AD4 RID: 23252 RVA: 0x001A10DC File Offset: 0x0019F2DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatUserInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043FC RID: 17404
		private ProChatUserCompactInfo _CompactInfo;

		// Token: 0x040043FD RID: 17405
		private int _Level;

		// Token: 0x040043FE RID: 17406
		private long _LogoutTime;

		// Token: 0x040043FF RID: 17407
		private IExtension extensionObject;

		// Token: 0x04004400 RID: 17408
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004401 RID: 17409
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004402 RID: 17410
		private LuaFunction m_ctor_hotfix;
	}
}
