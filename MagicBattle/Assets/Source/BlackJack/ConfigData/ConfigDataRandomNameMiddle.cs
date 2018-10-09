using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000271 RID: 625
	[ProtoContract(Name = "ConfigDataRandomNameMiddle")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRandomNameMiddle : IExtensible
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x000AD408 File Offset: 0x000AB608
		public ConfigDataRandomNameMiddle()
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

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000AD470 File Offset: 0x000AB670
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x000AD478 File Offset: 0x000AB678
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000AD484 File Offset: 0x000AB684
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x000AD48C File Offset: 0x000AB68C
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

		// Token: 0x06002817 RID: 10263 RVA: 0x000AD498 File Offset: 0x000AB698
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
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

		// Token: 0x06002819 RID: 10265 RVA: 0x000AD574 File Offset: 0x000AB774
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomNameMiddle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001898 RID: 6296
		private int _ID;

		// Token: 0x04001899 RID: 6297
		private string _Name;

		// Token: 0x0400189A RID: 6298
		private IExtension extensionObject;

		// Token: 0x0400189B RID: 6299
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400189C RID: 6300
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400189D RID: 6301
		private LuaFunction m_ctor_hotfix;
	}
}
