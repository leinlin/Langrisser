using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x02001526 RID: 5414
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController : LuaObject
{
	// Token: 0x06020264 RID: 131684 RVA: 0x00AA9928 File Offset: 0x00AA7B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillInfoAndDescObj(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GameObject descObj;
			LuaObject.checkType<GameObject>(l, 3, out descObj);
			playerHeroSkillUIController.SetSkillInfoAndDescObj(skillInfo, descObj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020265 RID: 131685 RVA: 0x00AA998C File Offset: 0x00AA7B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			playerHeroSkillUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020266 RID: 131686 RVA: 0x00AA99E4 File Offset: 0x00AA7BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			playerHeroSkillUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020267 RID: 131687 RVA: 0x00AA9A3C File Offset: 0x00AA7C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkillClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo obj;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out obj);
			playerHeroSkillUIController.m_luaExportHelper.__callDele_EventOnSkillClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020268 RID: 131688 RVA: 0x00AA9A98 File Offset: 0x00AA7C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkillClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo obj;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out obj);
			playerHeroSkillUIController.m_luaExportHelper.__clearDele_EventOnSkillClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020269 RID: 131689 RVA: 0x00AA9AF4 File Offset: 0x00AA7CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkillClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			Action<ConfigDataSkillInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataSkillInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerHeroSkillUIController.EventOnSkillClick += value;
				}
				else if (num == 2)
				{
					playerHeroSkillUIController.EventOnSkillClick -= value;
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

	// Token: 0x0602026A RID: 131690 RVA: 0x00AA9B74 File Offset: 0x00AA7D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_popupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroSkillUIController.m_luaExportHelper.m_popupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602026B RID: 131691 RVA: 0x00AA9BCC File Offset: 0x00AA7DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_popupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			GameObject popupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out popupGameObject);
			playerHeroSkillUIController.m_luaExportHelper.m_popupGameObject = popupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602026C RID: 131692 RVA: 0x00AA9C28 File Offset: 0x00AA7E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroSkillUIController.m_luaExportHelper.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602026D RID: 131693 RVA: 0x00AA9C80 File Offset: 0x00AA7E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroSkillUIController playerHeroSkillUIController = (PlayerHeroSkillUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			playerHeroSkillUIController.m_luaExportHelper.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602026E RID: 131694 RVA: 0x00AA9CDC File Offset: 0x00AA7EDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerHeroSkillUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.SetSkillInfoAndDescObj);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.__callDele_EventOnSkillClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.__clearDele_EventOnSkillClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache4);
		string name = "EventOnSkillClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.set_EventOnSkillClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache5, true);
		string name2 = "m_popupGameObject";
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.get_m_popupGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.set_m_popupGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache7, true);
		string name3 = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.get_m_skillInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.set_m_skillInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.<>f__mg$cache9, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerHeroSkillUIController), typeof(MonoBehaviour));
	}

	// Token: 0x040161FA RID: 90618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040161FB RID: 90619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040161FC RID: 90620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040161FD RID: 90621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040161FE RID: 90622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040161FF RID: 90623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016200 RID: 90624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016201 RID: 90625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016202 RID: 90626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016203 RID: 90627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
