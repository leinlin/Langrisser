using System;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x0200005E RID: 94
	[HotFix]
	public class LuaHotFixChecker
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00013D10 File Offset: 0x00011F10
		public LuaHotFixChecker()
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

		// Token: 0x0600046A RID: 1130 RVA: 0x00013D78 File Offset: 0x00011F78
		public void WithOutParam(int notOutParam, out LuaHotFixExample classParam, out LuaTestStruct valueTypeParam, out int intParam, out float floatParam, out bool boolParam, out ObjectLuaHotFixState enumParam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WithOutParamInt32LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_WithOutParam_Int32_LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState(this, this.m_WithOutParamInt32LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState__hotfix, notOutParam, out classParam, out valueTypeParam, out intParam, out floatParam, out boolParam, out enumParam);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixChecker CS Call WithOutParam");
			classParam = null;
			valueTypeParam = default(LuaTestStruct);
			valueTypeParam.m_str = "InCS";
			intParam = 99;
			floatParam = 0f;
			boolParam = false;
			enumParam = ObjectLuaHotFixState.Uninit;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00013E0C File Offset: 0x0001200C
		public int GetOutParam(out LuaHotFixExample classParam, out int intParam, out LuaTestStruct valueTypeParam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOutParamLuaHotFixExample_Int32_LuaTestStruct__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_GetOutParam_LuaHotFixExample_Int32_LuaTestStruct(this, this.m_GetOutParamLuaHotFixExample_Int32_LuaTestStruct__hotfix, out classParam, out intParam, out valueTypeParam);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixChecker CS Call GetOutParam");
			classParam = null;
			intParam = 0;
			valueTypeParam = default(LuaTestStruct);
			return 5;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00013E84 File Offset: 0x00012084
		public int GetRefParam(out LuaHotFixExample classParam, ref int intParam, out LuaTestStruct valueTypeParam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRefParamLuaHotFixExample_Int32_LuaTestStruct__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_GetRefParam_LuaHotFixExample_Int32_LuaTestStruct(this, this.m_GetRefParamLuaHotFixExample_Int32_LuaTestStruct__hotfix, out classParam, ref intParam, out valueTypeParam);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixChecker CS Call GetRefParam");
			classParam = null;
			valueTypeParam = default(LuaTestStruct);
			return 5;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00013EF8 File Offset: 0x000120F8
		public void WithOutParamAndArray(string[] strArray, out int intParam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WithOutParamAndArrayStringbeInt32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_WithOutParamAndArray_Stringbe_Int32(this, this.m_WithOutParamAndArrayStringbeInt32__hotfix, strArray, out intParam);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixChecker CS Call WithOutParamAndArrat");
			intParam = 3;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00013F5C File Offset: 0x0001215C
		public void ReturnVoid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnVoid_hotfix != null)
			{
				this.m_ReturnVoid_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("LuaHotFixChecker CS Call ReturnVoid");
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00013FC8 File Offset: 0x000121C8
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00013FE8 File Offset: 0x000121E8
		[DoNotToLua]
		public LuaHotFixChecker.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LuaHotFixChecker.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00013FF4 File Offset: 0x000121F4
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
					this.m_WithOutParamInt32LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState__hotfix = (luaObj.RawGet("WithOutParam") as LuaFunction);
					this.m_GetOutParamLuaHotFixExample_Int32_LuaTestStruct__hotfix = (luaObj.RawGet("GetOutParam") as LuaFunction);
					this.m_GetRefParamLuaHotFixExample_Int32_LuaTestStruct__hotfix = (luaObj.RawGet("GetRefParam") as LuaFunction);
					this.m_WithOutParamAndArrayStringbeInt32__hotfix = (luaObj.RawGet("WithOutParamAndArray") as LuaFunction);
					this.m_ReturnVoid_hotfix = (luaObj.RawGet("ReturnVoid") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001413C File Offset: 0x0001233C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LuaHotFixChecker));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040001F8 RID: 504
		[DoNotToLua]
		private LuaHotFixChecker.LuaExportHelper luaExportHelper;

		// Token: 0x040001F9 RID: 505
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040001FA RID: 506
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040001FB RID: 507
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040001FC RID: 508
		private LuaFunction m_WithOutParamInt32LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState__hotfix;

		// Token: 0x040001FD RID: 509
		private LuaFunction m_GetOutParamLuaHotFixExample_Int32_LuaTestStruct__hotfix;

		// Token: 0x040001FE RID: 510
		private LuaFunction m_GetRefParamLuaHotFixExample_Int32_LuaTestStruct__hotfix;

		// Token: 0x040001FF RID: 511
		private LuaFunction m_WithOutParamAndArrayStringbeInt32__hotfix;

		// Token: 0x04000200 RID: 512
		private LuaFunction m_ReturnVoid_hotfix;

		// Token: 0x0200005F RID: 95
		public class LuaExportHelper
		{
			// Token: 0x06000473 RID: 1139 RVA: 0x000141A4 File Offset: 0x000123A4
			public LuaExportHelper(LuaHotFixChecker owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04000201 RID: 513
			private LuaHotFixChecker m_owner;
		}
	}
}
