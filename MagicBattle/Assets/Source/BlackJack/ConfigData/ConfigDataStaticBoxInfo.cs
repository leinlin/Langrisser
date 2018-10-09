using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000295 RID: 661
	[ProtoContract(Name = "ConfigDataStaticBoxInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataStaticBoxInfo : IExtensible
	{
		// Token: 0x06002B7B RID: 11131 RVA: 0x000B2FE0 File Offset: 0x000B11E0
		public ConfigDataStaticBoxInfo()
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000B3054 File Offset: 0x000B1254
		// (set) Token: 0x06002B7D RID: 11133 RVA: 0x000B305C File Offset: 0x000B125C
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000B3068 File Offset: 0x000B1268
		[ProtoMember(3, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000B3070 File Offset: 0x000B1270
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000B3080 File Offset: 0x000B1280
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

		// Token: 0x06002B81 RID: 11137 RVA: 0x000B314C File Offset: 0x000B134C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataStaticBoxInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AC3 RID: 6851
		private int _ID;

		// Token: 0x04001AC4 RID: 6852
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x04001AC5 RID: 6853
		private IExtension extensionObject;

		// Token: 0x04001AC6 RID: 6854
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AC7 RID: 6855
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AC8 RID: 6856
		private LuaFunction m_ctor_hotfix;
	}
}
