using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020A RID: 522
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataBattleEventActionInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBattleEventActionInfo : IExtensible
	{
		// Token: 0x06001E1A RID: 7706 RVA: 0x0009C558 File Offset: 0x0009A758
		public ConfigDataBattleEventActionInfo()
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0009C624 File Offset: 0x0009A824
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0009C62C File Offset: 0x0009A82C
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0009C638 File Offset: 0x0009A838
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0009C640 File Offset: 0x0009A840
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0009C64C File Offset: 0x0009A84C
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0009C654 File Offset: 0x0009A854
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0009C660 File Offset: 0x0009A860
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0009C668 File Offset: 0x0009A868
		[ProtoMember(5, IsRequired = true, Name = "ActionType", DataFormat = DataFormat.TwosComplement)]
		public BattleEventActionType ActionType
		{
			get
			{
				return this._ActionType;
			}
			set
			{
				this._ActionType = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0009C674 File Offset: 0x0009A874
		[ProtoMember(6, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param1
		{
			get
			{
				return this._Param1;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0009C67C File Offset: 0x0009A87C
		[ProtoMember(7, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param2
		{
			get
			{
				return this._Param2;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0009C684 File Offset: 0x0009A884
		[ProtoMember(8, Name = "Param3", DataFormat = DataFormat.Default)]
		public List<ParamPosition> Param3
		{
			get
			{
				return this._Param3;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0009C68C File Offset: 0x0009A88C
		[ProtoMember(9, Name = "Param4", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param4
		{
			get
			{
				return this._Param4;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x0009C694 File Offset: 0x0009A894
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0009C69C File Offset: 0x0009A89C
		[ProtoMember(10, IsRequired = true, Name = "Param5", DataFormat = DataFormat.Default)]
		public string Param5
		{
			get
			{
				return this._Param5;
			}
			set
			{
				this._Param5 = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		[ProtoMember(11, Name = "Param6", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param6
		{
			get
			{
				return this._Param6;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0009C6B0 File Offset: 0x0009A8B0
		[ProtoMember(12, Name = "ReliefActorsBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReliefActorsBehavior
		{
			get
			{
				return this._ReliefActorsBehavior;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0009C6B8 File Offset: 0x0009A8B8
		[ProtoMember(13, Name = "ReliefGroups", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReliefGroups
		{
			get
			{
				return this._ReliefGroups;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0009C6C0 File Offset: 0x0009A8C0
		[ProtoMember(14, Name = "ReliefGroupBehavior", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReliefGroupBehavior
		{
			get
			{
				return this._ReliefGroupBehavior;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0009C6C8 File Offset: 0x0009A8C8
		[ProtoMember(15, Name = "ReliefRandomArmies_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReliefRandomArmies_ID
		{
			get
			{
				return this._ReliefRandomArmies_ID;
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0009C6D0 File Offset: 0x0009A8D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0009C6E0 File Offset: 0x0009A8E0
		public bool Initialize()
		{
			this.m_reliefGroupBehaviors = ConfigDataBattleEventActionInfo.ComputeGroupBehaviorDict(this.ReliefGroups, this.ReliefGroupBehavior);
			return true;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0009C6FC File Offset: 0x0009A8FC
		public static Dictionary<int, int> ComputeGroupBehaviorDict(List<int> groups, List<int> behaviors)
		{
			if (groups == null || groups.Count == 0 || behaviors == null || behaviors.Count == 0)
			{
				return null;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			List<int> list = new List<int>(new HashSet<int>(groups));
			list.Sort((int a, int b) => a - b);
			int num = 0;
			while (num < list.Count && num < behaviors.Count)
			{
				dictionary.Add(list[num], behaviors[num]);
				num++;
			}
			return dictionary;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0009C79C File Offset: 0x0009A99C
		public int Param1FirstValue()
		{
			if (this.Param1.Count > 0)
			{
				return this.Param1[0];
			}
			return 0;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0009C7C0 File Offset: 0x0009A9C0
		public int Param2FirstValue()
		{
			if (this.Param2.Count > 0)
			{
				return this.Param2[0];
			}
			return 0;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0009C7EC File Offset: 0x0009A9EC
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

		// Token: 0x06001E35 RID: 7733 RVA: 0x0009C8B8 File Offset: 0x0009AAB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleEventActionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001207 RID: 4615
		private int _ID;

		// Token: 0x04001208 RID: 4616
		private string _Name;

		// Token: 0x04001209 RID: 4617
		private string _NameStrKey;

		// Token: 0x0400120A RID: 4618
		private BattleEventActionType _ActionType;

		// Token: 0x0400120B RID: 4619
		private readonly List<int> _Param1 = new List<int>();

		// Token: 0x0400120C RID: 4620
		private readonly List<int> _Param2 = new List<int>();

		// Token: 0x0400120D RID: 4621
		private readonly List<ParamPosition> _Param3 = new List<ParamPosition>();

		// Token: 0x0400120E RID: 4622
		private readonly List<int> _Param4 = new List<int>();

		// Token: 0x0400120F RID: 4623
		private string _Param5;

		// Token: 0x04001210 RID: 4624
		private readonly List<int> _Param6 = new List<int>();

		// Token: 0x04001211 RID: 4625
		private readonly List<int> _ReliefActorsBehavior = new List<int>();

		// Token: 0x04001212 RID: 4626
		private readonly List<int> _ReliefGroups = new List<int>();

		// Token: 0x04001213 RID: 4627
		private readonly List<int> _ReliefGroupBehavior = new List<int>();

		// Token: 0x04001214 RID: 4628
		private readonly List<int> _ReliefRandomArmies_ID = new List<int>();

		// Token: 0x04001215 RID: 4629
		private IExtension extensionObject;

		// Token: 0x04001216 RID: 4630
		public Dictionary<int, int> m_reliefGroupBehaviors;

		// Token: 0x04001218 RID: 4632
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001219 RID: 4633
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400121A RID: 4634
		private LuaFunction m_ctor_hotfix;
	}
}
