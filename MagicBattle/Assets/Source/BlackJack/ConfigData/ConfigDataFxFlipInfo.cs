using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000234 RID: 564
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataFxFlipInfo")]
	[Serializable]
	public class ConfigDataFxFlipInfo : IExtensible
	{
		// Token: 0x06002290 RID: 8848 RVA: 0x000A3B3C File Offset: 0x000A1D3C
		public ConfigDataFxFlipInfo()
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

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x000A3BA4 File Offset: 0x000A1DA4
		// (set) Token: 0x06002292 RID: 8850 RVA: 0x000A3BAC File Offset: 0x000A1DAC
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x000A3BB8 File Offset: 0x000A1DB8
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		[ProtoMember(3, IsRequired = true, Name = "DefaultName", DataFormat = DataFormat.Default)]
		public string DefaultName
		{
			get
			{
				return this._DefaultName;
			}
			set
			{
				this._DefaultName = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000A3BCC File Offset: 0x000A1DCC
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x000A3BD4 File Offset: 0x000A1DD4
		[ProtoMember(4, IsRequired = true, Name = "FlipName", DataFormat = DataFormat.Default)]
		public string FlipName
		{
			get
			{
				return this._FlipName;
			}
			set
			{
				this._FlipName = value;
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000A3BE0 File Offset: 0x000A1DE0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000A3BF0 File Offset: 0x000A1DF0
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

		// Token: 0x06002299 RID: 8857 RVA: 0x000A3CBC File Offset: 0x000A1EBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataFxFlipInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014EB RID: 5355
		private int _ID;

		// Token: 0x040014EC RID: 5356
		private string _DefaultName;

		// Token: 0x040014ED RID: 5357
		private string _FlipName;

		// Token: 0x040014EE RID: 5358
		private IExtension extensionObject;

		// Token: 0x040014EF RID: 5359
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014F0 RID: 5360
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014F1 RID: 5361
		private LuaFunction m_ctor_hotfix;
	}
}
