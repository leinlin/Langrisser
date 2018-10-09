using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020012EB RID: 4843
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_BattleCamera : LuaObject
{
	// Token: 0x0601A14C RID: 106828 RVA: 0x007A9D2C File Offset: 0x007A7F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera o = new BattleCamera();
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

	// Token: 0x0601A14D RID: 106829 RVA: 0x007A9D74 File Offset: 0x007A7F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			battleCamera.Initialize(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A14E RID: 106830 RVA: 0x007A9DCC File Offset: 0x007A7FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			battleCamera.PrepareBattle(battlefieldInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A14F RID: 106831 RVA: 0x007A9E24 File Offset: 0x007A8024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			battleCamera.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A150 RID: 106832 RVA: 0x007A9E70 File Offset: 0x007A8070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float orthographicSize;
			LuaObject.checkType(l, 2, out orthographicSize);
			battleCamera.SetOrthographicSize(orthographicSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A151 RID: 106833 RVA: 0x007A9EC8 File Offset: 0x007A80C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleCamera.EnableTouchMove(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A152 RID: 106834 RVA: 0x007A9F20 File Offset: 0x007A8120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableTouchMove2(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleCamera.EnableTouchMove2(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A153 RID: 106835 RVA: 0x007A9F78 File Offset: 0x007A8178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleCamera.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A154 RID: 106836 RVA: 0x007A9FD0 File Offset: 0x007A81D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Look(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			battleCamera.Look(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A155 RID: 106837 RVA: 0x007AA028 File Offset: 0x007A8228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothLook(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			battleCamera.SmoothLook(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A156 RID: 106838 RVA: 0x007AA080 File Offset: 0x007A8280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSmoothMoving(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			bool b = battleCamera.IsSmoothMoving();
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

	// Token: 0x0601A157 RID: 106839 RVA: 0x007AA0D4 File Offset: 0x007A82D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Bound(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			float dt;
			LuaObject.checkType(l, 3, out dt);
			int speed;
			LuaObject.checkType(l, 4, out speed);
			battleCamera.Bound(p, dt, speed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A158 RID: 106840 RVA: 0x007AA148 File Offset: 0x007A8348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 position = battleCamera.GetPosition();
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

	// Token: 0x0601A159 RID: 106841 RVA: 0x007AA19C File Offset: 0x007A839C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateEnableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			battleCamera.m_luaExportHelper.UpdateEnableTouchMove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A15A RID: 106842 RVA: 0x007AA1F0 File Offset: 0x007A83F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouchUI(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			bool b = battleCamera.m_luaExportHelper.IsTouchUI(pos);
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

	// Token: 0x0601A15B RID: 106843 RVA: 0x007AA258 File Offset: 0x007A8458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleCamera.m_luaExportHelper.UpdateTouch(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A15C RID: 106844 RVA: 0x007AA2B4 File Offset: 0x007A84B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = battleCamera.m_luaExportHelper.ClampCameraPosition(p);
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

	// Token: 0x0601A15D RID: 106845 RVA: 0x007AA31C File Offset: 0x007A851C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBoundPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = battleCamera.m_luaExportHelper.ComputeBoundPosition(p);
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

	// Token: 0x0601A15E RID: 106846 RVA: 0x007AA384 File Offset: 0x007A8584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			GameObject cameraGo;
			LuaObject.checkType<GameObject>(l, 2, out cameraGo);
			GameObject animatorGo;
			LuaObject.checkType<GameObject>(l, 3, out animatorGo);
			battleCamera.m_luaExportHelper.__callBase_Initialize(cameraGo, animatorGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A15F RID: 106847 RVA: 0x007AA3F0 File Offset: 0x007A85F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetViewSize(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float o;
			float o2;
			battleCamera.m_luaExportHelper.__callBase_GetViewSize(out o, out o2);
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

	// Token: 0x0601A160 RID: 106848 RVA: 0x007AA458 File Offset: 0x007A8658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			battleCamera.m_luaExportHelper.__callBase_PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A161 RID: 106849 RVA: 0x007AA4B4 File Offset: 0x007A86B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAnimationOffset(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector3 o = battleCamera.m_luaExportHelper.__callBase_GetAnimationOffset();
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

	// Token: 0x0601A162 RID: 106850 RVA: 0x007AA510 File Offset: 0x007A8710
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
				BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = battleCamera.m_luaExportHelper.__callBase_IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				BattleCamera battleCamera2 = (BattleCamera)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = battleCamera2.m_luaExportHelper.__callBase_IsCulled(bmin, bmax);
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

	// Token: 0x0601A163 RID: 106851 RVA: 0x007AA5F4 File Offset: 0x007A87F4
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
			Vector2 o = BattleCamera.LuaExportHelper.ScreenPositionToViewPosition(p, viewWidth, viewHeight);
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

	// Token: 0x0601A164 RID: 106852 RVA: 0x007AA664 File Offset: 0x007A8864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A165 RID: 106853 RVA: 0x007AA6BC File Offset: 0x007A88BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			battleCamera.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A166 RID: 106854 RVA: 0x007AA718 File Offset: 0x007A8918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveStartPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_smoothMoveStartPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A167 RID: 106855 RVA: 0x007AA770 File Offset: 0x007A8970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveStartPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 smoothMoveStartPosition;
			LuaObject.checkType(l, 2, out smoothMoveStartPosition);
			battleCamera.m_luaExportHelper.m_smoothMoveStartPosition = smoothMoveStartPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A168 RID: 106856 RVA: 0x007AA7CC File Offset: 0x007A89CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveEndPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_smoothMoveEndPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A169 RID: 106857 RVA: 0x007AA824 File Offset: 0x007A8A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveEndPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 smoothMoveEndPosition;
			LuaObject.checkType(l, 2, out smoothMoveEndPosition);
			battleCamera.m_luaExportHelper.m_smoothMoveEndPosition = smoothMoveEndPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16A RID: 106858 RVA: 0x007AA880 File Offset: 0x007A8A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchMoveVelocity(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_touchMoveVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16B RID: 106859 RVA: 0x007AA8D8 File Offset: 0x007A8AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchMoveVelocity(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 touchMoveVelocity;
			LuaObject.checkType(l, 2, out touchMoveVelocity);
			battleCamera.m_luaExportHelper.m_touchMoveVelocity = touchMoveVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16C RID: 106860 RVA: 0x007AA934 File Offset: 0x007A8B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_enableTouchMove);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16D RID: 106861 RVA: 0x007AA98C File Offset: 0x007A8B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableTouchMove(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			bool enableTouchMove;
			LuaObject.checkType(l, 2, out enableTouchMove);
			battleCamera.m_luaExportHelper.m_enableTouchMove = enableTouchMove;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16E RID: 106862 RVA: 0x007AA9E8 File Offset: 0x007A8BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableTouchMove2(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_enableTouchMove2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A16F RID: 106863 RVA: 0x007AAA40 File Offset: 0x007A8C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableTouchMove2(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			bool enableTouchMove;
			LuaObject.checkType(l, 2, out enableTouchMove);
			battleCamera.m_luaExportHelper.m_enableTouchMove2 = enableTouchMove;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A170 RID: 106864 RVA: 0x007AAA9C File Offset: 0x007A8C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveTime(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_smoothMoveTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A171 RID: 106865 RVA: 0x007AAAF4 File Offset: 0x007A8CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveTime(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float smoothMoveTime;
			LuaObject.checkType(l, 2, out smoothMoveTime);
			battleCamera.m_luaExportHelper.m_smoothMoveTime = smoothMoveTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A172 RID: 106866 RVA: 0x007AAB50 File Offset: 0x007A8D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smoothMoveTotalTime(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_smoothMoveTotalTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A173 RID: 106867 RVA: 0x007AABA8 File Offset: 0x007A8DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smoothMoveTotalTime(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float smoothMoveTotalTime;
			LuaObject.checkType(l, 2, out smoothMoveTotalTime);
			battleCamera.m_luaExportHelper.m_smoothMoveTotalTime = smoothMoveTotalTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A174 RID: 106868 RVA: 0x007AAC04 File Offset: 0x007A8E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventSystem(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_eventSystem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A175 RID: 106869 RVA: 0x007AAC5C File Offset: 0x007A8E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventSystem(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			EventSystem eventSystem;
			LuaObject.checkType<EventSystem>(l, 2, out eventSystem);
			battleCamera.m_luaExportHelper.m_eventSystem = eventSystem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A176 RID: 106870 RVA: 0x007AACB8 File Offset: 0x007A8EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointData(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_pointData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A177 RID: 106871 RVA: 0x007AAD10 File Offset: 0x007A8F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointData(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			PointerEventData pointData;
			LuaObject.checkType<PointerEventData>(l, 2, out pointData);
			battleCamera.m_luaExportHelper.m_pointData = pointData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A178 RID: 106872 RVA: 0x007AAD6C File Offset: 0x007A8F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raycastResults(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_raycastResults);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A179 RID: 106873 RVA: 0x007AADC4 File Offset: 0x007A8FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raycastResults(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			List<RaycastResult> raycastResults;
			LuaObject.checkType<List<RaycastResult>>(l, 2, out raycastResults);
			battleCamera.m_luaExportHelper.m_raycastResults = raycastResults;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17A RID: 106874 RVA: 0x007AAE20 File Offset: 0x007A9020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_touchStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17B RID: 106875 RVA: 0x007AAE78 File Offset: 0x007A9078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			TouchStatus[] touchStatus;
			LuaObject.checkArray<TouchStatus>(l, 2, out touchStatus);
			battleCamera.m_luaExportHelper.m_touchStatus = touchStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17C RID: 106876 RVA: 0x007AAED4 File Offset: 0x007A90D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_initPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17D RID: 106877 RVA: 0x007AAF2C File Offset: 0x007A912C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector3 initPosition;
			LuaObject.checkType(l, 2, out initPosition);
			battleCamera.m_luaExportHelper.m_initPosition = initPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17E RID: 106878 RVA: 0x007AAF88 File Offset: 0x007A9188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapSizeHalf(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_mapSizeHalf);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A17F RID: 106879 RVA: 0x007AAFE0 File Offset: 0x007A91E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapSizeHalf(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			Vector2 mapSizeHalf;
			LuaObject.checkType(l, 2, out mapSizeHalf);
			battleCamera.m_luaExportHelper.m_mapSizeHalf = mapSizeHalf;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A180 RID: 106880 RVA: 0x007AB03C File Offset: 0x007A923C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewSizeMin(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_viewSizeMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A181 RID: 106881 RVA: 0x007AB094 File Offset: 0x007A9294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewSizeMin(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float viewSizeMin;
			LuaObject.checkType(l, 2, out viewSizeMin);
			battleCamera.m_luaExportHelper.m_viewSizeMin = viewSizeMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A182 RID: 106882 RVA: 0x007AB0F0 File Offset: 0x007A92F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewSizeMax(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCamera.m_luaExportHelper.m_viewSizeMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A183 RID: 106883 RVA: 0x007AB148 File Offset: 0x007A9348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewSizeMax(IntPtr l)
	{
		int result;
		try
		{
			BattleCamera battleCamera = (BattleCamera)LuaObject.checkSelf(l);
			float viewSizeMax;
			LuaObject.checkType(l, 2, out viewSizeMax);
			battleCamera.m_luaExportHelper.m_viewSizeMax = viewSizeMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A184 RID: 106884 RVA: 0x007AB1A4 File Offset: 0x007A93A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.BattleCamera");
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.PrepareBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.SetOrthographicSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.EnableTouchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.EnableTouchMove2);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.Look);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.SmoothLook);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.IsSmoothMoving);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.Bound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.UpdateEnableTouchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.IsTouchUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.UpdateTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.ClampCameraPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.ComputeBoundPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.__callBase_Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.__callBase_GetViewSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.__callBase_PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.__callBase_GetAnimationOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.__callBase_IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.ScreenPositionToViewPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache16);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache18, true);
		string name2 = "m_smoothMoveStartPosition";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_smoothMoveStartPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_smoothMoveStartPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1A, true);
		string name3 = "m_smoothMoveEndPosition";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_smoothMoveEndPosition);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_smoothMoveEndPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1C, true);
		string name4 = "m_touchMoveVelocity";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_touchMoveVelocity);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_touchMoveVelocity);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1E, true);
		string name5 = "m_enableTouchMove";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_enableTouchMove);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_enableTouchMove);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache20, true);
		string name6 = "m_enableTouchMove2";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_enableTouchMove2);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_enableTouchMove2);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache22, true);
		string name7 = "m_smoothMoveTime";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_smoothMoveTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_smoothMoveTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache24, true);
		string name8 = "m_smoothMoveTotalTime";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_smoothMoveTotalTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_smoothMoveTotalTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache26, true);
		string name9 = "m_eventSystem";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_eventSystem);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_eventSystem);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache28, true);
		string name10 = "m_pointData";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_pointData);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_pointData);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2A, true);
		string name11 = "m_raycastResults";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_raycastResults);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_raycastResults);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2C, true);
		string name12 = "m_touchStatus";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_touchStatus);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_touchStatus);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2E, true);
		string name13 = "m_initPosition";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_initPosition);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_initPosition);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache30, true);
		string name14 = "m_mapSizeHalf";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_mapSizeHalf);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_mapSizeHalf);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache32, true);
		string name15 = "m_viewSizeMin";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_viewSizeMin);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_viewSizeMin);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache34, true);
		string name16 = "m_viewSizeMax";
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.get_m_viewSizeMax);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.set_m_viewSizeMax);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache36, true);
		if (Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleCamera.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_BattleCamera.<>f__mg$cache37, typeof(BattleCamera), typeof(CameraBase));
	}

	// Token: 0x04010558 RID: 66904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010559 RID: 66905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401055A RID: 66906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401055B RID: 66907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401055C RID: 66908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401055D RID: 66909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401055E RID: 66910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401055F RID: 66911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010560 RID: 66912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010561 RID: 66913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010562 RID: 66914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010563 RID: 66915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010564 RID: 66916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010565 RID: 66917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010566 RID: 66918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010567 RID: 66919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010568 RID: 66920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010569 RID: 66921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401056A RID: 66922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401056B RID: 66923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401056C RID: 66924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401056D RID: 66925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401056E RID: 66926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401056F RID: 66927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010570 RID: 66928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010571 RID: 66929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010572 RID: 66930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010573 RID: 66931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010574 RID: 66932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010575 RID: 66933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010576 RID: 66934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010577 RID: 66935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010578 RID: 66936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010579 RID: 66937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401057A RID: 66938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401057B RID: 66939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401057C RID: 66940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401057D RID: 66941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401057E RID: 66942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401057F RID: 66943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010580 RID: 66944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010581 RID: 66945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010582 RID: 66946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010583 RID: 66947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010584 RID: 66948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010585 RID: 66949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010586 RID: 66950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010587 RID: 66951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010588 RID: 66952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010589 RID: 66953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401058A RID: 66954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401058B RID: 66955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401058C RID: 66956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401058D RID: 66957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401058E RID: 66958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401058F RID: 66959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
