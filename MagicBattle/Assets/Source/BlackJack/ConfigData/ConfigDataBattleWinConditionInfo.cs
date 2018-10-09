using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000213 RID: 531
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataBattleWinConditionInfo")]
	[Serializable]
	public class ConfigDataBattleWinConditionInfo : IExtensible
	{
		// Token: 0x06001EF0 RID: 7920 RVA: 0x0009DE50 File Offset: 0x0009C050
		public ConfigDataBattleWinConditionInfo()
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

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0009DED8 File Offset: 0x0009C0D8
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0009DEE0 File Offset: 0x0009C0E0
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

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0009DEEC File Offset: 0x0009C0EC
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0009DEF4 File Offset: 0x0009C0F4
		[ProtoMember(3, IsRequired = true, Name = "WinConditionType", DataFormat = DataFormat.TwosComplement)]
		public BattleWinConditionType WinConditionType
		{
			get
			{
				return this._WinConditionType;
			}
			set
			{
				this._WinConditionType = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x0009DF00 File Offset: 0x0009C100
		[ProtoMember(4, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param1
		{
			get
			{
				return this._Param1;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0009DF08 File Offset: 0x0009C108
		[ProtoMember(5, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param2
		{
			get
			{
				return this._Param2;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0009DF10 File Offset: 0x0009C110
		[ProtoMember(6, Name = "Param3", DataFormat = DataFormat.Default)]
		public List<ParamPosition> Param3
		{
			get
			{
				return this._Param3;
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0009DF18 File Offset: 0x0009C118
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0009DF28 File Offset: 0x0009C128
		public int Param1FirstValue()
		{
			if (this.Param1.Count > 0)
			{
				return this.Param1[0];
			}
			return 0;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0009DF4C File Offset: 0x0009C14C
		public int Param2FirstValue()
		{
			if (this.Param2.Count > 0)
			{
				return this.Param2[0];
			}
			return 0;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0009DF70 File Offset: 0x0009C170
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

		// Token: 0x06001EFC RID: 7932 RVA: 0x0009E03C File Offset: 0x0009C23C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleWinConditionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040012A4 RID: 4772
		private int _ID;

		// Token: 0x040012A5 RID: 4773
		private BattleWinConditionType _WinConditionType;

		// Token: 0x040012A6 RID: 4774
		private readonly List<int> _Param1 = new List<int>();

		// Token: 0x040012A7 RID: 4775
		private readonly List<int> _Param2 = new List<int>();

		// Token: 0x040012A8 RID: 4776
		private readonly List<ParamPosition> _Param3 = new List<ParamPosition>();

		// Token: 0x040012A9 RID: 4777
		private IExtension extensionObject;

		// Token: 0x040012AA RID: 4778
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040012AB RID: 4779
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040012AC RID: 4780
		private LuaFunction m_ctor_hotfix;
	}
}
