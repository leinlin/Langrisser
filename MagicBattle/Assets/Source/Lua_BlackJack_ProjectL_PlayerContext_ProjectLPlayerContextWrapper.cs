using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D8 RID: 4824
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper : LuaObject
{
	// Token: 0x06019F3B RID: 106299 RVA: 0x00799DA4 File Offset: 0x00797FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			IPlayerContextNetworkEventHandler playerContext;
			LuaObject.checkType<IPlayerContextNetworkEventHandler>(l, 2, out playerContext);
			ProjectLPlayerContextWrapper o = new ProjectLPlayerContextWrapper(playerContext);
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

	// Token: 0x06019F3C RID: 106300 RVA: 0x00799DF8 File Offset: 0x00797FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConnected(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			projectLPlayerContextWrapper.OnConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F3D RID: 106301 RVA: 0x00799E44 File Offset: 0x00798044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisconnected(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			projectLPlayerContextWrapper.OnDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F3E RID: 106302 RVA: 0x00799E90 File Offset: 0x00798090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnError(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			int err;
			LuaObject.checkType(l, 2, out err);
			string excepionInfo;
			LuaObject.checkType(l, 3, out excepionInfo);
			projectLPlayerContextWrapper.OnError(err, excepionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F3F RID: 106303 RVA: 0x00799EF4 File Offset: 0x007980F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginByAuthTokenAck(IntPtr l)
	{
		int result2;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			bool needRedirect;
			LuaObject.checkType(l, 3, out needRedirect);
			string sessionToken;
			LuaObject.checkType(l, 4, out sessionToken);
			projectLPlayerContextWrapper.OnLoginByAuthTokenAck(result, needRedirect, sessionToken);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06019F40 RID: 106304 RVA: 0x00799F68 File Offset: 0x00798168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginBySessionTokenAck(IntPtr l)
	{
		int result2;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			projectLPlayerContextWrapper.OnLoginBySessionTokenAck(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06019F41 RID: 106305 RVA: 0x00799FC0 File Offset: 0x007981C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessage(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			int msgId;
			LuaObject.checkType(l, 3, out msgId);
			projectLPlayerContextWrapper.OnMessage(msg, msgId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F42 RID: 106306 RVA: 0x0079A024 File Offset: 0x00798224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projectLPlayerContextWrapper.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F43 RID: 106307 RVA: 0x0079A07C File Offset: 0x0079827C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ProjectLPlayerContextWrapper projectLPlayerContextWrapper = (ProjectLPlayerContextWrapper)LuaObject.checkSelf(l);
			IPlayerContextNetworkEventHandler playerContext;
			LuaObject.checkType<IPlayerContextNetworkEventHandler>(l, 2, out playerContext);
			projectLPlayerContextWrapper.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F44 RID: 106308 RVA: 0x0079A0D8 File Offset: 0x007982D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ProjectLPlayerContextWrapper");
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.OnMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache5);
		string name = "m_playerContext";
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.get_m_playerContext);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.set_m_playerContext);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.<>f__mg$cache8, typeof(ProjectLPlayerContextWrapper));
	}

	// Token: 0x0401036D RID: 66413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401036E RID: 66414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401036F RID: 66415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010370 RID: 66416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010371 RID: 66417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010372 RID: 66418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010373 RID: 66419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010374 RID: 66420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010375 RID: 66421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
