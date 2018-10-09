using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F5 RID: 1781
	[ProtoContract(Name = "HeadPortraitSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeadPortraitSetReq : IExtensible
	{
		// Token: 0x06005F03 RID: 24323 RVA: 0x001AEA14 File Offset: 0x001ACC14
		public HeadPortraitSetReq()
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

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x001AEA7C File Offset: 0x001ACC7C
		// (set) Token: 0x06005F05 RID: 24325 RVA: 0x001AEA84 File Offset: 0x001ACC84
		[ProtoMember(1, IsRequired = true, Name = "HeadPortrait", DataFormat = DataFormat.TwosComplement)]
		public int HeadPortrait
		{
			get
			{
				return this._HeadPortrait;
			}
			set
			{
				this._HeadPortrait = value;
			}
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x001AEA90 File Offset: 0x001ACC90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x001AEAA0 File Offset: 0x001ACCA0
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

		// Token: 0x06005F08 RID: 24328 RVA: 0x001AEB6C File Offset: 0x001ACD6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadPortraitSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400471B RID: 18203
		private int _HeadPortrait;

		// Token: 0x0400471C RID: 18204
		private IExtension extensionObject;

		// Token: 0x0400471D RID: 18205
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400471E RID: 18206
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400471F RID: 18207
		private LuaFunction m_ctor_hotfix;
	}
}
