using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000237 RID: 567
	[ProtoContract(Name = "ConfigDataGiftCDKeyInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataGiftCDKeyInfo : IExtensible
	{
		// Token: 0x060022B4 RID: 8884 RVA: 0x000A4130 File Offset: 0x000A2330
		public ConfigDataGiftCDKeyInfo()
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000A4198 File Offset: 0x000A2398
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x000A41A0 File Offset: 0x000A23A0
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

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000A41AC File Offset: 0x000A23AC
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x000A41B4 File Offset: 0x000A23B4
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000A41C0 File Offset: 0x000A23C0
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x000A41C8 File Offset: 0x000A23C8
		[ProtoMember(4, IsRequired = true, Name = "RankRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int RankRewardMailTemplateId
		{
			get
			{
				return this._RankRewardMailTemplateId;
			}
			set
			{
				this._RankRewardMailTemplateId = value;
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000A41D4 File Offset: 0x000A23D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000A41E4 File Offset: 0x000A23E4
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

		// Token: 0x060022BD RID: 8893 RVA: 0x000A42B0 File Offset: 0x000A24B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGiftCDKeyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001503 RID: 5379
		private int _ID;

		// Token: 0x04001504 RID: 5380
		private string _Name;

		// Token: 0x04001505 RID: 5381
		private int _RankRewardMailTemplateId;

		// Token: 0x04001506 RID: 5382
		private IExtension extensionObject;

		// Token: 0x04001507 RID: 5383
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001508 RID: 5384
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001509 RID: 5385
		private LuaFunction m_ctor_hotfix;
	}
}
