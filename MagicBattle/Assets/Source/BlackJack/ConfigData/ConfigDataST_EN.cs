using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029A RID: 666
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataST_EN")]
	[Serializable]
	public class ConfigDataST_EN : IExtensible
	{
		// Token: 0x06002BA8 RID: 11176 RVA: 0x000B3940 File Offset: 0x000B1B40
		public ConfigDataST_EN()
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

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000B39A8 File Offset: 0x000B1BA8
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x000B39B0 File Offset: 0x000B1BB0
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

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000B39BC File Offset: 0x000B1BBC
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x000B39C4 File Offset: 0x000B1BC4
		[ProtoMember(4, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000B39D0 File Offset: 0x000B1BD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000B39E0 File Offset: 0x000B1BE0
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

		// Token: 0x06002BAF RID: 11183 RVA: 0x000B3AAC File Offset: 0x000B1CAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataST_EN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AE4 RID: 6884
		private int _ID;

		// Token: 0x04001AE5 RID: 6885
		private string _Value;

		// Token: 0x04001AE6 RID: 6886
		private IExtension extensionObject;

		// Token: 0x04001AE7 RID: 6887
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AE8 RID: 6888
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AE9 RID: 6889
		private LuaFunction m_ctor_hotfix;
	}
}
