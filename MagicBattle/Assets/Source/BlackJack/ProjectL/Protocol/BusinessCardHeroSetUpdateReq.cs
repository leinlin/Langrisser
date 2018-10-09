using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D7 RID: 1751
	[ProtoContract(Name = "BusinessCardHeroSetUpdateReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BusinessCardHeroSetUpdateReq : IExtensible
	{
		// Token: 0x06005DFC RID: 24060 RVA: 0x001AB1FC File Offset: 0x001A93FC
		public BusinessCardHeroSetUpdateReq()
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

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x001AB270 File Offset: 0x001A9470
		[ProtoMember(1, Name = "HeroSets", DataFormat = DataFormat.Default)]
		public List<ProBusinessCardHeroSet> HeroSets
		{
			get
			{
				return this._HeroSets;
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x001AB278 File Offset: 0x001A9478
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x001AB288 File Offset: 0x001A9488
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

		// Token: 0x06005E00 RID: 24064 RVA: 0x001AB354 File Offset: 0x001A9554
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardHeroSetUpdateReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004658 RID: 18008
		private readonly List<ProBusinessCardHeroSet> _HeroSets = new List<ProBusinessCardHeroSet>();

		// Token: 0x04004659 RID: 18009
		private IExtension extensionObject;

		// Token: 0x0400465A RID: 18010
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400465B RID: 18011
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400465C RID: 18012
		private LuaFunction m_ctor_hotfix;
	}
}
