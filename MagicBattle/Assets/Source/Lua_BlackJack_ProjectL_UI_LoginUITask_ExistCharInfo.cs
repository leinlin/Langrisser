using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014FD RID: 5373
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo : LuaObject
{
	// Token: 0x0601FCF4 RID: 130292 RVA: 0x00A7E814 File Offset: 0x00A7CA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string roleListURL;
			LuaObject.checkType(l, 2, out roleListURL);
			int channelId;
			LuaObject.checkType(l, 3, out channelId);
			int playerId;
			LuaObject.checkType(l, 4, out playerId);
			int headIcon;
			LuaObject.checkType(l, 5, out headIcon);
			int lastLoginHours;
			LuaObject.checkType(l, 6, out lastLoginHours);
			string charName;
			LuaObject.checkType(l, 7, out charName);
			LoginUITask.ExistCharInfo o = new LoginUITask.ExistCharInfo(roleListURL, channelId, playerId, headIcon, lastLoginHours, charName);
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

	// Token: 0x0601FCF5 RID: 130293 RVA: 0x00A7E8A8 File Offset: 0x00A7CAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_roleListURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF6 RID: 130294 RVA: 0x00A7E8FC File Offset: 0x00A7CAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			string roleListURL;
			LuaObject.checkType(l, 2, out roleListURL);
			existCharInfo.m_roleListURL = roleListURL;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF7 RID: 130295 RVA: 0x00A7E954 File Offset: 0x00A7CB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_channelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_channelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF8 RID: 130296 RVA: 0x00A7E9A8 File Offset: 0x00A7CBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_channelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			existCharInfo.m_channelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF9 RID: 130297 RVA: 0x00A7EA00 File Offset: 0x00A7CC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevel(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_playerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFA RID: 130298 RVA: 0x00A7EA54 File Offset: 0x00A7CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevel(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			existCharInfo.m_playerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFB RID: 130299 RVA: 0x00A7EAAC File Offset: 0x00A7CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFC RID: 130300 RVA: 0x00A7EB00 File Offset: 0x00A7CD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			existCharInfo.m_headIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFD RID: 130301 RVA: 0x00A7EB58 File Offset: 0x00A7CD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastLoginHours(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_lastLoginHours);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFE RID: 130302 RVA: 0x00A7EBAC File Offset: 0x00A7CDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastLoginHours(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			int lastLoginHours;
			LuaObject.checkType(l, 2, out lastLoginHours);
			existCharInfo.m_lastLoginHours = lastLoginHours;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCFF RID: 130303 RVA: 0x00A7EC04 File Offset: 0x00A7CE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existCharInfo.m_charName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD00 RID: 130304 RVA: 0x00A7EC58 File Offset: 0x00A7CE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ExistCharInfo existCharInfo = (LoginUITask.ExistCharInfo)LuaObject.checkSelf(l);
			string charName;
			LuaObject.checkType(l, 2, out charName);
			existCharInfo.m_charName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD01 RID: 130305 RVA: 0x00A7ECB0 File Offset: 0x00A7CEB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginUITask.ExistCharInfo");
		string name = "m_roleListURL";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_roleListURL);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_roleListURL);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache1, true);
		string name2 = "m_channelId";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_channelId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_channelId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache3, true);
		string name3 = "m_playerLevel";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_playerLevel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_playerLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache5, true);
		string name4 = "m_headIcon";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_headIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_headIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache7, true);
		string name5 = "m_lastLoginHours";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_lastLoginHours);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_lastLoginHours);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cache9, true);
		string name6 = "m_charName";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.get_m_charName);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.set_m_charName);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.<>f__mg$cacheC, typeof(LoginUITask.ExistCharInfo));
	}

	// Token: 0x04015CDC RID: 89308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015CDD RID: 89309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015CDE RID: 89310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015CDF RID: 89311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015CE0 RID: 89312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015CE1 RID: 89313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015CE2 RID: 89314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015CE3 RID: 89315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015CE4 RID: 89316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015CE5 RID: 89317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015CE6 RID: 89318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015CE7 RID: 89319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015CE8 RID: 89320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
