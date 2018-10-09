using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015DA RID: 5594
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoicePlayer : LuaObject
{
	// Token: 0x06022264 RID: 139876 RVA: 0x00BA866C File Offset: 0x00BA686C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			VoicePlayer o = new VoicePlayer();
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

	// Token: 0x06022265 RID: 139877 RVA: 0x00BA86B4 File Offset: 0x00BA68B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetVoiceContentAndPlayVoice_s(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatInfo;
			LuaObject.checkType<ChatVoiceMessage>(l, 1, out chatInfo);
			Action onStartPlayVoice;
			LuaObject.checkDelegate<Action>(l, 2, out onStartPlayVoice);
			VoicePlayer.GetVoiceContentAndPlayVoice(chatInfo, onStartPlayVoice);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022266 RID: 139878 RVA: 0x00BA870C File Offset: 0x00BA690C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayPlayerVoice_s(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatInfo;
			LuaObject.checkType<ChatVoiceMessage>(l, 1, out chatInfo);
			Action onStartPlayVoice;
			LuaObject.checkDelegate<Action>(l, 2, out onStartPlayVoice);
			VoicePlayer.PlayPlayerVoice(chatInfo, onStartPlayVoice);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022267 RID: 139879 RVA: 0x00BA8764 File Offset: 0x00BA6964
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoicePlayer");
		if (Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoicePlayer.GetVoiceContentAndPlayVoice_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoicePlayer.PlayPlayerVoice_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoicePlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_VoicePlayer.<>f__mg$cache2, typeof(VoicePlayer));
	}

	// Token: 0x04018092 RID: 98450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018093 RID: 98451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018094 RID: 98452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
