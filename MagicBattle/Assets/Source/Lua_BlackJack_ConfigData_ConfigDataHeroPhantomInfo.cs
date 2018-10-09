using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001157 RID: 4439
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo : LuaObject
{
	// Token: 0x06016976 RID: 92534 RVA: 0x005FFB6C File Offset: 0x005FDD6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo o = new ConfigDataHeroPhantomInfo();
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

	// Token: 0x06016977 RID: 92535 RVA: 0x005FFBB4 File Offset: 0x005FDDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levels(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.m_levels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016978 RID: 92536 RVA: 0x005FFC08 File Offset: 0x005FDE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levels(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			List<ConfigDataHeroPhantomLevelInfo> levels;
			LuaObject.checkType<List<ConfigDataHeroPhantomLevelInfo>>(l, 2, out levels);
			configDataHeroPhantomInfo.m_levels = levels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016979 RID: 92537 RVA: 0x005FFC60 File Offset: 0x005FDE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697A RID: 92538 RVA: 0x005FFCB4 File Offset: 0x005FDEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroPhantomInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697B RID: 92539 RVA: 0x005FFD0C File Offset: 0x005FDF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697C RID: 92540 RVA: 0x005FFD60 File Offset: 0x005FDF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroPhantomInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697D RID: 92541 RVA: 0x005FFDB8 File Offset: 0x005FDFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697E RID: 92542 RVA: 0x005FFE0C File Offset: 0x005FE00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataHeroPhantomInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601697F RID: 92543 RVA: 0x005FFE64 File Offset: 0x005FE064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016980 RID: 92544 RVA: 0x005FFEB8 File Offset: 0x005FE0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.OpenDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016981 RID: 92545 RVA: 0x005FFF0C File Offset: 0x005FE10C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string openDateTime;
			LuaObject.checkType(l, 2, out openDateTime);
			configDataHeroPhantomInfo.OpenDateTime = openDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016982 RID: 92546 RVA: 0x005FFF64 File Offset: 0x005FE164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CloseDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.CloseDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016983 RID: 92547 RVA: 0x005FFFB8 File Offset: 0x005FE1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CloseDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string closeDateTime;
			LuaObject.checkType(l, 2, out closeDateTime);
			configDataHeroPhantomInfo.CloseDateTime = closeDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016984 RID: 92548 RVA: 0x00600010 File Offset: 0x005FE210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.ShowDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016985 RID: 92549 RVA: 0x00600064 File Offset: 0x005FE264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ShowDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string showDateTime;
			LuaObject.checkType(l, 2, out showDateTime);
			configDataHeroPhantomInfo.ShowDateTime = showDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016986 RID: 92550 RVA: 0x006000BC File Offset: 0x005FE2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HideDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.HideDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016987 RID: 92551 RVA: 0x00600110 File Offset: 0x005FE310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HideDateTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string hideDateTime;
			LuaObject.checkType(l, 2, out hideDateTime);
			configDataHeroPhantomInfo.HideDateTime = hideDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016988 RID: 92552 RVA: 0x00600168 File Offset: 0x005FE368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016989 RID: 92553 RVA: 0x006001BC File Offset: 0x005FE3BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataHeroPhantomInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698A RID: 92554 RVA: 0x00600214 File Offset: 0x005FE414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698B RID: 92555 RVA: 0x00600268 File Offset: 0x005FE468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataHeroPhantomInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698C RID: 92556 RVA: 0x006002C0 File Offset: 0x005FE4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698D RID: 92557 RVA: 0x00600314 File Offset: 0x005FE514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataHeroPhantomInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698E RID: 92558 RVA: 0x0060036C File Offset: 0x005FE56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601698F RID: 92559 RVA: 0x006003C0 File Offset: 0x005FE5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataHeroPhantomInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016990 RID: 92560 RVA: 0x00600418 File Offset: 0x005FE618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016991 RID: 92561 RVA: 0x0060046C File Offset: 0x005FE66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomInfo configDataHeroPhantomInfo = (ConfigDataHeroPhantomInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataHeroPhantomInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016992 RID: 92562 RVA: 0x006004C4 File Offset: 0x005FE6C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroPhantomInfo");
		string name = "m_levels";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_m_levels);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_m_levels);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache7, true);
		string name5 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_LevelList);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache8, null, true);
		string name6 = "OpenDateTime";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_OpenDateTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_OpenDateTime);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheA, true);
		string name7 = "CloseDateTime";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_CloseDateTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_CloseDateTime);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheC, true);
		string name8 = "ShowDateTime";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_ShowDateTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_ShowDateTime);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheE, true);
		string name9 = "HideDateTime";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_HideDateTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_HideDateTime);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache10, true);
		string name10 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_Image);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_Image);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache12, true);
		string name11 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_Model);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_Model);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache14, true);
		string name12 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_UI_ModelScale);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache16, true);
		string name13 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache18, true);
		string name14 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1A, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.<>f__mg$cache1B, typeof(ConfigDataHeroPhantomInfo));
	}

	// Token: 0x0400D0AA RID: 53418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D0AB RID: 53419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D0AC RID: 53420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D0AD RID: 53421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D0AE RID: 53422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D0AF RID: 53423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D0B0 RID: 53424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D0B1 RID: 53425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D0B2 RID: 53426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D0B3 RID: 53427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D0B4 RID: 53428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D0B5 RID: 53429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D0B6 RID: 53430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D0B7 RID: 53431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D0B8 RID: 53432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D0B9 RID: 53433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D0BA RID: 53434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D0BB RID: 53435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D0BC RID: 53436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D0BD RID: 53437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D0BE RID: 53438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D0BF RID: 53439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D0C0 RID: 53440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D0C1 RID: 53441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D0C2 RID: 53442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D0C3 RID: 53443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D0C4 RID: 53444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D0C5 RID: 53445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
