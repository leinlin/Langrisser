using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000769 RID: 1897
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildSearchReq")]
	[Serializable]
	public class GuildSearchReq : IExtensible
	{
		// Token: 0x060062B8 RID: 25272 RVA: 0x001BC0DC File Offset: 0x001BA2DC
		public GuildSearchReq()
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

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x001BC150 File Offset: 0x001BA350
		// (set) Token: 0x060062BA RID: 25274 RVA: 0x001BC158 File Offset: 0x001BA358
		[DefaultValue("")]
		[ProtoMember(1, IsRequired = false, Name = "SearchText", DataFormat = DataFormat.Default)]
		public string SearchText
		{
			get
			{
				return this._SearchText;
			}
			set
			{
				this._SearchText = value;
			}
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x001BC164 File Offset: 0x001BA364
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x001BC174 File Offset: 0x001BA374
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

		// Token: 0x060062BD RID: 25277 RVA: 0x001BC240 File Offset: 0x001BA440
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildSearchReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049F7 RID: 18935
		private string _SearchText = string.Empty;

		// Token: 0x040049F8 RID: 18936
		private IExtension extensionObject;

		// Token: 0x040049F9 RID: 18937
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049FA RID: 18938
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049FB RID: 18939
		private LuaFunction m_ctor_hotfix;
	}
}
