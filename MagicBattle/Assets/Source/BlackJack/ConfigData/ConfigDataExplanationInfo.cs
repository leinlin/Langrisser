using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000230 RID: 560
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataExplanationInfo")]
	[Serializable]
	public class ConfigDataExplanationInfo : IExtensible
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x000A3140 File Offset: 0x000A1340
		public ConfigDataExplanationInfo()
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

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000A31A8 File Offset: 0x000A13A8
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x000A31B0 File Offset: 0x000A13B0
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000A31BC File Offset: 0x000A13BC
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x000A31C4 File Offset: 0x000A13C4
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

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x000A31D0 File Offset: 0x000A13D0
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x000A31D8 File Offset: 0x000A13D8
		[ProtoMember(5, IsRequired = true, Name = "ValueStrKey", DataFormat = DataFormat.Default)]
		public string ValueStrKey
		{
			get
			{
				return this._ValueStrKey;
			}
			set
			{
				this._ValueStrKey = value;
			}
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000A31E4 File Offset: 0x000A13E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000A31F4 File Offset: 0x000A13F4
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

		// Token: 0x06002236 RID: 8758 RVA: 0x000A32C0 File Offset: 0x000A14C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataExplanationInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014B2 RID: 5298
		private int _ID;

		// Token: 0x040014B3 RID: 5299
		private string _Value;

		// Token: 0x040014B4 RID: 5300
		private string _ValueStrKey;

		// Token: 0x040014B5 RID: 5301
		private IExtension extensionObject;

		// Token: 0x040014B6 RID: 5302
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014B7 RID: 5303
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014B8 RID: 5304
		private LuaFunction m_ctor_hotfix;
	}
}
