using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200185B RID: 6235
[Preserve]
public class Lua_UnityEngine_UI_Selectable : LuaObject
{
	// Token: 0x06024259 RID: 148057 RVA: 0x00CB1DAC File Offset: 0x00CAFFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInteractable(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			bool b = selectable.IsInteractable();
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

	// Token: 0x0602425A RID: 148058 RVA: 0x00CB1E00 File Offset: 0x00CB0000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectable(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Vector3 dir;
			LuaObject.checkType(l, 2, out dir);
			Selectable o = selectable.FindSelectable(dir);
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

	// Token: 0x0602425B RID: 148059 RVA: 0x00CB1E64 File Offset: 0x00CB0064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnLeft(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Selectable o = selectable.FindSelectableOnLeft();
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

	// Token: 0x0602425C RID: 148060 RVA: 0x00CB1EB8 File Offset: 0x00CB00B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnRight(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Selectable o = selectable.FindSelectableOnRight();
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

	// Token: 0x0602425D RID: 148061 RVA: 0x00CB1F0C File Offset: 0x00CB010C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnUp(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Selectable o = selectable.FindSelectableOnUp();
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

	// Token: 0x0602425E RID: 148062 RVA: 0x00CB1F60 File Offset: 0x00CB0160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindSelectableOnDown(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Selectable o = selectable.FindSelectableOnDown();
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

