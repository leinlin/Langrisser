using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000632 RID: 1586
	[ProtoContract(Name = "ClimbTowerLevelAttackAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ClimbTowerLevelAttackAck : IExtensible
	{
		// Token: 0x060056EF RID: 22255 RVA: 0x00196D2C File Offset: 0x00194F2C
		public ClimbTowerLevelAttackAck()
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

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x00196D94 File Offset: 0x00194F94
		// (set) Token: 0x060056F1 RID: 22257 RVA: 0x00196D9C File Offset: 0x00194F9C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x00196DA8 File Offset: 0x00194FA8
		// (set) Token: 0x060056F3 RID: 22259 RVA: 0x00196DB0 File Offset: 0x00194FB0
		[ProtoMember(2, IsRequired = true, Name = "FloorId", DataFormat = DataFormat.TwosComplement)]
		public int FloorId
		{
			get
			{
				return this._FloorId;
			}
			set
			{
				this._FloorId = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x00196DBC File Offset: 0x00194FBC
		// (set) Token: 0x060056F5 RID: 22261 RVA: 0x00196DC4 File Offset: 0x00194FC4
		[ProtoMember(3, IsRequired = true, Name = "BattleBeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BattleBeginInfo
		{
			get
			{
				return this._BattleBeginInfo;
			}
			set
			{
				this._BattleBeginInfo = value;
			}
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00196DD0 File Offset: 0x00194FD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x00196DE0 File Offset: 0x00194FE0
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

		// Token: 0x060056F8 RID: 22264 RVA: 0x00196EAC File Offset: 0x001950AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004151 RID: 16721
		private int _Result;

		// Token: 0x04004152 RID: 16722
		private int _FloorId;

		// Token: 0x04004153 RID: 16723
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004154 RID: 16724
		private IExtension extensionObject;

		// Token: 0x04004155 RID: 16725
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004156 RID: 16726
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004157 RID: 16727
		private LuaFunction m_ctor_hotfix;
	}
}
