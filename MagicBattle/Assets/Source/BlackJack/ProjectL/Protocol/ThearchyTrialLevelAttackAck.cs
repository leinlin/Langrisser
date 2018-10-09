using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084B RID: 2123
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ThearchyTrialLevelAttackAck")]
	[Serializable]
	public class ThearchyTrialLevelAttackAck : IExtensible
	{
		// Token: 0x06006A0A RID: 27146 RVA: 0x001DD668 File Offset: 0x001DB868
		public ThearchyTrialLevelAttackAck()
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

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06006A0B RID: 27147 RVA: 0x001DD6D0 File Offset: 0x001DB8D0
		// (set) Token: 0x06006A0C RID: 27148 RVA: 0x001DD6D8 File Offset: 0x001DB8D8
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06006A0D RID: 27149 RVA: 0x001DD6E4 File Offset: 0x001DB8E4
		// (set) Token: 0x06006A0E RID: 27150 RVA: 0x001DD6EC File Offset: 0x001DB8EC
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06006A0F RID: 27151 RVA: 0x001DD6F8 File Offset: 0x001DB8F8
		// (set) Token: 0x06006A10 RID: 27152 RVA: 0x001DD700 File Offset: 0x001DB900
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

		// Token: 0x06006A11 RID: 27153 RVA: 0x001DD70C File Offset: 0x001DB90C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x001DD71C File Offset: 0x001DB91C
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

		// Token: 0x06006A13 RID: 27155 RVA: 0x001DD7E8 File Offset: 0x001DB9E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051BB RID: 20923
		private int _Result;

		// Token: 0x040051BC RID: 20924
		private int _LevelId;

		// Token: 0x040051BD RID: 20925
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x040051BE RID: 20926
		private IExtension extensionObject;

		// Token: 0x040051BF RID: 20927
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051C0 RID: 20928
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051C1 RID: 20929
		private LuaFunction m_ctor_hotfix;
	}
}
