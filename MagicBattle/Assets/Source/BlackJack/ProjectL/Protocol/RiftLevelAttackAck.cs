using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000819 RID: 2073
	[ProtoContract(Name = "RiftLevelAttackAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RiftLevelAttackAck : IExtensible
	{
		// Token: 0x06006884 RID: 26756 RVA: 0x001D7AF4 File Offset: 0x001D5CF4
		public RiftLevelAttackAck()
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06006885 RID: 26757 RVA: 0x001D7B5C File Offset: 0x001D5D5C
		// (set) Token: 0x06006886 RID: 26758 RVA: 0x001D7B64 File Offset: 0x001D5D64
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

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x001D7B70 File Offset: 0x001D5D70
		// (set) Token: 0x06006888 RID: 26760 RVA: 0x001D7B78 File Offset: 0x001D5D78
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

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x001D7B84 File Offset: 0x001D5D84
		// (set) Token: 0x0600688A RID: 26762 RVA: 0x001D7B8C File Offset: 0x001D5D8C
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

		// Token: 0x0600688B RID: 26763 RVA: 0x001D7B98 File Offset: 0x001D5D98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001D7BA8 File Offset: 0x001D5DA8
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

		// Token: 0x0600688D RID: 26765 RVA: 0x001D7C74 File Offset: 0x001D5E74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400508E RID: 20622
		private int _Result;

		// Token: 0x0400508F RID: 20623
		private int _LevelId;

		// Token: 0x04005090 RID: 20624
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04005091 RID: 20625
		private IExtension extensionObject;

		// Token: 0x04005092 RID: 20626
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005093 RID: 20627
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005094 RID: 20628
		private LuaFunction m_ctor_hotfix;
	}
}
