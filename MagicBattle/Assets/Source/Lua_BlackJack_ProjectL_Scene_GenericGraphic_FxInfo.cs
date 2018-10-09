using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Scene;
using SLua;
using Spine;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001345 RID: 4933
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo : LuaObject
{
	// Token: 0x0601A7FA RID: 108538 RVA: 0x007DB2AC File Offset: 0x007D94AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo o = new GenericGraphic.FxInfo();
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

	// Token: 0x0601A7FB RID: 108539 RVA: 0x007DB2F4 File Offset: 0x007D94F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxDesc(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_fxDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7FC RID: 108540 RVA: 0x007DB348 File Offset: 0x007D9548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxDesc(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			FxDesc fxDesc;
			LuaObject.checkType<FxDesc>(l, 2, out fxDesc);
			fxInfo.m_fxDesc = fxDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7FD RID: 108541 RVA: 0x007DB3A0 File Offset: 0x007D95A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initLife(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_initLife);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7FE RID: 108542 RVA: 0x007DB3F4 File Offset: 0x007D95F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initLife(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			float initLife;
			LuaObject.checkType(l, 2, out initLife);
			fxInfo.m_initLife = initLife;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7FF RID: 108543 RVA: 0x007DB44C File Offset: 0x007D964C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeCountdown(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_lifeCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A800 RID: 108544 RVA: 0x007DB4A0 File Offset: 0x007D96A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeCountdown(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			float lifeCountdown;
			LuaObject.checkType(l, 2, out lifeCountdown);
			fxInfo.m_lifeCountdown = lifeCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A801 RID: 108545 RVA: 0x007DB4F8 File Offset: 0x007D96F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initLoop(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_initLoop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A802 RID: 108546 RVA: 0x007DB54C File Offset: 0x007D974C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initLoop(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			bool initLoop;
			LuaObject.checkType(l, 2, out initLoop);
			fxInfo.m_initLoop = initLoop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A803 RID: 108547 RVA: 0x007DB5A4 File Offset: 0x007D97A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_isDeleteMe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A804 RID: 108548 RVA: 0x007DB5F8 File Offset: 0x007D97F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			bool isDeleteMe;
			LuaObject.checkType(l, 2, out isDeleteMe);
			fxInfo.m_isDeleteMe = isDeleteMe;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A805 RID: 108549 RVA: 0x007DB650 File Offset: 0x007D9850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoDelete(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_isAutoDelete);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A806 RID: 108550 RVA: 0x007DB6A4 File Offset: 0x007D98A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoDelete(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			bool isAutoDelete;
			LuaObject.checkType(l, 2, out isAutoDelete);
			fxInfo.m_isAutoDelete = isAutoDelete;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A807 RID: 108551 RVA: 0x007DB6FC File Offset: 0x007D98FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tag(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_tag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A808 RID: 108552 RVA: 0x007DB750 File Offset: 0x007D9950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tag(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			int tag;
			LuaObject.checkType(l, 2, out tag);
			fxInfo.m_tag = tag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A809 RID: 108553 RVA: 0x007DB7A8 File Offset: 0x007D99A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopParticleSystems(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_stopParticleSystems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80A RID: 108554 RVA: 0x007DB7FC File Offset: 0x007D99FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopParticleSystems(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			List<ParticleSystem> stopParticleSystems;
			LuaObject.checkType<List<ParticleSystem>>(l, 2, out stopParticleSystems);
			fxInfo.m_stopParticleSystems = stopParticleSystems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80B RID: 108555 RVA: 0x007DB854 File Offset: 0x007D9A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopRenderers(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_stopRenderers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80C RID: 108556 RVA: 0x007DB8A8 File Offset: 0x007D9AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopRenderers(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			List<Renderer> stopRenderers;
			LuaObject.checkType<List<Renderer>>(l, 2, out stopRenderers);
			fxInfo.m_stopRenderers = stopRenderers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80D RID: 108557 RVA: 0x007DB900 File Offset: 0x007D9B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trailRenderers(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_trailRenderers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80E RID: 108558 RVA: 0x007DB954 File Offset: 0x007D9B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trailRenderers(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			TrailRenderer[] trailRenderers;
			LuaObject.checkArray<TrailRenderer>(l, 2, out trailRenderers);
			fxInfo.m_trailRenderers = trailRenderers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A80F RID: 108559 RVA: 0x007DB9AC File Offset: 0x007D9BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachBone(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_attachBone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A810 RID: 108560 RVA: 0x007DBA00 File Offset: 0x007D9C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachBone(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			Bone attachBone;
			LuaObject.checkType<Bone>(l, 2, out attachBone);
			fxInfo.m_attachBone = attachBone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A811 RID: 108561 RVA: 0x007DBA58 File Offset: 0x007D9C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_yOffset(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxInfo.m_yOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A812 RID: 108562 RVA: 0x007DBAAC File Offset: 0x007D9CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_yOffset(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.FxInfo fxInfo = (GenericGraphic.FxInfo)LuaObject.checkSelf(l);
			float yOffset;
			LuaObject.checkType(l, 2, out yOffset);
			fxInfo.m_yOffset = yOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A813 RID: 108563 RVA: 0x007DBB04 File Offset: 0x007D9D04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GenericGraphic.FxInfo");
		string name = "m_fxDesc";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_fxDesc);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_fxDesc);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache1, true);
		string name2 = "m_initLife";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_initLife);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_initLife);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache3, true);
		string name3 = "m_lifeCountdown";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_lifeCountdown);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_lifeCountdown);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache5, true);
		string name4 = "m_initLoop";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_initLoop);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_initLoop);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache7, true);
		string name5 = "m_isDeleteMe";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_isDeleteMe);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_isDeleteMe);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache9, true);
		string name6 = "m_isAutoDelete";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_isAutoDelete);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_isAutoDelete);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheB, true);
		string name7 = "m_tag";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_tag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_tag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheD, true);
		string name8 = "m_stopParticleSystems";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_stopParticleSystems);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_stopParticleSystems);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cacheF, true);
		string name9 = "m_stopRenderers";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_stopRenderers);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_stopRenderers);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache11, true);
		string name10 = "m_trailRenderers";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_trailRenderers);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_trailRenderers);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache13, true);
		string name11 = "m_attachBone";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_attachBone);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_attachBone);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache15, true);
		string name12 = "m_yOffset";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.get_m_yOffset);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.set_m_yOffset);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.<>f__mg$cache18, typeof(GenericGraphic.FxInfo));
	}

	// Token: 0x04010B52 RID: 68434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B53 RID: 68435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B54 RID: 68436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B55 RID: 68437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B56 RID: 68438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B57 RID: 68439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B58 RID: 68440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B59 RID: 68441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B5A RID: 68442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010B5B RID: 68443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010B5C RID: 68444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010B5D RID: 68445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B5E RID: 68446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B5F RID: 68447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B60 RID: 68448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010B61 RID: 68449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010B62 RID: 68450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010B63 RID: 68451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010B64 RID: 68452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010B65 RID: 68453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010B66 RID: 68454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010B67 RID: 68455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010B68 RID: 68456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010B69 RID: 68457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010B6A RID: 68458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
