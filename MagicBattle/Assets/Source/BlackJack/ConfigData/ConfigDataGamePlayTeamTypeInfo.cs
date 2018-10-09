using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000236 RID: 566
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGamePlayTeamTypeInfo")]
	[Serializable]
	public class ConfigDataGamePlayTeamTypeInfo : IExtensible
	{
		// Token: 0x060022AA RID: 8874 RVA: 0x000A3F48 File Offset: 0x000A2148
		public ConfigDataGamePlayTeamTypeInfo()
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000A3FB0 File Offset: 0x000A21B0
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x000A3FB8 File Offset: 0x000A21B8
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

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000A3FC4 File Offset: 0x000A21C4
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x000A3FCC File Offset: 0x000A21CC
		[ProtoMember(3, IsRequired = true, Name = "GamePlayName", DataFormat = DataFormat.Default)]
		public string GamePlayName
		{
			get
			{
				return this._GamePlayName;
			}
			set
			{
				this._GamePlayName = value;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000A3FD8 File Offset: 0x000A21D8
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x000A3FE0 File Offset: 0x000A21E0
		[ProtoMember(4, IsRequired = true, Name = "TeamType", DataFormat = DataFormat.TwosComplement)]
		public int TeamType
		{
			get
			{
				return this._TeamType;
			}
			set
			{
				this._TeamType = value;
			}
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x000A3FEC File Offset: 0x000A21EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000A3FFC File Offset: 0x000A21FC
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

		// Token: 0x060022B3 RID: 8883 RVA: 0x000A40C8 File Offset: 0x000A22C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGamePlayTeamTypeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014FC RID: 5372
		private int _ID;

		// Token: 0x040014FD RID: 5373
		private string _GamePlayName;

		// Token: 0x040014FE RID: 5374
		private int _TeamType;

		// Token: 0x040014FF RID: 5375
		private IExtension extensionObject;

		// Token: 0x04001500 RID: 5376
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001501 RID: 5377
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001502 RID: 5378
		private LuaFunction m_ctor_hotfix;
	}
}
