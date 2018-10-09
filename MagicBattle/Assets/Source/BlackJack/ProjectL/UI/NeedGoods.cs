using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001065 RID: 4197
	[HotFix]
	public class NeedGoods
	{
		// Token: 0x0601551E RID: 87326 RVA: 0x0056932C File Offset: 0x0056752C
		public NeedGoods(GoodsType gt, int gi, int gc)
		{
			this.goodsType = gt;
			this.goodsID = gi;
			this.goodsNeedCount = gc;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_ctorGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					gt,
					gi,
					gc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0601551F RID: 87327 RVA: 0x005693D8 File Offset: 0x005675D8
		// (set) Token: 0x06015520 RID: 87328 RVA: 0x005693F8 File Offset: 0x005675F8
		[DoNotToLua]
		public NeedGoods.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NeedGoods.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x00569404 File Offset: 0x00567604
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
					this.m_ctorGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06015522 RID: 87330 RVA: 0x005694D0 File Offset: 0x005676D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NeedGoods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B9ED RID: 47597
		public GoodsType goodsType;

		// Token: 0x0400B9EE RID: 47598
		public int goodsID;

		// Token: 0x0400B9EF RID: 47599
		public int goodsNeedCount;

		// Token: 0x0400B9F0 RID: 47600
		[DoNotToLua]
		private NeedGoods.LuaExportHelper luaExportHelper;

		// Token: 0x0400B9F1 RID: 47601
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B9F2 RID: 47602
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B9F3 RID: 47603
		private LuaFunction m_ctorGoodsTypeInt32Int32_hotfix;

		// Token: 0x02001066 RID: 4198
		public class LuaExportHelper
		{
			// Token: 0x06015523 RID: 87331 RVA: 0x00569538 File Offset: 0x00567738
			public LuaExportHelper(NeedGoods owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400B9F4 RID: 47604
			private NeedGoods m_owner;
		}
	}
}
