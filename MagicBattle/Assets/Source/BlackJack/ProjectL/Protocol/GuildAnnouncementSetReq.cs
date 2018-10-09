using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077B RID: 1915
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildAnnouncementSetReq")]
	[Serializable]
	public class GuildAnnouncementSetReq : IExtensible
	{
		// Token: 0x06006345 RID: 25413 RVA: 0x001BE1D8 File Offset: 0x001BC3D8
		public GuildAnnouncementSetReq()
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

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x001BE240 File Offset: 0x001BC440
		// (set) Token: 0x06006347 RID: 25415 RVA: 0x001BE248 File Offset: 0x001BC448
		[ProtoMember(1, IsRequired = true, Name = "Announcement", DataFormat = DataFormat.Default)]
		public string Announcement
		{
			get
			{
				return this._Announcement;
			}
			set
			{
				this._Announcement = value;
			}
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x001BE254 File Offset: 0x001BC454
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x001BE264 File Offset: 0x001BC464
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

		// Token: 0x0600634A RID: 25418 RVA: 0x001BE330 File Offset: 0x001BC530
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildAnnouncementSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A63 RID: 19043
		private string _Announcement;

		// Token: 0x04004A64 RID: 19044
		private IExtension extensionObject;

		// Token: 0x04004A65 RID: 19045
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A66 RID: 19046
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A67 RID: 19047
		private LuaFunction m_ctor_hotfix;
	}
}
