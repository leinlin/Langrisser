using System;
using System.Collections;
using System.Diagnostics;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000056 RID: 86
	[HotFix]
	public class LuaCoroutineChecker : MonoBehaviour
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00012238 File Offset: 0x00010438
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
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000122A4 File Offset: 0x000104A4
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00012304 File Offset: 0x00010504
		[DebuggerHidden]
		private IEnumerator TestCoroutine()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestCoroutine_hotfix != null)
			{
				return (IEnumerator)this.m_TestCoroutine_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new LuaCoroutineChecker.<TestCoroutine>c__Iterator0();
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00012378 File Offset: 0x00010578
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00012398 File Offset: 0x00010598
		[DoNotToLua]
		public LuaCoroutineChecker.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LuaCoroutineChecker.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000123A4 File Offset: 0x000105A4
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
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_TestCoroutine_hotfix = (luaObj.RawGet("TestCoroutine") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000124A4 File Offset: 0x000106A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LuaCoroutineChecker));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040001B5 RID: 437
		[DoNotToLua]
		private LuaCoroutineChecker.LuaExportHelper luaExportHelper;

		// Token: 0x040001B6 RID: 438
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040001B7 RID: 439
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040001B8 RID: 440
		private LuaFunction m_Awake_hotfix;

		// Token: 0x040001B9 RID: 441
		private LuaFunction m_Start_hotfix;

		// Token: 0x040001BA RID: 442
		private LuaFunction m_TestCoroutine_hotfix;

		// Token: 0x02000057 RID: 87
		public class LuaExportHelper
		{
			// Token: 0x060003E0 RID: 992 RVA: 0x0001250C File Offset: 0x0001070C
			public LuaExportHelper(LuaCoroutineChecker owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0001251C File Offset: 0x0001071C
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0001252C File Offset: 0x0001072C
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0001253C File Offset: 0x0001073C
			public IEnumerator TestCoroutine()
			{
				return this.m_owner.TestCoroutine();
			}

			// Token: 0x040001BB RID: 443
			private LuaCoroutineChecker m_owner;
		}
	}
}
