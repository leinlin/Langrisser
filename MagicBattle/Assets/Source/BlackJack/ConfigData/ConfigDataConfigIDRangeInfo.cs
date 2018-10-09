using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000221 RID: 545
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataConfigIDRangeInfo")]
	[Serializable]
	public class ConfigDataConfigIDRangeInfo : IExtensible
	{
		// Token: 0x06002059 RID: 8281 RVA: 0x000A064C File Offset: 0x0009E84C
		public ConfigDataConfigIDRangeInfo()
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

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x000A06C0 File Offset: 0x0009E8C0
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x000A06C8 File Offset: 0x0009E8C8
		[ProtoMember(1, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x000A06D4 File Offset: 0x0009E8D4
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x000A06DC File Offset: 0x0009E8DC
		[ProtoMember(2, IsRequired = true, Name = "ConfigObjectName", DataFormat = DataFormat.Default)]
		public string ConfigObjectName
		{
			get
			{
				return this._ConfigObjectName;
			}
			set
			{
				this._ConfigObjectName = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000A06E8 File Offset: 0x0009E8E8
		[ProtoMember(3, Name = "ConfigIDRange", DataFormat = DataFormat.TwosComplement)]
		public List<int> ConfigIDRange
		{
			get
			{
				return this._ConfigIDRange;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000A06F0 File Offset: 0x0009E8F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000A0700 File Offset: 0x0009E900
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

		// Token: 0x06002061 RID: 8289 RVA: 0x000A07CC File Offset: 0x0009E9CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataConfigIDRangeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001388 RID: 5000
		private int _ID;

		// Token: 0x04001389 RID: 5001
		private string _ConfigObjectName;

		// Token: 0x0400138A RID: 5002
		private readonly List<int> _ConfigIDRange = new List<int>();

		// Token: 0x0400138B RID: 5003
		private IExtension extensionObject;

		// Token: 0x0400138C RID: 5004
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400138D RID: 5005
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400138E RID: 5006
		private LuaFunction m_ctor_hotfix;
	}
}
