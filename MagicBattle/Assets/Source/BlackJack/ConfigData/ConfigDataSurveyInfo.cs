using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029B RID: 667
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSurveyInfo")]
	[Serializable]
	public class ConfigDataSurveyInfo : IExtensible
	{
		// Token: 0x06002BB0 RID: 11184 RVA: 0x000B3B14 File Offset: 0x000B1D14
		public ConfigDataSurveyInfo()
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

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000B3B88 File Offset: 0x000B1D88
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x000B3B90 File Offset: 0x000B1D90
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000B3B9C File Offset: 0x000B1D9C
		[ProtoMember(3, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000B3BA4 File Offset: 0x000B1DA4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000B3BB4 File Offset: 0x000B1DB4
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

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000B3C80 File Offset: 0x000B1E80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSurveyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AEA RID: 6890
		private int _ID;

		// Token: 0x04001AEB RID: 6891
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x04001AEC RID: 6892
		private IExtension extensionObject;

		// Token: 0x04001AED RID: 6893
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AEE RID: 6894
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AEF RID: 6895
		private LuaFunction m_ctor_hotfix;
	}
}
