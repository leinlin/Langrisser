using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000916 RID: 2326
	[HotFix]
	public class TouchStatus
	{
		// Token: 0x06008674 RID: 34420 RVA: 0x0026990C File Offset: 0x00267B0C
		public TouchStatus()
		{
			this.m_pressed = false;
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

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06008675 RID: 34421 RVA: 0x0026997C File Offset: 0x00267B7C
		// (set) Token: 0x06008676 RID: 34422 RVA: 0x0026999C File Offset: 0x00267B9C
		[DoNotToLua]
		public TouchStatus.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TouchStatus.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x002699A8 File Offset: 0x00267BA8
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00269A74 File Offset: 0x00267C74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TouchStatus));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005F82 RID: 24450
		public Vector2 m_beginPosition;

		// Token: 0x04005F83 RID: 24451
		public Vector2 m_currentPosition;

		// Token: 0x04005F84 RID: 24452
		public Vector2 m_prevPosition;

		// Token: 0x04005F85 RID: 24453
		public bool m_pressed;

		// Token: 0x04005F86 RID: 24454
		[DoNotToLua]
		private TouchStatus.LuaExportHelper luaExportHelper;

		// Token: 0x04005F87 RID: 24455
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005F88 RID: 24456
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005F89 RID: 24457
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000917 RID: 2327
		public class LuaExportHelper
		{
			// Token: 0x06008679 RID: 34425 RVA: 0x00269ADC File Offset: 0x00267CDC
			public LuaExportHelper(TouchStatus owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04005F8A RID: 24458
			private TouchStatus m_owner;
		}
	}
}
