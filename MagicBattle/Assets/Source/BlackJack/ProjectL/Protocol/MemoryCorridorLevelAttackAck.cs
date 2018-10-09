using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F2 RID: 2034
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "MemoryCorridorLevelAttackAck")]
	[Serializable]
	public class MemoryCorridorLevelAttackAck : IExtensible
	{
		// Token: 0x06006747 RID: 26439 RVA: 0x001CBF30 File Offset: 0x001CA130
		public MemoryCorridorLevelAttackAck()
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

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x001CBF98 File Offset: 0x001CA198
		// (set) Token: 0x06006749 RID: 26441 RVA: 0x001CBFA0 File Offset: 0x001CA1A0
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

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x001CBFAC File Offset: 0x001CA1AC
		// (set) Token: 0x0600674B RID: 26443 RVA: 0x001CBFB4 File Offset: 0x001CA1B4
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

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x0600674C RID: 26444 RVA: 0x001CBFC0 File Offset: 0x001CA1C0
		// (set) Token: 0x0600674D RID: 26445 RVA: 0x001CBFC8 File Offset: 0x001CA1C8
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

		// Token: 0x0600674E RID: 26446 RVA: 0x001CBFD4 File Offset: 0x001CA1D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x001CBFE4 File Offset: 0x001CA1E4
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

		// Token: 0x06006750 RID: 26448 RVA: 0x001CC0B0 File Offset: 0x001CA2B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D5E RID: 19806
		private int _Result;

		// Token: 0x04004D5F RID: 19807
		private int _LevelId;

		// Token: 0x04004D60 RID: 19808
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004D61 RID: 19809
		private IExtension extensionObject;

		// Token: 0x04004D62 RID: 19810
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D63 RID: 19811
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D64 RID: 19812
		private LuaFunction m_ctor_hotfix;
	}
}
