using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081A RID: 2074
	[ProtoContract(Name = "RiftLevelBattleFinishedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RiftLevelBattleFinishedReq : IExtensible
	{
		// Token: 0x0600688E RID: 26766 RVA: 0x001D7CDC File Offset: 0x001D5EDC
		public RiftLevelBattleFinishedReq()
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

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x001D7D44 File Offset: 0x001D5F44
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x001D7D4C File Offset: 0x001D5F4C
		[ProtoMember(1, IsRequired = true, Name = "RiftLevelId", DataFormat = DataFormat.TwosComplement)]
		public int RiftLevelId
		{
			get
			{
				return this._RiftLevelId;
			}
			set
			{
				this._RiftLevelId = value;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x001D7D58 File Offset: 0x001D5F58
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x001D7D60 File Offset: 0x001D5F60
		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public ProBattleReport BattleReport
		{
			get
			{
				return this._BattleReport;
			}
			set
			{
				this._BattleReport = value;
			}
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x001D7D6C File Offset: 0x001D5F6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x001D7D7C File Offset: 0x001D5F7C
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

		// Token: 0x06006895 RID: 26773 RVA: 0x001D7E48 File Offset: 0x001D6048
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelBattleFinishedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005095 RID: 20629
		private int _RiftLevelId;

		// Token: 0x04005096 RID: 20630
		private ProBattleReport _BattleReport;

		// Token: 0x04005097 RID: 20631
		private IExtension extensionObject;

		// Token: 0x04005098 RID: 20632
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005099 RID: 20633
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400509A RID: 20634
		private LuaFunction m_ctor_hotfix;
	}
}
