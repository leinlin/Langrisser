using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D5 RID: 1749
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BusinessCardDescUpdateReq")]
	[Serializable]
	public class BusinessCardDescUpdateReq : IExtensible
	{
		// Token: 0x06005DEE RID: 24046 RVA: 0x001AAE68 File Offset: 0x001A9068
		public BusinessCardDescUpdateReq()
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

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x001AAED0 File Offset: 0x001A90D0
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x001AAED8 File Offset: 0x001A90D8
		[ProtoMember(1, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x001AAEE4 File Offset: 0x001A90E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x001AAEF4 File Offset: 0x001A90F4
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

		// Token: 0x06005DF3 RID: 24051 RVA: 0x001AAFC0 File Offset: 0x001A91C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardDescUpdateReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400464D RID: 17997
		private string _Desc;

		// Token: 0x0400464E RID: 17998
		private IExtension extensionObject;

		// Token: 0x0400464F RID: 17999
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004650 RID: 18000
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004651 RID: 18001
		private LuaFunction m_ctor_hotfix;
	}
}
