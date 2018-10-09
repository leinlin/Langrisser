using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024E RID: 590
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroPerformanceWordInfo")]
	[Serializable]
	public class ConfigDataHeroPerformanceWordInfo : IExtensible
	{
		// Token: 0x060024BE RID: 9406 RVA: 0x000A7BAC File Offset: 0x000A5DAC
		public ConfigDataHeroPerformanceWordInfo()
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

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000A7C14 File Offset: 0x000A5E14
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000A7C1C File Offset: 0x000A5E1C
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

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000A7C28 File Offset: 0x000A5E28
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000A7C30 File Offset: 0x000A5E30
		[ProtoMember(3, IsRequired = true, Name = "Word", DataFormat = DataFormat.Default)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				this._Word = value;
			}
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000A7C3C File Offset: 0x000A5E3C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000A7C4C File Offset: 0x000A5E4C
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

		// Token: 0x060024C5 RID: 9413 RVA: 0x000A7D18 File Offset: 0x000A5F18
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroPerformanceWordInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400166D RID: 5741
		private int _ID;

		// Token: 0x0400166E RID: 5742
		private string _Word;

		// Token: 0x0400166F RID: 5743
		private IExtension extensionObject;

		// Token: 0x04001670 RID: 5744
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001671 RID: 5745
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001672 RID: 5746
		private LuaFunction m_ctor_hotfix;
	}
}
