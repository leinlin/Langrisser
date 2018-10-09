using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000216 RID: 534
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBehaviorChangeRule")]
	[Serializable]
	public class ConfigDataBehaviorChangeRule : IExtensible
	{
		// Token: 0x06001F25 RID: 7973 RVA: 0x0009E88C File Offset: 0x0009CA8C
		public ConfigDataBehaviorChangeRule()
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0009E900 File Offset: 0x0009CB00
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0009E908 File Offset: 0x0009CB08
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0009E914 File Offset: 0x0009CB14
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0009E91C File Offset: 0x0009CB1C
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

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0009E928 File Offset: 0x0009CB28
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0009E930 File Offset: 0x0009CB30
		[ProtoMember(4, IsRequired = true, Name = "ChangeCondition", DataFormat = DataFormat.TwosComplement)]
		public BehaviorCondition ChangeCondition
		{
			get
			{
				return this._ChangeCondition;
			}
			set
			{
				this._ChangeCondition = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0009E93C File Offset: 0x0009CB3C
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0009E944 File Offset: 0x0009CB44
		[ProtoMember(5, IsRequired = true, Name = "CCParam", DataFormat = DataFormat.Default)]
		public string CCParam
		{
			get
			{
				return this._CCParam;
			}
			set
			{
				this._CCParam = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x0009E950 File Offset: 0x0009CB50
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0009E958 File Offset: 0x0009CB58
		[ProtoMember(6, IsRequired = true, Name = "NextBehaviorID", DataFormat = DataFormat.TwosComplement)]
		public int NextBehaviorID
		{
			get
			{
				return this._NextBehaviorID;
			}
			set
			{
				this._NextBehaviorID = value;
			}
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0009E964 File Offset: 0x0009CB64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x0009E974 File Offset: 0x0009CB74
		public bool Initialize()
		{
			this.CCParamData = ConfigDataBehavior.InitParamData(this.ChangeCondition, this.CCParam);
			if (this.CCParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse ChangeCondition {0} 's param {1} of Behavior {2}", this.ChangeCondition, this.CCParam, this.ID));
				return false;
			}
			return true;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0009E9D4 File Offset: 0x0009CBD4
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

		// Token: 0x06001F33 RID: 7987 RVA: 0x0009EAA0 File Offset: 0x0009CCA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBehaviorChangeRule));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040012CB RID: 4811
		private int _ID;

		// Token: 0x040012CC RID: 4812
		private string _Desc;

		// Token: 0x040012CD RID: 4813
		private BehaviorCondition _ChangeCondition;

		// Token: 0x040012CE RID: 4814
		private string _CCParam;

		// Token: 0x040012CF RID: 4815
		private int _NextBehaviorID;

		// Token: 0x040012D0 RID: 4816
		private IExtension extensionObject;

		// Token: 0x040012D1 RID: 4817
		public ConfigDataBehavior.ParamData CCParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x040012D2 RID: 4818
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040012D3 RID: 4819
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040012D4 RID: 4820
		private LuaFunction m_ctor_hotfix;
	}
}
