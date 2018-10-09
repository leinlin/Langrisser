using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000628 RID: 1576
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatContactUserSummaryInfoAck")]
	[Serializable]
	public class ChatContactUserSummaryInfoAck : IExtensible
	{
		// Token: 0x06005695 RID: 22165 RVA: 0x00195A54 File Offset: 0x00193C54
		public ChatContactUserSummaryInfoAck()
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

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x00195AC8 File Offset: 0x00193CC8
		[ProtoMember(1, Name = "UserSummaryInfoList", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> UserSummaryInfoList
		{
			get
			{
				return this._UserSummaryInfoList;
			}
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x00195AD0 File Offset: 0x00193CD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x00195AE0 File Offset: 0x00193CE0
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

		// Token: 0x06005699 RID: 22169 RVA: 0x00195BAC File Offset: 0x00193DAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatContactUserSummaryInfoAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400410F RID: 16655
		private readonly List<ProUserSummary> _UserSummaryInfoList = new List<ProUserSummary>();

		// Token: 0x04004110 RID: 16656
		private IExtension extensionObject;

		// Token: 0x04004111 RID: 16657
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004112 RID: 16658
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004113 RID: 16659
		private LuaFunction m_ctor_hotfix;
	}
}
