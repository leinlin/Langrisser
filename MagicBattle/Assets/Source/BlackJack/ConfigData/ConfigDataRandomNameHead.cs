using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000270 RID: 624
	[ProtoContract(Name = "ConfigDataRandomNameHead")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRandomNameHead : IExtensible
	{
		// Token: 0x0600280A RID: 10250 RVA: 0x000AD234 File Offset: 0x000AB434
		public ConfigDataRandomNameHead()
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

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000AD29C File Offset: 0x000AB49C
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x000AD2A4 File Offset: 0x000AB4A4
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x000AD2B8 File Offset: 0x000AB4B8
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

		// Token: 0x0600280F RID: 10255 RVA: 0x000AD2C4 File Offset: 0x000AB4C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000AD2D4 File Offset: 0x000AB4D4
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

		// Token: 0x06002811 RID: 10257 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomNameHead));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001892 RID: 6290
		private int _ID;

		// Token: 0x04001893 RID: 6291
		private string _Name;

		// Token: 0x04001894 RID: 6292
		private IExtension extensionObject;

		// Token: 0x04001895 RID: 6293
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001896 RID: 6294
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001897 RID: 6295
		private LuaFunction m_ctor_hotfix;
	}
}
