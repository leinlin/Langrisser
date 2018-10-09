using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000275 RID: 629
	[ProtoContract(Name = "ConfigDataRandomStoreLevelZoneInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRandomStoreLevelZoneInfo : IExtensible
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x000ADC34 File Offset: 0x000ABE34
		public ConfigDataRandomStoreLevelZoneInfo()
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

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000ADC9C File Offset: 0x000ABE9C
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x000ADCA4 File Offset: 0x000ABEA4
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

		// Token: 0x0600284B RID: 10315 RVA: 0x000ADCB0 File Offset: 0x000ABEB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000ADCC0 File Offset: 0x000ABEC0
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

		// Token: 0x0600284D RID: 10317 RVA: 0x000ADD8C File Offset: 0x000ABF8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomStoreLevelZoneInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018BB RID: 6331
		private int _ID;

		// Token: 0x040018BC RID: 6332
		private IExtension extensionObject;

		// Token: 0x040018BD RID: 6333
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018BE RID: 6334
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018BF RID: 6335
		private LuaFunction m_ctor_hotfix;
	}
}
