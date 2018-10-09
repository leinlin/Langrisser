using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000662 RID: 1634
	[ProtoContract(Name = "ProOperationalActivityBasicInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProOperationalActivityBasicInfo : IExtensible
	{
		// Token: 0x0600594F RID: 22863 RVA: 0x0019CF60 File Offset: 0x0019B160
		public ProOperationalActivityBasicInfo()
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

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x0019CFC8 File Offset: 0x0019B1C8
		// (set) Token: 0x06005951 RID: 22865 RVA: 0x0019CFD0 File Offset: 0x0019B1D0
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06005952 RID: 22866 RVA: 0x0019CFDC File Offset: 0x0019B1DC
		// (set) Token: 0x06005953 RID: 22867 RVA: 0x0019CFE4 File Offset: 0x0019B1E4
		[ProtoMember(2, IsRequired = true, Name = "ActivityId", DataFormat = DataFormat.TwosComplement)]
		public int ActivityId
		{
			get
			{
				return this._ActivityId;
			}
			set
			{
				this._ActivityId = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x0019CFF0 File Offset: 0x0019B1F0
		// (set) Token: 0x06005955 RID: 22869 RVA: 0x0019CFF8 File Offset: 0x0019B1F8
		[ProtoMember(3, IsRequired = true, Name = "OperationStartTime", DataFormat = DataFormat.TwosComplement)]
		public long OperationStartTime
		{
			get
			{
				return this._OperationStartTime;
			}
			set
			{
				this._OperationStartTime = value;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x0019D004 File Offset: 0x0019B204
		// (set) Token: 0x06005957 RID: 22871 RVA: 0x0019D00C File Offset: 0x0019B20C
		[ProtoMember(4, IsRequired = true, Name = "OperationEndTime", DataFormat = DataFormat.TwosComplement)]
		public long OperationEndTime
		{
			get
			{
				return this._OperationEndTime;
			}
			set
			{
				this._OperationEndTime = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06005958 RID: 22872 RVA: 0x0019D018 File Offset: 0x0019B218
		// (set) Token: 0x06005959 RID: 22873 RVA: 0x0019D020 File Offset: 0x0019B220
		[ProtoMember(5, IsRequired = true, Name = "GainRewardEndTime", DataFormat = DataFormat.TwosComplement)]
		public long GainRewardEndTime
		{
			get
			{
				return this._GainRewardEndTime;
			}
			set
			{
				this._GainRewardEndTime = value;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x0019D02C File Offset: 0x0019B22C
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x0019D034 File Offset: 0x0019B234
		[ProtoMember(6, IsRequired = false, Name = "OperationShowTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public long OperationShowTime
		{
			get
			{
				return this._OperationShowTime;
			}
			set
			{
				this._OperationShowTime = value;
			}
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x0019D040 File Offset: 0x0019B240
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x0019D050 File Offset: 0x0019B250
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

		// Token: 0x0600595E RID: 22878 RVA: 0x0019D11C File Offset: 0x0019B31C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProOperationalActivityBasicInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042F5 RID: 17141
		private ulong _InstanceId;

		// Token: 0x040042F6 RID: 17142
		private int _ActivityId;

		// Token: 0x040042F7 RID: 17143
		private long _OperationStartTime;

		// Token: 0x040042F8 RID: 17144
		private long _OperationEndTime;

		// Token: 0x040042F9 RID: 17145
		private long _GainRewardEndTime;

		// Token: 0x040042FA RID: 17146
		private long _OperationShowTime;

		// Token: 0x040042FB RID: 17147
		private IExtension extensionObject;

		// Token: 0x040042FC RID: 17148
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042FD RID: 17149
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042FE RID: 17150
		private LuaFunction m_ctor_hotfix;
	}
}
