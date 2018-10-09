using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000310 RID: 784
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GameFuncDayBonus")]
	[Serializable]
	public class GameFuncDayBonus : IExtensible
	{
		// Token: 0x06002EC9 RID: 11977 RVA: 0x000BAA4C File Offset: 0x000B8C4C
		public GameFuncDayBonus()
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000BAAB4 File Offset: 0x000B8CB4
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x000BAABC File Offset: 0x000B8CBC
		[ProtoMember(1, IsRequired = true, Name = "GameFuncId", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionType GameFuncId
		{
			get
			{
				return this._GameFuncId;
			}
			set
			{
				this._GameFuncId = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000BAAC8 File Offset: 0x000B8CC8
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x000BAAD0 File Offset: 0x000B8CD0
		[ProtoMember(2, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000BAADC File Offset: 0x000B8CDC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000BAAEC File Offset: 0x000B8CEC
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

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000BABB8 File Offset: 0x000B8DB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GameFuncDayBonus));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023DD RID: 9181
		private GameFunctionType _GameFuncId;

		// Token: 0x040023DE RID: 9182
		private int _Nums;

		// Token: 0x040023DF RID: 9183
		private IExtension extensionObject;

		// Token: 0x040023E0 RID: 9184
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023E1 RID: 9185
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023E2 RID: 9186
		private LuaFunction m_ctor_hotfix;
	}
}
