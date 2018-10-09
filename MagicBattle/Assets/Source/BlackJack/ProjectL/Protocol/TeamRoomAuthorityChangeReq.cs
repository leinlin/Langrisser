using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000830 RID: 2096
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomAuthorityChangeReq")]
	[Serializable]
	public class TeamRoomAuthorityChangeReq : IExtensible
	{
		// Token: 0x06006950 RID: 26960 RVA: 0x001DA610 File Offset: 0x001D8810
		public TeamRoomAuthorityChangeReq()
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06006951 RID: 26961 RVA: 0x001DA678 File Offset: 0x001D8878
		// (set) Token: 0x06006952 RID: 26962 RVA: 0x001DA680 File Offset: 0x001D8880
		[ProtoMember(1, IsRequired = true, Name = "Authority", DataFormat = DataFormat.TwosComplement)]
		public int Authority
		{
			get
			{
				return this._Authority;
			}
			set
			{
				this._Authority = value;
			}
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x001DA68C File Offset: 0x001D888C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x001DA69C File Offset: 0x001D889C
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

		// Token: 0x06006955 RID: 26965 RVA: 0x001DA768 File Offset: 0x001D8968
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAuthorityChangeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005126 RID: 20774
		private int _Authority;

		// Token: 0x04005127 RID: 20775
		private IExtension extensionObject;

		// Token: 0x04005128 RID: 20776
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005129 RID: 20777
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400512A RID: 20778
		private LuaFunction m_ctor_hotfix;
	}
}
