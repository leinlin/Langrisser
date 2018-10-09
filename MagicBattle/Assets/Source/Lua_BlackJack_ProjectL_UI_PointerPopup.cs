using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x02001538 RID: 5432
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PointerPopup : LuaObject
{
	// Token: 0x06020639 RID: 132665 RVA: 0x00AC8444 File Offset: 0x00AC6644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPopupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			GameObject popupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out popupGameObject);
			pointerPopup.SetPopupGameObject(popupGameObject);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063A RID: 132666 RVA: 0x00AC849C File Offset: 0x00AC669C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerPopup.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063B RID: 132667 RVA: 0x00AC84F4 File Offset: 0x00AC66F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerPopup.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063C RID: 132668 RVA: 0x00AC854C File Offset: 0x00AC674C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_popupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerPopup.m_luaExportHelper.m_popupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063D RID: 132669 RVA: 0x00AC85A4 File Offset: 0x00AC67A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_popupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			GameObject popupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out popupGameObject);
			pointerPopup.m_luaExportHelper.m_popupGameObject = popupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063E RID: 132670 RVA: 0x00AC8600 File Offset: 0x00AC6800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerPopup.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602063F RID: 132671 RVA: 0x00AC8658 File Offset: 0x00AC6858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			PointerPopup pointerPopup = (PointerPopup)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			pointerPopup.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020640 RID: 132672 RVA: 0x00AC86B4 File Offset: 0x00AC68B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PointerPopup");
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.SetPopupGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache2);
		string name = "m_popupGameObject";
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.get_m_popupGameObject);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.set_m_popupGameObject);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache4, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointerPopup.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PointerPopup.<>f__mg$cache6, true);
		LuaObject.createTypeMetatable(l, null, typeof(PointerPopup), typeof(MonoBehaviour));
	}

	// Token: 0x040165AB RID: 91563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040165AC RID: 91564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040165AD RID: 91565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040165AE RID: 91566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040165AF RID: 91567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040165B0 RID: 91568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040165B1 RID: 91569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
