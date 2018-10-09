using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BE RID: 1470
	[ProtoContract(Name = "ArenaVictoryPointsRewardGainReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaVictoryPointsRewardGainReq : IExtensible
	{
		// Token: 0x0600530E RID: 21262 RVA: 0x001894D0 File Offset: 0x001876D0
		public ArenaVictoryPointsRewardGainReq()
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x00189538 File Offset: 0x00187738
		// (set) Token: 0x06005310 RID: 21264 RVA: 0x00189540 File Offset: 0x00187740
		[ProtoMember(1, IsRequired = true, Name = "RewardIndex", DataFormat = DataFormat.TwosComplement)]
		public int RewardIndex
		{
			get
			{
				return this._RewardIndex;
			}
			set
			{
				this._RewardIndex = value;
			}
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x0018954C File Offset: 0x0018774C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x0018955C File Offset: 0x0018775C
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

		// Token: 0x06005313 RID: 21267 RVA: 0x00189628 File Offset: 0x00187828
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaVictoryPointsRewardGainReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E65 RID: 15973
		private int _RewardIndex;

		// Token: 0x04003E66 RID: 15974
		private IExtension extensionObject;

		// Token: 0x04003E67 RID: 15975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E68 RID: 15976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E69 RID: 15977
		private LuaFunction m_ctor_hotfix;
	}
}
