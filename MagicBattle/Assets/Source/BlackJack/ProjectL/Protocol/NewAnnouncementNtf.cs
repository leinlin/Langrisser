using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FA RID: 2042
	[ProtoContract(Name = "NewAnnouncementNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class NewAnnouncementNtf : IExtensible
	{
		// Token: 0x06006792 RID: 26514 RVA: 0x001CCE58 File Offset: 0x001CB058
		public NewAnnouncementNtf()
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

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x001CCEC0 File Offset: 0x001CB0C0
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x001CCEC8 File Offset: 0x001CB0C8
		[ProtoMember(1, IsRequired = true, Name = "AnnouncementInfo", DataFormat = DataFormat.Default)]
		public ProAnnouncement AnnouncementInfo
		{
			get
			{
				return this._AnnouncementInfo;
			}
			set
			{
				this._AnnouncementInfo = value;
			}
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x001CCED4 File Offset: 0x001CB0D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x001CCEE4 File Offset: 0x001CB0E4
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

		// Token: 0x06006797 RID: 26519 RVA: 0x001CCFB0 File Offset: 0x001CB1B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NewAnnouncementNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D95 RID: 19861
		private ProAnnouncement _AnnouncementInfo;

		// Token: 0x04004D96 RID: 19862
		private IExtension extensionObject;

		// Token: 0x04004D97 RID: 19863
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D98 RID: 19864
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D99 RID: 19865
		private LuaFunction m_ctor_hotfix;
	}
}
