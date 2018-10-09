using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020E RID: 526
	[ProtoContract(Name = "ConfigDataBattleLoseConditionInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattleLoseConditionInfo : IExtensible
	{
		// Token: 0x06001EAB RID: 7851 RVA: 0x0009D374 File Offset: 0x0009B574
		public ConfigDataBattleLoseConditionInfo()
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

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0009D3FC File Offset: 0x0009B5FC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0009D404 File Offset: 0x0009B604
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

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0009D410 File Offset: 0x0009B610
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0009D418 File Offset: 0x0009B618
		[ProtoMember(3, IsRequired = true, Name = "LoseConditionType", DataFormat = DataFormat.TwosComplement)]
		public BattleLoseConditionType LoseConditionType
		{
			get
			{
				return this._LoseConditionType;
			}
			set
			{
				this._LoseConditionType = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0009D424 File Offset: 0x0009B624
		[ProtoMember(4, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param1
		{
			get
			{
				return this._Param1;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0009D42C File Offset: 0x0009B62C
		[ProtoMember(5, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public List<int> Param2
		{
			get
			{
				return this._Param2;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0009D434 File Offset: 0x0009B634
		[ProtoMember(6, Name = "Param3", DataFormat = DataFormat.Default)]
		public List<ParamPosition> Param3
		{
			get
			{
				return this._Param3;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0009D43C File Offset: 0x0009B63C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0009D44C File Offset: 0x0009B64C
		public int Param1FirstValue()
		{
			if (this.Param1.Count > 0)
			{
				return this.Param1[0];
			}
			return 0;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0009D470 File Offset: 0x0009B670
		public int Param2FirstValue()
		{
			if (this.Param2.Count > 0)
			{
				return this.Param2[0];
			}
			return 0;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0009D494 File Offset: 0x0009B694
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

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0009D560 File Offset: 0x0009B760
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleLoseConditionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001271 RID: 4721
		private int _ID;

		// Token: 0x04001272 RID: 4722
		private BattleLoseConditionType _LoseConditionType;

		// Token: 0x04001273 RID: 4723
		private readonly List<int> _Param1 = new List<int>();

		// Token: 0x04001274 RID: 4724
		private readonly List<int> _Param2 = new List<int>();

		// Token: 0x04001275 RID: 4725
		private readonly List<ParamPosition> _Param3 = new List<ParamPosition>();

		// Token: 0x04001276 RID: 4726
		private IExtension extensionObject;

		// Token: 0x04001277 RID: 4727
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001278 RID: 4728
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001279 RID: 4729
		private LuaFunction m_ctor_hotfix;
	}
}
