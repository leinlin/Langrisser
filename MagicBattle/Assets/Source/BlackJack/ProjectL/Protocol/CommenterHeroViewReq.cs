using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063D RID: 1597
	[ProtoContract(Name = "CommenterHeroViewReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class CommenterHeroViewReq : IExtensible
	{
		// Token: 0x06005760 RID: 22368 RVA: 0x0019825C File Offset: 0x0019645C
		public CommenterHeroViewReq()
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

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x001982C4 File Offset: 0x001964C4
		// (set) Token: 0x06005762 RID: 22370 RVA: 0x001982CC File Offset: 0x001964CC
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x001982D8 File Offset: 0x001964D8
		// (set) Token: 0x06005764 RID: 22372 RVA: 0x001982E0 File Offset: 0x001964E0
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x001982EC File Offset: 0x001964EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x001982FC File Offset: 0x001964FC
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

		// Token: 0x06005767 RID: 22375 RVA: 0x001983C8 File Offset: 0x001965C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommenterHeroViewReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041A1 RID: 16801
		private int _HeroId;

		// Token: 0x040041A2 RID: 16802
		private string _UserId;

		// Token: 0x040041A3 RID: 16803
		private IExtension extensionObject;

		// Token: 0x040041A4 RID: 16804
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041A5 RID: 16805
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041A6 RID: 16806
		private LuaFunction m_ctor_hotfix;
	}
}
