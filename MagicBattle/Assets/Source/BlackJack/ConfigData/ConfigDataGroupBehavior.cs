using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023A RID: 570
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGroupBehavior")]
	[Serializable]
	public class ConfigDataGroupBehavior : IExtensible
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x000A4A40 File Offset: 0x000A2C40
		public ConfigDataGroupBehavior()
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x000A4ABC File Offset: 0x000A2CBC
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000A4AC8 File Offset: 0x000A2CC8
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x000A4AD0 File Offset: 0x000A2CD0
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

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000A4ADC File Offset: 0x000A2CDC
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x000A4AE4 File Offset: 0x000A2CE4
		[ProtoMember(4, IsRequired = true, Name = "SelectLeaderCondition", DataFormat = DataFormat.TwosComplement)]
		public BehaviorCondition SelectLeaderCondition
		{
			get
			{
				return this._SelectLeaderCondition;
			}
			set
			{
				this._SelectLeaderCondition = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000A4AF0 File Offset: 0x000A2CF0
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x000A4AF8 File Offset: 0x000A2CF8
		[ProtoMember(5, IsRequired = true, Name = "SLCParam", DataFormat = DataFormat.Default)]
		public string SLCParam
		{
			get
			{
				return this._SLCParam;
			}
			set
			{
				this._SLCParam = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000A4B04 File Offset: 0x000A2D04
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x000A4B0C File Offset: 0x000A2D0C
		[ProtoMember(6, IsRequired = true, Name = "LeaderBehavior", DataFormat = DataFormat.TwosComplement)]
		public int LeaderBehavior
		{
			get
			{
				return this._LeaderBehavior;
			}
			set
			{
				this._LeaderBehavior = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000A4B18 File Offset: 0x000A2D18
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x000A4B20 File Offset: 0x000A2D20
		[ProtoMember(7, IsRequired = true, Name = "MemberBehavior", DataFormat = DataFormat.TwosComplement)]
		public int MemberBehavior
		{
			get
			{
				return this._MemberBehavior;
			}
			set
			{
				this._MemberBehavior = value;
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000A4B2C File Offset: 0x000A2D2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000A4B3C File Offset: 0x000A2D3C
		public bool Initialize()
		{
			this.SLCParamData = ConfigDataBehavior.InitParamData(this.SelectLeaderCondition, this.SLCParam);
			if (this.SLCParamData == null)
			{
				DebugUtility.LogError(string.Format("Failed to parse SelectLeaderCondition {0} 's param {1} of GroupBehavior {2}", this.SelectLeaderCondition, this.SLCParam, this.ID));
				return false;
			}
			return true;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x000A4B9C File Offset: 0x000A2D9C
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

		// Token: 0x06002334 RID: 9012 RVA: 0x000A4C68 File Offset: 0x000A2E68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGroupBehavior));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001544 RID: 5444
		private int _ID;

		// Token: 0x04001545 RID: 5445
		private string _Desc;

		// Token: 0x04001546 RID: 5446
		private BehaviorCondition _SelectLeaderCondition;

		// Token: 0x04001547 RID: 5447
		private string _SLCParam;

		// Token: 0x04001548 RID: 5448
		private int _LeaderBehavior;

		// Token: 0x04001549 RID: 5449
		private int _MemberBehavior;

		// Token: 0x0400154A RID: 5450
		private IExtension extensionObject;

		// Token: 0x0400154B RID: 5451
		public ConfigDataBehavior.ParamData SLCParamData = new ConfigDataBehavior.ParamData();

		// Token: 0x0400154C RID: 5452
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400154D RID: 5453
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400154E RID: 5454
		private LuaFunction m_ctor_hotfix;
	}
}
