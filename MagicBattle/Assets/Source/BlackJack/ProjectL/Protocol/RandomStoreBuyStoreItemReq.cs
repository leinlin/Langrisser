using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200080A RID: 2058
	[ProtoContract(Name = "RandomStoreBuyStoreItemReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RandomStoreBuyStoreItemReq : IExtensible
	{
		// Token: 0x0600680F RID: 26639 RVA: 0x001D5F8C File Offset: 0x001D418C
		public RandomStoreBuyStoreItemReq()
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x001D5FF4 File Offset: 0x001D41F4
		// (set) Token: 0x06006811 RID: 26641 RVA: 0x001D5FFC File Offset: 0x001D41FC
		[ProtoMember(1, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x001D6008 File Offset: 0x001D4208
		// (set) Token: 0x06006813 RID: 26643 RVA: 0x001D6010 File Offset: 0x001D4210
		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x001D601C File Offset: 0x001D421C
		// (set) Token: 0x06006815 RID: 26645 RVA: 0x001D6024 File Offset: 0x001D4224
		[ProtoMember(3, IsRequired = true, Name = "SelectedIndex", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006816 RID: 26646 RVA: 0x001D6030 File Offset: 0x001D4230
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x001D6040 File Offset: 0x001D4240
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

		// Token: 0x06006818 RID: 26648 RVA: 0x001D610C File Offset: 0x001D430C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreBuyStoreItemReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005034 RID: 20532
		private int _StoreId;

		// Token: 0x04005035 RID: 20533
		private int _Index;

		// Token: 0x04005036 RID: 20534
		private int _SelectedIndex;

		// Token: 0x04005037 RID: 20535
		private IExtension extensionObject;

		// Token: 0x04005038 RID: 20536
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005039 RID: 20537
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400503A RID: 20538
		private LuaFunction m_ctor_hotfix;
	}
}
