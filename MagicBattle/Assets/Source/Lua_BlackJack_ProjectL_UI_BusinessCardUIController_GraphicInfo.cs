using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013DD RID: 5085
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo : LuaObject
{
	// Token: 0x0601C82B RID: 116779 RVA: 0x008DB248 File Offset: 0x008D9448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			HeroDirectionType directionType;
			LuaObject.checkEnum<HeroDirectionType>(l, 3, out directionType);
			HeroActionType actionType;
			LuaObject.checkEnum<HeroActionType>(l, 4, out actionType);
			BusinessCardUIController.GraphicInfo o = new BusinessCardUIController.GraphicInfo(graphic, directionType, actionType);
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

	// Token: 0x0601C82C RID: 116780 RVA: 0x008DB2B8 File Offset: 0x008D94B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicInfo.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C82D RID: 116781 RVA: 0x008DB30C File Offset: 0x008D950C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			graphicInfo.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C82E RID: 116782 RVA: 0x008DB364 File Offset: 0x008D9564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_directionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)graphicInfo.m_directionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C82F RID: 116783 RVA: 0x008DB3B8 File Offset: 0x008D95B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_directionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			HeroDirectionType directionType;
			LuaObject.checkEnum<HeroDirectionType>(l, 2, out directionType);
			graphicInfo.m_directionType = directionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C830 RID: 116784 RVA: 0x008DB410 File Offset: 0x008D9610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)graphicInfo.m_actionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C831 RID: 116785 RVA: 0x008DB464 File Offset: 0x008D9664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionType(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUIController.GraphicInfo graphicInfo = (BusinessCardUIController.GraphicInfo)LuaObject.checkSelf(l);
			HeroActionType actionType;
			LuaObject.checkEnum<HeroActionType>(l, 2, out actionType);
			graphicInfo.m_actionType = actionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C832 RID: 116786 RVA: 0x008DB4BC File Offset: 0x008D96BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardUIController.GraphicInfo");
		string name = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.get_m_graphic);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.set_m_graphic);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache1, true);
		string name2 = "m_directionType";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.get_m_directionType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.set_m_directionType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache3, true);
		string name3 = "m_actionType";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.get_m_actionType);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.set_m_actionType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.<>f__mg$cache6, typeof(BusinessCardUIController.GraphicInfo));
	}

	// Token: 0x04012A53 RID: 76371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012A54 RID: 76372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012A55 RID: 76373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012A56 RID: 76374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012A57 RID: 76375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012A58 RID: 76376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012A59 RID: 76377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
