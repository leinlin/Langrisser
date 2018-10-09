using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Resource;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001109 RID: 4361
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_GameManager : LuaObject
{
	// Token: 0x06015B18 RID: 88856 RVA: 0x005938E0 File Offset: 0x00591AE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitlizeAudioManager(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			bool b = gameManager.InitlizeAudioManager();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B19 RID: 88857 RVA: 0x00593934 File Offset: 0x00591B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitlizeBeforeGameAuthLogin(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			string loginUserId;
			LuaObject.checkType(l, 2, out loginUserId);
			bool b = gameManager.InitlizeBeforeGameAuthLogin(loginUserId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1A RID: 88858 RVA: 0x00593998 File Offset: 0x00591B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPlayerContext(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			bool b = gameManager.InitPlayerContext();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1B RID: 88859 RVA: 0x005939EC File Offset: 0x00591BEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGameManagerParam(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			object value;
			LuaObject.checkType<object>(l, 3, out value);
			gameManager.SetGameManagerParam(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1C RID: 88860 RVA: 0x00593A50 File Offset: 0x00591C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Return2Login(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			bool raiseCriticalDataCacheDirty;
			LuaObject.checkType(l, 2, out raiseCriticalDataCacheDirty);
			gameManager.Return2Login(raiseCriticalDataCacheDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1D RID: 88861 RVA: 0x00593AA8 File Offset: 0x00591CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear4Return2Login(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			bool isCacheDataDirty;
			LuaObject.checkType(l, 2, out isCacheDataDirty);
			gameManager.Clear4Return2Login(isCacheDataDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1E RID: 88862 RVA: 0x00593B00 File Offset: 0x00591D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear4Relogin(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			gameManager.Clear4Relogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B1F RID: 88863 RVA: 0x00593B4C File Offset: 0x00591D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCorutine(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Func<IEnumerator>)))
			{
				GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
				Func<IEnumerator> corutine;
				LuaObject.checkDelegate<Func<IEnumerator>>(l, 2, out corutine);
				gameManager.StartCorutine(corutine);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(IEnumerator)))
			{
				GameManager gameManager2 = (GameManager)LuaObject.checkSelf(l);
				IEnumerator corutine2;
				LuaObject.checkType<IEnumerator>(l, 2, out corutine2);
				gameManager2.StartCorutine(corutine2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartCorutine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B20 RID: 88864 RVA: 0x00593C24 File Offset: 0x00591E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			gameManager.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B21 RID: 88865 RVA: 0x00593C70 File Offset: 0x00591E70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GameManager.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B22 RID: 88866 RVA: 0x00593CB8 File Offset: 0x00591EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GameClientSetting(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.GameClientSetting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B23 RID: 88867 RVA: 0x00593D0C File Offset: 0x00591F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CreateResourceManagerHandler(IntPtr l)
	{
		int result;
		try
		{
			Func<ResourceManager> func;
			int num = LuaObject.checkDelegate<Func<ResourceManager>>(l, 2, out func);
			if (num == 0)
			{
				GameManager.CreateResourceManagerHandler = func;
			}
			else if (num == 1)
			{
				GameManager.CreateResourceManagerHandler = (Func<ResourceManager>)Delegate.Combine(GameManager.CreateResourceManagerHandler, func);
			}
			else if (num == 2)
			{
				GameManager.CreateResourceManagerHandler = (Func<ResourceManager>)Delegate.Remove(GameManager.CreateResourceManagerHandler, func);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B24 RID: 88868 RVA: 0x00593DA0 File Offset: 0x00591FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AudioManager(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.AudioManager);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B25 RID: 88869 RVA: 0x00593DF4 File Offset: 0x00591FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B26 RID: 88870 RVA: 0x00593E48 File Offset: 0x00592048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StringTableManager(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.StringTableManager);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B27 RID: 88871 RVA: 0x00593E9C File Offset: 0x0059209C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NetworkClient(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.NetworkClient);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B28 RID: 88872 RVA: 0x00593EF0 File Offset: 0x005920F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerContext(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.PlayerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B29 RID: 88873 RVA: 0x00593F44 File Offset: 0x00592144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoginUserId(IntPtr l)
	{
		int result;
		try
		{
			GameManager gameManager = (GameManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameManager.LoginUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B2A RID: 88874 RVA: 0x00593F98 File Offset: 0x00592198
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.GameManager");
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.InitlizeAudioManager);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.InitlizeBeforeGameAuthLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.InitPlayerContext);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.SetGameManagerParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.Return2Login);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.Clear4Return2Login);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.Clear4Relogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.StartCorutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache8);
		string name = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_Instance);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache9, null, false);
		string name2 = "GameClientSetting";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_GameClientSetting);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheA, null, true);
		string name3 = "CreateResourceManagerHandler";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.set_CreateResourceManagerHandler);
		}
		LuaObject.addMember(l, name3, get, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheB, false);
		string name4 = "AudioManager";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_AudioManager);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheC, null, true);
		string name5 = "ConfigDataLoader";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheD, null, true);
		string name6 = "StringTableManager";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_StringTableManager);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheE, null, true);
		string name7 = "NetworkClient";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_NetworkClient);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cacheF, null, true);
		string name8 = "PlayerContext";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_PlayerContext);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache10, null, true);
		string name9 = "LoginUserId";
		if (Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_GameManager.get_LoginUserId);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_BJFramework_Runtime_GameManager.<>f__mg$cache11, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(GameManager));
	}

	// Token: 0x0400C2E8 RID: 49896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2E9 RID: 49897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2EA RID: 49898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C2EB RID: 49899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C2EC RID: 49900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C2ED RID: 49901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C2EE RID: 49902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C2EF RID: 49903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C2F0 RID: 49904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C2F1 RID: 49905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C2F2 RID: 49906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C2F3 RID: 49907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C2F4 RID: 49908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C2F5 RID: 49909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C2F6 RID: 49910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C2F7 RID: 49911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C2F8 RID: 49912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C2F9 RID: 49913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
