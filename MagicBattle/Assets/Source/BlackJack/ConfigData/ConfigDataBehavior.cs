using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000214 RID: 532
	[ProtoContract(Name = "ConfigDataBehavior")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBehavior : IExtensible
	{
		// Token: 0x06001EFD RID: 7933 RVA: 0x0009E0A4 File Offset: 0x0009C2A4
		public ConfigDataBehavior()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0009E158 File Offset: 0x0009C358
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0009E160 File Offset: 0x0009C360
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0009E16C File Offset: 0x0009C36C
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0009E174 File Offset: 0x0009C374
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0009E180 File Offset: 0x0009C380
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0009E188 File Offset: 0x0009C388
		[ProtoMember(4, IsRequired = true, Name = "MoveTarget", DataFormat = DataFormat.TwosComplement)]
		public SelectTarget MoveTarget
		{
			get
			{
				return this._MoveTarget;
			}
			set
			{
				this._MoveTarget = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0009E194 File Offset: 0x0009C394
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0009E19C File Offset: 0x0009C39C
		[ProtoMember(5, IsRequired = true, Name = "MTParam", DataFormat = DataFormat.Default)]
		public string MTParam
		{
			get
			{
				return this._MTParam;
			}
			set
			{
				this._MTParam = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0009E1A8 File Offset: 0x0009C3A8
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0009E1B0 File Offset: 0x0009C3B0
		[ProtoMember(6, IsRequired = true, Name = "StartAttackCondition", DataFormat = DataFormat.TwosComplement)]
		public BehaviorCondition StartAttackCondition
		{
			get
			{
				return this._StartAttackCondition;
			}
			set
			{
				this._StartAttackCondition = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0009E1BC File Offset: 0x0009C3BC
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0009E1C4 File Offset: 0x0009C3C4
		[ProtoMember(7, IsRequired = true, Name = "StartACParam", DataFormat = DataFormat.Default)]
		public string StartACParam
		{
			get
			{
				return this._StartACParam;
			}
			set
			{
				this._StartACParam = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		[ProtoMember(8, IsRequired = true, Name = "SelectAttackTarget", DataFormat = DataFormat.TwosComplement)]
		public SelectTarget SelectAttackTarget
		{
			get
			{
				return this._SelectAttackTarget;
			}
			set
			{
				this._SelectAttackTarget = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0009E1E4 File Offset: 0x0009C3E4
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0009E1EC File Offset: 0x0009C3EC
		[ProtoMember(9, IsRequired = true, Name = "SATParam", DataFormat = DataFormat.Default)]
		public string SATParam
		{
			get
			{
				return this._SATParam;
			}
			set
			{
				this._SATParam = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x0009E1F8 File Offset: 0x0009C3F8
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0009E200 File Offset: 0x0009C400
		[ProtoMember(10, IsRequired = true, Name = "ReselectAttackTargetCondition", DataFormat = DataFormat.TwosComplement)]
		public BehaviorCondition ReselectAttackTargetCondition
		{
			get
			{
				return this._ReselectAttackTargetCondition;
			}
			set
			{
				this._ReselectAttackTargetCondition = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0009E20C File Offset: 0x0009C40C
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x0009E214 File Offset: 0x0009C414
		[ProtoMember(11, IsRequired = true, Name = "RATCParam", DataFormat = DataFormat.Default)]
		public string RATCParam
		{
			get
			{
				return this._RATCParam;
			}
			set
			{
				this._RATCParam = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0009E220 File Offset: 0x0009C420
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x0009E228 File Offset: 0x0009C428
		[ProtoMember(12, IsRequired = true, Name = "SelectSkill", DataFormat = DataFormat.TwosComplement)]
		public SelectSkill SelectSkill
		{
			get
			{
				return this._SelectSkill;
			}
			set
			{
				this._SelectSkill = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x0009E234 File Offset: 0x0009C434
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x0009E23C File Offset: 0x0009C43C
		[ProtoMember(13, IsRequired = true, Name = "SSParam", DataFormat = DataFormat.Default)]
		public string SSParam
		{
			get
			{
				return this._SSParam;
			}
			set
			{
				this._SSParam = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0009E248 File Offset: 0x0009C448
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0009E250 File Offset: 0x0009C450
		[ProtoMember(14, IsRequired = true, Name = "StopAttackCondition", DataFormat = DataFormat.TwosComplement)]
		public BehaviorCondition StopAttackCondition
		{
			get
			{
				return this._StopAttackCondition;
			}
			set
			{
				this._StopAttackCondition = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0009E25C File Offset: 0x0009C45C
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0009E264 File Offset: 0x0009C464
		[ProtoMember(15, IsRequired = true, Name = "StopACParam", DataFormat = DataFormat.Default)]
		public string StopACParam
		{
			get
			{
				return this._StopACParam;
			}
			set
			{
				this._StopACParam = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0009E270 File Offset: 0x0009C470
		[ProtoMember(16, Name = "BehaviorChangeRules", DataFormat = DataFormat.TwosComplement)]
		public List<int> BehaviorChangeRules
		{
			get
			{
				return this._BehaviorChangeRules;
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0009E278 File Offset: 0x0009C478
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0009E288 File Offset: 0x0009C488
		public static ConfigDataBehavior.ParamData InitParamData(BehaviorCondition c, string param)
		{
			ConfigDataBehavior.ParamData paramData = new ConfigDataBehavior.ParamData();
			if (c == BehaviorCondition.BehaviorCondition_EnemyHPPercentLessEqual || c == BehaviorCondition.BehaviorCondition_DistanceToMoveTargetLestEqual || c == BehaviorCondition.BehaviorCondition_SelfHPPercentLessEqual || c == BehaviorCondition.BehaviorCondition_SelfHPPercentGreaterEqual)
			{
				if (!float.TryParse(param, out paramData._float))
				{
					return null;
				}
			}
			else if (c == BehaviorCondition.BehaviorCondition_TurnN || c == BehaviorCondition.BehaviorCondition_DoingBehaviorN || c == BehaviorCondition.BehaviorCondition_FoundEnemyWithBuffN || c == BehaviorCondition.BehaviorCondition_NoEnemyWithBuffN || c == BehaviorCondition.BehaviorCondition_HeroNExist || c == BehaviorCondition.BehaviorCondition_MemberAttackedByEnemy)
			{
				if (!int.TryParse(param, out paramData._int))
				{
					return null;
				}
			}
			else if (c == BehaviorCondition.BehaviorCondition_MemberHPPercentLessEqual)
			{
				string[] array = param.Split(new char[]
				{
					','
				});
				if (array.Length != 2)
				{
					return null;
				}
				if (!int.TryParse(array[0], out paramData._int))
				{
					return null;
				}
				if (!float.TryParse(array[1], out paramData._float))
				{
					return null;
				}
			}
			else if (c == BehaviorCondition.BehaviorCondition_EnemyEnterMoveAndAttackRangeExcept || c == BehaviorCondition.BehaviorCondition_NoEnemyEnterMoveAndAttackRangeExcept)
			{
				ConfigDataBehavior.TryParseIntArray(param, out paramData._ints);
			}
			return paramData;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0009E38C File Offset: 0x0009C58C
		[DoNotToLua]
		private static bool TryParsePositionList(string param, out List<GridPosition> positions)
		{
			positions = null;
			if (string.IsNullOrEmpty(param))
			{
				return false;
			}
			string[] array = param.Split(new char[]
			{
				'/'
			});
			if (array == null || array.Length == 0)
			{
				return false;
			}
			positions = new List<GridPosition>();
			foreach (string str in array)
			{
				GridPosition item;
				if (!GridPosition.TryParse(str, out item))
				{
					return false;
				}
				positions.Add(item);
			}
			return true;
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0009E408 File Offset: 0x0009C608
		public static ConfigDataBehavior.ParamData InitParamData(SelectTarget t, string param)
		{
			ConfigDataBehavior.ParamData paramData = new ConfigDataBehavior.ParamData();
			if (t == SelectTarget.SelectTarget_PositionNearest)
			{
				if (!ConfigDataBehavior.TryParsePositionList(param, out paramData._GridPositions))
				{
					return null;
				}
			}
			else if (t == SelectTarget.SelectTarget_MemberHeroID || t == SelectTarget.SelectTarget_MemberIndex || t == SelectTarget.SelectTarget_EnemyWithBuffN)
			{
				if (!int.TryParse(param, out paramData._int))
				{
					return null;
				}
			}
			else if (t == SelectTarget.SelectTarget_EnemyIDFilter)
			{
				string[] array = param.Split(new char[]
				{
					'/'
				});
				if (array == null || array.Length == 0)
				{
					return null;
				}
				if (array.Length > 0)
				{
					ConfigDataBehavior.TryParseIntArray(array[0], out paramData._ints);
				}
				if (array.Length > 1)
				{
					ConfigDataBehavior.TryParseIntArray(array[1], out paramData._ints2);
				}
			}
			return paramData;
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0009E4C4 File Offset: 0x0009C6C4
		public static bool TryParseIntArray(string s, out int[] ret)
		{
			ret = null;
			string[] array = s.Split(new char[]
			{
				','
			});
			if (array == null || array.Length == 0)
			{
				return false;
			}
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (!int.TryParse(array[i], out array2[i]))
				{
					return false;
				}
			}
			ret = array2;
			return true;
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0009E530 File Offset: 0x0009C730
		public static ConfigDataBehavior.ParamData InitParamData(SelectSkill s, string param)
		{
			ConfigDataBehavior.ParamData paramData = new ConfigDataBehavior.ParamData();
			if ((s == SelectSkill.SelectSkill_ExcludeSkillID || s == SelectSkill.SelectSkill_IncludeSkillID) && !ConfigDataBehavior.TryParseIntArray(param, out paramData._ints))
			{
				return null;
			}
			return paramData;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0009E568 File Offset: 0x0009C768
		public bool Initialize()
		{
			this.SSParamData = ConfigDataBehavior.InitParamData(this.SelectSkill, this.SSParam);
			if (this.SSParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse SelectSkill {0} 's param {1} of Behavior {2}", this.SelectSkill, this.SSParam, this.ID));
				return false;
			}
			this.SATParamData = ConfigDataBehavior.InitParamData(this.SelectAttackTarget, this.SATParam);
			if (this.SATParam == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse SelectAttackTarget {0} 's param {1} of Behavior {2}", this.SelectAttackTarget, this.SATParam, this.ID));
				return false;
			}
			this.RATCParamData = ConfigDataBehavior.InitParamData(this.ReselectAttackTargetCondition, this.RATCParam);
			if (this.RATCParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse ReselectAttackTargetCondition {0} 's param {1} of Behavior {2}", this.ReselectAttackTargetCondition, this.RATCParam, this.ID));
				return false;
			}
			this.MTParamData = ConfigDataBehavior.InitParamData(this.MoveTarget, this.MTParam);
			if (this.MTParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse MoveTarget {0} 's param {1} of Behavior {2}", this.MoveTarget, this.MTParam, this.ID));
				return false;
			}
			this.StartACParamData = ConfigDataBehavior.InitParamData(this.StartAttackCondition, this.StartACParam);
			if (this.StartACParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse StartAttackCondition {0} param {1} of Behavior {2}", this.StartAttackCondition, this.StartACParam, this.ID));
				return false;
			}
			this.StopACParamData = ConfigDataBehavior.InitParamData(this.StopAttackCondition, this.StopACParam);
			if (this.StopACParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse StopAttackCondition {0} param {1} of Behavior {2}", this.StopAttackCondition, this.StopACParam, this.ID));
				return false;
			}
			return true;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0009E750 File Offset: 0x0009C950
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0009E81C File Offset: 0x0009CA1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBehavior));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040012AD RID: 4781
		private int _ID;

		// Token: 0x040012AE RID: 4782
		private string _Desc;

		// Token: 0x040012AF RID: 4783
		private SelectTarget _MoveTarget;

		// Token: 0x040012B0 RID: 4784
		private string _MTParam;

		// Token: 0x040012B1 RID: 4785
		private BehaviorCondition _StartAttackCondition;

		// Token: 0x040012B2 RID: 4786
		private string _StartACParam;

		// Token: 0x040012B3 RID: 4787
		private SelectTarget _SelectAttackTarget;

		// Token: 0x040012B4 RID: 4788
		private string _SATParam;

		// Token: 0x040012B5 RID: 4789
		private BehaviorCondition _ReselectAttackTargetCondition;

		// Token: 0x040012B6 RID: 4790
		private string _RATCParam;

		// Token: 0x040012B7 RID: 4791
		private SelectSkill _SelectSkill;

		// Token: 0x040012B8 RID: 4792
		private string _SSParam;

		// Token: 0x040012B9 RID: 4793
		private BehaviorCondition _StopAttackCondition;

		// Token: 0x040012BA RID: 4794
		private string _StopACParam;

		// Token: 0x040012BB RID: 4795
		private readonly List<int> _BehaviorChangeRules = new List<int>();

		// Token: 0x040012BC RID: 4796
		private IExtension extensionObject;

		// Token: 0x040012BD RID: 4797
		public ConfigDataBehavior.ParamData RATCParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012BE RID: 4798
		public ConfigDataBehavior.ParamData MTParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012BF RID: 4799
		public ConfigDataBehavior.ParamData StartACParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012C0 RID: 4800
		public ConfigDataBehavior.ParamData StopACParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012C1 RID: 4801
		public ConfigDataBehavior.ParamData SATParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012C2 RID: 4802
		public ConfigDataBehavior.ParamData SSParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012C3 RID: 4803
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040012C4 RID: 4804
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040012C5 RID: 4805
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000215 RID: 533
		[CustomLuaClass]
		public class ParamData
		{
			// Token: 0x040012C6 RID: 4806
			public float _float;

			// Token: 0x040012C7 RID: 4807
			public int _int;

			// Token: 0x040012C8 RID: 4808
			public List<GridPosition> _GridPositions;

			// Token: 0x040012C9 RID: 4809
			public int[] _ints;

			// Token: 0x040012CA RID: 4810
			public int[] _ints2;
		}
	}
}
