using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015DB RID: 5595
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner : LuaObject
{
	// Token: 0x06022269 RID: 139881 RVA: 0x00BA87F8 File Offset: 0x00BA69F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTalkButtonSize(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Vector2 talkButtonSize;
			LuaObject.checkType(l, 2, out talkButtonSize);
			voiceRecordButtonListerner.SetTalkButtonSize(talkButtonSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226A RID: 139882 RVA: 0x00BA8850 File Offset: 0x00BA6A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226B RID: 139883 RVA: 0x00BA88A4 File Offset: 0x00BA6AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitTalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			voiceRecordButtonListerner.m_luaExportHelper.OnExitTalkButton(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226C RID: 139884 RVA: 0x00BA8900 File Offset: 0x00BA6B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnterTalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			voiceRecordButtonListerner.m_luaExportHelper.OnEnterTalkButton(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226D RID: 139885 RVA: 0x00BA895C File Offset: 0x00BA6B5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTalkButtonClickDown(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			voiceRecordButtonListerner.m_luaExportHelper.OnTalkButtonClickDown(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226E RID: 139886 RVA: 0x00BA89B8 File Offset: 0x00BA6BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			voiceRecordButtonListerner.m_luaExportHelper.OnTalkButtonClickUp(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602226F RID: 139887 RVA: 0x00BA8A14 File Offset: 0x00BA6C14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTalkButtonTestHoding(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			IEnumerator o = voiceRecordButtonListerner.m_luaExportHelper.OnTalkButtonTestHoding();
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

	// Token: 0x06022270 RID: 139888 RVA: 0x00BA8A70 File Offset: 0x00BA6C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__callDele_EventOnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022271 RID: 139889 RVA: 0x00BA8AC4 File Offset: 0x00BA6CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__clearDele_EventOnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022272 RID: 139890 RVA: 0x00BA8B18 File Offset: 0x00BA6D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__callDele_EventOnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022273 RID: 139891 RVA: 0x00BA8B6C File Offset: 0x00BA6D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__clearDele_EventOnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022274 RID: 139892 RVA: 0x00BA8BC0 File Offset: 0x00BA6DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__callDele_EventOnExitTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022275 RID: 139893 RVA: 0x00BA8C14 File Offset: 0x00BA6E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__clearDele_EventOnExitTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022276 RID: 139894 RVA: 0x00BA8C68 File Offset: 0x00BA6E68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__callDele_EventOnEnterTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022277 RID: 139895 RVA: 0x00BA8CBC File Offset: 0x00BA6EBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			voiceRecordButtonListerner.m_luaExportHelper.__clearDele_EventOnEnterTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022278 RID: 139896 RVA: 0x00BA8D10 File Offset: 0x00BA6F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordButtonListerner.m_luaExportHelper.TalkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022279 RID: 139897 RVA: 0x00BA8D68 File Offset: 0x00BA6F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Button talkButton;
			LuaObject.checkType<Button>(l, 2, out talkButton);
			voiceRecordButtonListerner.m_luaExportHelper.TalkButton = talkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602227A RID: 139898 RVA: 0x00BA8DC4 File Offset: 0x00BA6FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_coroutineTalkButtonTestHolding(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordButtonListerner.m_luaExportHelper.m_coroutineTalkButtonTestHolding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602227B RID: 139899 RVA: 0x00BA8E1C File Offset: 0x00BA701C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_coroutineTalkButtonTestHolding(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Coroutine coroutineTalkButtonTestHolding;
			LuaObject.checkType<Coroutine>(l, 2, out coroutineTalkButtonTestHolding);
			voiceRecordButtonListerner.m_luaExportHelper.m_coroutineTalkButtonTestHolding = coroutineTalkButtonTestHolding;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602227C RID: 139900 RVA: 0x00BA8E78 File Offset: 0x00BA7078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordButtonListerner.EventOnTalkButtonHold += value;
				}
				else if (num == 2)
				{
					voiceRecordButtonListerner.EventOnTalkButtonHold -= value;
				}
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

	// Token: 0x0602227D RID: 139901 RVA: 0x00BA8EF8 File Offset: 0x00BA70F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordButtonListerner.EventOnTalkButtonClickUp += value;
				}
				else if (num == 2)
				{
					voiceRecordButtonListerner.EventOnTalkButtonClickUp -= value;
				}
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

	// Token: 0x0602227E RID: 139902 RVA: 0x00BA8F78 File Offset: 0x00BA7178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordButtonListerner.EventOnExitTalkButtonClick += value;
				}
				else if (num == 2)
				{
					voiceRecordButtonListerner.EventOnExitTalkButtonClick -= value;
				}
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

	// Token: 0x0602227F RID: 139903 RVA: 0x00BA8FF8 File Offset: 0x00BA71F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordButtonListerner voiceRecordButtonListerner = (VoiceRecordButtonListerner)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					voiceRecordButtonListerner.EventOnEnterTalkButtonClick += value;
				}
				else if (num == 2)
				{
					voiceRecordButtonListerner.EventOnEnterTalkButtonClick -= value;
				}
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

	// Token: 0x06022280 RID: 139904 RVA: 0x00BA9078 File Offset: 0x00BA7278
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoiceRecordButtonListerner");
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.SetTalkButtonSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.OnExitTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.OnEnterTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.OnTalkButtonClickDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.OnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.OnTalkButtonTestHoding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__callDele_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__clearDele_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__callDele_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__clearDele_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__callDele_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__clearDele_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__callDele_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.__clearDele_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheE);
		string name = "TalkButton";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.get_TalkButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_TalkButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache10, true);
		string name2 = "m_coroutineTalkButtonTestHolding";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.get_m_coroutineTalkButtonTestHolding);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_m_coroutineTalkButtonTestHolding);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache12, true);
		string name3 = "EventOnTalkButtonHold";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache13, true);
		string name4 = "EventOnTalkButtonClickUp";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache14, true);
		string name5 = "EventOnExitTalkButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache15, true);
		string name6 = "EventOnEnterTalkButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.set_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.<>f__mg$cache16, true);
		LuaObject.createTypeMetatable(l, null, typeof(VoiceRecordButtonListerner), typeof(MonoBehaviour));
	}

	// Token: 0x04018095 RID: 98453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018096 RID: 98454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018097 RID: 98455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018098 RID: 98456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018099 RID: 98457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401809A RID: 98458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401809B RID: 98459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401809C RID: 98460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401809D RID: 98461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401809E RID: 98462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401809F RID: 98463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040180A0 RID: 98464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040180A1 RID: 98465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040180A2 RID: 98466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040180A3 RID: 98467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040180A4 RID: 98468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040180A5 RID: 98469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040180A6 RID: 98470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040180A7 RID: 98471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040180A8 RID: 98472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040180A9 RID: 98473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040180AA RID: 98474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040180AB RID: 98475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
