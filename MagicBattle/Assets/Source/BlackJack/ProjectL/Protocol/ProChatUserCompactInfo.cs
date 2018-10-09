using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000681 RID: 1665
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatUserCompactInfo")]
	[Serializable]
	public class ProChatUserCompactInfo : IExtensible
	{
		// Token: 0x06005ABF RID: 23231 RVA: 0x001A0D60 File Offset: 0x0019EF60
		public ProChatUserCompactInfo()
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

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x001A0DC8 File Offset: 0x0019EFC8
		// (set) Token: 0x06005AC1 RID: 23233 RVA: 0x001A0DD0 File Offset: 0x0019EFD0
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x001A0DDC File Offset: 0x0019EFDC
		// (set) Token: 0x06005AC3 RID: 23235 RVA: 0x001A0DE4 File Offset: 0x0019EFE4
		[ProtoMember(2, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
		public int HeadIcon
		{
			get
			{
				return this._HeadIcon;
			}
			set
			{
				this._HeadIcon = value;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x001A0DF0 File Offset: 0x0019EFF0
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x001A0DF8 File Offset: 0x0019EFF8
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x001A0E04 File Offset: 0x0019F004
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x001A0E0C File Offset: 0x0019F00C
		[ProtoMember(4, IsRequired = true, Name = "Online", DataFormat = DataFormat.Default)]
		public bool Online
		{
			get
			{
				return this._Online;
			}
			set
			{
				this._Online = value;
			}
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x001A0E18 File Offset: 0x0019F018
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001A0E28 File Offset: 0x0019F028
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

		// Token: 0x06005ACA RID: 23242 RVA: 0x001A0EF4 File Offset: 0x0019F0F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatUserCompactInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043F4 RID: 17396
		private string _UserId;

		// Token: 0x040043F5 RID: 17397
		private int _HeadIcon;

		// Token: 0x040043F6 RID: 17398
		private string _Name;

		// Token: 0x040043F7 RID: 17399
		private bool _Online;

		// Token: 0x040043F8 RID: 17400
		private IExtension extensionObject;

		// Token: 0x040043F9 RID: 17401
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043FA RID: 17402
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043FB RID: 17403
		private LuaFunction m_ctor_hotfix;
	}
}
