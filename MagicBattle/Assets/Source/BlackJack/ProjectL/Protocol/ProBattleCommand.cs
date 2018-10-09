using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000648 RID: 1608
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleCommand")]
	[Serializable]
	public class ProBattleCommand : IExtensible
	{
		// Token: 0x060057E3 RID: 22499 RVA: 0x00199888 File Offset: 0x00197A88
		public ProBattleCommand()
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

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x060057E4 RID: 22500 RVA: 0x001998F0 File Offset: 0x00197AF0
		// (set) Token: 0x060057E5 RID: 22501 RVA: 0x001998F8 File Offset: 0x00197AF8
		[ProtoMember(1, IsRequired = true, Name = "CommandType", DataFormat = DataFormat.TwosComplement)]
		public int CommandType
		{
			get
			{
				return this._CommandType;
			}
			set
			{
				this._CommandType = value;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x060057E6 RID: 22502 RVA: 0x00199904 File Offset: 0x00197B04
		// (set) Token: 0x060057E7 RID: 22503 RVA: 0x0019990C File Offset: 0x00197B0C
		[ProtoMember(2, IsRequired = true, Name = "ActorId", DataFormat = DataFormat.TwosComplement)]
		public int ActorId
		{
			get
			{
				return this._ActorId;
			}
			set
			{
				this._ActorId = value;
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x060057E8 RID: 22504 RVA: 0x00199918 File Offset: 0x00197B18
		// (set) Token: 0x060057E9 RID: 22505 RVA: 0x00199920 File Offset: 0x00197B20
		[ProtoMember(3, IsRequired = true, Name = "Step", DataFormat = DataFormat.TwosComplement)]
		public int Step
		{
			get
			{
				return this._Step;
			}
			set
			{
				this._Step = value;
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x0019992C File Offset: 0x00197B2C
		// (set) Token: 0x060057EB RID: 22507 RVA: 0x00199934 File Offset: 0x00197B34
		[ProtoMember(4, IsRequired = true, Name = "TargetPosition", DataFormat = DataFormat.Default)]
		public ProBattlePosition TargetPosition
		{
			get
			{
				return this._TargetPosition;
			}
			set
			{
				this._TargetPosition = value;
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x00199940 File Offset: 0x00197B40
		// (set) Token: 0x060057ED RID: 22509 RVA: 0x00199948 File Offset: 0x00197B48
		[ProtoMember(5, IsRequired = true, Name = "TargetPosition2", DataFormat = DataFormat.Default)]
		public ProBattlePosition TargetPosition2
		{
			get
			{
				return this._TargetPosition2;
			}
			set
			{
				this._TargetPosition2 = value;
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x00199954 File Offset: 0x00197B54
		// (set) Token: 0x060057EF RID: 22511 RVA: 0x0019995C File Offset: 0x00197B5C
		[ProtoMember(6, IsRequired = true, Name = "SkillIndex", DataFormat = DataFormat.TwosComplement)]
		public int SkillIndex
		{
			get
			{
				return this._SkillIndex;
			}
			set
			{
				this._SkillIndex = value;
			}
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00199968 File Offset: 0x00197B68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x00199978 File Offset: 0x00197B78
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

		// Token: 0x060057F2 RID: 22514 RVA: 0x00199A44 File Offset: 0x00197C44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleCommand));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041FE RID: 16894
		private int _CommandType;

		// Token: 0x040041FF RID: 16895
		private int _ActorId;

		// Token: 0x04004200 RID: 16896
		private int _Step;

		// Token: 0x04004201 RID: 16897
		private ProBattlePosition _TargetPosition;

		// Token: 0x04004202 RID: 16898
		private ProBattlePosition _TargetPosition2;

		// Token: 0x04004203 RID: 16899
		private int _SkillIndex;

		// Token: 0x04004204 RID: 16900
		private IExtension extensionObject;

		// Token: 0x04004205 RID: 16901
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004206 RID: 16902
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004207 RID: 16903
		private LuaFunction m_ctor_hotfix;
	}
}
