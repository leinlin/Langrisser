using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022D RID: 557
	[ProtoContract(Name = "ConfigDataEquipmentLevelLimitInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataEquipmentLevelLimitInfo : IExtensible
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x000A29D4 File Offset: 0x000A0BD4
		public ConfigDataEquipmentLevelLimitInfo()
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

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x000A2A3C File Offset: 0x000A0C3C
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x000A2A44 File Offset: 0x000A0C44
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

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000A2A50 File Offset: 0x000A0C50
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x000A2A58 File Offset: 0x000A0C58
		[ProtoMember(3, IsRequired = true, Name = "LevelLimit", DataFormat = DataFormat.TwosComplement)]
		public int LevelLimit
		{
			get
			{
				return this._LevelLimit;
			}
			set
			{
				this._LevelLimit = value;
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000A2A64 File Offset: 0x000A0C64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000A2A74 File Offset: 0x000A0C74
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

		// Token: 0x060021EC RID: 8684 RVA: 0x000A2B40 File Offset: 0x000A0D40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEquipmentLevelLimitInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001484 RID: 5252
		private int _ID;

		// Token: 0x04001485 RID: 5253
		private int _LevelLimit;

		// Token: 0x04001486 RID: 5254
		private IExtension extensionObject;

		// Token: 0x04001487 RID: 5255
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001488 RID: 5256
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001489 RID: 5257
		private LuaFunction m_ctor_hotfix;
	}
}
