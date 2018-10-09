using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D8 RID: 2008
	[ProtoContract(Name = "HeroTrainningLevelAttackAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroTrainningLevelAttackAck : IExtensible
	{
		// Token: 0x0600666A RID: 26218 RVA: 0x001C8EC8 File Offset: 0x001C70C8
		public HeroTrainningLevelAttackAck()
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

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x0600666B RID: 26219 RVA: 0x001C8F30 File Offset: 0x001C7130
		// (set) Token: 0x0600666C RID: 26220 RVA: 0x001C8F38 File Offset: 0x001C7138
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

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x0600666D RID: 26221 RVA: 0x001C8F44 File Offset: 0x001C7144
		// (set) Token: 0x0600666E RID: 26222 RVA: 0x001C8F4C File Offset: 0x001C714C
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

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x0600666F RID: 26223 RVA: 0x001C8F58 File Offset: 0x001C7158
		// (set) Token: 0x06006670 RID: 26224 RVA: 0x001C8F60 File Offset: 0x001C7160
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

		// Token: 0x06006671 RID: 26225 RVA: 0x001C8F6C File Offset: 0x001C716C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x001C8F7C File Offset: 0x001C717C
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

		// Token: 0x06006673 RID: 26227 RVA: 0x001C9048 File Offset: 0x001C7248
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CB7 RID: 19639
		private int _Result;

		// Token: 0x04004CB8 RID: 19640
		private int _LevelId;

		// Token: 0x04004CB9 RID: 19641
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004CBA RID: 19642
		private IExtension extensionObject;

		// Token: 0x04004CBB RID: 19643
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CBC RID: 19644
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CBD RID: 19645
		private LuaFunction m_ctor_hotfix;
	}
}
