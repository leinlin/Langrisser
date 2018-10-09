using System;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x0200005D RID: 93
	[CustomLuaClass]
	public class LuaHotFixExample
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x000139BC File Offset: 0x00011BBC
		public LuaHotFixExample()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix(null) && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00013A14 File Offset: 0x00011C14
		public void WithOutParam(int notOutParam, out LuaHotFixExample classParam, out LuaTestStruct valueTypeParam, out int intParam, out float floatParam, out bool boolParam, out ObjectLuaHotFixState enumParam)
		{
			if (BJLuaObjHelper.IsSkipLuaHotfix || !this.TryInitHotFix(string.Empty) || this.m_WithOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix != null)
			{
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixExample CS Call WithOutParam");
			classParam = null;
			valueTypeParam = default(LuaTestStruct);
			valueTypeParam.m_str = "InCS";
			intParam = 99;
			floatParam = 0f;
			boolParam = false;
			enumParam = ObjectLuaHotFixState.Uninit;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00013A88 File Offset: 0x00011C88
		public int GetOutParam(out LuaHotFixExample classParam, LuaHotFixExample notOutClassParam, out LuaTestStruct valueTypeParam, LuaTestStruct notOutvalueTypeParam, out int intParam, int notOutIntParam, out float floatParam, float notOutfloatParam, out bool boolParam, bool notOutboolParam, out ObjectLuaHotFixState enumParam, ObjectLuaHotFixState notOutEnumParam)
		{
			if (BJLuaObjHelper.IsSkipLuaHotfix || !this.TryInitHotFix(null) || this.m_WithOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix != null)
			{
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixExample CS Call WithOutParam");
			classParam = null;
			valueTypeParam = default(LuaTestStruct);
			valueTypeParam.m_str = "InCS";
			intParam = 99;
			floatParam = 0f;
			boolParam = false;
			enumParam = ObjectLuaHotFixState.Uninit;
			return 777;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00013AFC File Offset: 0x00011CFC
		public int GetOutParam(out LuaHotFixExample classParam, out int intParam, out LuaTestStruct valueTypeParam)
		{
			if (BJLuaObjHelper.IsSkipLuaHotfix || !this.TryInitHotFix(null) || this.m_GetOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix != null)
			{
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixExample CS Call GetOutParam");
			classParam = null;
			intParam = 0;
			valueTypeParam = default(LuaTestStruct);
			return 5;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00013B50 File Offset: 0x00011D50
		public int GetRefParam(out LuaHotFixExample classParam, ref int intParam, out LuaTestStruct valueTypeParam)
		{
			if (BJLuaObjHelper.IsSkipLuaHotfix || !this.TryInitHotFix(null) || this.m_GetRefParamLuaHotFixExampleInt32LuaTestStruct_hotfix != null)
			{
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixExample CS Call GetRefParam");
			classParam = null;
			valueTypeParam = default(LuaTestStruct);
			return 5;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00013BA0 File Offset: 0x00011DA0
		public void ReturnVoid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix(string.Empty) && this.m_ReturnVoid_hotfix != null)
			{
				this.m_ReturnVoid_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixExample CS Call ReturnVoid");
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00013C00 File Offset: 0x00011E00
		private bool InitHotFix(LuaTable module)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, module);
			LuaFunction luaFunction = module.RawGet("HotFixObject") as LuaFunction;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				return false;
			}
			luaFunction.call(new object[]
			{
				this,
				this.m_luaObjHelper
			});
			LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
			if (luaObj == null)
			{
				return false;
			}
			this.m_WithOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix = (luaObj.RawGet("WithOutParam") as LuaFunction);
			this.m_GetOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix = (luaObj.RawGet("GetOutParam") as LuaFunction);
			this.m_GetRefParamLuaHotFixExampleInt32LuaTestStruct_hotfix = (luaObj.RawGet("GetRefParam") as LuaFunction);
			return true;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00013CC8 File Offset: 0x00011EC8
		private bool TryInitHotFix(string luaModuleName = null)
		{
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				return this.m_hotfixState == ObjectLuaHotFixState.InitAvialable;
			}
			bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LuaHotFixExample));
			this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
			return flag;
		}

		// Token: 0x040001F1 RID: 497
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040001F2 RID: 498
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040001F3 RID: 499
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040001F4 RID: 500
		private LuaFunction m_GetRefParamLuaHotFixExampleInt32LuaTestStruct_hotfix;

		// Token: 0x040001F5 RID: 501
		private LuaFunction m_GetOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix;

		// Token: 0x040001F6 RID: 502
		private LuaFunction m_WithOutParamLuaHotFixExampleInt32LuaTestStruct_hotfix;

		// Token: 0x040001F7 RID: 503
		private LuaFunction m_ReturnVoid_hotfix;
	}
}
