using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001581 RID: 5505
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierShowItemController : LuaObject
{
	// Token: 0x06021223 RID: 135715 RVA: 0x00B27B88 File Offset: 0x00B25D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameObject soldierItem;
			LuaObject.checkType<GameObject>(l, 2, out soldierItem);
			SoldierShowItemController o = new SoldierShowItemController(soldierItem);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021224 RID: 135716 RVA: 0x00B27BDC File Offset: 0x00B25DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActive(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			bool active;
			LuaObject.checkType(l, 2, out active);
			soldierShowItemController.SetActive(active);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021225 RID: 135717 RVA: 0x00B27C34 File Offset: 0x00B25E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkinGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierShowItemController.m_soldierSkinGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021226 RID: 135718 RVA: 0x00B27C88 File Offset: 0x00B25E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkinGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			UISpineGraphic soldierSkinGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierSkinGraphic);
			soldierShowItemController.m_soldierSkinGraphic = soldierSkinGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021227 RID: 135719 RVA: 0x00B27CE0 File Offset: 0x00B25EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierShowItemController.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021228 RID: 135720 RVA: 0x00B27D34 File Offset: 0x00B25F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			soldierShowItemController.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021229 RID: 135721 RVA: 0x00B27D8C File Offset: 0x00B25F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierShowItemController.m_spineObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122A RID: 135722 RVA: 0x00B27DE0 File Offset: 0x00B25FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			GameObject spineObj;
			LuaObject.checkType<GameObject>(l, 2, out spineObj);
			soldierShowItemController.m_spineObj = spineObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122B RID: 135723 RVA: 0x00B27E38 File Offset: 0x00B26038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierShowItemController.m_itemStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122C RID: 135724 RVA: 0x00B27E8C File Offset: 0x00B2608C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			CommonUIStateController itemStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemStateCtrl);
			soldierShowItemController.m_itemStateCtrl = itemStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122D RID: 135725 RVA: 0x00B27EE4 File Offset: 0x00B260E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_item(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierShowItemController.m_luaExportHelper.m_item);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122E RID: 135726 RVA: 0x00B27F3C File Offset: 0x00B2613C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_item(IntPtr l)
	{
		int result;
		try
		{
			SoldierShowItemController soldierShowItemController = (SoldierShowItemController)LuaObject.checkSelf(l);
			GameObject item;
			LuaObject.checkType<GameObject>(l, 2, out item);
			soldierShowItemController.m_luaExportHelper.m_item = item;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602122F RID: 135727 RVA: 0x00B27F98 File Offset: 0x00B26198
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierShowItemController");
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.SetActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache0);
		string name = "m_soldierSkinGraphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.get_m_soldierSkinGraphic);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.set_m_soldierSkinGraphic);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache2, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache4, true);
		string name3 = "m_spineObj";
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.get_m_spineObj);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.set_m_spineObj);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache6, true);
		string name4 = "m_itemStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.get_m_itemStateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.set_m_itemStateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache8, true);
		string name5 = "m_item";
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.get_m_item);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.set_m_item);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SoldierShowItemController.<>f__mg$cacheB, typeof(SoldierShowItemController));
	}

	// Token: 0x04017103 RID: 94467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017104 RID: 94468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017105 RID: 94469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017106 RID: 94470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017107 RID: 94471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017108 RID: 94472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017109 RID: 94473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401710A RID: 94474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401710B RID: 94475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401710C RID: 94476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401710D RID: 94477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401710E RID: 94478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
