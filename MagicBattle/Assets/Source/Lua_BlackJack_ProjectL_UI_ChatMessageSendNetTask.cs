using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013EC RID: 5100
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask : LuaObject
{
	// Token: 0x0601C94F RID: 117071 RVA: 0x008E3B94 File Offset: 0x008E1D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ChatChannel channel;
				LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
				string content;
				LuaObject.checkType(l, 3, out content);
				ChatMessageSendNetTask o = new ChatMessageSendNetTask(channel, content);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 8)
			{
				ChatChannel channel2;
				LuaObject.checkEnum<ChatChannel>(l, 2, out channel2);
				byte[] voiceBytes;
				LuaObject.checkArray<byte>(l, 3, out voiceBytes);
				int length;
				LuaObject.checkType(l, 4, out length);
				int frequency;
				LuaObject.checkType(l, 5, out frequency);
				int samples;
				LuaObject.checkType(l, 6, out samples);
				string translateText;
				LuaObject.checkType(l, 7, out translateText);
				string userID;
				LuaObject.checkType(l, 8, out userID);
				ChatMessageSendNetTask o = new ChatMessageSendNetTask(channel2, voiceBytes, length, frequency, samples, translateText, userID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C950 RID: 117072 RVA: 0x008E3C90 File Offset: 0x008E1E90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatMessageSendNetTask");
		if (Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask.<>f__mg$cache0, typeof(ChatMessageSendNetTask), typeof(UINetTask));
	}

	// Token: 0x04012B59 RID: 76633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
