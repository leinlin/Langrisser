using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022E RID: 558
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataErrorCodeStringTable")]
	[Serializable]
	public class ConfigDataErrorCodeStringTable : IExtensible
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x000A2BA8 File Offset: 0x000A0DA8
		public ConfigDataErrorCodeStringTable()
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

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x000A2C10 File Offset: 0x000A0E10
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x000A2C18 File Offset: 0x000A0E18
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

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000A2C24 File Offset: 0x000A0E24
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x000A2C2C File Offset: 0x000A0E2C
		[ProtoMember(3, IsRequired = true, Name = "Text", DataFormat = DataFormat.Default)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000A2C38 File Offset: 0x000A0E38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000A2C48 File Offset: 0x000A0E48
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

		// Token: 0x060021F4 RID: 8692 RVA: 0x000A2D14 File Offset: 0x000A0F14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataErrorCodeStringTable));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400148A RID: 5258
		private int _ID;

		// Token: 0x0400148B RID: 5259
		private string _Text;

		// Token: 0x0400148C RID: 5260
		private IExtension extensionObject;

		// Token: 0x0400148D RID: 5261
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400148E RID: 5262
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400148F RID: 5263
		private LuaFunction m_ctor_hotfix;
	}
}
