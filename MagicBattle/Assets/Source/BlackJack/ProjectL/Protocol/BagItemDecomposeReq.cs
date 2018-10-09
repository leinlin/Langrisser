using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005DC RID: 1500
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BagItemDecomposeReq")]
	[Serializable]
	public class BagItemDecomposeReq : IExtensible
	{
		// Token: 0x06005410 RID: 21520 RVA: 0x0018CCAC File Offset: 0x0018AEAC
		public BagItemDecomposeReq()
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x0018CD20 File Offset: 0x0018AF20
		[ProtoMember(1, Name = "Goods", DataFormat = DataFormat.Default)]
		public List<ProGoods> Goods
		{
			get
			{
				return this._Goods;
			}
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0018CD28 File Offset: 0x0018AF28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x0018CD38 File Offset: 0x0018AF38
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

		// Token: 0x06005414 RID: 21524 RVA: 0x0018CE04 File Offset: 0x0018B004
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagItemDecomposeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F26 RID: 16166
		private readonly List<ProGoods> _Goods = new List<ProGoods>();

		// Token: 0x04003F27 RID: 16167
		private IExtension extensionObject;

		// Token: 0x04003F28 RID: 16168
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F29 RID: 16169
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F2A RID: 16170
		private LuaFunction m_ctor_hotfix;
	}
}
