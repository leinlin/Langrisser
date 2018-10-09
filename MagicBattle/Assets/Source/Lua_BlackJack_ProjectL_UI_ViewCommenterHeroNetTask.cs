using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D8 RID: 5592
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask : LuaObject
{
	// Token: 0x06022250 RID: 139856 RVA: 0x00BA7DCC File Offset: 0x00BA5FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			string userId;
			LuaObject.checkType(l, 3, out userId);
			ViewCommenterHeroNetTask o = new ViewCommenterHeroNetTask(heroId, userId);
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

	// Token: 0x06022251 RID: 139857 RVA: 0x00BA7E2C File Offset: 0x00BA602C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerHero(IntPtr l)
	{
		int result;
		try
		{
			ViewCommenterHeroNetTask viewCommenterHeroNetTask = (ViewCommenterHeroNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, viewCommenterHeroNetTask.PlayerHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022252 RID: 139858 RVA: 0x00BA7E80 File Offset: 0x00BA6080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerHero(IntPtr l)
	{
		int result;
		try
		{
			ViewCommenterHeroNetTask viewCommenterHeroNetTask = (ViewCommenterHeroNetTask)LuaObject.checkSelf(l);
			Hero playerHero;
			LuaObject.checkType<Hero>(l, 2, out playerHero);
			viewCommenterHeroNetTask.PlayerHero = playerHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022253 RID: 139859 RVA: 0x00BA7ED8 File Offset: 0x00BA60D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ViewCommenterHeroNetTask");
		string name = "PlayerHero";
		if (Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.get_PlayerHero);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.set_PlayerHero);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.<>f__mg$cache2, typeof(ViewCommenterHeroNetTask), typeof(UINetTask));
	}

	// Token: 0x04018082 RID: 98434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018083 RID: 98435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018084 RID: 98436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
