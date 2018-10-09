using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F7 RID: 2039
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DirectelyActivitedMissionUpdateNtf")]
	[Serializable]
	public class DirectelyActivitedMissionUpdateNtf : IExtensible
	{
		// Token: 0x0600677A RID: 26490 RVA: 0x001CC8DC File Offset: 0x001CAADC
		public DirectelyActivitedMissionUpdateNtf()
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

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x0600677B RID: 26491 RVA: 0x001CC944 File Offset: 0x001CAB44
		// (set) Token: 0x0600677C RID: 26492 RVA: 0x001CC94C File Offset: 0x001CAB4C
		[ProtoMember(1, IsRequired = true, Name = "MissionId", DataFormat = DataFormat.TwosComplement)]
		public int MissionId
		{
			get
			{
				return this._MissionId;
			}
			set
			{
				this._MissionId = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x001CC958 File Offset: 0x001CAB58
		// (set) Token: 0x0600677E RID: 26494 RVA: 0x001CC960 File Offset: 0x001CAB60
		[ProtoMember(2, IsRequired = true, Name = "Add", DataFormat = DataFormat.Default)]
		public bool Add
		{
			get
			{
				return this._Add;
			}
			set
			{
				this._Add = value;
			}
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x001CC96C File Offset: 0x001CAB6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x001CC97C File Offset: 0x001CAB7C
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

		// Token: 0x06006781 RID: 26497 RVA: 0x001CCA48 File Offset: 0x001CAC48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DirectelyActivitedMissionUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D83 RID: 19843
		private int _MissionId;

		// Token: 0x04004D84 RID: 19844
		private bool _Add;

		// Token: 0x04004D85 RID: 19845
		private IExtension extensionObject;

		// Token: 0x04004D86 RID: 19846
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D87 RID: 19847
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D88 RID: 19848
		private LuaFunction m_ctor_hotfix;
	}
}
