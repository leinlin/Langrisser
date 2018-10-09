using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000653 RID: 1619
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProCardPool")]
	[Serializable]
	public class ProCardPool : IExtensible
	{
		// Token: 0x06005862 RID: 22626 RVA: 0x0019AE8C File Offset: 0x0019908C
		public ProCardPool()
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

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x0019AEF4 File Offset: 0x001990F4
		// (set) Token: 0x06005864 RID: 22628 RVA: 0x0019AEFC File Offset: 0x001990FC
		[ProtoMember(1, IsRequired = true, Name = "CardPoolId", DataFormat = DataFormat.TwosComplement)]
		public int CardPoolId
		{
			get
			{
				return this._CardPoolId;
			}
			set
			{
				this._CardPoolId = value;
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x0019AF08 File Offset: 0x00199108
		// (set) Token: 0x06005866 RID: 22630 RVA: 0x0019AF10 File Offset: 0x00199110
		[ProtoMember(2, IsRequired = true, Name = "SelectCount", DataFormat = DataFormat.TwosComplement)]
		public int SelectCount
		{
			get
			{
				return this._SelectCount;
			}
			set
			{
				this._SelectCount = value;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0019AF1C File Offset: 0x0019911C
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x0019AF24 File Offset: 0x00199124
		[ProtoMember(3, IsRequired = true, Name = "DiscountCount", DataFormat = DataFormat.TwosComplement)]
		public int DiscountCount
		{
			get
			{
				return this._DiscountCount;
			}
			set
			{
				this._DiscountCount = value;
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x0019AF30 File Offset: 0x00199130
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0019AF40 File Offset: 0x00199140
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

		// Token: 0x0600586B RID: 22635 RVA: 0x0019B00C File Offset: 0x0019920C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProCardPool));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004257 RID: 16983
		private int _CardPoolId;

		// Token: 0x04004258 RID: 16984
		private int _SelectCount;

		// Token: 0x04004259 RID: 16985
		private int _DiscountCount;

		// Token: 0x0400425A RID: 16986
		private IExtension extensionObject;

		// Token: 0x0400425B RID: 16987
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400425C RID: 16988
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400425D RID: 16989
		private LuaFunction m_ctor_hotfix;
	}
}
