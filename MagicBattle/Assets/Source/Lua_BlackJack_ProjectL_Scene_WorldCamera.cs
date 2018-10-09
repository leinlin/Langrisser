using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200134B RID: 4939
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_WorldCamera : LuaObject
{
	// Token: 0x0601A867 RID: 108647 RVA: 0x007DE26C File Offset: 0x007DC46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera o = new WorldCamera();
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

	// Token: 0x0601A868 RID: 108648 RVA: 0x007DE2B4 File Offset: 0x007DC4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			worldCamera.Initialize(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A869 RID: 108649 RVA: 0x007DE30C File Offset: 0x007DC50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			ConfigDataWorldMapInfo worldMap;
			LuaObject.checkType<ConfigDataWorldMapInfo>(l, 2, out worldMap);
			worldCamera.Start(worldMap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A86A RID: 108650 RVA: 0x007DE364 File Offset: 0x007DC564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			worldCamera.EnableTouchMove(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A86B RID: 108651 RVA: 0x007DE3BC File Offset: 0x007DC5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			worldCamera.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A86C RID: 108652 RVA: 0x007DE414 File Offset: 0x007DC614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Look(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			worldCamera.Look(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A86D RID: 108653 RVA: 0x007DE46C File Offset: 0x007DC66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothLook(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			worldCamera.SmoothLook(p, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A86E RID: 108654 RVA: 0x007DE4D0 File Offset: 0x007DC6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSmoothMoving(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			bool b = worldCamera.IsSmoothMoving();
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

	// Token: 0x0601A86F RID: 108655 RVA: 0x007DE524 File Offset: 0x007DC724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFollow(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			worldCamera.StartFollow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A870 RID: 108656 RVA: 0x007DE570 File Offset: 0x007DC770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFollowPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 followPosition;
			LuaObject.checkType(l, 2, out followPosition);
			worldCamera.SetFollowPosition(followPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A871 RID: 108657 RVA: 0x007DE5C8 File Offset: 0x007DC7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 position = worldCamera.GetPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A872 RID: 108658 RVA: 0x007DE61C File Offset: 0x007DC81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetZoomFactor(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float zoomFactor = worldCamera.GetZoomFactor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, zoomFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A873 RID: 108659 RVA: 0x007DE670 File Offset: 0x007DC870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouchUI(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			bool b = worldCamera.m_luaExportHelper.IsTouchUI(pos);
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

	// Token: 0x0601A874 RID: 108660 RVA: 0x007DE6D8 File Offset: 0x007DC8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTouch(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			worldCamera.m_luaExportHelper.UpdateTouch(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A875 RID: 108661 RVA: 0x007DE734 File Offset: 0x007DC934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = worldCamera.m_luaExportHelper.ClampCameraPosition(p);
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

	// Token: 0x0601A876 RID: 108662 RVA: 0x007DE79C File Offset: 0x007DC99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GroundPositionToCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = worldCamera.m_luaExportHelper.GroundPositionToCameraPosition(p);
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

	// Token: 0x0601A877 RID: 108663 RVA: 0x007DE804 File Offset: 0x007DCA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initialize(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			GameObject cameraGo;
			LuaObject.checkType<GameObject>(l, 2, out cameraGo);
			GameObject animatorGo;
			LuaObject.checkType<GameObject>(l, 3, out animatorGo);
			worldCamera.m_luaExportHelper.__callBase_Initialize(cameraGo, animatorGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A878 RID: 108664 RVA: 0x007DE870 File Offset: 0x007DCA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetViewSize(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float o;
			float o2;
			worldCamera.m_luaExportHelper.__callBase_GetViewSize(out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A879 RID: 108665 RVA: 0x007DE8D8 File Offset: 0x007DCAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			worldCamera.m_luaExportHelper.__callBase_PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A87A RID: 108666 RVA: 0x007DE934 File Offset: 0x007DCB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAnimationOffset(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector3 o = worldCamera.m_luaExportHelper.__callBase_GetAnimationOffset();
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

	// Token: 0x0601A87B RID: 108667 RVA: 0x007DE990 File Offset: 0x007DCB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCulled(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = worldCamera.m_luaExportHelper.__callBase_IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				WorldCamera worldCamera2 = (WorldCamera)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = worldCamera2.m_luaExportHelper.__callBase_IsCulled(bmin, bmax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsCulled to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A87C RID: 108668 RVA: 0x007DEA74 File Offset: 0x007DCC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onSmoothMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			worldCamera.m_luaExportHelper.__callDele_m_onSmoothMoveEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A87D RID: 108669 RVA: 0x007DEAC8 File Offset: 0x007DCCC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onSmoothMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			worldCamera.m_luaExportHelper.__clearDele_m_onSmoothMoveEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A87E RID: 108670 RVA: 0x007DEB1C File Offset: 0x007DCD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPositionToViewPosition_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 p;
			LuaObject.checkType(l, 1, out p);
			float viewWidth;
			LuaObject.checkType(l, 2, out viewWidth);
			float viewHeight;
			LuaObject.checkType(l, 3, out viewHeight);
			Vector2 o = WorldCamera.LuaExportHelper.ScreenPositionToViewPosition(p, viewWidth, viewHeight);
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

	// Token: 0x0601A87F RID: 108671 RVA: 0x007DEB8C File Offset: 0x007DCD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A880 RID: 108672 RVA: 0x007DEBE4 File Offset: 0x007DCDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			worldCamera.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A881 RID: 108673 RVA: 0x007DEC40 File Offset: 0x007DCE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_height(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A882 RID: 108674 RVA: 0x007DEC98 File Offset: 0x007DCE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_height(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			worldCamera.m_luaExportHelper.m_height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A883 RID: 108675 RVA: 0x007DECF4 File Offset: 0x007DCEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveStartPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_smoothMoveStartPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A884 RID: 108676 RVA: 0x007DED4C File Offset: 0x007DCF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveStartPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 smoothMoveStartPosition;
			LuaObject.checkType(l, 2, out smoothMoveStartPosition);
			worldCamera.m_luaExportHelper.m_smoothMoveStartPosition = smoothMoveStartPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A885 RID: 108677 RVA: 0x007DEDA8 File Offset: 0x007DCFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveEndPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_smoothMoveEndPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A886 RID: 108678 RVA: 0x007DEE00 File Offset: 0x007DD000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveEndPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 smoothMoveEndPosition;
			LuaObject.checkType(l, 2, out smoothMoveEndPosition);
			worldCamera.m_luaExportHelper.m_smoothMoveEndPosition = smoothMoveEndPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A887 RID: 108679 RVA: 0x007DEE5C File Offset: 0x007DD05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchMoveVelocity(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_touchMoveVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A888 RID: 108680 RVA: 0x007DEEB4 File Offset: 0x007DD0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchMoveVelocity(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 touchMoveVelocity;
			LuaObject.checkType(l, 2, out touchMoveVelocity);
			worldCamera.m_luaExportHelper.m_touchMoveVelocity = touchMoveVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A889 RID: 108681 RVA: 0x007DEF10 File Offset: 0x007DD110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_followTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_followTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88A RID: 108682 RVA: 0x007DEF68 File Offset: 0x007DD168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_followTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 followTargetPosition;
			LuaObject.checkType(l, 2, out followTargetPosition);
			worldCamera.m_luaExportHelper.m_followTargetPosition = followTargetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88B RID: 108683 RVA: 0x007DEFC4 File Offset: 0x007DD1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_followVelocity(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_followVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88C RID: 108684 RVA: 0x007DF01C File Offset: 0x007DD21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_followVelocity(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 followVelocity;
			LuaObject.checkType(l, 2, out followVelocity);
			worldCamera.m_luaExportHelper.m_followVelocity = followVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88D RID: 108685 RVA: 0x007DF078 File Offset: 0x007DD278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_enableTouchMove);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88E RID: 108686 RVA: 0x007DF0D0 File Offset: 0x007DD2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			bool enableTouchMove;
			LuaObject.checkType(l, 2, out enableTouchMove);
			worldCamera.m_luaExportHelper.m_enableTouchMove = enableTouchMove;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A88F RID: 108687 RVA: 0x007DF12C File Offset: 0x007DD32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFollowing(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_isFollowing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A890 RID: 108688 RVA: 0x007DF184 File Offset: 0x007DD384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFollowing(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			bool isFollowing;
			LuaObject.checkType(l, 2, out isFollowing);
			worldCamera.m_luaExportHelper.m_isFollowing = isFollowing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A891 RID: 108689 RVA: 0x007DF1E0 File Offset: 0x007DD3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveTime(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_smoothMoveTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A892 RID: 108690 RVA: 0x007DF238 File Offset: 0x007DD438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveTime(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float smoothMoveTime;
			LuaObject.checkType(l, 2, out smoothMoveTime);
			worldCamera.m_luaExportHelper.m_smoothMoveTime = smoothMoveTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A893 RID: 108691 RVA: 0x007DF294 File Offset: 0x007DD494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveTotalTime(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_smoothMoveTotalTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A894 RID: 108692 RVA: 0x007DF2EC File Offset: 0x007DD4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveTotalTime(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float smoothMoveTotalTime;
			LuaObject.checkType(l, 2, out smoothMoveTotalTime);
			worldCamera.m_luaExportHelper.m_smoothMoveTotalTime = smoothMoveTotalTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A895 RID: 108693 RVA: 0x007DF348 File Offset: 0x007DD548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventSystem(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_eventSystem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A896 RID: 108694 RVA: 0x007DF3A0 File Offset: 0x007DD5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventSystem(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			EventSystem eventSystem;
			LuaObject.checkType<EventSystem>(l, 2, out eventSystem);
			worldCamera.m_luaExportHelper.m_eventSystem = eventSystem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A897 RID: 108695 RVA: 0x007DF3FC File Offset: 0x007DD5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointData(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_pointData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A898 RID: 108696 RVA: 0x007DF454 File Offset: 0x007DD654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointData(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			PointerEventData pointData;
			LuaObject.checkType<PointerEventData>(l, 2, out pointData);
			worldCamera.m_luaExportHelper.m_pointData = pointData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A899 RID: 108697 RVA: 0x007DF4B0 File Offset: 0x007DD6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raycastResults(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_raycastResults);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89A RID: 108698 RVA: 0x007DF508 File Offset: 0x007DD708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raycastResults(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			List<RaycastResult> raycastResults;
			LuaObject.checkType<List<RaycastResult>>(l, 2, out raycastResults);
			worldCamera.m_luaExportHelper.m_raycastResults = raycastResults;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89B RID: 108699 RVA: 0x007DF564 File Offset: 0x007DD764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchStatus(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_touchStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89C RID: 108700 RVA: 0x007DF5BC File Offset: 0x007DD7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchStatus(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			TouchStatus[] touchStatus;
			LuaObject.checkArray<TouchStatus>(l, 2, out touchStatus);
			worldCamera.m_luaExportHelper.m_touchStatus = touchStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89D RID: 108701 RVA: 0x007DF618 File Offset: 0x007DD818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_initPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89E RID: 108702 RVA: 0x007DF670 File Offset: 0x007DD870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector3 initPosition;
			LuaObject.checkType(l, 2, out initPosition);
			worldCamera.m_luaExportHelper.m_initPosition = initPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A89F RID: 108703 RVA: 0x007DF6CC File Offset: 0x007DD8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initFov(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_initFov);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A0 RID: 108704 RVA: 0x007DF724 File Offset: 0x007DD924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initFov(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float initFov;
			LuaObject.checkType(l, 2, out initFov);
			worldCamera.m_luaExportHelper.m_initFov = initFov;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A1 RID: 108705 RVA: 0x007DF780 File Offset: 0x007DD980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapSizeHalf(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_mapSizeHalf);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A2 RID: 108706 RVA: 0x007DF7D8 File Offset: 0x007DD9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapSizeHalf(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Vector2 mapSizeHalf;
			LuaObject.checkType(l, 2, out mapSizeHalf);
			worldCamera.m_luaExportHelper.m_mapSizeHalf = mapSizeHalf;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A3 RID: 108707 RVA: 0x007DF834 File Offset: 0x007DDA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewHeightMin(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_viewHeightMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A4 RID: 108708 RVA: 0x007DF88C File Offset: 0x007DDA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewHeightMin(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float viewHeightMin;
			LuaObject.checkType(l, 2, out viewHeightMin);
			worldCamera.m_luaExportHelper.m_viewHeightMin = viewHeightMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A5 RID: 108709 RVA: 0x007DF8E8 File Offset: 0x007DDAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewHeightMax(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_viewHeightMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A6 RID: 108710 RVA: 0x007DF940 File Offset: 0x007DDB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewHeightMax(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			float viewHeightMax;
			LuaObject.checkType(l, 2, out viewHeightMax);
			worldCamera.m_luaExportHelper.m_viewHeightMax = viewHeightMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A7 RID: 108711 RVA: 0x007DF99C File Offset: 0x007DDB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitWaypointUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_hitWaypointUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A8 RID: 108712 RVA: 0x007DF9F4 File Offset: 0x007DDBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitWaypointUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			WorldWaypointUIController hitWaypointUIController;
			LuaObject.checkType<WorldWaypointUIController>(l, 2, out hitWaypointUIController);
			worldCamera.m_luaExportHelper.m_hitWaypointUIController = hitWaypointUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8A9 RID: 108713 RVA: 0x007DFA50 File Offset: 0x007DDC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitEventActorUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldCamera.m_luaExportHelper.m_hitEventActorUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8AA RID: 108714 RVA: 0x007DFAA8 File Offset: 0x007DDCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitEventActorUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			WorldEventActorUIController hitEventActorUIController;
			LuaObject.checkType<WorldEventActorUIController>(l, 2, out hitEventActorUIController);
			worldCamera.m_luaExportHelper.m_hitEventActorUIController = hitEventActorUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8AB RID: 108715 RVA: 0x007DFB04 File Offset: 0x007DDD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onSmoothMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			WorldCamera worldCamera = (WorldCamera)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				worldCamera.m_luaExportHelper.m_onSmoothMoveEnd = action;
			}
			else if (num == 1)
			{
				WorldCamera.LuaExportHelper luaExportHelper = worldCamera.m_luaExportHelper;
				luaExportHelper.m_onSmoothMoveEnd = (Action)Delegate.Combine(luaExportHelper.m_onSmoothMoveEnd, action);
			}
			else if (num == 2)
			{
				WorldCamera.LuaExportHelper luaExportHelper2 = worldCamera.m_luaExportHelper;
				luaExportHelper2.m_onSmoothMoveEnd = (Action)Delegate.Remove(luaExportHelper2.m_onSmoothMoveEnd, action);
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

	// Token: 0x0601A8AC RID: 108716 RVA: 0x007DFBB8 File Offset: 0x007DDDB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.WorldCamera");
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.EnableTouchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.Look);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.SmoothLook);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.IsSmoothMoving);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.StartFollow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.SetFollowPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.GetZoomFactor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.IsTouchUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.UpdateTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.ClampCameraPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.GroundPositionToCameraPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callBase_Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callBase_GetViewSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callBase_PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callBase_GetAnimationOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callBase_IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__callDele_m_onSmoothMoveEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.__clearDele_m_onSmoothMoveEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.ScreenPositionToViewPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache16);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache18, true);
		string name2 = "m_height";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_height);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1A, true);
		string name3 = "m_smoothMoveStartPosition";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_smoothMoveStartPosition);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_smoothMoveStartPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1C, true);
		string name4 = "m_smoothMoveEndPosition";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_smoothMoveEndPosition);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_smoothMoveEndPosition);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1E, true);
		string name5 = "m_touchMoveVelocity";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_touchMoveVelocity);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_touchMoveVelocity);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache20, true);
		string name6 = "m_followTargetPosition";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_followTargetPosition);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_followTargetPosition);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache22, true);
		string name7 = "m_followVelocity";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_followVelocity);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_followVelocity);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache24, true);
		string name8 = "m_enableTouchMove";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_enableTouchMove);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_enableTouchMove);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache26, true);
		string name9 = "m_isFollowing";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_isFollowing);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_isFollowing);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache28, true);
		string name10 = "m_smoothMoveTime";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_smoothMoveTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_smoothMoveTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2A, true);
		string name11 = "m_smoothMoveTotalTime";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_smoothMoveTotalTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_smoothMoveTotalTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2C, true);
		string name12 = "m_eventSystem";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_eventSystem);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_eventSystem);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2E, true);
		string name13 = "m_pointData";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_pointData);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_pointData);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache30, true);
		string name14 = "m_raycastResults";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_raycastResults);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_raycastResults);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache32, true);
		string name15 = "m_touchStatus";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_touchStatus);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_touchStatus);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache34, true);
		string name16 = "m_initPosition";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_initPosition);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_initPosition);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache36, true);
		string name17 = "m_initFov";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_initFov);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_initFov);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache38, true);
		string name18 = "m_mapSizeHalf";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_mapSizeHalf);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_mapSizeHalf);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3A, true);
		string name19 = "m_viewHeightMin";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_viewHeightMin);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_viewHeightMin);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3C, true);
		string name20 = "m_viewHeightMax";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_viewHeightMax);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_viewHeightMax);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3E, true);
		string name21 = "m_hitWaypointUIController";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_hitWaypointUIController);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_hitWaypointUIController);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache40, true);
		string name22 = "m_hitEventActorUIController";
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.get_m_hitEventActorUIController);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_hitEventActorUIController);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache42, true);
		string name23 = "m_onSmoothMoveEnd";
		LuaCSFunction get23 = null;
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.set_m_onSmoothMoveEnd);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache43, true);
		if (Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldCamera.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_WorldCamera.<>f__mg$cache44, typeof(WorldCamera), typeof(CameraBase));
	}

	// Token: 0x04010BB3 RID: 68531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010BB4 RID: 68532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010BB5 RID: 68533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010BB6 RID: 68534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010BB7 RID: 68535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010BB8 RID: 68536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010BB9 RID: 68537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010BBA RID: 68538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010BBB RID: 68539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010BBC RID: 68540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010BBD RID: 68541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010BBE RID: 68542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010BBF RID: 68543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010BC0 RID: 68544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010BC1 RID: 68545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010BC2 RID: 68546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010BC3 RID: 68547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010BC4 RID: 68548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010BC5 RID: 68549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010BC6 RID: 68550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010BC7 RID: 68551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010BC8 RID: 68552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010BC9 RID: 68553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010BCA RID: 68554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010BCB RID: 68555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010BCC RID: 68556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010BCD RID: 68557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010BCE RID: 68558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010BCF RID: 68559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010BD0 RID: 68560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010BD1 RID: 68561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010BD2 RID: 68562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010BD3 RID: 68563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010BD4 RID: 68564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010BD5 RID: 68565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010BD6 RID: 68566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010BD7 RID: 68567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010BD8 RID: 68568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010BD9 RID: 68569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010BDA RID: 68570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010BDB RID: 68571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010BDC RID: 68572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010BDD RID: 68573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010BDE RID: 68574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010BDF RID: 68575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010BE0 RID: 68576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010BE1 RID: 68577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010BE2 RID: 68578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010BE3 RID: 68579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010BE4 RID: 68580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010BE5 RID: 68581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010BE6 RID: 68582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010BE7 RID: 68583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010BE8 RID: 68584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010BE9 RID: 68585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010BEA RID: 68586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010BEB RID: 68587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010BEC RID: 68588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010BED RID: 68589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010BEE RID: 68590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010BEF RID: 68591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010BF0 RID: 68592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010BF1 RID: 68593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010BF2 RID: 68594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04010BF3 RID: 68595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04010BF4 RID: 68596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04010BF5 RID: 68597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04010BF6 RID: 68598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04010BF7 RID: 68599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;
}
