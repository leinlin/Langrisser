using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080B RID: 2059
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomStoreBuyStoreItemAck")]
	[Serializable]
	public class RandomStoreBuyStoreItemAck : IExtensible
	{
		// Token: 0x06006819 RID: 26649 RVA: 0x001D6174 File Offset: 0x001D4374
		public RandomStoreBuyStoreItemAck()
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x001D61DC File Offset: 0x001D43DC
		// (set) Token: 0x0600681B RID: 26651 RVA: 0x001D61E4 File Offset: 0x001D43E4
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x001D61F0 File Offset: 0x001D43F0
		// (set) Token: 0x0600681D RID: 26653 RVA: 0x001D61F8 File Offset: 0x001D43F8
		[ProtoMember(2, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public int StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600681E RID: 26654 RVA: 0x001D6204 File Offset: 0x001D4404
		// (set) Token: 0x0600681F RID: 26655 RVA: 0x001D620C File Offset: 0x001D440C
		[ProtoMember(3, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				this._Index = value;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x001D6218 File Offset: 0x001D4418
		// (set) Token: 0x06006821 RID: 26657 RVA: 0x001D6220 File Offset: 0x001D4420
		[ProtoMember(4, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
		public int SelectedIndex
		{
			get
			{
				return this._SelectedIndex;
			}
			set
			{
				this._SelectedIndex = value;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x001D622C File Offset: 0x001D442C
		// (set) Token: 0x06006823 RID: 26659 RVA: 0x001D6234 File Offset: 0x001D4434
		[ProtoMember(5, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x001D6240 File Offset: 0x001D4440
		// (set) Token: 0x06006825 RID: 26661 RVA: 0x001D6248 File Offset: 0x001D4448
		[DefaultValue(null)]
		[ProtoMember(6, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x001D6254 File Offset: 0x001D4454
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x001D6264 File Offset: 0x001D4464
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

		// Token: 0x06006828 RID: 26664 RVA: 0x001D6330 File Offset: 0x001D4530
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreBuyStoreItemAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400503B RID: 20539
		private int _Result;

		// Token: 0x0400503C RID: 20540
		private int _StoreId;

		// Token: 0x0400503D RID: 20541
		private int _Index;

		// Token: 0x0400503E RID: 20542
		private int _SelectedIndex;

		// Token: 0x0400503F RID: 20543
		private int _Id;

		// Token: 0x04005040 RID: 20544
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04005041 RID: 20545
		private IExtension extensionObject;

		// Token: 0x04005042 RID: 20546
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005043 RID: 20547
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005044 RID: 20548
		private LuaFunction m_ctor_hotfix;
	}
}
