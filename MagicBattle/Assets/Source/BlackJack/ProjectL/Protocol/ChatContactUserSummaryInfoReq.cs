using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000627 RID: 1575
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatContactUserSummaryInfoReq")]
	[Serializable]
	public class ChatContactUserSummaryInfoReq : IExtensible
	{
		// Token: 0x06005690 RID: 22160 RVA: 0x00195894 File Offset: 0x00193A94
		public ChatContactUserSummaryInfoReq()
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

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06005691 RID: 22161 RVA: 0x00195908 File Offset: 0x00193B08
		[ProtoMember(1, Name = "ContactUserList", DataFormat = DataFormat.Default)]
		public List<string> ContactUserList
		{
			get
			{
				return this._ContactUserList;
			}
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x00195910 File Offset: 0x00193B10
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x00195920 File Offset: 0x00193B20
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

		// Token: 0x06005694 RID: 22164 RVA: 0x001959EC File Offset: 0x00193BEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatContactUserSummaryInfoReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400410A RID: 16650
		private readonly List<string> _ContactUserList = new List<string>();

		// Token: 0x0400410B RID: 16651
		private IExtension extensionObject;

		// Token: 0x0400410C RID: 16652
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400410D RID: 16653
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400410E RID: 16654
		private LuaFunction m_ctor_hotfix;
	}
}
