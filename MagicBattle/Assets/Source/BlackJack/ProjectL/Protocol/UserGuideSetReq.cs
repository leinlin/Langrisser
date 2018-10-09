using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FB RID: 1787
	[ProtoContract(Name = "UserGuideSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UserGuideSetReq : IExtensible
	{
		// Token: 0x06005F29 RID: 24361 RVA: 0x001AF4A8 File Offset: 0x001AD6A8
		public UserGuideSetReq()
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

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x001AF51C File Offset: 0x001AD71C
		[ProtoMember(1, Name = "CompleteStepIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> CompleteStepIds
		{
			get
			{
				return this._CompleteStepIds;
			}
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x001AF524 File Offset: 0x001AD724
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x001AF534 File Offset: 0x001AD734
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

		// Token: 0x06005F2D RID: 24365 RVA: 0x001AF600 File Offset: 0x001AD800
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400473A RID: 18234
		private readonly List<int> _CompleteStepIds = new List<int>();

		// Token: 0x0400473B RID: 18235
		private IExtension extensionObject;

		// Token: 0x0400473C RID: 18236
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400473D RID: 18237
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400473E RID: 18238
		private LuaFunction m_ctor_hotfix;
	}
}
