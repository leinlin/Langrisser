using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005AF RID: 1455
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AnikiGymLevelAttackAck")]
	[Serializable]
	public class AnikiGymLevelAttackAck : IExtensible
	{
		// Token: 0x06005293 RID: 21139 RVA: 0x00187918 File Offset: 0x00185B18
		public AnikiGymLevelAttackAck()
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

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x00187980 File Offset: 0x00185B80
		// (set) Token: 0x06005295 RID: 21141 RVA: 0x00187988 File Offset: 0x00185B88
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

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x00187994 File Offset: 0x00185B94
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x0018799C File Offset: 0x00185B9C
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

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06005298 RID: 21144 RVA: 0x001879A8 File Offset: 0x00185BA8
		// (set) Token: 0x06005299 RID: 21145 RVA: 0x001879B0 File Offset: 0x00185BB0
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

		// Token: 0x0600529A RID: 21146 RVA: 0x001879BC File Offset: 0x00185BBC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x001879CC File Offset: 0x00185BCC
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

		// Token: 0x0600529C RID: 21148 RVA: 0x00187A98 File Offset: 0x00185C98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E07 RID: 15879
		private int _Result;

		// Token: 0x04003E08 RID: 15880
		private int _LevelId;

		// Token: 0x04003E09 RID: 15881
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04003E0A RID: 15882
		private IExtension extensionObject;

		// Token: 0x04003E0B RID: 15883
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E0C RID: 15884
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E0D RID: 15885
		private LuaFunction m_ctor_hotfix;
	}
}
