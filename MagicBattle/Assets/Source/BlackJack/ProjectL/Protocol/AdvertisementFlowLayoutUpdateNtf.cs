using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000802 RID: 2050
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AdvertisementFlowLayoutUpdateNtf")]
	[Serializable]
	public class AdvertisementFlowLayoutUpdateNtf : IExtensible
	{
		// Token: 0x060067D2 RID: 26578 RVA: 0x001CDCF8 File Offset: 0x001CBEF8
		public AdvertisementFlowLayoutUpdateNtf()
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

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x001CDD6C File Offset: 0x001CBF6C
		[ProtoMember(1, Name = "Layouts", DataFormat = DataFormat.Default)]
		public List<ProAdvertisementFlowLayout> Layouts
		{
			get
			{
				return this._Layouts;
			}
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x001CDD74 File Offset: 0x001CBF74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x001CDD84 File Offset: 0x001CBF84
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

		// Token: 0x060067D6 RID: 26582 RVA: 0x001CDE50 File Offset: 0x001CC050
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AdvertisementFlowLayoutUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DC5 RID: 19909
		private readonly List<ProAdvertisementFlowLayout> _Layouts = new List<ProAdvertisementFlowLayout>();

		// Token: 0x04004DC6 RID: 19910
		private IExtension extensionObject;

		// Token: 0x04004DC7 RID: 19911
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DC8 RID: 19912
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DC9 RID: 19913
		private LuaFunction m_ctor_hotfix;
	}
}
