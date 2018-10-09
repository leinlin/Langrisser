using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200022C RID: 556
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataEquipmentLevelInfo")]
	[Serializable]
	public class ConfigDataEquipmentLevelInfo : IExtensible
	{
		// Token: 0x060021DE RID: 8670 RVA: 0x000A2800 File Offset: 0x000A0A00
		public ConfigDataEquipmentLevelInfo()
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

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x000A2874 File Offset: 0x000A0A74
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x000A287C File Offset: 0x000A0A7C
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

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000A2888 File Offset: 0x000A0A88
		[ProtoMember(3, Name = "RankEquipmentNextExps", DataFormat = DataFormat.TwosComplement)]
		public List<int> RankEquipmentNextExps
		{
			get
			{
				return this._RankEquipmentNextExps;
			}
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000A2890 File Offset: 0x000A0A90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000A28A0 File Offset: 0x000A0AA0
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

		// Token: 0x060021E4 RID: 8676 RVA: 0x000A296C File Offset: 0x000A0B6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEquipmentLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400147E RID: 5246
		private int _ID;

		// Token: 0x0400147F RID: 5247
		private readonly List<int> _RankEquipmentNextExps = new List<int>();

		// Token: 0x04001480 RID: 5248
		private IExtension extensionObject;

		// Token: 0x04001481 RID: 5249
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001482 RID: 5250
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001483 RID: 5251
		private LuaFunction m_ctor_hotfix;
	}
}
