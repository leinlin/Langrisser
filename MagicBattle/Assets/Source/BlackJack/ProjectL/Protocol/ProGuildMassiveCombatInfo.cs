using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B0 RID: 1712
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildMassiveCombatInfo")]
	[Serializable]
	public class ProGuildMassiveCombatInfo : IExtensible
	{
		// Token: 0x06005CC5 RID: 23749 RVA: 0x001A69DC File Offset: 0x001A4BDC
		public ProGuildMassiveCombatInfo()
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

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06005CC6 RID: 23750 RVA: 0x001A6A58 File Offset: 0x001A4C58
		// (set) Token: 0x06005CC7 RID: 23751 RVA: 0x001A6A60 File Offset: 0x001A4C60
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

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06005CC8 RID: 23752 RVA: 0x001A6A6C File Offset: 0x001A4C6C
		// (set) Token: 0x06005CC9 RID: 23753 RVA: 0x001A6A74 File Offset: 0x001A4C74
		[ProtoMember(2, IsRequired = true, Name = "Difficulty", DataFormat = DataFormat.TwosComplement)]
		public int Difficulty
		{
			get
			{
				return this._Difficulty;
			}
			set
			{
				this._Difficulty = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06005CCA RID: 23754 RVA: 0x001A6A80 File Offset: 0x001A4C80
		[ProtoMember(3, Name = "Strongholds", DataFormat = DataFormat.Default)]
		public List<ProGuildMassiveCombatStrongholdInfo> Strongholds
		{
			get
			{
				return this._Strongholds;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x001A6A88 File Offset: 0x001A4C88
		[ProtoMember(4, Name = "Members", DataFormat = DataFormat.Default)]
		public List<ProGuildMassiveCombatMemberInfo> Members
		{
			get
			{
				return this._Members;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06005CCC RID: 23756 RVA: 0x001A6A90 File Offset: 0x001A4C90
		// (set) Token: 0x06005CCD RID: 23757 RVA: 0x001A6A98 File Offset: 0x001A4C98
		[ProtoMember(5, IsRequired = true, Name = "CreateTime", DataFormat = DataFormat.TwosComplement)]
		public long CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				this._CreateTime = value;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06005CCE RID: 23758 RVA: 0x001A6AA4 File Offset: 0x001A4CA4
		// (set) Token: 0x06005CCF RID: 23759 RVA: 0x001A6AAC File Offset: 0x001A4CAC
		[ProtoMember(6, IsRequired = true, Name = "FinishTime", DataFormat = DataFormat.TwosComplement)]
		public long FinishTime
		{
			get
			{
				return this._FinishTime;
			}
			set
			{
				this._FinishTime = value;
			}
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x001A6AB8 File Offset: 0x001A4CB8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x001A6AC8 File Offset: 0x001A4CC8
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

		// Token: 0x06005CD2 RID: 23762 RVA: 0x001A6B94 File Offset: 0x001A4D94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMassiveCombatInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004563 RID: 17763
		private ulong _InstanceId;

		// Token: 0x04004564 RID: 17764
		private int _Difficulty;

		// Token: 0x04004565 RID: 17765
		private readonly List<ProGuildMassiveCombatStrongholdInfo> _Strongholds = new List<ProGuildMassiveCombatStrongholdInfo>();

		// Token: 0x04004566 RID: 17766
		private readonly List<ProGuildMassiveCombatMemberInfo> _Members = new List<ProGuildMassiveCombatMemberInfo>();

		// Token: 0x04004567 RID: 17767
		private long _CreateTime;

		// Token: 0x04004568 RID: 17768
		private long _FinishTime;

		// Token: 0x04004569 RID: 17769
		private IExtension extensionObject;

		// Token: 0x0400456A RID: 17770
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400456B RID: 17771
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400456C RID: 17772
		private LuaFunction m_ctor_hotfix;
	}
}
