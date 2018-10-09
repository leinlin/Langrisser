using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200151C RID: 5404
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OnDragTrigger : LuaObject
{
	// Token: 0x060200F0 RID: 131312 RVA: 0x00A9DF20 File Offset: 0x00A9C120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSliderAndEffectSlider(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Slider slider;
			LuaObject.checkType<Slider>(l, 2, out slider);
			Slider effectSlider;
			LuaObject.checkType<Slider>(l, 3, out effectSlider);
			List<int> heroPerformanceIds;
			LuaObject.checkType<List<int>>(l, 4, out heroPerformanceIds);
			onDragTrigger.SetSliderAndEffectSlider(slider, effectSlider, heroPerformanceIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F1 RID: 131313 RVA: 0x00A9DF94 File Offset: 0x00A9C194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			onDragTrigger.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F2 RID: 131314 RVA: 0x00A9DFEC File Offset: 0x00A9C1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			onDragTrigger.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F3 RID: 131315 RVA: 0x00A9E044 File Offset: 0x00A9C244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			onDragTrigger.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F4 RID: 131316 RVA: 0x00A9E09C File Offset: 0x00A9C29C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			onDragTrigger.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F5 RID: 131317 RVA: 0x00A9E0F4 File Offset: 0x00A9C2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F6 RID: 131318 RVA: 0x00A9E148 File Offset: 0x00A9C348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SliderValueDown(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			IEnumerator o = onDragTrigger.m_luaExportHelper.SliderValueDown();
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

	// Token: 0x060200F7 RID: 131319 RVA: 0x00A9E1A4 File Offset: 0x00A9C3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDragObjPostion(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			PointerEventData dragObjPostion;
			LuaObject.checkType<PointerEventData>(l, 2, out dragObjPostion);
			onDragTrigger.m_luaExportHelper.SetDragObjPostion(dragObjPostion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F8 RID: 131320 RVA: 0x00A9E200 File Offset: 0x00A9C400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__callDele_EventOnBeginDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200F9 RID: 131321 RVA: 0x00A9E254 File Offset: 0x00A9C454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__clearDele_EventOnBeginDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FA RID: 131322 RVA: 0x00A9E2A8 File Offset: 0x00A9C4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__callDele_EventOnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FB RID: 131323 RVA: 0x00A9E2FC File Offset: 0x00A9C4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__clearDele_EventOnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FC RID: 131324 RVA: 0x00A9E350 File Offset: 0x00A9C550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FD RID: 131325 RVA: 0x00A9E3A4 File Offset: 0x00A9C5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FE RID: 131326 RVA: 0x00A9E3F8 File Offset: 0x00A9C5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__callDele_EventOnSliderFull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200FF RID: 131327 RVA: 0x00A9E44C File Offset: 0x00A9C64C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__clearDele_EventOnSliderFull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020100 RID: 131328 RVA: 0x00A9E4A0 File Offset: 0x00A9C6A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnSliderEmpty(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__callDele_EventOnSliderEmpty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020101 RID: 131329 RVA: 0x00A9E4F4 File Offset: 0x00A9C6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSliderEmpty(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			onDragTrigger.m_luaExportHelper.__clearDele_EventOnSliderEmpty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020102 RID: 131330 RVA: 0x00A9E548 File Offset: 0x00A9C748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_pixelInterval(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_pixelInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020103 RID: 131331 RVA: 0x00A9E5A0 File Offset: 0x00A9C7A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_pixelInterval(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			int pixelInterval;
			LuaObject.checkType(l, 2, out pixelInterval);
			onDragTrigger.m_luaExportHelper.m_pixelInterval = pixelInterval;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020104 RID: 131332 RVA: 0x00A9E5FC File Offset: 0x00A9C7FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onDragTrigger.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					onDragTrigger.EventOnBeginDrag -= value;
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

	// Token: 0x06020105 RID: 131333 RVA: 0x00A9E67C File Offset: 0x00A9C87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onDragTrigger.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					onDragTrigger.EventOnEndDrag -= value;
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

	// Token: 0x06020106 RID: 131334 RVA: 0x00A9E6FC File Offset: 0x00A9C8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onDragTrigger.EventOnClick += value;
				}
				else if (num == 2)
				{
					onDragTrigger.EventOnClick -= value;
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

	// Token: 0x06020107 RID: 131335 RVA: 0x00A9E77C File Offset: 0x00A9C97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onDragTrigger.EventOnSliderFull += value;
				}
				else if (num == 2)
				{
					onDragTrigger.EventOnSliderFull -= value;
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

	// Token: 0x06020108 RID: 131336 RVA: 0x00A9E7FC File Offset: 0x00A9C9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSliderEmpty(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onDragTrigger.EventOnSliderEmpty += value;
				}
				else if (num == 2)
				{
					onDragTrigger.EventOnSliderEmpty -= value;
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

	// Token: 0x06020109 RID: 131337 RVA: 0x00A9E87C File Offset: 0x00A9CA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchImage(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_touchImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010A RID: 131338 RVA: 0x00A9E8D4 File Offset: 0x00A9CAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchImage(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			GameObject touchImage;
			LuaObject.checkType<GameObject>(l, 2, out touchImage);
			onDragTrigger.m_luaExportHelper.m_touchImage = touchImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010B RID: 131339 RVA: 0x00A9E930 File Offset: 0x00A9CB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slider(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_slider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010C RID: 131340 RVA: 0x00A9E988 File Offset: 0x00A9CB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slider(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Slider slider;
			LuaObject.checkType<Slider>(l, 2, out slider);
			onDragTrigger.m_luaExportHelper.m_slider = slider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010D RID: 131341 RVA: 0x00A9E9E4 File Offset: 0x00A9CBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectSlider(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_effectSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010E RID: 131342 RVA: 0x00A9EA3C File Offset: 0x00A9CC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectSlider(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			Slider effectSlider;
			LuaObject.checkType<Slider>(l, 2, out effectSlider);
			onDragTrigger.m_luaExportHelper.m_effectSlider = effectSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602010F RID: 131343 RVA: 0x00A9EA98 File Offset: 0x00A9CC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalNeedMovePixel(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_totalNeedMovePixel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020110 RID: 131344 RVA: 0x00A9EAEC File Offset: 0x00A9CCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalNeedMovePixel(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			int totalNeedMovePixel;
			LuaObject.checkType(l, 2, out totalNeedMovePixel);
			onDragTrigger.m_totalNeedMovePixel = totalNeedMovePixel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020111 RID: 131345 RVA: 0x00A9EB44 File Offset: 0x00A9CD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMovePixel(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_curMovePixel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020112 RID: 131346 RVA: 0x00A9EB9C File Offset: 0x00A9CD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMovePixel(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			float curMovePixel;
			LuaObject.checkType(l, 2, out curMovePixel);
			onDragTrigger.m_luaExportHelper.m_curMovePixel = curMovePixel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020113 RID: 131347 RVA: 0x00A9EBF8 File Offset: 0x00A9CDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_isDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020114 RID: 131348 RVA: 0x00A9EC50 File Offset: 0x00A9CE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDrag(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			bool isDrag;
			LuaObject.checkType(l, 2, out isDrag);
			onDragTrigger.m_luaExportHelper.m_isDrag = isDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020115 RID: 131349 RVA: 0x00A9ECAC File Offset: 0x00A9CEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasDoneEvent(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_hasDoneEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020116 RID: 131350 RVA: 0x00A9ED04 File Offset: 0x00A9CF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasDoneEvent(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			bool hasDoneEvent;
			LuaObject.checkType(l, 2, out hasDoneEvent);
			onDragTrigger.m_luaExportHelper.m_hasDoneEvent = hasDoneEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020117 RID: 131351 RVA: 0x00A9ED60 File Offset: 0x00A9CF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_heroPerformanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020118 RID: 131352 RVA: 0x00A9EDB8 File Offset: 0x00A9CFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPerformanceIds(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			List<int> heroPerformanceIds;
			LuaObject.checkType<List<int>>(l, 2, out heroPerformanceIds);
			onDragTrigger.m_luaExportHelper.m_heroPerformanceIds = heroPerformanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020119 RID: 131353 RVA: 0x00A9EE14 File Offset: 0x00A9D014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastCount(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_lastCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011A RID: 131354 RVA: 0x00A9EE6C File Offset: 0x00A9D06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastCount(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			int lastCount;
			LuaObject.checkType(l, 2, out lastCount);
			onDragTrigger.m_luaExportHelper.m_lastCount = lastCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011B RID: 131355 RVA: 0x00A9EEC8 File Offset: 0x00A9D0C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastHeroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_lastHeroPerformanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011C RID: 131356 RVA: 0x00A9EF20 File Offset: 0x00A9D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastHeroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			int lastHeroPerformanceId;
			LuaObject.checkType(l, 2, out lastHeroPerformanceId);
			onDragTrigger.m_luaExportHelper.m_lastHeroPerformanceId = lastHeroPerformanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011D RID: 131357 RVA: 0x00A9EF7C File Offset: 0x00A9D17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_audioPlayback(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_audioPlayback);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011E RID: 131358 RVA: 0x00A9EFD4 File Offset: 0x00A9D1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_audioPlayback(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			IAudioPlayback audioPlayback;
			LuaObject.checkType<IAudioPlayback>(l, 2, out audioPlayback);
			onDragTrigger.m_luaExportHelper.m_audioPlayback = audioPlayback;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602011F RID: 131359 RVA: 0x00A9F030 File Offset: 0x00A9D230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onDragTrigger.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020120 RID: 131360 RVA: 0x00A9F088 File Offset: 0x00A9D288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OnDragTrigger onDragTrigger = (OnDragTrigger)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			onDragTrigger.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020121 RID: 131361 RVA: 0x00A9F0E4 File Offset: 0x00A9D2E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OnDragTrigger");
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.SetSliderAndEffectSlider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.SliderValueDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.SetDragObjPostion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__callDele_EventOnSliderFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__clearDele_EventOnSliderFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__callDele_EventOnSliderEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.__clearDele_EventOnSliderEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache11);
		string name = "m_pixelInterval";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_pixelInterval);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_pixelInterval);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache13, true);
		string name2 = "EventOnBeginDrag";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache14, true);
		string name3 = "EventOnEndDrag";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache15, true);
		string name4 = "EventOnClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_EventOnClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache16, true);
		string name5 = "EventOnSliderFull";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_EventOnSliderFull);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache17, true);
		string name6 = "EventOnSliderEmpty";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_EventOnSliderEmpty);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache18, true);
		string name7 = "m_touchImage";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_touchImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_touchImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1A, true);
		string name8 = "m_slider";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_slider);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_slider);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1C, true);
		string name9 = "m_effectSlider";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_effectSlider);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_effectSlider);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1E, true);
		string name10 = "m_totalNeedMovePixel";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_totalNeedMovePixel);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_totalNeedMovePixel);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache20, true);
		string name11 = "m_curMovePixel";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_curMovePixel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_curMovePixel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache22, true);
		string name12 = "m_isDrag";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_isDrag);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_isDrag);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache24, true);
		string name13 = "m_hasDoneEvent";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_hasDoneEvent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_hasDoneEvent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache26, true);
		string name14 = "m_heroPerformanceIds";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_heroPerformanceIds);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_heroPerformanceIds);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache28, true);
		string name15 = "m_lastCount";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_lastCount);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_lastCount);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2A, true);
		string name16 = "m_lastHeroPerformanceId";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_lastHeroPerformanceId);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_lastHeroPerformanceId);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2C, true);
		string name17 = "m_audioPlayback";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_audioPlayback);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_audioPlayback);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2E, true);
		string name18 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.get_m_configDataLoader);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnDragTrigger.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_OnDragTrigger.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnDragTrigger), typeof(MonoBehaviour));
	}

	// Token: 0x0401609A RID: 90266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401609B RID: 90267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401609C RID: 90268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401609D RID: 90269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401609E RID: 90270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401609F RID: 90271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040160A0 RID: 90272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040160A1 RID: 90273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040160A2 RID: 90274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040160A3 RID: 90275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040160A4 RID: 90276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040160A5 RID: 90277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040160A6 RID: 90278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040160A7 RID: 90279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040160A8 RID: 90280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040160A9 RID: 90281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040160AA RID: 90282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040160AB RID: 90283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040160AC RID: 90284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040160AD RID: 90285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040160AE RID: 90286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040160AF RID: 90287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040160B0 RID: 90288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040160B1 RID: 90289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040160B2 RID: 90290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040160B3 RID: 90291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040160B4 RID: 90292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040160B5 RID: 90293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040160B6 RID: 90294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040160B7 RID: 90295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040160B8 RID: 90296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040160B9 RID: 90297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040160BA RID: 90298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040160BB RID: 90299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040160BC RID: 90300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040160BD RID: 90301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040160BE RID: 90302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040160BF RID: 90303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040160C0 RID: 90304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040160C1 RID: 90305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040160C2 RID: 90306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040160C3 RID: 90307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040160C4 RID: 90308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040160C5 RID: 90309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040160C6 RID: 90310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040160C7 RID: 90311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040160C8 RID: 90312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040160C9 RID: 90313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040160CA RID: 90314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
