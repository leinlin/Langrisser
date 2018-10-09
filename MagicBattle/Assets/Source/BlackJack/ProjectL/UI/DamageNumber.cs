using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ACA RID: 2762
	[HotFix]
	public class DamageNumber : MonoBehaviour
	{
		// Token: 0x0600B3CC RID: 46028 RVA: 0x0031AA60 File Offset: 0x00318C60
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text = Utility.FindChildComponent<Text>(base.gameObject, "Text", true);
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x0031AAD8 File Offset: 0x00318CD8
		private void OnEnable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnable_hotfix != null)
			{
				this.m_OnEnable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_startTime = Time.time;
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x0031AB44 File Offset: 0x00318D44
		public void SetNumber(int num)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNumberInt32_hotfix != null)
			{
				this.m_SetNumberInt32_hotfix.call(new object[]
				{
					this,
					num
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (num < 0)
			{
				num = -num;
			}
			this.m_text.text = num.ToString();
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x0031ABD8 File Offset: 0x00318DD8
		public void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Time.time - this.m_startTime > 1.5f)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600B3D0 RID: 46032 RVA: 0x0031AC5C File Offset: 0x00318E5C
		// (set) Token: 0x0600B3D1 RID: 46033 RVA: 0x0031AC7C File Offset: 0x00318E7C
		[DoNotToLua]
		public DamageNumber.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DamageNumber.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x0031AC88 File Offset: 0x00318E88
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_OnEnable_hotfix = (luaObj.RawGet("OnEnable") as LuaFunction);
					this.m_SetNumberInt32_hotfix = (luaObj.RawGet("SetNumber") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x0031ADA0 File Offset: 0x00318FA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DamageNumber));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400747F RID: 29823
		private float m_startTime;

		// Token: 0x04007480 RID: 29824
		private Text m_text;

		// Token: 0x04007481 RID: 29825
		[DoNotToLua]
		private DamageNumber.LuaExportHelper luaExportHelper;

		// Token: 0x04007482 RID: 29826
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007483 RID: 29827
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007484 RID: 29828
		private LuaFunction m_Awake_hotfix;

		// Token: 0x04007485 RID: 29829
		private LuaFunction m_OnEnable_hotfix;

		// Token: 0x04007486 RID: 29830
		private LuaFunction m_SetNumberInt32_hotfix;

		// Token: 0x04007487 RID: 29831
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000ACB RID: 2763
		public class LuaExportHelper
		{
			// Token: 0x0600B3D4 RID: 46036 RVA: 0x0031AE08 File Offset: 0x00319008
			public LuaExportHelper(DamageNumber owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700246A RID: 9322
			// (get) Token: 0x0600B3D5 RID: 46037 RVA: 0x0031AE18 File Offset: 0x00319018
			// (set) Token: 0x0600B3D6 RID: 46038 RVA: 0x0031AE28 File Offset: 0x00319028
			public float m_startTime
			{
				get
				{
					return this.m_owner.m_startTime;
				}
				set
				{
					this.m_owner.m_startTime = value;
				}
			}

			// Token: 0x1700246B RID: 9323
			// (get) Token: 0x0600B3D7 RID: 46039 RVA: 0x0031AE38 File Offset: 0x00319038
			// (set) Token: 0x0600B3D8 RID: 46040 RVA: 0x0031AE48 File Offset: 0x00319048
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x0600B3D9 RID: 46041 RVA: 0x0031AE58 File Offset: 0x00319058
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600B3DA RID: 46042 RVA: 0x0031AE68 File Offset: 0x00319068
			public void OnEnable()
			{
				this.m_owner.OnEnable();
			}

			// Token: 0x04007488 RID: 29832
			private DamageNumber m_owner;
		}
	}
}
