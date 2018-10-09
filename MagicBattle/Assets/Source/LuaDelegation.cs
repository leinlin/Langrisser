using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Script.ProjectL.Runtime.UI.Activity;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using FixMath.NET;
using PD.SDK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace SLua
{
	// Token: 0x02000002 RID: 2
	public class LuaDelegation : LuaObject
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public static void Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_WithOutParam_Int32_LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState(LuaHotFixChecker obj, LuaFunction ld, int a1, out LuaHotFixExample a2, out LuaTestStruct a3, out int a4, out float a5, out bool a6, out ObjectLuaHotFixState a7)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<LuaHotFixExample>(l, num + 1, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 2, out a3);
			LuaObject.checkType(l, num + 3, out a4);
			LuaObject.checkType(l, num + 4, out a5);
			LuaObject.checkType(l, num + 5, out a6);
			LuaObject.checkEnum<ObjectLuaHotFixState>(l, num + 6, out a7);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020DC File Offset: 0x000002DC
		public static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_GetOutParam_LuaHotFixExample_Int32_LuaTestStruct(LuaHotFixChecker obj, LuaFunction ld, out LuaHotFixExample a1, out int a2, out LuaTestStruct a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<LuaHotFixExample>(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002140 File Offset: 0x00000340
		public static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_GetRefParam_LuaHotFixExample_Int32_LuaTestStruct(LuaHotFixChecker obj, LuaFunction ld, out LuaHotFixExample a1, ref int a2, out LuaTestStruct a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<LuaHotFixExample>(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021AC File Offset: 0x000003AC
		public static void Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker_WithOutParamAndArray_Stringbe_Int32(LuaHotFixChecker obj, LuaFunction ld, string[] a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		public static void Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample_WithOutParam_Int32_LuaHotFixExample_LuaTestStruct_Int32_Single_Boolean_ObjectLuaHotFixState(LuaHotFixExample obj, LuaFunction ld, int a1, out LuaHotFixExample a2, out LuaTestStruct a3, out int a4, out float a5, out bool a6, out ObjectLuaHotFixState a7)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<LuaHotFixExample>(l, num + 1, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 2, out a3);
			LuaObject.checkType(l, num + 3, out a4);
			LuaObject.checkType(l, num + 4, out a5);
			LuaObject.checkType(l, num + 5, out a6);
			LuaObject.checkEnum<ObjectLuaHotFixState>(l, num + 6, out a7);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002278 File Offset: 0x00000478
		public static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample_GetOutParam_LuaHotFixExample_LuaHotFixExample_LuaTestStruct_LuaTestStruct_Int32_Int32_Single_Single_Boolean_Boolean_ObjectLuaHotFixState_ObjectLuaHotFixState(LuaHotFixExample obj, LuaFunction ld, out LuaHotFixExample a1, LuaHotFixExample a2, out LuaTestStruct a3, LuaTestStruct a4, out int a5, int a6, out float a7, float a8, out bool a9, bool a10, out ObjectLuaHotFixState a11, ObjectLuaHotFixState a12)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a6);
			LuaObject.pushValue(l, a8);
			LuaObject.pushValue(l, a10);
			LuaObject.pushValue(l, a12);
			ld.pcall(7, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<LuaHotFixExample>(l, num + 2, out a1);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 3, out a3);
			LuaObject.checkType(l, num + 4, out a5);
			LuaObject.checkType(l, num + 5, out a7);
			LuaObject.checkType(l, num + 6, out a9);
			LuaObject.checkEnum<ObjectLuaHotFixState>(l, num + 7, out a11);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000233C File Offset: 0x0000053C
		public static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample_GetOutParam_LuaHotFixExample_Int32_LuaTestStruct(LuaHotFixExample obj, LuaFunction ld, out LuaHotFixExample a1, out int a2, out LuaTestStruct a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<LuaHotFixExample>(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023A0 File Offset: 0x000005A0
		public static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample_GetRefParam_LuaHotFixExample_Int32_LuaTestStruct(LuaHotFixExample obj, LuaFunction ld, out LuaHotFixExample a1, ref int a2, out LuaTestStruct a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<LuaHotFixExample>(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkValueType<LuaTestStruct>(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000240C File Offset: 0x0000060C
		public static bool Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase_IsDataCacheDirtyByPlayerInfoInitAck_Object_Boolean(PlayerContextBase obj, LuaFunction ld, object a1, out bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002460 File Offset: 0x00000660
		public static bool Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase_TryGetAsset_String_Object(PrefabResourceContainerBase obj, LuaFunction ld, string a1, out UnityEngine.Object a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<UnityEngine.Object>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024B4 File Offset: 0x000006B4
		public static bool Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager_RegBundleLoadingCtx_String_BundleLoadingCtx(ResourceManager obj, LuaFunction ld, string a1, out ResourceManager.BundleLoadingCtx a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<ResourceManager.BundleLoadingCtx>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002508 File Offset: 0x00000708
		public static bool Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase_LoadLastLoginWithUIInputInfo_String_String_Int32(LoginUITaskBase obj, LuaFunction ld, out string a1, out string a2, out int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkType(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000256C File Offset: 0x0000076C
		public static bool Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom_TryGetParam_String_Object(UIIntentCustom obj, LuaFunction ld, string a1, out object a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<object>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000025C0 File Offset: 0x000007C0
		public static bool Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable___callBase_TryGetParam_String_Object(UIIntentReturnable obj, LuaFunction ld, string a1, out object a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<object>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002614 File Offset: 0x00000814
		public static bool Lua_BlackJack_ProjectL_Battle_BattleActor_FindRandomEmptyPosition_Int32_Int32_GridPosition(BattleActor obj, LuaFunction ld, int a1, int a2, ref GridPosition a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkValueType<GridPosition>(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002684 File Offset: 0x00000884
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32(BattleActor obj, LuaFunction ld, BattlePropertyModifier a1, ref uint a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000026D4 File Offset: 0x000008D4
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32_Boolean_Boolean(BattleActor obj, LuaFunction ld, BattlePropertyModifier a1, ref uint a2, bool a3, bool a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(5, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002734 File Offset: 0x00000934
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_CollectOtherActorBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32(BattleActor obj, LuaFunction ld, BattlePropertyModifier a1, ref uint a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002784 File Offset: 0x00000984
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTagsInCombat_BattlePropertyModifier_UInt32_BattleActor_Boolean_Int32(BattleActor obj, LuaFunction ld, BattlePropertyModifier a1, ref uint a2, BattleActor a3, bool a4, int a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(6, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027EC File Offset: 0x000009EC
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationAttack_Int32_Boolean_ArmyRelationData(BattleActor obj, LuaFunction ld, int a1, bool a2, ref ArmyRelationData a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkValueType<ArmyRelationData>(l, num + 1, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000284C File Offset: 0x00000A4C
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationDefend_Int32_Boolean_ArmyRelationData(BattleActor obj, LuaFunction ld, int a1, bool a2, ref ArmyRelationData a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkValueType<ArmyRelationData>(l, num + 1, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028AC File Offset: 0x00000AAC
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationModifyAttack_Int32_Boolean_ArmyRelationData(BattleActor obj, LuaFunction ld, int a1, bool a2, ref ArmyRelationData a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkValueType<ArmyRelationData>(l, num + 1, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000290C File Offset: 0x00000B0C
		public static void Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationModifyDefend_Int32_Boolean_ArmyRelationData(BattleActor obj, LuaFunction ld, int a1, bool a2, ref ArmyRelationData a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkValueType<ArmyRelationData>(l, num + 1, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000296C File Offset: 0x00000B6C
		public static List<ConfigDataSkillInfo> Lua_BlackJack_ProjectL_Battle_BattlePlayer_GetTrainingTechSoldierSkillInfos_IConfigDataLoader_ConfigDataSoldierInfo_Int32(BattlePlayer obj, LuaFunction ld, IConfigDataLoader a1, ConfigDataSoldierInfo a2, out int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			List<ConfigDataSkillInfo> result;
			LuaObject.checkType<List<ConfigDataSkillInfo>>(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029C8 File Offset: 0x00000BC8
		public static void Lua_BlackJack_ProjectL_Battle_CombatFlyObject_ComputeParabolicPosition_Fix64_Vector2i_Fix64(CombatFlyObject obj, LuaFunction ld, Fix64 a1, out Vector2i a2, out Fix64 a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkValueType<Vector2i>(l, num + 1, out a2);
			LuaObject.checkValueType<Fix64>(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A20 File Offset: 0x00000C20
		public static int Lua_BlackJack_ProjectL_Common_BagComponentCommon_IsGoodsEnough_List1_List1(BagComponentCommon obj, LuaFunction ld, List<Goods> a1, out List<BagItemBase> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<List<BagItemBase>>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002A74 File Offset: 0x00000C74
		public static bool Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckCooperateBattleAvailable_Int32_Int32(CooperateBattleCompomentCommon obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public static bool Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckCooperateBattleLevelAvailable_Int32_Int32_Int32(CooperateBattleCompomentCommon obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002B34 File Offset: 0x00000D34
		public static bool Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckPlayerOutOfBattle_Int32(CooperateBattleCompomentCommon obj, LuaFunction ld, ref int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002B88 File Offset: 0x00000D88
		public static bool Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckEnergy_Int32_Int32_Int32(CooperateBattleCompomentCommon obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002BEC File Offset: 0x00000DEC
		public static bool Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckBag_Int32_Int32_Int32(CooperateBattleCompomentCommon obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002C50 File Offset: 0x00000E50
		public static bool Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon_CheckRankingListInfoQuery_RankingListType_Int32(GlobalRankingListComponentCommon obj, LuaFunction ld, RankingListType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public static bool Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckHeroPhantomAvailable_Int32_Int32(HeroPhantomCompomentCommon obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D04 File Offset: 0x00000F04
		public static bool Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckHeroPhantomLevelAvailable_Int32_Int32(HeroPhantomCompomentCommon obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D60 File Offset: 0x00000F60
		public static bool Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckPlayerOutOfBattle_Int32(HeroPhantomCompomentCommon obj, LuaFunction ld, ref int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public static bool Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckEnergy_Int32_Int32(HeroPhantomCompomentCommon obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002E10 File Offset: 0x00001010
		public static bool Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckBag_Int32_Int32(HeroPhantomCompomentCommon obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E6C File Offset: 0x0000106C
		public static bool Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon_TryGetBotParamsForNovice_BattleMode_Int32_Int32_Int32_Int32_Int32(RealTimePVPComponentCommon obj, LuaFunction ld, BattleMode a1, int a2, out int a3, out int a4, out int a5, out int a6)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaObject.checkType(l, num + 3, out a4);
			LuaObject.checkType(l, num + 4, out a5);
			LuaObject.checkType(l, num + 5, out a6);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002EF0 File Offset: 0x000010F0
		public static bool Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon_TryGetBotParamsForLoser_BattleMode_Int32_Int32_Int32_Int32_Int32_Int32(RealTimePVPComponentCommon obj, LuaFunction ld, BattleMode a1, int a2, int a3, out int a4, out int a5, out int a6, out int a7)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a4);
			LuaObject.checkType(l, num + 3, out a5);
			LuaObject.checkType(l, num + 4, out a6);
			LuaObject.checkType(l, num + 5, out a7);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002F7C File Offset: 0x0000117C
		public static int Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon_GetCrystalCount_CardPool_Boolean_Boolean(SelectCardComponentCommon obj, LuaFunction ld, CardPool a1, bool a2, out bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002FD8 File Offset: 0x000011D8
		public static void Lua_BlackJack_ProjectL_Common_TeamComponentCommon_GetTeamRoomInfo_GameFunctionType_Int32(TeamComponentCommon obj, LuaFunction ld, out GameFunctionType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkEnum<GameFunctionType>(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003024 File Offset: 0x00001224
		public static int Lua_BlackJack_ProjectL_PlayerContext_BagComponent___callBase_IsGoodsEnough_List1_List1(BagComponent obj, LuaFunction ld, List<Goods> a1, out List<BagItemBase> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<List<BagItemBase>>(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003078 File Offset: 0x00001278
		public static int Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent_TryRaid_Int32_Int32(ClimbTowerComponent obj, LuaFunction ld, out int a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000030D0 File Offset: 0x000012D0
		public static bool Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment___callBase_CheckCooperateBattleAvailable_Int32_Int32(CooperateBattleCompoment obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000312C File Offset: 0x0000132C
		public static bool Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment___callBase_CheckCooperateBattleLevelAvailable_Int32_Int32_Int32(CooperateBattleCompoment obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003190 File Offset: 0x00001390
		public static bool Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment___callBase_CheckPlayerOutOfBattle_Int32(CooperateBattleCompoment obj, LuaFunction ld, ref int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000031E4 File Offset: 0x000013E4
		public static bool Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment___callBase_CheckEnergy_Int32_Int32_Int32(CooperateBattleCompoment obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003248 File Offset: 0x00001448
		public static bool Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment___callBase_CheckBag_Int32_Int32_Int32(CooperateBattleCompoment obj, LuaFunction ld, int a1, int a2, ref int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032AC File Offset: 0x000014AC
		public static bool Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_IsAbleQueryRankingListInfo_RankingListType_Int32(GlobalRankingListComponent obj, LuaFunction ld, RankingListType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003304 File Offset: 0x00001504
		public static bool Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent___callBase_CheckRankingListInfoQuery_RankingListType_Int32(GlobalRankingListComponent obj, LuaFunction ld, RankingListType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000335C File Offset: 0x0000155C
		public static bool Lua_BlackJack_ProjectL_PlayerContext_Happening_GetGameFunctionTypeAndLocationId_GameFunctionType_Int32(Happening obj, LuaFunction ld, out GameFunctionType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkEnum<GameFunctionType>(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000033B4 File Offset: 0x000015B4
		public static bool Lua_BlackJack_ProjectL_PlayerContext_Happening_GetStarCondition_Int32_Int32(Happening obj, LuaFunction ld, out int a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000340C File Offset: 0x0000160C
		public static bool Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment___callBase_CheckHeroPhantomAvailable_Int32_Int32(HeroPhantomCompoment obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003468 File Offset: 0x00001668
		public static bool Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment___callBase_CheckHeroPhantomLevelAvailable_Int32_Int32(HeroPhantomCompoment obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000034C4 File Offset: 0x000016C4
		public static bool Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment___callBase_CheckPlayerOutOfBattle_Int32(HeroPhantomCompoment obj, LuaFunction ld, ref int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003518 File Offset: 0x00001718
		public static bool Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment___callBase_CheckEnergy_Int32_Int32(HeroPhantomCompoment obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003574 File Offset: 0x00001774
		public static bool Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment___callBase_CheckBag_Int32_Int32(HeroPhantomCompoment obj, LuaFunction ld, int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000035D0 File Offset: 0x000017D0
		public static bool Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_IsDataCacheDirtyByPlayerInfoInitAck_Object_Boolean(ProjectLPlayerContext obj, LuaFunction ld, object a1, out bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003624 File Offset: 0x00001824
		public static int Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_ClimbTowerTryRaid_Int32_Int32(ProjectLPlayerContext obj, LuaFunction ld, out int a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000367C File Offset: 0x0000187C
		public static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_GetWaypointEvent_Int32_ConfigDataEventInfo_RandomEvent(ProjectLPlayerContext obj, LuaFunction ld, int a1, out ConfigDataEventInfo a2, out RandomEvent a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<ConfigDataEventInfo>(l, num + 1, out a2);
			LuaObject.checkType<RandomEvent>(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000036D0 File Offset: 0x000018D0
		public static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_SetChangedGoodsStatus_ProGoods_Boolean_Boolean_Boolean(ProjectLPlayerContext obj, LuaFunction ld, ProGoods a1, ref bool a2, ref bool a3, ref bool a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(5, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaObject.checkType(l, num + 2, out a3);
			LuaObject.checkType(l, num + 3, out a4);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003748 File Offset: 0x00001948
		public static bool Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_IsAbleQueryRankingListInfo_RankingListType_Int32(ProjectLPlayerContext obj, LuaFunction ld, RankingListType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000037A0 File Offset: 0x000019A0
		public static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_GetUnchartedScoreOpenTime_Int32_DateTime_DateTime(ProjectLPlayerContext obj, LuaFunction ld, int a1, out DateTime a2, out DateTime a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkValueType<DateTime>(l, num + 1, out a2);
			LuaObject.checkValueType<DateTime>(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000037F4 File Offset: 0x000019F4
		public static bool Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent___callBase_TryGetBotParamsForNovice_BattleMode_Int32_Int32_Int32_Int32_Int32(RealTimePVPComponent obj, LuaFunction ld, BattleMode a1, int a2, out int a3, out int a4, out int a5, out int a6)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaObject.checkType(l, num + 3, out a4);
			LuaObject.checkType(l, num + 4, out a5);
			LuaObject.checkType(l, num + 5, out a6);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003878 File Offset: 0x00001A78
		public static bool Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent___callBase_TryGetBotParamsForLoser_BattleMode_Int32_Int32_Int32_Int32_Int32_Int32(RealTimePVPComponent obj, LuaFunction ld, BattleMode a1, int a2, int a3, out int a4, out int a5, out int a6, out int a7)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a4);
			LuaObject.checkType(l, num + 3, out a5);
			LuaObject.checkType(l, num + 4, out a6);
			LuaObject.checkType(l, num + 5, out a7);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003904 File Offset: 0x00001B04
		public static int Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent___callBase_GetCrystalCount_CardPool_Boolean_Boolean(SelectCardComponent obj, LuaFunction ld, CardPool a1, bool a2, out bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003960 File Offset: 0x00001B60
		public static void Lua_BlackJack_ProjectL_PlayerContext_TeamComponent___callBase_GetTeamRoomInfo_GameFunctionType_Int32(TeamComponent obj, LuaFunction ld, out GameFunctionType a1, out int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkEnum<GameFunctionType>(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000039AC File Offset: 0x00001BAC
		public static void Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent_GetUnchartedScoreOpenTime_Int32_DateTime_DateTime(UnchartedScoreComponent obj, LuaFunction ld, int a1, out DateTime a2, out DateTime a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkValueType<DateTime>(l, num + 1, out a2);
			LuaObject.checkValueType<DateTime>(l, num + 2, out a3);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003A00 File Offset: 0x00001C00
		public static void Lua_BlackJack_ProjectL_Scene_BattleCamera___callBase_GetViewSize_Single_Single(BattleCamera obj, LuaFunction ld, out float a1, out float a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003A4C File Offset: 0x00001C4C
		public static void Lua_BlackJack_ProjectL_Scene_CameraBase_GetViewSize_Single_Single(CameraBase obj, LuaFunction ld, out float a1, out float a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003A98 File Offset: 0x00001C98
		public static void Lua_BlackJack_ProjectL_Scene_CombatCamera___callBase_GetViewSize_Single_Single(CombatCamera obj, LuaFunction ld, out float a1, out float a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public static void Lua_BlackJack_ProjectL_Scene_CutsceneCamera___callBase_GetViewSize_Single_Single(CutsceneCamera obj, LuaFunction ld, out float a1, out float a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003B30 File Offset: 0x00001D30
		public static void Lua_BlackJack_ProjectL_Scene_WorldCamera___callBase_GetViewSize_Single_Single(WorldCamera obj, LuaFunction ld, out float a1, out float a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003B7C File Offset: 0x00001D7C
		public static bool Lua_BlackJack_ProjectL_Scene_WorldPathfinder_GetWaypoint_Int32_ConfigDataWaypointInfo_Vector2(WorldPathfinder obj, LuaFunction ld, int a1, out ConfigDataWaypointInfo a2, out Vector2 a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType<ConfigDataWaypointInfo>(l, num + 2, out a2);
			LuaObject.checkType(l, num + 3, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003BDC File Offset: 0x00001DDC
		public static bool Lua_BlackJack_ProjectL_UI_CombatSceneUIController_GetActorGraphicPosition_CombatActor_Vector3(CombatSceneUIController obj, LuaFunction ld, CombatActor a1, out Vector3 a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003C30 File Offset: 0x00001E30
		public static void Lua_BlackJack_ProjectL_UI_DialogUIController_CreateEffectInGroup_String_ConfigDataPrefabStateInfo_GameObject_Action(DialogUIController obj, LuaFunction ld, ref string a1, ConfigDataPrefabStateInfo a2, GameObject a3, Action a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(5, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003C90 File Offset: 0x00001E90
		public static List<ExpressionParseController.PosStringTuple> Lua_BlackJack_ProjectL_UI_ExpressionParseController_ParseEmoji_String_String(ExpressionParseController obj, LuaFunction ld, string a1, out string a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			List<ExpressionParseController.PosStringTuple> result;
			LuaObject.checkType<List<ExpressionParseController.PosStringTuple>>(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public static void Lua_BlackJack_ProjectL_UI_HeroCommentUIController_CreateSpineGraphic_UISpineGraphic_String_GameObject_Int32_Vector2_Single_List1(HeroCommentUIController obj, LuaFunction ld, ref UISpineGraphic a1, string a2, GameObject a3, int a4, Vector2 a5, float a6, List<ReplaceAnim> a7)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			LuaObject.pushValue(l, a6);
			LuaObject.pushValue(l, a7);
			ld.pcall(8, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003D5C File Offset: 0x00001F5C
		public static void Lua_BlackJack_ProjectL_UI_HeroCommentUIController_DestroySpineGraphic_UISpineGraphic(HeroCommentUIController obj, LuaFunction ld, ref UISpineGraphic a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public static void Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_CreateSpineGraphic_UISpineGraphic_ConfigDataJobConnectionInfo_GameObject_Single_String_Int32(HeroJobTransferUIController obj, LuaFunction ld, ref UISpineGraphic a1, ConfigDataJobConnectionInfo a2, GameObject a3, float a4, string a5, int a6)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			LuaObject.pushValue(l, a6);
			ld.pcall(7, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003E14 File Offset: 0x00002014
		public static void Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_CreateSoldierGraphic_UISpineGraphic_ConfigDataSoldierInfo_GameObject_Single_Int32(HeroJobTransferUIController obj, LuaFunction ld, ref UISpineGraphic a1, ConfigDataSoldierInfo a2, GameObject a3, float a4, int a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(6, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003E7C File Offset: 0x0000207C
		public static void Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_DestroyGraphic_UISpineGraphic(HeroJobTransferUIController obj, LuaFunction ld, ref UISpineGraphic a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003EC4 File Offset: 0x000020C4
		public static void Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController_CreateSpineGraphic_ConfigDataJobConnectionInfo_UISpineGraphic_GameObject(HeroSimpleItemInfoUIController obj, LuaFunction ld, ConfigDataJobConnectionInfo a1, ref UISpineGraphic a2, GameObject a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003F1C File Offset: 0x0000211C
		public static void Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController_DestroySpineGraphic_UISpineGraphic(HeroSimpleItemInfoUIController obj, LuaFunction ld, ref UISpineGraphic a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a1);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003F64 File Offset: 0x00002164
		public static bool Lua_BlackJack_ProjectL_UI_LoginUITask_ParseLoginAgentAck_String_String_String_String_String_String(LoginUITask obj, LuaFunction ld, string a1, ref string a2, ref string a3, ref string a4, ref string a5, ref string a6)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			LuaObject.pushValue(l, a6);
			ld.pcall(7, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaObject.checkType(l, num + 3, out a3);
			LuaObject.checkType(l, num + 4, out a4);
			LuaObject.checkType(l, num + 5, out a5);
			LuaObject.checkType(l, num + 6, out a6);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004014 File Offset: 0x00002214
		public static bool Lua_BlackJack_ProjectL_UI_LoginUITask___callBase_LoadLastLoginWithUIInputInfo_String_String_Int32(LoginUITask obj, LuaFunction ld, out string a1, out string a2, out int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaObject.checkType(l, num + 4, out a3);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004078 File Offset: 0x00002278
		public static void Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController_SetSpineAnim_String_UISpineGraphic_GameObject_ConfigDataSoldierInfo(StoreSoldierSkinDetailUIController obj, LuaFunction ld, string a1, ref UISpineGraphic a2, GameObject a3, ConfigDataSoldierInfo a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(5, num);
			LuaObject.checkType<UISpineGraphic>(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000040D8 File Offset: 0x000022D8
		public static bool Lua_BlackJack_ProjectL_UI_TestUI_ToolButton_Int32_Int32_Single_String(TestUI obj, LuaFunction ld, ref int a1, ref int a2, float a3, string a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(5, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004150 File Offset: 0x00002350
		public static bool Lua_BlackJack_ProjectL_UI_TestUI_ToolToggle_Int32_Int32_Single_String_Boolean(TestUI obj, LuaFunction ld, ref int a1, ref int a2, float a3, string a4, bool a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(6, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a1);
			LuaObject.checkType(l, num + 3, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000041D0 File Offset: 0x000023D0
		public static void Lua_BlackJack_ProjectL_UI_TestUI_TextLine_Int32_Int32_String(TestUI obj, LuaFunction ld, int a1, ref int a2, string a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(4, num);
			LuaObject.checkType(l, num + 1, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004228 File Offset: 0x00002428
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIGMReloginButton_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004284 File Offset: 0x00002484
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIToolToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000042E0 File Offset: 0x000024E0
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUISpeedToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000433C File Offset: 0x0000253C
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIAudioToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004398 File Offset: 0x00002598
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUITouchToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000043F4 File Offset: 0x000025F4
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIMultiTouchToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004450 File Offset: 0x00002650
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIResolutionToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000044AC File Offset: 0x000026AC
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIFrameRateToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004508 File Offset: 0x00002708
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUITimeToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004564 File Offset: 0x00002764
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIMemoryToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000045C0 File Offset: 0x000027C0
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUILowMemoryTest_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000461C File Offset: 0x0000281C
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIGMCommandToggle_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004678 File Offset: 0x00002878
		public static void Lua_BlackJack_ProjectL_UI_TestUI_GUIGMCommand_Int32_Int32(TestUI obj, LuaFunction ld, ref int a1, ref int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(3, num);
			LuaObject.checkType(l, num + 1, out a1);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000046D4 File Offset: 0x000028D4
		public static bool Lua_System_Collections_Generic_Dictionary_2_int_string_TryGetValue_Int32_String(Dictionary<int, string> obj, LuaFunction ld, int a1, out string a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, obj);
			LuaObject.pushValue(l, a1);
			ld.pcall(2, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaObject.checkType(l, num + 2, out a2);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004728 File Offset: 0x00002928
		internal static void Lua_BlackJack_ProjectL_UI_StoreListUIController_Action_5_BlackJack_ConfigData_StoreId_int_int_int_List_BlackJack_ConfigData_Goods_(LuaFunction ld, StoreId a1, int a2, int a3, int a4, List<Goods> a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(5, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004780 File Offset: 0x00002980
		internal static int Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker_ReturnIntDelegate(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000047C4 File Offset: 0x000029C4
		internal static int Lua_BlackJack_ProjectL_Battle_BattleActor_ComputeActorScoreFunc(LuaFunction ld, BattleActor a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000480C File Offset: 0x00002A0C
		internal static bool Lua_BlackJack_ProjectL_Common_AnikiGymLevelClearCheck(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004850 File Offset: 0x00002A50
		internal static int Lua_BlackJack_ProjectL_Common_ComputeBattlePower(LuaFunction ld, Hero a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004894 File Offset: 0x00002A94
		internal static DateTime Lua_BlackJack_ProjectL_Common_CurrentTime(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			DateTime result;
			LuaObject.checkValueType<DateTime>(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000048D0 File Offset: 0x00002AD0
		internal static Hero Lua_BlackJack_ProjectL_Common_FindHero(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			Hero result;
			LuaObject.checkType<Hero>(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004914 File Offset: 0x00002B14
		internal static int Lua_BlackJack_ProjectL_Common_GetUserLevel(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004950 File Offset: 0x00002B50
		internal static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_HeroDungeonLevelBattleFinishedAckCallback(LuaFunction ld, int a1, int a2, BattleReward a3, bool a4, List<int> a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(5, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000049A4 File Offset: 0x00002BA4
		internal static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_HeroPhantomBattleFinishedAckCallback(LuaFunction ld, int a1, bool a2, BattleReward a3, bool a4, List<int> a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(5, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000049F8 File Offset: 0x00002BF8
		internal static void Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext_RiftLevelBattleFinishedAckCallback(LuaFunction ld, int a1, int a2, BattleReward a3, bool a4, List<int> a5)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			LuaObject.pushValue(l, a5);
			ld.pcall(5, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004A4C File Offset: 0x00002C4C
		internal static void Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup_UpdateChildrenCallbackDelegate(LuaFunction ld, int a1, Transform a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004A88 File Offset: 0x00002C88
		internal static void Lua_System_Action(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004AB8 File Offset: 0x00002CB8
		internal static void Lua_System_Action_1_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase(LuaFunction ld, SceneLayerBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004AEC File Offset: 0x00002CEC
		internal static void Lua_System_Action_1_BlackJack_BJFramework_Runtime_TaskNs_Task(LuaFunction ld, Task a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004B20 File Offset: 0x00002D20
		internal static void Lua_System_Action_1_BlackJack_BJFramework_Runtime_UI_UIControllerBase(LuaFunction ld, UIControllerBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004B54 File Offset: 0x00002D54
		internal static void Lua_System_Action_1_BlackJack_BJFramework_Runtime_UI_UITaskBase(LuaFunction ld, UITaskBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004B88 File Offset: 0x00002D88
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataAnikiGymInfo(LuaFunction ld, ConfigDataAnikiGymInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004BBC File Offset: 0x00002DBC
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataAnikiLevelInfo(LuaFunction ld, ConfigDataAnikiLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004BF0 File Offset: 0x00002DF0
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataBattleInfo(LuaFunction ld, ConfigDataBattleInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004C24 File Offset: 0x00002E24
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataChallengeLevelInfo(LuaFunction ld, ConfigDataChallengeLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C58 File Offset: 0x00002E58
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo(LuaFunction ld, ConfigDataCooperateBattleLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004C8C File Offset: 0x00002E8C
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo(LuaFunction ld, ConfigDataGuildMassiveCombatDifficultyInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004CC0 File Offset: 0x00002EC0
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo(LuaFunction ld, ConfigDataHeroDungeonLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004CF4 File Offset: 0x00002EF4
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo(LuaFunction ld, ConfigDataHeroPhantomLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004D28 File Offset: 0x00002F28
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo(LuaFunction ld, ConfigDataHeroTrainningLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004D5C File Offset: 0x00002F5C
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataJobConnectionInfo(LuaFunction ld, ConfigDataJobConnectionInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004D90 File Offset: 0x00002F90
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo(LuaFunction ld, ConfigDataMemoryCorridorLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004DC4 File Offset: 0x00002FC4
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataRiftChapterInfo(LuaFunction ld, ConfigDataRiftChapterInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004DF8 File Offset: 0x00002FF8
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataRiftLevelInfo(LuaFunction ld, ConfigDataRiftLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004E2C File Offset: 0x0000302C
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataScenarioInfo(LuaFunction ld, ConfigDataScenarioInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004E60 File Offset: 0x00003060
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataScoreLevelInfo(LuaFunction ld, ConfigDataScoreLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004E94 File Offset: 0x00003094
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataSkillInfo(LuaFunction ld, ConfigDataSkillInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004EC8 File Offset: 0x000030C8
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataSoldierInfo(LuaFunction ld, ConfigDataSoldierInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004EFC File Offset: 0x000030FC
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataST_CN(LuaFunction ld, ConfigDataST_CN a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004F30 File Offset: 0x00003130
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataST_EN(LuaFunction ld, ConfigDataST_EN a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004F64 File Offset: 0x00003164
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo(LuaFunction ld, ConfigDataThearchyTrialLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004F98 File Offset: 0x00003198
		internal static void Lua_System_Action_1_BlackJack_ConfigData_ConfigDataTreasureLevelInfo(LuaFunction ld, ConfigDataTreasureLevelInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004FCC File Offset: 0x000031CC
		internal static void Lua_System_Action_1_BlackJack_ConfigData_GetPathData(LuaFunction ld, GetPathData a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005000 File Offset: 0x00003200
		internal static void Lua_System_Action_1_BlackJack_ConfigData_GoodsType(LuaFunction ld, GoodsType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000503C File Offset: 0x0000323C
		internal static void Lua_System_Action_1_BlackJack_ConfigData_StoreId(LuaFunction ld, StoreId a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005078 File Offset: 0x00003278
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_ArenaBattleReport(LuaFunction ld, ArenaBattleReport a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000050AC File Offset: 0x000032AC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_BagItemBase(LuaFunction ld, BagItemBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000050E0 File Offset: 0x000032E0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_BattleHero(LuaFunction ld, BattleHero a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005114 File Offset: 0x00003314
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_BattleMode(LuaFunction ld, BattleMode a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005150 File Offset: 0x00003350
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_BattleType(LuaFunction ld, BattleType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000518C File Offset: 0x0000338C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_BusinessCard(LuaFunction ld, BusinessCard a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000051C0 File Offset: 0x000033C0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_CardPool(LuaFunction ld, CardPool a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000051F4 File Offset: 0x000033F4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_ChatChannel(LuaFunction ld, ChatChannel a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005230 File Offset: 0x00003430
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_ChatMessage(LuaFunction ld, ChatMessage a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005264 File Offset: 0x00003464
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_ChatVoiceMessage(LuaFunction ld, ChatVoiceMessage a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005298 File Offset: 0x00003498
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_DanmakuEntry(LuaFunction ld, DanmakuEntry a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000052CC File Offset: 0x000034CC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_EquipmentBagItem(LuaFunction ld, EquipmentBagItem a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005300 File Offset: 0x00003500
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_GuildLog(LuaFunction ld, GuildLog a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005334 File Offset: 0x00003534
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral(LuaFunction ld, GuildMassiveCombatGeneral a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005368 File Offset: 0x00003568
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold(LuaFunction ld, GuildMassiveCombatStronghold a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000539C File Offset: 0x0000359C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo(LuaFunction ld, GuildPlayerMassiveCombatInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000053D0 File Offset: 0x000035D0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_Hero(LuaFunction ld, Hero a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005404 File Offset: 0x00003604
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_HeroCommentEntry(LuaFunction ld, HeroCommentEntry a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005438 File Offset: 0x00003638
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_Mail(LuaFunction ld, Mail a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000546C File Offset: 0x0000366C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_Marquee(LuaFunction ld, Marquee a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000054A0 File Offset: 0x000036A0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_OperationalActivityBase(LuaFunction ld, OperationalActivityBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000054D4 File Offset: 0x000036D4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_RankingListType(LuaFunction ld, RankingListType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005510 File Offset: 0x00003710
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_RealTimePVPBattleReport(LuaFunction ld, RealTimePVPBattleReport a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005544 File Offset: 0x00003744
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_TeamRoomAuthority(LuaFunction ld, TeamRoomAuthority a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005580 File Offset: 0x00003780
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_TeamRoomInviteInfo(LuaFunction ld, TeamRoomInviteInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000055B4 File Offset: 0x000037B4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_TeamRoomPlayer(LuaFunction ld, TeamRoomPlayer a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000055E8 File Offset: 0x000037E8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_TeamRoomSetting(LuaFunction ld, TeamRoomSetting a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000561C File Offset: 0x0000381C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_TrainingTech(LuaFunction ld, TrainingTech a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005650 File Offset: 0x00003850
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Common_UserSummary(LuaFunction ld, UserSummary a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005684 File Offset: 0x00003884
		internal static void Lua_System_Action_1_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient(LuaFunction ld, ChatComponent.ChatMessageClient a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000056B8 File Offset: 0x000038B8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_PlayerContext_PVPInviteInfo(LuaFunction ld, PVPInviteInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000056EC File Offset: 0x000038EC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Protocol_FriendGetUserSummaryAck(LuaFunction ld, FriendGetUserSummaryAck a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005720 File Offset: 0x00003920
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Protocol_ProChatGroupInfo(LuaFunction ld, ProChatGroupInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005754 File Offset: 0x00003954
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Protocol_ProRealTimePVPUserInfo(LuaFunction ld, ProRealTimePVPUserInfo a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005788 File Offset: 0x00003988
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Scene_ClientBattleActor(LuaFunction ld, ClientBattleActor a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000057BC File Offset: 0x000039BC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_Scene_SkipCombatMode(LuaFunction ld, SkipCombatMode a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000057F8 File Offset: 0x000039F8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_AnikiLevelListItemUIController(LuaFunction ld, AnikiLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000582C File Offset: 0x00003A2C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ArchiveItemUIController(LuaFunction ld, ArchiveItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005860 File Offset: 0x00003A60
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ArenaActionOrderButton(LuaFunction ld, ArenaActionOrderButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005894 File Offset: 0x00003A94
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ArenaDefendActor(LuaFunction ld, ArenaDefendActor a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000058C8 File Offset: 0x00003AC8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController(LuaFunction ld, ArenaOpponentListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000058FC File Offset: 0x00003AFC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ARHeroCardUIController(LuaFunction ld, ARHeroCardUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005930 File Offset: 0x00003B30
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_AssistanceTeamUIController(LuaFunction ld, AssistanceTeamUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005964 File Offset: 0x00003B64
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BattlePrepareStageActor(LuaFunction ld, BattlePrepareStageActor a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005998 File Offset: 0x00003B98
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BattleSoldierItemUIController(LuaFunction ld, BattleSoldierItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000059CC File Offset: 0x00003BCC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController(LuaFunction ld, BeforeJoinSingleGuildUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005A00 File Offset: 0x00003C00
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController(LuaFunction ld, BusinessCardHeroCharItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005A34 File Offset: 0x00003C34
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController(LuaFunction ld, BusinessCardHeroEquipmentItemController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005A68 File Offset: 0x00003C68
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController(LuaFunction ld, BusinessCardHeroListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005A9C File Offset: 0x00003C9C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController(LuaFunction ld, ClimbTowerFloorItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005AD0 File Offset: 0x00003CD0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_CooperateBattleButton(LuaFunction ld, CooperateBattleButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005B04 File Offset: 0x00003D04
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController(LuaFunction ld, CooperateBattleLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005B38 File Offset: 0x00003D38
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_CourseItemUIController(LuaFunction ld, CourseItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005B6C File Offset: 0x00003D6C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_DayButtonUIController(LuaFunction ld, DayButtonUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005BA0 File Offset: 0x00003DA0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_DrillRoomToggleUIController(LuaFunction ld, DrillRoomToggleUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005BD4 File Offset: 0x00003DD4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_EventRiftLevelButton(LuaFunction ld, EventRiftLevelButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005C08 File Offset: 0x00003E08
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController(LuaFunction ld, FettersConfessionSkillItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005C3C File Offset: 0x00003E3C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController(LuaFunction ld, FettersInformationVoiceItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005C70 File Offset: 0x00003E70
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FriendBigItemUIController(LuaFunction ld, FriendBigItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005CA4 File Offset: 0x00003EA4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FriendGroupUIController(LuaFunction ld, FriendGroupUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005CD8 File Offset: 0x00003ED8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FriendPanelType(LuaFunction ld, FriendPanelType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005D14 File Offset: 0x00003F14
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_FriendSmallItemUIController(LuaFunction ld, FriendSmallItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005D48 File Offset: 0x00003F48
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GainRewardButton(LuaFunction ld, GainRewardButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005D7C File Offset: 0x00003F7C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GoddessDialogChoiceButton(LuaFunction ld, GoddessDialogChoiceButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005DB0 File Offset: 0x00003FB0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GoddessDialogJobButton(LuaFunction ld, GoddessDialogJobButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005DE4 File Offset: 0x00003FE4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildGameListItemUIController(LuaFunction ld, GuildGameListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005E18 File Offset: 0x00004018
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController(LuaFunction ld, GuildInviteMemberInfoItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005E4C File Offset: 0x0000404C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController(LuaFunction ld, GuildMassiveCombatLastHeroUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005E80 File Offset: 0x00004080
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController(LuaFunction ld, GuildMassiveCombatStrongHoldUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005EB4 File Offset: 0x000040B4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController(LuaFunction ld, GuildMemberInfoItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005EE8 File Offset: 0x000040E8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_GuildRaidListItemUIController(LuaFunction ld, GuildRaidListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005F1C File Offset: 0x0000411C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroCharSkinItemUIController(LuaFunction ld, HeroCharSkinItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005F50 File Offset: 0x00004150
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroDragButton(LuaFunction ld, HeroDragButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005F84 File Offset: 0x00004184
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController(LuaFunction ld, HeroDungeonLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005FB8 File Offset: 0x000041B8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroEquipItemUIController(LuaFunction ld, HeroEquipItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005FEC File Offset: 0x000041EC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroExpItemUIController(LuaFunction ld, HeroExpItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006020 File Offset: 0x00004220
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroHeadUIController(LuaFunction ld, HeroHeadUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006054 File Offset: 0x00004254
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroItemUIController(LuaFunction ld, HeroItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006088 File Offset: 0x00004288
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroJobCardItemUIController(LuaFunction ld, HeroJobCardItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000060BC File Offset: 0x000042BC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroListUIController_HeroSortType(LuaFunction ld, HeroListUIController.HeroSortType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000060F8 File Offset: 0x000042F8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController(LuaFunction ld, HeroOrSoliderSkinUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000612C File Offset: 0x0000432C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroPhantomButton(LuaFunction ld, HeroPhantomButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006160 File Offset: 0x00004360
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController(LuaFunction ld, HeroPhantomLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006194 File Offset: 0x00004394
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroSkillItemUIController(LuaFunction ld, HeroSkillItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000061C8 File Offset: 0x000043C8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_HeroTrainningLevelListItemUIController(LuaFunction ld, HeroTrainningLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000061FC File Offset: 0x000043FC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_IntegralGoodsUIController(LuaFunction ld, IntegralGoodsUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00006230 File Offset: 0x00004430
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_JobMaterialEquipedUIController(LuaFunction ld, JobMaterialEquipedUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006264 File Offset: 0x00004464
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_MailItemUIController(LuaFunction ld, MailItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006298 File Offset: 0x00004498
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController(LuaFunction ld, MemoryCorridorLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000062CC File Offset: 0x000044CC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_NoticeText(LuaFunction ld, NoticeText a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006300 File Offset: 0x00004500
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController(LuaFunction ld, OfflineArenaBattleReportListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006334 File Offset: 0x00004534
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_OfflineArenaPanelType(LuaFunction ld, OfflineArenaPanelType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006370 File Offset: 0x00004570
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController(LuaFunction ld, OnlineArenaBattleReportListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000063A4 File Offset: 0x000045A4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_OnlineArenaPanelType(LuaFunction ld, OnlineArenaPanelType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000063E0 File Offset: 0x000045E0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_OpenServiceMissonUIController(LuaFunction ld, OpenServiceMissonUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006414 File Offset: 0x00004614
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_PastScenarioListItemUIController(LuaFunction ld, PastScenarioListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006448 File Offset: 0x00004648
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_RiftChapterButton(LuaFunction ld, RiftChapterButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000647C File Offset: 0x0000467C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_RiftLevelButton(LuaFunction ld, RiftLevelButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000064B0 File Offset: 0x000046B0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_SmallExpressionItemContrller(LuaFunction ld, SmallExpressionItemContrller a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000064E4 File Offset: 0x000046E4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_SoldierItemUIController(LuaFunction ld, SoldierItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006518 File Offset: 0x00004718
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_SoldierManualItemUIController(LuaFunction ld, SoldierManualItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000654C File Offset: 0x0000474C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController(LuaFunction ld, StoreHeroSkinItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006580 File Offset: 0x00004780
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_StoreItemUIController(LuaFunction ld, StoreItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000065B4 File Offset: 0x000047B4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController(LuaFunction ld, StoreSoldierSkinItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000065E8 File Offset: 0x000047E8
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_SummonToggleUIController(LuaFunction ld, SummonToggleUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000661C File Offset: 0x0000481C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController(LuaFunction ld, TeamRoomInfoListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006650 File Offset: 0x00004850
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TeamRoomInvitePlayerType(LuaFunction ld, TeamRoomInvitePlayerType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000668C File Offset: 0x0000488C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TeamRoomListItemUIController(LuaFunction ld, TeamRoomListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000066C0 File Offset: 0x000048C0
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController(LuaFunction ld, TeamRoomPlayerInfoUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000066F4 File Offset: 0x000048F4
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TestListType(LuaFunction ld, TestListType a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006730 File Offset: 0x00004930
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController(LuaFunction ld, ThearchyLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006764 File Offset: 0x00004964
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TrainingDifficultItemUIController(LuaFunction ld, TrainingDifficultItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006798 File Offset: 0x00004998
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TrainingHeroItemUIController(LuaFunction ld, TrainingHeroItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000067CC File Offset: 0x000049CC
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TrainingSkillItemUIController(LuaFunction ld, TrainingSkillItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006800 File Offset: 0x00004A00
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_TreasureLevelListItemUIController(LuaFunction ld, TreasureLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006834 File Offset: 0x00004A34
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_UnchartedScoreButton(LuaFunction ld, UnchartedScoreButton a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006868 File Offset: 0x00004A68
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController(LuaFunction ld, UnchartedScoreLevelListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000689C File Offset: 0x00004A9C
		internal static void Lua_System_Action_1_BlackJack_ProjectL_UI_WorldEventListItemUIController(LuaFunction ld, WorldEventListItemUIController a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000068D0 File Offset: 0x00004AD0
		internal static void Lua_System_Action_1_BlackJack_ProjectLBasic_DialogBoxResult(LuaFunction ld, DialogBoxResult a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000690C File Offset: 0x00004B0C
		internal static void Lua_System_Action_1_bool(LuaFunction ld, bool a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006940 File Offset: 0x00004B40
		internal static void Lua_System_Action_1_float(LuaFunction ld, float a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006974 File Offset: 0x00004B74
		internal static void Lua_System_Action_1_int(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000069A8 File Offset: 0x00004BA8
		internal static void Lua_System_Action_1_List_BlackJack_ConfigData_Goods_(LuaFunction ld, List<Goods> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000069DC File Offset: 0x00004BDC
		internal static void Lua_System_Action_1_List_BlackJack_ProjectL_Common_BusinessCardHeroSet_(LuaFunction ld, List<BusinessCardHeroSet> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006A10 File Offset: 0x00004C10
		internal static void Lua_System_Action_1_List_BlackJack_ProjectL_Common_GuildLog_(LuaFunction ld, List<GuildLog> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006A44 File Offset: 0x00004C44
		internal static void Lua_System_Action_1_List_BlackJack_ProjectL_Common_UserSummary_(LuaFunction ld, List<UserSummary> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006A78 File Offset: 0x00004C78
		internal static void Lua_System_Action_1_List_System_Int32_(LuaFunction ld, List<int> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006AAC File Offset: 0x00004CAC
		internal static void Lua_System_Action_1_List_System_String_(LuaFunction ld, List<string> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006AE0 File Offset: 0x00004CE0
		internal static void Lua_System_Action_1_PD_SDK_LoginSuccessMsg(LuaFunction ld, LoginSuccessMsg a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006B1C File Offset: 0x00004D1C
		internal static void Lua_System_Action_1_string(LuaFunction ld, string a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006B50 File Offset: 0x00004D50
		internal static void Lua_System_Action_1_System_Action(LuaFunction ld, Action a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006B84 File Offset: 0x00004D84
		internal static void Lua_System_Action_1_System_Action_List_BlackJack_ProjectL_Common_GuildLog__(LuaFunction ld, Action<List<GuildLog>> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006BB8 File Offset: 0x00004DB8
		internal static void Lua_System_Action_1_System_Action_List_BlackJack_ProjectL_Common_UserSummary__(LuaFunction ld, Action<List<UserSummary>> a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006BEC File Offset: 0x00004DEC
		internal static void Lua_System_Action_1_System_Int64(LuaFunction ld, long a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006C20 File Offset: 0x00004E20
		internal static void Lua_System_Action_1_System_Object(LuaFunction ld, object a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006C54 File Offset: 0x00004E54
		internal static void Lua_System_Action_1_System_UInt64(LuaFunction ld, ulong a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006C88 File Offset: 0x00004E88
		internal static void Lua_System_Action_1_UnityEngine_EventSystems_PointerEventData(LuaFunction ld, PointerEventData a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006CBC File Offset: 0x00004EBC
		internal static void Lua_System_Action_1_UnityEngine_GameObject(LuaFunction ld, GameObject a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006CF0 File Offset: 0x00004EF0
		internal static void Lua_System_Action_1_UnityEngine_Object(LuaFunction ld, UnityEngine.Object a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00006D24 File Offset: 0x00004F24
		internal static void Lua_System_Action_1_UnityEngine_Vector2(LuaFunction ld, Vector2 a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006D58 File Offset: 0x00004F58
		internal static void Lua_System_Action_1_UnityEngine_WWW(LuaFunction ld, WWW a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006D8C File Offset: 0x00004F8C
		internal static void Lua_System_Action_2_BlackJack_BJFramework_Runtime_UI_UIControllerBase_bool(LuaFunction ld, UIControllerBase a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006DC8 File Offset: 0x00004FC8
		internal static void Lua_System_Action_2_BlackJack_ConfigData_ConfigDataRiftLevelInfo_BlackJack_ProjectL_UI_NeedGoods(LuaFunction ld, ConfigDataRiftLevelInfo a1, NeedGoods a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006E04 File Offset: 0x00005004
		internal static void Lua_System_Action_2_BlackJack_ConfigData_ConfigDataWaypointInfo_BlackJack_ConfigData_ConfigDataEventInfo(LuaFunction ld, ConfigDataWaypointInfo a1, ConfigDataEventInfo a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006E40 File Offset: 0x00005040
		internal static void Lua_System_Action_2_BlackJack_ConfigData_GameFunctionType_int(LuaFunction ld, GameFunctionType a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006E80 File Offset: 0x00005080
		internal static void Lua_System_Action_2_BlackJack_ConfigData_GetPathData_BlackJack_ProjectL_UI_NeedGoods(LuaFunction ld, GetPathData a1, NeedGoods a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006EBC File Offset: 0x000050BC
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BagItemBase_BlackJack_ProjectL_UI_BagListUIController_DisplayType(LuaFunction ld, BagItemBase a1, BagListUIController.DisplayType a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006EFC File Offset: 0x000050FC
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BattleHero_BlackJack_ProjectL_Common_GridPosition(LuaFunction ld, BattleHero a1, GridPosition a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006F3C File Offset: 0x0000513C
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BattleHero_int(LuaFunction ld, BattleHero a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006F78 File Offset: 0x00005178
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BattleHero_List_System_Int32_(LuaFunction ld, BattleHero a1, List<int> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006FB4 File Offset: 0x000051B4
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BattleMode_bool(LuaFunction ld, BattleMode a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006FF4 File Offset: 0x000051F4
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_BattleType_int(LuaFunction ld, BattleType a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007034 File Offset: 0x00005234
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_ChatMessage_UnityEngine_GameObject(LuaFunction ld, ChatMessage a1, GameObject a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007070 File Offset: 0x00005270
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_Hero_BlackJack_BJFramework_Runtime_UI_UIIntent(LuaFunction ld, Hero a1, UIIntent a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000070AC File Offset: 0x000052AC
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Common_Hero_int(LuaFunction ld, Hero a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000070E8 File Offset: 0x000052E8
		internal static void Lua_System_Action_2_BlackJack_ProjectL_Protocol_ProChatGroupInfo_BlackJack_ProjectL_Common_UserSummary(LuaFunction ld, ProChatGroupInfo a1, UserSummary a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007124 File Offset: 0x00005324
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_ArenaActionOrderButton_UnityEngine_EventSystems_PointerEventData(LuaFunction ld, ArenaActionOrderButton a1, PointerEventData a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007160 File Offset: 0x00005360
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_ArenaDefendActor_BlackJack_ProjectL_Common_GridPosition(LuaFunction ld, ArenaDefendActor a1, GridPosition a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000071A0 File Offset: 0x000053A0
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_ArenaDefendActor_BlackJack_ProjectL_UI_ArenaDefendActor(LuaFunction ld, ArenaDefendActor a1, ArenaDefendActor a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000071DC File Offset: 0x000053DC
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_BattlePrepareStageActor_BlackJack_ProjectL_Common_GridPosition(LuaFunction ld, BattlePrepareStageActor a1, GridPosition a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000721C File Offset: 0x0000541C
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_BattlePrepareStageActor_BlackJack_ProjectL_UI_BattlePrepareStageActor(LuaFunction ld, BattlePrepareStageActor a1, BattlePrepareStageActor a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00007258 File Offset: 0x00005458
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_EquipmentSortItemUIController_bool(LuaFunction ld, EquipmentSortItemUIController a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00007294 File Offset: 0x00005494
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_FettersGiftItemUIController_bool(LuaFunction ld, FettersGiftItemUIController a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000072D0 File Offset: 0x000054D0
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController_bool(LuaFunction ld, GuildApplyMemberInfoItemUIController a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000730C File Offset: 0x0000550C
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_HeroDragButton_UnityEngine_EventSystems_PointerEventData(LuaFunction ld, HeroDragButton a1, PointerEventData a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007348 File Offset: 0x00005548
		internal static void Lua_System_Action_2_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController_UnityEngine_EventSystems_PointerEventData(LuaFunction ld, TeamRoomPlayerInfoUIController a1, PointerEventData a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007384 File Offset: 0x00005584
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_AnikiGymListItemUIController(LuaFunction ld, bool a1, AnikiGymListItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000073C0 File Offset: 0x000055C0
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_FriendSmallItemUIController(LuaFunction ld, bool a1, FriendSmallItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000073FC File Offset: 0x000055FC
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController(LuaFunction ld, bool a1, PlayerInfoHeadFrameItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007438 File Offset: 0x00005638
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController(LuaFunction ld, bool a1, PlayerInfoHeadPortraitItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00007474 File Offset: 0x00005674
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController(LuaFunction ld, bool a1, TeamGameFunctionTypeListItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000074B0 File Offset: 0x000056B0
		internal static void Lua_System_Action_2_bool_BlackJack_ProjectL_UI_TeamLocationListItemUIController(LuaFunction ld, bool a1, TeamLocationListItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000074EC File Offset: 0x000056EC
		internal static void Lua_System_Action_2_bool_UnityEngine_WWW(LuaFunction ld, bool a1, WWW a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007528 File Offset: 0x00005728
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_EquipmentBagItem(LuaFunction ld, int a1, EquipmentBagItem a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007564 File Offset: 0x00005764
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_Guild(LuaFunction ld, int a1, Guild a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000075A0 File Offset: 0x000057A0
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral(LuaFunction ld, int a1, GuildMassiveCombatGeneral a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000075DC File Offset: 0x000057DC
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_Hero(LuaFunction ld, int a1, Hero a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007618 File Offset: 0x00005818
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_HeroCommentEntry(LuaFunction ld, int a1, HeroCommentEntry a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00007654 File Offset: 0x00005854
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Common_UserSummary(LuaFunction ld, int a1, UserSummary a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00007690 File Offset: 0x00005890
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_PlayerContext_BattleReward(LuaFunction ld, int a1, BattleReward a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000076CC File Offset: 0x000058CC
		internal static void Lua_System_Action_2_int_BlackJack_ProjectL_Protocol_ProChatGroupInfo(LuaFunction ld, int a1, ProChatGroupInfo a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00007708 File Offset: 0x00005908
		internal static void Lua_System_Action_2_int_bool(LuaFunction ld, int a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00007744 File Offset: 0x00005944
		internal static void Lua_System_Action_2_int_Dictionary_System_Int32_object_(LuaFunction ld, int a1, Dictionary<int, object> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00007780 File Offset: 0x00005980
		internal static void Lua_System_Action_2_int_int(LuaFunction ld, int a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000077BC File Offset: 0x000059BC
		internal static void Lua_System_Action_2_int_List_BlackJack_ConfigData_Goods_(LuaFunction ld, int a1, List<Goods> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000077F8 File Offset: 0x000059F8
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Common_CommonBattleProperty_(LuaFunction ld, int a1, List<CommonBattleProperty> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007834 File Offset: 0x00005A34
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Common_GuildLog_(LuaFunction ld, int a1, List<GuildLog> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007870 File Offset: 0x00005A70
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Common_GuildSearchInfo_(LuaFunction ld, int a1, List<GuildSearchInfo> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000078AC File Offset: 0x00005AAC
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Common_TeamRoom_(LuaFunction ld, int a1, List<TeamRoom> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000078E8 File Offset: 0x00005AE8
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Common_UserSummary_(LuaFunction ld, int a1, List<UserSummary> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007924 File Offset: 0x00005B24
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_Protocol_ProChatGroupCompactInfo_(LuaFunction ld, int a1, List<ProChatGroupCompactInfo> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007960 File Offset: 0x00005B60
		internal static void Lua_System_Action_2_int_List_BlackJack_ProjectL_UI_GuildJoinInvitation_(LuaFunction ld, int a1, List<GuildJoinInvitation> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000799C File Offset: 0x00005B9C
		internal static void Lua_System_Action_2_int_string(LuaFunction ld, int a1, string a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000079D8 File Offset: 0x00005BD8
		internal static void Lua_System_Action_2_int_System_Action(LuaFunction ld, int a1, Action a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007A14 File Offset: 0x00005C14
		internal static void Lua_System_Action_2_int_System_DateTime(LuaFunction ld, int a1, DateTime a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007A54 File Offset: 0x00005C54
		internal static void Lua_System_Action_2_int_System_UInt64(LuaFunction ld, int a1, ulong a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007A90 File Offset: 0x00005C90
		internal static void Lua_System_Action_2_int_UnityEngine_RectTransform(LuaFunction ld, int a1, RectTransform a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00007ACC File Offset: 0x00005CCC
		internal static void Lua_System_Action_2_List_BlackJack_ConfigData_Goods__BlackJack_ProjectL_UI_SignRewardItemUIController(LuaFunction ld, List<Goods> a1, SignRewardItemUIController a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007B08 File Offset: 0x00005D08
		internal static void Lua_System_Action_2_List_BlackJack_ProjectL_Common_Hero__List_BlackJack_ProjectL_Common_Hero_(LuaFunction ld, List<Hero> a1, List<Hero> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007B44 File Offset: 0x00005D44
		internal static void Lua_System_Action_2_List_BlackJack_ProjectL_Protocol_ProGoods__System_Action_List_BlackJack_ConfigData_Goods__(LuaFunction ld, List<ProGoods> a1, Action<List<Goods>> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007B80 File Offset: 0x00005D80
		internal static void Lua_System_Action_2_string_bool(LuaFunction ld, string a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007BBC File Offset: 0x00005DBC
		internal static void Lua_System_Action_2_string_double(LuaFunction ld, string a1, double a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007BF8 File Offset: 0x00005DF8
		internal static void Lua_System_Action_2_string_int(LuaFunction ld, string a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007C34 File Offset: 0x00005E34
		internal static void Lua_System_Action_2_string_List_System_String_(LuaFunction ld, string a1, List<string> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007C70 File Offset: 0x00005E70
		internal static void Lua_System_Action_2_string_string(LuaFunction ld, string a1, string a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00007CAC File Offset: 0x00005EAC
		internal static void Lua_System_Action_2_string_System_Action(LuaFunction ld, string a1, Action a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007CE8 File Offset: 0x00005EE8
		internal static void Lua_System_Action_2_string_System_Action_System_Int32_(LuaFunction ld, string a1, Action<int> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007D24 File Offset: 0x00005F24
		internal static void Lua_System_Action_2_string_System_Nullable_UnityEngine_SceneManagement_Scene_(LuaFunction ld, string a1, Scene? a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007D64 File Offset: 0x00005F64
		internal static void Lua_System_Action_2_string_UnityEngine_Object(LuaFunction ld, string a1, UnityEngine.Object a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal static void Lua_System_Action_2_System_Action_List_BlackJack_ProjectL_Common_UserSummary___bool(LuaFunction ld, Action<List<UserSummary>> a1, bool a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007DDC File Offset: 0x00005FDC
		internal static void Lua_System_Action_2_System_Int64_System_Int64(LuaFunction ld, long a1, long a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007E18 File Offset: 0x00006018
		internal static void Lua_System_Action_2_System_UInt64_BlackJack_ProjectL_Common_BattleRoomQuitReason(LuaFunction ld, ulong a1, BattleRoomQuitReason a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007E58 File Offset: 0x00006058
		internal static void Lua_System_Action_2_System_UInt64_int(LuaFunction ld, ulong a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007E94 File Offset: 0x00006094
		internal static void Lua_System_Action_2_UnityEngine_EventSystems_PointerEventData_InputButton_UnityEngine_Vector2(LuaFunction ld, PointerEventData.InputButton a1, Vector2 a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00007ED4 File Offset: 0x000060D4
		internal static void Lua_System_Action_3_BlackJack_ConfigData_ConfigDataGiftStoreItemInfo_bool_int(LuaFunction ld, ConfigDataGiftStoreItemInfo a1, bool a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007F18 File Offset: 0x00006118
		internal static void Lua_System_Action_3_BlackJack_ConfigData_GoodsType_int_int(LuaFunction ld, GoodsType a1, int a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007F60 File Offset: 0x00006160
		internal static void Lua_System_Action_3_BlackJack_ConfigData_StoreId_int_List_BlackJack_ConfigData_Goods_(LuaFunction ld, StoreId a1, int a2, List<Goods> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007FA8 File Offset: 0x000061A8
		internal static void Lua_System_Action_3_BlackJack_ConfigData_StoreType_int_int(LuaFunction ld, StoreType a1, int a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007FF0 File Offset: 0x000061F0
		internal static void Lua_System_Action_3_BlackJack_ProjectL_Common_BattleHero_BlackJack_ProjectL_Common_GridPosition_int(LuaFunction ld, BattleHero a1, GridPosition a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008038 File Offset: 0x00006238
		internal static void Lua_System_Action_3_BlackJack_ProjectL_Common_BattleType_int_List_System_Int32_(LuaFunction ld, BattleType a1, int a2, List<int> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008080 File Offset: 0x00006280
		internal static void Lua_System_Action_3_BlackJack_ProjectL_Common_ChatChannel_string_string(LuaFunction ld, ChatChannel a1, string a2, string a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000080C8 File Offset: 0x000062C8
		internal static void Lua_System_Action_3_BlackJack_ProjectL_Common_UserSummary_UnityEngine_Vector3_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask_PostionType(LuaFunction ld, UserSummary a1, Vector3 a2, PlayerSimpleInfoUITask.PostionType a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008110 File Offset: 0x00006310
		internal static void Lua_System_Action_3_BlackJack_ProjectL_Protocol_HeroInteractAck_List_BlackJack_ConfigData_Goods__int(LuaFunction ld, HeroInteractAck a1, List<Goods> a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008154 File Offset: 0x00006354
		internal static void Lua_System_Action_3_BlackJack_ProjectL_UI_ArenaUIType_bool_BlackJack_BJFramework_Runtime_UI_UIIntent(LuaFunction ld, ArenaUIType a1, bool a2, UIIntent a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000819C File Offset: 0x0000639C
		internal static void Lua_System_Action_3_int_BlackJack_ConfigData_GameFunctionType_int(LuaFunction ld, int a1, GameFunctionType a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000081E4 File Offset: 0x000063E4
		internal static void Lua_System_Action_3_int_BlackJack_ProjectL_PlayerContext_BattleReward_bool(LuaFunction ld, int a1, BattleReward a2, bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008228 File Offset: 0x00006428
		internal static void Lua_System_Action_3_int_BlackJack_ProjectL_PlayerContext_BattleReward_List_BlackJack_ConfigData_Goods_(LuaFunction ld, int a1, BattleReward a2, List<Goods> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000826C File Offset: 0x0000646C
		internal static void Lua_System_Action_3_int_BlackJack_ProjectL_Protocol_ProChatGroupInfo_BlackJack_ProjectL_Protocol_ProChatUserInfo(LuaFunction ld, int a1, ProChatGroupInfo a2, ProChatUserInfo a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000082B0 File Offset: 0x000064B0
		internal static void Lua_System_Action_3_int_bool_BlackJack_ProjectL_PlayerContext_BattleReward(LuaFunction ld, int a1, bool a2, BattleReward a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000082F4 File Offset: 0x000064F4
		internal static void Lua_System_Action_3_int_int_BlackJack_ConfigData_ArmyTag(LuaFunction ld, int a1, int a2, ArmyTag a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000833C File Offset: 0x0000653C
		internal static void Lua_System_Action_3_int_int_BlackJack_ConfigData_Goods(LuaFunction ld, int a1, int a2, Goods a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008380 File Offset: 0x00006580
		internal static void Lua_System_Action_3_int_int_bool(LuaFunction ld, int a1, int a2, bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000083C4 File Offset: 0x000065C4
		internal static void Lua_System_Action_3_int_int_int(LuaFunction ld, int a1, int a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008408 File Offset: 0x00006608
		internal static void Lua_System_Action_3_int_int_List_BlackJack_ProjectL_Common_CommonBattleProperty_(LuaFunction ld, int a1, int a2, List<CommonBattleProperty> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000844C File Offset: 0x0000664C
		internal static void Lua_System_Action_3_int_int_System_Action(LuaFunction ld, int a1, int a2, Action a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008490 File Offset: 0x00006690
		internal static void Lua_System_Action_3_int_int_System_Action_List_BlackJack_ConfigData_Goods__(LuaFunction ld, int a1, int a2, Action<List<Goods>> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000084D4 File Offset: 0x000066D4
		internal static void Lua_System_Action_3_int_List_BlackJack_ProjectL_Protocol_ProBattleHero__int(LuaFunction ld, int a1, List<ProBattleHero> a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008518 File Offset: 0x00006718
		internal static void Lua_System_Action_3_int_List_System_Int32__bool(LuaFunction ld, int a1, List<int> a2, bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000855C File Offset: 0x0000675C
		internal static void Lua_System_Action_3_int_string_BlackJack_ProjectL_Common_OrderReward(LuaFunction ld, int a1, string a2, OrderReward a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000085A0 File Offset: 0x000067A0
		internal static void Lua_System_Action_3_int_string_string(LuaFunction ld, int a1, string a2, string a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000085E4 File Offset: 0x000067E4
		internal static void Lua_System_Action_3_int_System_UInt64_BlackJack_ProjectL_UI_BagListUIController_DisplayType(LuaFunction ld, int a1, ulong a2, BagListUIController.DisplayType a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000862C File Offset: 0x0000682C
		internal static void Lua_System_Action_3_int_System_UInt64_int(LuaFunction ld, int a1, ulong a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008670 File Offset: 0x00006870
		internal static void Lua_System_Action_3_string_bool_System_Action(LuaFunction ld, string a1, bool a2, Action a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000086B4 File Offset: 0x000068B4
		internal static void Lua_System_Action_3_string_int_int(LuaFunction ld, string a1, int a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000086F8 File Offset: 0x000068F8
		internal static void Lua_System_Action_3_string_UnityEngine_Vector3_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask_PostionType(LuaFunction ld, string a1, Vector3 a2, PlayerSimpleInfoUITask.PostionType a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008740 File Offset: 0x00006940
		internal static void Lua_System_Action_3_System_UInt64_int_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController(LuaFunction ld, ulong a1, int a2, ActivityRewardUIController a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008784 File Offset: 0x00006984
		internal static void Lua_System_Action_3_System_UInt64_int_BlackJack_ProjectL_UI_EquipmentForgeUIController_ForgeState(LuaFunction ld, ulong a1, int a2, EquipmentForgeUIController.ForgeState a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000087CC File Offset: 0x000069CC
		internal static void Lua_System_Action_3_System_UInt64_int_List_BlackJack_ConfigData_Goods_(LuaFunction ld, ulong a1, int a2, List<Goods> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00008810 File Offset: 0x00006A10
		internal static void Lua_System_Action_3_System_UInt64_int_System_Action(LuaFunction ld, ulong a1, int a2, Action a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008854 File Offset: 0x00006A54
		internal static void Lua_System_Action_3_System_UInt64_System_UInt64_System_Action_System_Int32_List_BlackJack_ProjectL_Common_CommonBattleProperty__(LuaFunction ld, ulong a1, ulong a2, Action<int, List<CommonBattleProperty>> a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00008898 File Offset: 0x00006A98
		internal static void Lua_System_Action_4_BlackJack_ConfigData_GoodsType_int_int_BlackJack_ProjectL_UI_BagListUIController_DisplayType(LuaFunction ld, GoodsType a1, int a2, int a3, BagListUIController.DisplayType a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000088EC File Offset: 0x00006AEC
		internal static void Lua_System_Action_4_BlackJack_ConfigData_GoodsType_int_int_System_Action_List_BlackJack_ConfigData_Goods__(LuaFunction ld, GoodsType a1, int a2, int a3, Action<List<Goods>> a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000893C File Offset: 0x00006B3C
		internal static void Lua_System_Action_4_BlackJack_ConfigData_StoreId_int_int_List_BlackJack_ConfigData_Goods_(LuaFunction ld, StoreId a1, int a2, int a3, List<Goods> a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000898C File Offset: 0x00006B8C
		internal static void Lua_System_Action_4_bool_int_string_System_Action(LuaFunction ld, bool a1, int a2, string a3, Action a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000089D8 File Offset: 0x00006BD8
		internal static void Lua_System_Action_4_bool_int_System_UInt32_bool(LuaFunction ld, bool a1, int a2, uint a3, bool a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008A24 File Offset: 0x00006C24
		internal static void Lua_System_Action_4_int_BlackJack_ProjectL_Common_BagItemBase_int_System_Action(LuaFunction ld, int a1, BagItemBase a2, int a3, Action a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008A70 File Offset: 0x00006C70
		internal static void Lua_System_Action_4_int_BlackJack_ProjectL_Protocol_ProArenaOpponent_List_BlackJack_ProjectL_Protocol_ProBattleHero__int(LuaFunction ld, int a1, ProArenaOpponent a2, List<ProBattleHero> a3, int a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008ABC File Offset: 0x00006CBC
		internal static void Lua_System_Action_4_int_bool_bool_int(LuaFunction ld, int a1, bool a2, bool a3, int a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008B08 File Offset: 0x00006D08
		internal static void Lua_System_Action_4_int_List_System_Int32__int_int(LuaFunction ld, int a1, List<int> a2, int a3, int a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008B54 File Offset: 0x00006D54
		internal static void Lua_System_Action_4_System_UInt64_List_System_UInt64__System_Action_int(LuaFunction ld, ulong a1, List<ulong> a2, Action a3, int a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008BA0 File Offset: 0x00006DA0
		internal static void Lua_System_Action_4_System_UInt64_System_UInt64_System_Action_int(LuaFunction ld, ulong a1, ulong a2, Action a3, int a4)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			LuaObject.pushValue(l, a4);
			ld.pcall(4, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008BEC File Offset: 0x00006DEC
		internal static int Lua_System_Comparison_1_int(LuaFunction ld, int a1, int a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008C34 File Offset: 0x00006E34
		internal static int Lua_System_Comparison_1_string(LuaFunction ld, string a1, string a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008C7C File Offset: 0x00006E7C
		internal static ResourceManager Lua_System_Func_1_BlackJack_BJFramework_Runtime_Resource_ResourceManager(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			ResourceManager result;
			LuaObject.checkType<ResourceManager>(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008CB8 File Offset: 0x00006EB8
		internal static int Lua_System_Func_1_int(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			int result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008CF4 File Offset: 0x00006EF4
		internal static string Lua_System_Func_1_string(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			string result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008D30 File Offset: 0x00006F30
		internal static IEnumerator Lua_System_Func_1_System_Collections_IEnumerator(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			IEnumerator result;
			LuaObject.checkType<IEnumerator>(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008D6C File Offset: 0x00006F6C
		internal static bool Lua_System_Func_2_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase_bool(LuaFunction ld, SceneLayerBase a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008DB0 File Offset: 0x00006FB0
		internal static bool Lua_System_Func_2_BlackJack_BJFramework_Runtime_UI_UIManager_UIProcessQueueItem_bool(LuaFunction ld, UIManager.UIProcessQueueItem a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008DF4 File Offset: 0x00006FF4
		internal static bool Lua_System_Func_2_int_bool(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008E38 File Offset: 0x00007038
		internal static bool Lua_System_Func_4_int_string_bool_bool(LuaFunction ld, int a1, string a2, bool a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008E88 File Offset: 0x00007088
		internal static object Lua_System_Func_4_System_IO_Stream_System_Type_int_System_Object(LuaFunction ld, Stream a1, Type a2, int a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			object result;
			LuaObject.checkType<object>(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008ED8 File Offset: 0x000070D8
		internal static bool Lua_System_Predicate_1_BlackJack_ProjectL_Common_Announcement(LuaFunction ld, Announcement a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00008F1C File Offset: 0x0000711C
		internal static bool Lua_System_Predicate_1_int(LuaFunction ld, int a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008F60 File Offset: 0x00007160
		internal static bool Lua_System_Predicate_1_string(LuaFunction ld, string a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008FA4 File Offset: 0x000071A4
		internal static void Lua_UnityEngine_Application_AdvertisingIdentifierCallback(LuaFunction ld, string a1, bool a2, string a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00008FE8 File Offset: 0x000071E8
		internal static void Lua_UnityEngine_Application_LogCallback(LuaFunction ld, string a1, string a2, LogType a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009030 File Offset: 0x00007230
		internal static void Lua_UnityEngine_Application_LowMemoryCallback(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009060 File Offset: 0x00007260
		internal static void Lua_UnityEngine_Camera_CameraCallback(LuaFunction ld, Camera a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009094 File Offset: 0x00007294
		internal static void Lua_UnityEngine_Canvas_WillRenderCanvases(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000090C4 File Offset: 0x000072C4
		internal static void Lua_UnityEngine_CullingGroup_StateChanged(LuaFunction ld, CullingGroupEvent a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009100 File Offset: 0x00007300
		internal static void Lua_UnityEngine_Display_DisplaysUpdatedDelegate(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009130 File Offset: 0x00007330
		internal static void Lua_UnityEngine_Events_UnityAction(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009160 File Offset: 0x00007360
		internal static void Lua_UnityEngine_Font_FontTextureRebuildCallback(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009190 File Offset: 0x00007390
		internal static void Lua_UnityEngine_RectTransform_ReapplyDrivenProperties(LuaFunction ld, RectTransform a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000091C4 File Offset: 0x000073C4
		internal static void Lua_UnityEngine_U2D_SpriteAtlasManager_RequestAtlasCallback(LuaFunction ld, string a1, Action<SpriteAtlas> a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009200 File Offset: 0x00007400
		internal static char Lua_UnityEngine_UI_InputField_OnValidateInput(LuaFunction ld, string a1, int a2, char a3)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			LuaObject.pushValue(l, a3);
			ld.pcall(3, num);
			char result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009250 File Offset: 0x00007450
		internal static bool Lua_System_Func_1_bool(LuaFunction ld)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			ld.pcall(0, num);
			bool result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000928C File Offset: 0x0000748C
		internal static float Lua_System_Func_2_UnityEngine_UI_ILayoutElement_float(LuaFunction ld, ILayoutElement a1)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			ld.pcall(1, num);
			float result;
			LuaObject.checkType(l, num + 1, out result);
			LuaDLL.lua_settop(l, num - 1);
			return result;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000092D0 File Offset: 0x000074D0
		internal static void Lua_UnityEngine_EventSystems_ExecuteEvents_EventFunction_1_UnityEngine_EventSystems_IEventSystemHandler(LuaFunction ld, IEventSystemHandler a1, BaseEventData a2)
		{
			IntPtr l = ld.L;
			int num = LuaObject.pushTry(l);
			LuaObject.pushValue(l, a1);
			LuaObject.pushValue(l, a2);
			ld.pcall(2, num);
			LuaDLL.lua_settop(l, num - 1);
		}
	}
}
