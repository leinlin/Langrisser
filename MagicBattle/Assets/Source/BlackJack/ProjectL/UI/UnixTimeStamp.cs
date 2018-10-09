using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E54 RID: 3668
	[HotFix]
	public class UnixTimeStamp
	{
		// Token: 0x06011C40 RID: 72768 RVA: 0x004992F4 File Offset: 0x004974F4
		public UnixTimeStamp()
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

		// Token: 0x06011C41 RID: 72769 RVA: 0x0049935C File Offset: 0x0049755C
		public static long From(DateTime t)
		{
			return (t - UnixTimeStamp.originTime).Ticks / 10000000L;
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x06011C42 RID: 72770 RVA: 0x00499384 File Offset: 0x00497584
		// (set) Token: 0x06011C43 RID: 72771 RVA: 0x004993A4 File Offset: 0x004975A4
		[DoNotToLua]
		public UnixTimeStamp.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnixTimeStamp.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011C45 RID: 72773 RVA: 0x004993C4 File Offset: 0x004975C4
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

		// Token: 0x06011C46 RID: 72774 RVA: 0x00499490 File Offset: 0x00497690
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnixTimeStamp));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A1C2 RID: 41410
		private static DateTime originTime = new DateTime(1970, 1, 1);

		// Token: 0x0400A1C3 RID: 41411
		[DoNotToLua]
		private UnixTimeStamp.LuaExportHelper luaExportHelper;

		// Token: 0x0400A1C4 RID: 41412
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A1C5 RID: 41413
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A1C6 RID: 41414
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000E55 RID: 3669
		public class LuaExportHelper
		{
			// Token: 0x06011C47 RID: 72775 RVA: 0x004994F8 File Offset: 0x004976F8
			public LuaExportHelper(UnixTimeStamp owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003681 RID: 13953
			// (get) Token: 0x06011C48 RID: 72776 RVA: 0x00499508 File Offset: 0x00497708
			// (set) Token: 0x06011C49 RID: 72777 RVA: 0x00499510 File Offset: 0x00497710
			public static DateTime originTime
			{
				get
				{
					return UnixTimeStamp.originTime;
				}
				set
				{
					UnixTimeStamp.originTime = value;
				}
			}

			// Token: 0x0400A1C7 RID: 41415
			private UnixTimeStamp m_owner;
		}
	}
}
