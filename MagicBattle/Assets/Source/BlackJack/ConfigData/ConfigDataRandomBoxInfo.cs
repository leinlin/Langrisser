using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026E RID: 622
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRandomBoxInfo")]
	[Serializable]
	public class ConfigDataRandomBoxInfo : IExtensible
	{
		// Token: 0x060027F6 RID: 10230 RVA: 0x000ACE50 File Offset: 0x000AB050
		public ConfigDataRandomBoxInfo()
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x000ACECC File Offset: 0x000AB0CC
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		[ProtoMember(3, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<RandomBoxGoods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000ACEF0 File Offset: 0x000AB0F0
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

		// Token: 0x060027FC RID: 10236 RVA: 0x000ACFBC File Offset: 0x000AB1BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomBoxInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001883 RID: 6275
		private int _ID;

		// Token: 0x04001884 RID: 6276
		private readonly List<RandomBoxGoods> _Reward = new List<RandomBoxGoods>();

		// Token: 0x04001885 RID: 6277
		private IExtension extensionObject;

		// Token: 0x04001886 RID: 6278
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001887 RID: 6279
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001888 RID: 6280
		private LuaFunction m_ctor_hotfix;
	}
}
