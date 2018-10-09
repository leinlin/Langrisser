using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020F RID: 527
	[ProtoContract(Name = "ConfigDataBattlePerformInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattlePerformInfo : IExtensible
	{
		// Token: 0x06001EB8 RID: 7864 RVA: 0x0009D5C8 File Offset: 0x0009B7C8
		public ConfigDataBattlePerformInfo()
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0009D650 File Offset: 0x0009B850
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0009D658 File Offset: 0x0009B858
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0009D664 File Offset: 0x0009B864
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0009D66C File Offset: 0x0009B86C
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

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x0009D678 File Offset: 0x0009B878
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x0009D680 File Offset: 0x0009B880
		[ProtoMember(4, IsRequired = true, Name = "NextPerform_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextPerform_ID
		{
			get
			{
				return this._NextPerform_ID;
			}
			set
			{
				this._NextPerform_ID = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x0009D68C File Offset: 0x0009B88C
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x0009D694 File Offset: 0x0009B894
		[ProtoMember(5, IsRequired = true, Name = "PerformType", DataFormat = DataFormat.TwosComplement)]
		public BattlePerformType PerformType
		{
			get
			{
				return this._PerformType;
			}
			set
			{
				this._PerformType = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x0009D6A8 File Offset: 0x0009B8A8
		[ProtoMember(6, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x0009D6B4 File Offset: 0x0009B8B4
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x0009D6BC File Offset: 0x0009B8BC
		[ProtoMember(7, IsRequired = true, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public int Param2
		{
			get
			{
				return this._Param2;
			}
			set
			{
				this._Param2 = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x0009D6C8 File Offset: 0x0009B8C8
		[ProtoMember(8, Name = "Param3", DataFormat = DataFormat.Default)]
		public List<ParamPosition> Param3
		{
			get
			{
				return this._Param3;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0009D6D0 File Offset: 0x0009B8D0
		[ProtoMember(9, Name = "Param4", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param4
		{
			get
			{
				return this._Param4;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0009D6D8 File Offset: 0x0009B8D8
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x0009D6E0 File Offset: 0x0009B8E0
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0009D6EC File Offset: 0x0009B8EC
		[ProtoMember(11, Name = "Param6", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param6
		{
			get
			{
				return this._Param6;
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0009D6F4 File Offset: 0x0009B8F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0009D704 File Offset: 0x0009B904
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

		// Token: 0x06001ECC RID: 7884 RVA: 0x0009D7D0 File Offset: 0x0009B9D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattlePerformInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400127A RID: 4730
		private int _ID;

		// Token: 0x0400127B RID: 4731
		private string _Name;

		// Token: 0x0400127C RID: 4732
		private int _NextPerform_ID;

		// Token: 0x0400127D RID: 4733
		private BattlePerformType _PerformType;

		// Token: 0x0400127E RID: 4734
		private int _Param1;

		// Token: 0x0400127F RID: 4735
		private int _Param2;

		// Token: 0x04001280 RID: 4736
		private readonly List<ParamPosition> _Param3 = new List<ParamPosition>();

		// Token: 0x04001281 RID: 4737
		private readonly List<int> _Param4 = new List<int>();

		// Token: 0x04001282 RID: 4738
		private string _Param5;

		// Token: 0x04001283 RID: 4739
		private readonly List<int> _Param6 = new List<int>();

		// Token: 0x04001284 RID: 4740
		private IExtension extensionObject;

		// Token: 0x04001285 RID: 4741
		public ConfigDataBattlePerformInfo m_prevPerformInfo;

		// Token: 0x04001286 RID: 4742
		public ConfigDataBattlePerformInfo m_nextPerformInfo;

		// Token: 0x04001287 RID: 4743
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001288 RID: 4744
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001289 RID: 4745
		private LuaFunction m_ctor_hotfix;
	}
}
