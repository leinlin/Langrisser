using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079A RID: 1946
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroDungeonLevelAttackAck")]
	[Serializable]
	public class HeroDungeonLevelAttackAck : IExtensible
	{
		// Token: 0x06006424 RID: 25636 RVA: 0x001C19A8 File Offset: 0x001BFBA8
		public HeroDungeonLevelAttackAck()
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

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x001C1A10 File Offset: 0x001BFC10
		// (set) Token: 0x06006426 RID: 25638 RVA: 0x001C1A18 File Offset: 0x001BFC18
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06006427 RID: 25639 RVA: 0x001C1A24 File Offset: 0x001BFC24
		// (set) Token: 0x06006428 RID: 25640 RVA: 0x001C1A2C File Offset: 0x001BFC2C
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

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x001C1A38 File Offset: 0x001BFC38
		// (set) Token: 0x0600642A RID: 25642 RVA: 0x001C1A40 File Offset: 0x001BFC40
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

		// Token: 0x0600642B RID: 25643 RVA: 0x001C1A4C File Offset: 0x001BFC4C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x001C1A5C File Offset: 0x001BFC5C
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

		// Token: 0x0600642D RID: 25645 RVA: 0x001C1B28 File Offset: 0x001BFD28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B12 RID: 19218
		private int _Result;

		// Token: 0x04004B13 RID: 19219
		private int _LevelId;

		// Token: 0x04004B14 RID: 19220
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004B15 RID: 19221
		private IExtension extensionObject;

		// Token: 0x04004B16 RID: 19222
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B17 RID: 19223
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B18 RID: 19224
		private LuaFunction m_ctor_hotfix;
	}
}
