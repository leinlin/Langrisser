using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000212 RID: 530
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleTreasureInfo")]
	[Serializable]
	public class ConfigDataBattleTreasureInfo : IExtensible
	{
		// Token: 0x06001EDB RID: 7899 RVA: 0x0009DBE0 File Offset: 0x0009BDE0
		public ConfigDataBattleTreasureInfo()
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x0009DC68 File Offset: 0x0009BE68
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0009DC70 File Offset: 0x0009BE70
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x0009DC7C File Offset: 0x0009BE7C
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0009DC84 File Offset: 0x0009BE84
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x0009DC90 File Offset: 0x0009BE90
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x0009DC98 File Offset: 0x0009BE98
		[ProtoMember(4, IsRequired = true, Name = "NameKey", DataFormat = DataFormat.Default)]
		public string NameKey
		{
			get
			{
				return this._NameKey;
			}
			set
			{
				this._NameKey = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x0009DCA4 File Offset: 0x0009BEA4
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0009DCAC File Offset: 0x0009BEAC
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x0009DCB8 File Offset: 0x0009BEB8
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x0009DCC0 File Offset: 0x0009BEC0
		[ProtoMember(6, IsRequired = true, Name = "DescKey", DataFormat = DataFormat.Default)]
		public string DescKey
		{
			get
			{
				return this._DescKey;
			}
			set
			{
				this._DescKey = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x0009DCCC File Offset: 0x0009BECC
		[ProtoMember(7, Name = "ModelPosition", DataFormat = DataFormat.Default)]
		public List<ParamPosition> ModelPosition
		{
			get
			{
				return this._ModelPosition;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x0009DCD4 File Offset: 0x0009BED4
		[ProtoMember(8, Name = "TriggerPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> TriggerPositions
		{
			get
			{
				return this._TriggerPositions;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x0009DCDC File Offset: 0x0009BEDC
		[ProtoMember(9, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0009DCE4 File Offset: 0x0009BEE4
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0009DCEC File Offset: 0x0009BEEC
		[ProtoMember(10, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0009DCF8 File Offset: 0x0009BEF8
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x0009DD00 File Offset: 0x0009BF00
		[ProtoMember(11, IsRequired = true, Name = "ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int ModelScale
		{
			get
			{
				return this._ModelScale;
			}
			set
			{
				this._ModelScale = value;
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0009DD0C File Offset: 0x0009BF0C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0009DD1C File Offset: 0x0009BF1C
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

		// Token: 0x06001EEF RID: 7919 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleTreasureInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001296 RID: 4758
		private int _ID;

		// Token: 0x04001297 RID: 4759
		private string _Name;

		// Token: 0x04001298 RID: 4760
		private string _NameKey;

		// Token: 0x04001299 RID: 4761
		private string _Desc;

		// Token: 0x0400129A RID: 4762
		private string _DescKey;

		// Token: 0x0400129B RID: 4763
		private readonly List<ParamPosition> _ModelPosition = new List<ParamPosition>();

		// Token: 0x0400129C RID: 4764
		private readonly List<ParamPosition> _TriggerPositions = new List<ParamPosition>();

		// Token: 0x0400129D RID: 4765
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x0400129E RID: 4766
		private string _Model;

		// Token: 0x0400129F RID: 4767
		private int _ModelScale;

		// Token: 0x040012A0 RID: 4768
		private IExtension extensionObject;

		// Token: 0x040012A1 RID: 4769
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040012A2 RID: 4770
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040012A3 RID: 4771
		private LuaFunction m_ctor_hotfix;
	}
}
