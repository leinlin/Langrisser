using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014FE RID: 5374
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo : LuaObject
{
	// Token: 0x0601FD03 RID: 130307 RVA: 0x00A7EEA4 File Offset: 0x00A7D0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int initialIndex;
			LuaObject.checkType(l, 2, out initialIndex);
			int id;
			LuaObject.checkType(l, 3, out id);
			string name;
			LuaObject.checkType(l, 4, out name);
			LoginUITask.ServerInfo.State state;
			LuaObject.checkEnum<LoginUITask.ServerInfo.State>(l, 5, out state);
			bool isNew;
			LuaObject.checkType(l, 6, out isNew);
			string ip;
			LuaObject.checkType(l, 7, out ip);
			int port;
			LuaObject.checkType(l, 8, out port);
			string loginAgentUrl;
			LuaObject.checkType(l, 9, out loginAgentUrl);
			int channelId;
			LuaObject.checkType(l, 10, out channelId);
			int bornChannelId;
			LuaObject.checkType(l, 11, out bornChannelId);
			float recommendWeight;
			LuaObject.checkType(l, 12, out recommendWeight);
			string roleListURL;
			LuaObject.checkType(l, 13, out roleListURL);
			int realmID;
			LuaObject.checkType(l, 14, out realmID);
			bool isAppleReview;
			LuaObject.checkType(l, 15, out isAppleReview);
			string serverOpenDateTime;
			LuaObject.checkType(l, 16, out serverOpenDateTime);
			bool isRefuseNewPlayer;
			LuaObject.checkType(l, 17, out isRefuseNewPlayer);
			string areaName;
			LuaObject.checkType(l, 18, out areaName);
			LoginUITask.ServerInfo o = new LoginUITask.ServerInfo(initialIndex, id, name, state, isNew, ip, port, loginAgentUrl, channelId, bornChannelId, recommendWeight, roleListURL, realmID, isAppleReview, serverOpenDateTime, isRefuseNewPlayer, areaName);
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

	// Token: 0x0601FD04 RID: 130308 RVA: 0x00A7EFC4 File Offset: 0x00A7D1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD05 RID: 130309 RVA: 0x00A7F018 File Offset: 0x00A7D218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			serverInfo.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD06 RID: 130310 RVA: 0x00A7F070 File Offset: 0x00A7D270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_name(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD07 RID: 130311 RVA: 0x00A7F0C4 File Offset: 0x00A7D2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_name(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			serverInfo.m_name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD08 RID: 130312 RVA: 0x00A7F11C File Offset: 0x00A7D31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)serverInfo.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD09 RID: 130313 RVA: 0x00A7F170 File Offset: 0x00A7D370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LoginUITask.ServerInfo.State state;
			LuaObject.checkEnum<LoginUITask.ServerInfo.State>(l, 2, out state);
			serverInfo.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0A RID: 130314 RVA: 0x00A7F1C8 File Offset: 0x00A7D3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_isNew);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0B RID: 130315 RVA: 0x00A7F21C File Offset: 0x00A7D41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			bool isNew;
			LuaObject.checkType(l, 2, out isNew);
			serverInfo.m_isNew = isNew;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0C RID: 130316 RVA: 0x00A7F274 File Offset: 0x00A7D474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ip(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_ip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0D RID: 130317 RVA: 0x00A7F2C8 File Offset: 0x00A7D4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ip(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string ip;
			LuaObject.checkType(l, 2, out ip);
			serverInfo.m_ip = ip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0E RID: 130318 RVA: 0x00A7F320 File Offset: 0x00A7D520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_port(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_port);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD0F RID: 130319 RVA: 0x00A7F374 File Offset: 0x00A7D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_port(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int port;
			LuaObject.checkType(l, 2, out port);
			serverInfo.m_port = port;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD10 RID: 130320 RVA: 0x00A7F3CC File Offset: 0x00A7D5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginAgentUrl(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_loginAgentUrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD11 RID: 130321 RVA: 0x00A7F420 File Offset: 0x00A7D620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginAgentUrl(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string loginAgentUrl;
			LuaObject.checkType(l, 2, out loginAgentUrl);
			serverInfo.m_loginAgentUrl = loginAgentUrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD12 RID: 130322 RVA: 0x00A7F478 File Offset: 0x00A7D678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_channelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_channelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD13 RID: 130323 RVA: 0x00A7F4CC File Offset: 0x00A7D6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_channelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			serverInfo.m_channelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD14 RID: 130324 RVA: 0x00A7F524 File Offset: 0x00A7D724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_bornChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD15 RID: 130325 RVA: 0x00A7F578 File Offset: 0x00A7D778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int bornChannelId;
			LuaObject.checkType(l, 2, out bornChannelId);
			serverInfo.m_bornChannelId = bornChannelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD16 RID: 130326 RVA: 0x00A7F5D0 File Offset: 0x00A7D7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendWeight(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_recommendWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD17 RID: 130327 RVA: 0x00A7F624 File Offset: 0x00A7D824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendWeight(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			float recommendWeight;
			LuaObject.checkType(l, 2, out recommendWeight);
			serverInfo.m_recommendWeight = recommendWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD18 RID: 130328 RVA: 0x00A7F67C File Offset: 0x00A7D87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initialIndex(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_initialIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD19 RID: 130329 RVA: 0x00A7F6D0 File Offset: 0x00A7D8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initialIndex(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int initialIndex;
			LuaObject.checkType(l, 2, out initialIndex);
			serverInfo.m_initialIndex = initialIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1A RID: 130330 RVA: 0x00A7F728 File Offset: 0x00A7D928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sdkPlatformName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_sdkPlatformName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1B RID: 130331 RVA: 0x00A7F77C File Offset: 0x00A7D97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sdkPlatformName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string sdkPlatformName;
			LuaObject.checkType(l, 2, out sdkPlatformName);
			serverInfo.m_sdkPlatformName = sdkPlatformName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1C RID: 130332 RVA: 0x00A7F7D4 File Offset: 0x00A7D9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sdkPlatformUserID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_sdkPlatformUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1D RID: 130333 RVA: 0x00A7F828 File Offset: 0x00A7DA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sdkPlatformUserID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string sdkPlatformUserID;
			LuaObject.checkType(l, 2, out sdkPlatformUserID);
			serverInfo.m_sdkPlatformUserID = sdkPlatformUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1E RID: 130334 RVA: 0x00A7F880 File Offset: 0x00A7DA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_roleListURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD1F RID: 130335 RVA: 0x00A7F8D4 File Offset: 0x00A7DAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string roleListURL;
			LuaObject.checkType(l, 2, out roleListURL);
			serverInfo.m_roleListURL = roleListURL;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD20 RID: 130336 RVA: 0x00A7F92C File Offset: 0x00A7DB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realmID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_realmID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD21 RID: 130337 RVA: 0x00A7F980 File Offset: 0x00A7DB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realmID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			int realmID;
			LuaObject.checkType(l, 2, out realmID);
			serverInfo.m_realmID = realmID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD22 RID: 130338 RVA: 0x00A7F9D8 File Offset: 0x00A7DBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAppleReview(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_isAppleReview);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD23 RID: 130339 RVA: 0x00A7FA2C File Offset: 0x00A7DC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAppleReview(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			bool isAppleReview;
			LuaObject.checkType(l, 2, out isAppleReview);
			serverInfo.m_isAppleReview = isAppleReview;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD24 RID: 130340 RVA: 0x00A7FA84 File Offset: 0x00A7DC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverOpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_serverOpenDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD25 RID: 130341 RVA: 0x00A7FAD8 File Offset: 0x00A7DCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverOpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string serverOpenDateTime;
			LuaObject.checkType(l, 2, out serverOpenDateTime);
			serverInfo.m_serverOpenDateTime = serverOpenDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD26 RID: 130342 RVA: 0x00A7FB30 File Offset: 0x00A7DD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRefuseNewPlayer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_isRefuseNewPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD27 RID: 130343 RVA: 0x00A7FB84 File Offset: 0x00A7DD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRefuseNewPlayer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			bool isRefuseNewPlayer;
			LuaObject.checkType(l, 2, out isRefuseNewPlayer);
			serverInfo.m_isRefuseNewPlayer = isRefuseNewPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD28 RID: 130344 RVA: 0x00A7FBDC File Offset: 0x00A7DDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_areaName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfo.m_areaName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD29 RID: 130345 RVA: 0x00A7FC30 File Offset: 0x00A7DE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_areaName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo serverInfo = (LoginUITask.ServerInfo)LuaObject.checkSelf(l);
			string areaName;
			LuaObject.checkType(l, 2, out areaName);
			serverInfo.m_areaName = areaName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD2A RID: 130346 RVA: 0x00A7FC88 File Offset: 0x00A7DE88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginUITask.ServerInfo");
		string name = "m_id";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1, true);
		string name2 = "m_name";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache3, true);
		string name3 = "m_state";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_state);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_state);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache5, true);
		string name4 = "m_isNew";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_isNew);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_isNew);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache7, true);
		string name5 = "m_ip";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_ip);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_ip);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache9, true);
		string name6 = "m_port";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_port);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_port);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheB, true);
		string name7 = "m_loginAgentUrl";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_loginAgentUrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_loginAgentUrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheD, true);
		string name8 = "m_channelId";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_channelId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_channelId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cacheF, true);
		string name9 = "m_bornChannelId";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_bornChannelId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_bornChannelId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache11, true);
		string name10 = "m_recommendWeight";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_recommendWeight);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_recommendWeight);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache13, true);
		string name11 = "m_initialIndex";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_initialIndex);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_initialIndex);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache15, true);
		string name12 = "m_sdkPlatformName";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_sdkPlatformName);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_sdkPlatformName);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache17, true);
		string name13 = "m_sdkPlatformUserID";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_sdkPlatformUserID);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_sdkPlatformUserID);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache19, true);
		string name14 = "m_roleListURL";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_roleListURL);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_roleListURL);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1B, true);
		string name15 = "m_realmID";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_realmID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_realmID);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1D, true);
		string name16 = "m_isAppleReview";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_isAppleReview);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_isAppleReview);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache1F, true);
		string name17 = "m_serverOpenDateTime";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_serverOpenDateTime);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_serverOpenDateTime);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache21, true);
		string name18 = "m_isRefuseNewPlayer";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_isRefuseNewPlayer);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_isRefuseNewPlayer);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache23, true);
		string name19 = "m_areaName";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.get_m_areaName);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.set_m_areaName);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache25, true);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.<>f__mg$cache26, typeof(LoginUITask.ServerInfo));
	}

	// Token: 0x04015CE9 RID: 89321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015CEA RID: 89322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015CEB RID: 89323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015CEC RID: 89324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015CED RID: 89325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015CEE RID: 89326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015CEF RID: 89327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015CF0 RID: 89328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015CF1 RID: 89329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015CF2 RID: 89330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015CF3 RID: 89331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015CF4 RID: 89332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015CF5 RID: 89333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015CF6 RID: 89334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015CF7 RID: 89335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015CF8 RID: 89336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015CF9 RID: 89337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015CFA RID: 89338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015CFB RID: 89339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015CFC RID: 89340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015CFD RID: 89341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015CFE RID: 89342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015CFF RID: 89343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015D00 RID: 89344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015D01 RID: 89345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015D02 RID: 89346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015D03 RID: 89347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015D04 RID: 89348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015D05 RID: 89349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015D06 RID: 89350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015D07 RID: 89351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015D08 RID: 89352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015D09 RID: 89353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015D0A RID: 89354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015D0B RID: 89355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015D0C RID: 89356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015D0D RID: 89357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015D0E RID: 89358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015D0F RID: 89359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
