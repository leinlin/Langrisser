using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DB RID: 1755
	[ProtoContract(Name = "HeroRandomActionSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroRandomActionSetReq : IExtensible
	{
		// Token: 0x06005E18 RID: 24088 RVA: 0x001AB938 File Offset: 0x001A9B38
		public HeroRandomActionSetReq()
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

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x001AB9A0 File Offset: 0x001A9BA0
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x001AB9A8 File Offset: 0x001A9BA8
		[ProtoMember(1, IsRequired = true, Name = "IsActionRandom", DataFormat = DataFormat.Default)]
		public bool IsActionRandom
		{
			get
			{
				return this._IsActionRandom;
			}
			set
			{
				this._IsActionRandom = value;
			}
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x001AB9B4 File Offset: 0x001A9BB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x001AB9C4 File Offset: 0x001A9BC4
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

		// Token: 0x06005E1D RID: 24093 RVA: 0x001ABA90 File Offset: 0x001A9C90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroRandomActionSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400466F RID: 18031
		private bool _IsActionRandom;

		// Token: 0x04004670 RID: 18032
		private IExtension extensionObject;

		// Token: 0x04004671 RID: 18033
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004672 RID: 18034
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004673 RID: 18035
		private LuaFunction m_ctor_hotfix;
	}
}
