using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028C RID: 652
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSmallExpressionPathInfo")]
	[Serializable]
	public class ConfigDataSmallExpressionPathInfo : IExtensible
	{
		// Token: 0x06002AB8 RID: 10936 RVA: 0x000B1A08 File Offset: 0x000AFC08
		public ConfigDataSmallExpressionPathInfo()
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

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000B1A70 File Offset: 0x000AFC70
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x000B1A78 File Offset: 0x000AFC78
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000B1A84 File Offset: 0x000AFC84
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x000B1A8C File Offset: 0x000AFC8C
		[ProtoMember(3, IsRequired = true, Name = "SmallExpressionIconPath", DataFormat = DataFormat.Default)]
		public string SmallExpressionIconPath
		{
			get
			{
				return this._SmallExpressionIconPath;
			}
			set
			{
				this._SmallExpressionIconPath = value;
			}
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000B1A98 File Offset: 0x000AFC98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000B1AA8 File Offset: 0x000AFCA8
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

		// Token: 0x06002ABF RID: 10943 RVA: 0x000B1B74 File Offset: 0x000AFD74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSmallExpressionPathInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001A47 RID: 6727
		private int _ID;

		// Token: 0x04001A48 RID: 6728
		private string _SmallExpressionIconPath;

		// Token: 0x04001A49 RID: 6729
		private IExtension extensionObject;

		// Token: 0x04001A4A RID: 6730
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001A4B RID: 6731
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001A4C RID: 6732
		private LuaFunction m_ctor_hotfix;
	}
}