	// Token: 0x0602425F RID: 148063 RVA: 0x00CB1FB4 File Offset: 0x00CB01B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMove(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			AxisEventData eventData;
			LuaObject.checkType<AxisEventData>(l, 2, out eventData);
			selectable.OnMove(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024260 RID: 148064 RVA: 0x00CB200C File Offset: 0x00CB020C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			selectable.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024261 RID: 148065 RVA: 0x00CB2064 File Offset: 0x00CB0264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			selectable.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024262 RID: 148066 RVA: 0x00CB20BC File Offset: 0x00CB02BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerEnter(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			selectable.OnPointerEnter(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024263 RID: 148067 RVA: 0x00CB2114 File Offset: 0x00CB0314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerExit(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			selectable.OnPointerExit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024264 RID: 148068 RVA: 0x00CB216C File Offset: 0x00CB036C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelect(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			selectable.OnSelect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024265 RID: 148069 RVA: 0x00CB21C4 File Offset: 0x00CB03C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeselect(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			selectable.OnDeselect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024266 RID: 148070 RVA: 0x00CB221C File Offset: 0x00CB041C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Select(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			selectable.Select();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024267 RID: 148071 RVA: 0x00CB2268 File Offset: 0x00CB0468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allSelectables(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Selectable.allSelectables);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024268 RID: 148072 RVA: 0x00CB22B0 File Offset: 0x00CB04B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_navigation(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.navigation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024269 RID: 148073 RVA: 0x00CB2308 File Offset: 0x00CB0508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_navigation(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 2, out navigation);
			selectable.navigation = navigation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426A RID: 148074 RVA: 0x00CB2360 File Offset: 0x00CB0560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transition(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)selectable.transition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426B RID: 148075 RVA: 0x00CB23B4 File Offset: 0x00CB05B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transition(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Selectable.Transition transition;
			LuaObject.checkEnum<Selectable.Transition>(l, 2, out transition);
			selectable.transition = transition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426C RID: 148076 RVA: 0x00CB240C File Offset: 0x00CB060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colors(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.colors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426D RID: 148077 RVA: 0x00CB2464 File Offset: 0x00CB0664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colors(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			ColorBlock colors;
			LuaObject.checkValueType<ColorBlock>(l, 2, out colors);
			selectable.colors = colors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426E RID: 148078 RVA: 0x00CB24BC File Offset: 0x00CB06BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spriteState(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.spriteState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602426F RID: 148079 RVA: 0x00CB2514 File Offset: 0x00CB0714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spriteState(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 2, out spriteState);
			selectable.spriteState = spriteState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024270 RID: 148080 RVA: 0x00CB256C File Offset: 0x00CB076C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_animationTriggers(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.animationTriggers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024271 RID: 148081 RVA: 0x00CB25C0 File Offset: 0x00CB07C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_animationTriggers(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			AnimationTriggers animationTriggers;
			LuaObject.checkType<AnimationTriggers>(l, 2, out animationTriggers);
			selectable.animationTriggers = animationTriggers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024272 RID: 148082 RVA: 0x00CB2618 File Offset: 0x00CB0818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_targetGraphic(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.targetGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024273 RID: 148083 RVA: 0x00CB266C File Offset: 0x00CB086C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_targetGraphic(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Graphic targetGraphic;
			LuaObject.checkType<Graphic>(l, 2, out targetGraphic);
			selectable.targetGraphic = targetGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024274 RID: 148084 RVA: 0x00CB26C4 File Offset: 0x00CB08C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_interactable(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.interactable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024275 RID: 148085 RVA: 0x00CB2718 File Offset: 0x00CB0918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_interactable(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			bool interactable;
			LuaObject.checkType(l, 2, out interactable);
			selectable.interactable = interactable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024276 RID: 148086 RVA: 0x00CB2770 File Offset: 0x00CB0970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_image(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024277 RID: 148087 RVA: 0x00CB27C4 File Offset: 0x00CB09C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_image(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			selectable.image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024278 RID: 148088 RVA: 0x00CB281C File Offset: 0x00CB0A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_animator(IntPtr l)
	{
		int result;
		try
		{
			Selectable selectable = (Selectable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectable.animator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024279 RID: 148089 RVA: 0x00CB2870 File Offset: 0x00CB0A70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Selectable");
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.IsInteractable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.FindSelectable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.FindSelectableOnLeft);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.FindSelectableOnRight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.FindSelectableOnUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.FindSelectableOnDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnPointerEnter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnPointerExit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnSelect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cacheB);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.OnDeselect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cacheC);
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.Select);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Selectable.<>f__mg$cacheD);
		string name = "allSelectables";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_allSelectables);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_Selectable.<>f__mg$cacheE, null, false);
		string name2 = "navigation";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_navigation);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Selectable.<>f__mg$cacheF;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_navigation);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_UI_Selectable.<>f__mg$cache10, true);
		string name3 = "transition";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_transition);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache11;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_transition);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_UI_Selectable.<>f__mg$cache12, true);
		string name4 = "colors";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_colors);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache13;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_colors);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_UI_Selectable.<>f__mg$cache14, true);
		string name5 = "spriteState";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_spriteState);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache15;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_spriteState);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_UI_Selectable.<>f__mg$cache16, true);
		string name6 = "animationTriggers";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_animationTriggers);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache17;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_animationTriggers);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_UI_Selectable.<>f__mg$cache18, true);
		string name7 = "targetGraphic";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_targetGraphic);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache19;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_targetGraphic);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_UI_Selectable.<>f__mg$cache1A, true);
		string name8 = "interactable";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_interactable);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache1B;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_interactable);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_UI_Selectable.<>f__mg$cache1C, true);
		string name9 = "image";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_image);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_Selectable.<>f__mg$cache1D;
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.set_image);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_UI_Selectable.<>f__mg$cache1E, true);
		string name10 = "animator";
		if (Lua_UnityEngine_UI_Selectable.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_Selectable.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_Selectable.get_animator);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_UI_Selectable.<>f__mg$cache1F, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Selectable), typeof(UIBehaviour));
	}

	// Token: 0x04019E01 RID: 105985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E02 RID: 105986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E03 RID: 105987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E04 RID: 105988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E05 RID: 105989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E06 RID: 105990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E07 RID: 105991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E08 RID: 105992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019E09 RID: 105993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019E0A RID: 105994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019E0B RID: 105995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019E0C RID: 105996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019E0D RID: 105997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019E0E RID: 105998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019E0F RID: 105999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019E10 RID: 106000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019E11 RID: 106001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019E12 RID: 106002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019E13 RID: 106003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019E14 RID: 106004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019E15 RID: 106005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019E16 RID: 106006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019E17 RID: 106007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019E18 RID: 106008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019E19 RID: 106009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019E1A RID: 106010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019E1B RID: 106011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019E1C RID: 106012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019E1D RID: 106013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019E1E RID: 106014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019E1F RID: 106015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019E20 RID: 106016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
