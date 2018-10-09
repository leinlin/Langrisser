using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F5 RID: 2037
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GetMissionRewardReq")]
	[Serializable]
	public class GetMissionRewardReq : IExtensible
	{
		// Token: 0x0600676A RID: 26474 RVA: 0x001CC534 File Offset: 0x001CA734
		public GetMissionRewardReq()
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

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x001CC59C File Offset: 0x001CA79C
		// (set) Token: 0x0600676C RID: 26476 RVA: 0x001CC5A4 File Offset: 0x001CA7A4
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

		// Token: 0x0600676D RID: 26477 RVA: 0x001CC5B0 File Offset: 0x001CA7B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x001CC5C0 File Offset: 0x001CA7C0
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

		// Token: 0x0600676F RID: 26479 RVA: 0x001CC68C File Offset: 0x001CA88C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetMissionRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D77 RID: 19831
		private int _MissionId;

		// Token: 0x04004D78 RID: 19832
		private IExtension extensionObject;

		// Token: 0x04004D79 RID: 19833
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D7A RID: 19834
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D7B RID: 19835
		private LuaFunction m_ctor_hotfix;
	}
}
